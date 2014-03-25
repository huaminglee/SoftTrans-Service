using CYQ.Data.Aop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using CYQ.Data;
using System.Runtime.Serialization;
using SoftTrans.Service.Entity.Enum;

namespace SoftTrans.Service.DAL
{
    public class AppLogger : CYQ.Data.Aop.IAop
    {
        public CYQ.Data.Aop.AopResult Begin(CYQ.Data.Aop.AopEnum action, CYQ.Data.Aop.AopInfo aopInfo)
        {
            AopResult result = AopResult.Continue;
            // Default摘要:  本结果将执行原有事件，但跳过Aop.End事件
            // Continue摘要: 本结果将继续执行原有事件和Aop.End事件
            // Break摘要: 本结果将跳过原有事件,但会执行Aop End事件 
            // Return摘要: 本结果将直接跳出原有函数的执行   

            //此处可验证权限
            //if (aopInfo.AopPara[0].ToString() != "admin")
            //{
            //    result = AopResult.Break;
            //}

            return result;
        }

        public void End(CYQ.Data.Aop.AopEnum action, CYQ.Data.Aop.AopInfo aopInfo)
        {
            WriteLog(action, aopInfo);
        }

        private void WriteLog(CYQ.Data.Aop.AopEnum action, CYQ.Data.Aop.AopInfo aopInfo)
        {
            string Log = "";

            switch (action)
            {
                case CYQ.Data.Aop.AopEnum.Delete: //删除操作
                    Log = string.Format("删除 [{0}] 参数 [{1}] 执行状态[{2}]..............", aopInfo.AopPara[0], aopInfo.AopPara[1], aopInfo.IsSuccess ? "成功" : "失败");
                    break;
                case CYQ.Data.Aop.AopEnum.Fill:
                    break;
                case CYQ.Data.Aop.AopEnum.Insert:
                    Log = string.Format("新增 [{0}] 参数 [{1}] 执行状态[{2}]..............", aopInfo.AopPara[0], aopInfo.AopPara[1], aopInfo.IsSuccess ? "成功" : "失败");
                    break;
                case CYQ.Data.Aop.AopEnum.Select:
                    Log = "查询了" + aopInfo.TableName;
                    break;
                case CYQ.Data.Aop.AopEnum.Update:
                    break;
                case CYQ.Data.Aop.AopEnum.ExeMDataTable: //MProc查询操作
                    break;
                case CYQ.Data.Aop.AopEnum.ExeNonQuery: //执行SQL操作
                default:
                    break;
            }

            using (CYQ.Data.MAction write = new CYQ.Data.MAction(TableNames.T_OperationLog))
            {
                write.Set("LogInfo", Log);
                write.Set("LogType", action);
                write.Set("UserName", aopInfo.AopPara.Length > 0 ? aopInfo.AopPara[0] : "未知");
                write.Set("IsSuccess", aopInfo.IsSuccess);
                write.Insert();
            }
        }








        public IAop Clone()
        {
            return null;
        }

        public IAop GetFromConfig()
        {
            return null;
        }

        public void OnError(string msg)
        {

        }

        public void OnLoad()
        {

        }
    }
}
