using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Collections.Specialized;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections;
using System.Reflection;

namespace SoftTrans.Service.Entity
{
    public class BaseEntity : IEditableObject
    {

        #region IEditableObject 成员
        [NonSerialized]
        bool _inTx;

        public void BeginEdit()
        {
            if (!_inTx)
            {
                Backup();
                _inTx = true;
            }
        }

        public void CancelEdit()
        {
            if (_inTx)
            {
                Restore();
                _inTx = false;
            }
        }

        public void EndEdit()
        {
            if (_inTx)
            {
                if (____backup != null)
                {
                    ____backup.Clear();
                    ____backup = null;
                }
                _inTx = false;
            }
        }

        #endregion


        #region Backup and Restore Data

        Stack<byte[]> ____backup;
        public virtual void Backup()
        {
            if (____backup == null)
            {
                ____backup = new Stack<byte[]>();
                Type sourceType = this.GetType();
                HybridDictionary state = new HybridDictionary();
                FieldInfo[] fields;

                do
                {
                    // 获取所有字段信息。
                    fields = sourceType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);

                    foreach (FieldInfo field in fields)
                    {
                        //只处理我们自己的字段。
                        if (field.DeclaringType != sourceType)
                            continue;

                        //如果标记了NonSerialized则忽略。
                        if (field.GetCustomAttributes(typeof(NonSerializedAttribute), true).Length != 0)
                            continue;

                        object value = field.GetValue(this);
                        if (typeof(BaseEntity).IsAssignableFrom(field.FieldType))
                        {
                            if (value == null)
                            {
                                //值为空，我们也要保存。
                                state.Add(field.DeclaringType.Name + "!" + field.Name, null);
                            }
                            else
                            {
                                // 不为空，而且是同一类型，则同时调用Backup方法。
                                ((BaseEntity)value).Backup();
                            }
                        }
                        //检查字段类型是否为ICollection，以便为集合中的项进行备份。
                        else if (typeof(ICollection).IsAssignableFrom(field.FieldType) && value != null && ((ICollection)value).Count > 0)
                        {
                            var col = (ICollection)value;
                            foreach (var item in col)
                            {
                                if (item is BaseEntity)
                                    ((BaseEntity)item).Backup();
                            }

                            state.Add(field.DeclaringType.Name + "!" + field.Name, value);
                        }
                        else
                        {
                            //普通字段，加入字典。
                            state.Add(field.DeclaringType.Name + "!" + field.Name, value);
                        }

                    }
                    //向上递归调用。
                    sourceType = sourceType.BaseType;
                } while (sourceType != null);

                //序列化，推上栈。
                using (MemoryStream buffer = new MemoryStream())
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(buffer, state);
                    ____backup.Push(buffer.ToArray());
                }

            }
        }

        public virtual void Restore()
        {
            // 如果没有备份数据，则忽略此调用。
            if (____backup != null && ____backup.Count > 0)
            {
                //反序列化得到字典。
                HybridDictionary state;
                using (MemoryStream buffer = new MemoryStream(____backup.Pop()))
                {
                    buffer.Position = 0;
                    BinaryFormatter formatter = new BinaryFormatter();
                    try
                    {
                        state = (HybridDictionary)formatter.Deserialize(buffer);
                    }
                    catch
                    {
                        return;
                    }
                }

                object source = this;
                Type sourceType = source.GetType();
                FieldInfo[] fields;

                do
                {
                    //获取字段信息。
                    fields = sourceType.GetFields(BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);
                    foreach (FieldInfo field in fields)
                    {
                        //只处理我们自己的字段。
                        if (field.DeclaringType == sourceType)
                        {
                            //获取新值。
                            object value = field.GetValue(source);

                            if (typeof(BaseEntity).IsAssignableFrom(field.FieldType))
                            {
                                //这是个子对象，检查只是否为空。
                                if (state.Contains(field.DeclaringType.Name + "!" + field.Name))
                                {
                                    //原来为空，设置为空。
                                    field.SetValue(source, null);
                                }
                                else
                                {
                                    if (value != null)
                                    {
                                        // 子对象调用Restore方法。
                                        ((BaseEntity)value).Restore();
                                    }
                                }
                            }
                            //如果字典包含该字段，则还原。
                            else if (state.Contains(field.DeclaringType.Name + "!" + field.Name))
                            {
                                field.SetValue(source, state[field.DeclaringType.Name + "!" + field.Name]);
                            }

                            //检查值是否为集合，如果是，就对每项调用Restore方法。
                            var oldValue = state[field.DeclaringType.Name + "!" + field.Name];
                            if (oldValue != null && oldValue is ICollection)
                            {
                                var col = (ICollection)oldValue;
                                foreach (var item in col)
                                {
                                    if (item is BaseEntity)
                                        ((BaseEntity)item).Restore();
                                }
                            }

                        }
                    }
                    //递归向上调用。
                    sourceType = sourceType.BaseType;
                } while (sourceType != null);

                ____backup = null;
            }
        }

        #endregion
    }
}
