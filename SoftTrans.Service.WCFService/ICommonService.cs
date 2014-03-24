using SoftTrans.Service.Entity;
using SoftTrans.Service.Entity.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SoftTrans.Service.WCFService
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IService1”。
    [ServiceContract]

    public interface ICommonService
    {


        [OperationContract(Name = "SelectPage")]
        string SelectPage(TableNames t, int pageIndex, int pageSize, object where, out int rowCount, params object[] aopPara);

        [OperationContract(Name = "Select")]
        string Select(TableNames t, object where);

        [OperationContract(Name = "SelectColumns")]
        string Select(TableNames t, object where, params object[] columnsName);

        [OperationContract(Name = "Delete")]
        bool Delete(TableNames t, object where, params object[] aopPara);

        [OperationContract(Name = "Update")]
        bool Update(TableNames t, string json);
        [OperationContract(Name = "Insert")]
        bool Insert(TableNames t, string json);
        [OperationContract(Name = "Fill")]
        string Fill(TableNames t, object where);

        // TODO: 在此添加您的服务操作
    }
}
