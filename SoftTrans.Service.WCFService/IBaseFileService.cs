using SoftTrans.Service.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SoftTrans.Service.WCFService
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“IBaseFileService”。
    [ServiceContract]
    public interface IBaseFileService
    {
        [OperationContract(Name = "Insert_T_baseBalanceExchange_Rate")]
        T_baseBalanceExchange_Rate Insert(T_baseBalanceExchange_Rate entity);

        [OperationContract(Name = "Update_T_baseBalanceExchange_Rate")]
        bool Update(T_baseBalanceExchange_Rate entity);

        [OperationContract(Name = "Delete_T_baseBalanceExchange_Rate")]
        bool Delete(object keyId);

        [OperationContract(Name = "Load_T_baseBalanceExchange_Rate")]
        string LoadEntities(object where);

        [OperationContract(Name = "LoadPage_T_baseBalanceExchange_Rate")]
        string LoadPageEntities(int pageIndex, int pageSize, object where, out int rowCount, params object[] aopPara);
    }
}
