using SoftTrans.Service.UI.CommonService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace SoftTrans.Service.UI
{
    public class CommonProxy : ClientBase<ICommonServiceChannel>
    {

        /// <summary>
        /// 硬编码定义绑定
        /// </summary>
        public static readonly EndpointAddress CommonAddress = new EndpointAddress(new Uri("http://localhost:2956/CommonService.svc"));

        public CommonProxy() : base("BasicHttpBinding_ICommonService", CommonAddress) { }


        public string SelectPage(out int rowCount, Entity.Enum.TableNames t, int pageIndex, int pageSize, object where, object[] aopPara)
        {
            return Channel.SelectPage(out rowCount, t, pageIndex, pageSize, where, aopPara);
        }

        public string Select(Entity.Enum.TableNames t, object where)
        {
            return Channel.Select(t, where);
        }

        public string SelectColumns(Entity.Enum.TableNames t, object where, object[] columnsName)
        {
            return Channel.SelectColumns(t, where, columnsName);
        }

        public bool Delete(Entity.Enum.TableNames t, object where, object[] aopPara)
        {
            return Channel.Delete(t, where, aopPara);
        }

        public bool Update(Entity.Enum.TableNames t, string json)
        {
            return Channel.Update(t, json);
        }

        public bool Insert(Entity.Enum.TableNames t, string json)
        {
            return Channel.Insert(t, json);
        }

        public string Fill(Entity.Enum.TableNames t, object where)
        {
            return Channel.Fill(t, where);
        }
    }
}
