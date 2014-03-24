using CYQ.Data;
using SoftTrans.Service.Entity.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftTrans.Service.DAL
{
    /// <summary>
    /// 数据仓库基类
    /// </summary>
    public class BaseRepository<T> where T : class
    {
        /// <summary>
        /// 当前操作表
        /// </summary>
        public TableNames TableName { get; set; }
        private const string Conn = "Data Source=POPEYE-PC;Initial Catalog=PopeyeMaster;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="entity">实体</param>
        /// <returns></returns>
        public T Insert(T entity)
        {
            using (MAction action = new MAction(TableName, Conn))
            {
                action.Data.SetFromEntity(entity);
                action.Insert();
                entity = action.Data.ToEntity<T>();
            }
            return entity;
        }

        public bool Update(T entity)
        {
            using (MAction action = new MAction(TableName, Conn))
            {
                action.Data.SetFromEntity(entity);
                action.Update();
            }
            return true;
        }

        public bool Delete(object keyId)
        {
            using (MAction action = new MAction(TableName, Conn))
            {
                action.Delete(keyId);
            }
            return true;
        }

        public List<T> LoadEntities(object where)
        {

            List<T> list = null;
            using (MAction action = new MAction(TableName, Conn))
            {
                list = action.Select(where).ToList<T>();
            }
            return list;
        }

        public List<T> LoadPageEntities(int pageIndex, int pageSize, object where, out int rowCount, params object[] aopPara)
        {
            List<T> list = null;
            using (MAction action = new MAction(TableName, Conn))
            {
                list = action.Select(pageIndex, pageSize, where, out rowCount, aopPara).ToList<T>();
            }
            return list;
        }
    }
}
