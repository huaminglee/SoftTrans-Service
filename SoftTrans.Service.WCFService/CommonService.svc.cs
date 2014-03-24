using CYQ.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using CYQ.Data.Table;
using SoftTrans.Service.Entity.Enum;
using CYQ.Data.Aop;

namespace SoftTrans.Service.WCFService
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“Service1”。
    // 注意: 为了启动 WCF 测试客户端以测试此服务，请在解决方案资源管理器中选择 Service1.svc 或 Service1.svc.cs，然后开始调试。
    [KnownType(typeof(SoftTrans.Service.Entity.DataFileds))]
    public class CommonService : ICommonService
    {
      

        public string SelectPage(TableNames t, int pageIndex, int pageSize, object where, out int rowCount, params object[] aopPara)
        {
            string json = string.Empty;

            using (MAction action = new MAction(t))
            {
                json = action.Select(pageIndex, pageSize, where, out rowCount, "查询","分页","df").ToJson(true, true);
            }
            return json;
        }

        public string Select(TableNames t, object where)
        {
            string json = string.Empty;
            using (MAction action = new MAction(t))
            {
                json = action.Select(where).ToJson(true, true);
            }
            return json;
        }

        public string Select(TableNames t, object where, params object[] columnsName)
        {
            string json = string.Empty;
            using (MAction action = new MAction(t))
            {

                action.SetSelectColumns(columnsName);
                json = action.Select(where).ToJson(true, true);
            }
            return json;
        }

        public bool Delete(TableNames t, object where, params object[] aopPara)
        {
            bool result = false;
            using (MAction action = new MAction(t))
            {
                result = action.Delete(where, aopPara);
            }
            return result;
        }

        public bool Update(TableNames t, string json)
        {
            bool result = false;
            List<string> jsons = new List<string>();
            jsons = Common.JsonManager.SplitJson(json);

            using (MAction action = new MAction(t))
            {
                action.BeginTransation();
                for (int i = 0; i < jsons.Count; i++)
                {
                    action.GetFromJson(jsons[i]);
                    action.Update();
                }
                action.EndTransation();
                result = true;

            }
            /*

            MDataTable dtFromJson = MDataTable.LoadFromJson(json);
            dtFromJson.TableName = t.ToString();
            dtFromJson.Conn = "server=.;database=PopeyeMaster;uid=sa;pwd=sa";

            foreach (MDataRow dr in dtFromJson.Rows)
            {
                dr.SetState(2);
            }

            result = dtFromJson.AcceptChanges(AcceptOp.Update);
            */
            return result;

        }



        public bool Insert(TableNames t, string json)
        {

            bool result = false;
            List<string> jsons = new List<string>();
            jsons = Common.JsonManager.SplitJson(json);
            using (MAction action = new MAction(t))
            {
                action.BeginTransation();
                for (int i = 0; i < jsons.Count; i++)
                {
                    action.GetFromJson(jsons[i]);
                    action.Insert(InsertOp.None);
                }
                action.EndTransation();
                result = true;
            }

            return result;
        }


        public string Fill(TableNames t, object where)
        {
            string json = string.Empty;
            using (MAction action = new MAction(t))
            {
                action.Fill(where);
                json = action.Data.ToJson();
            }
            return json;
        }
    }
}
