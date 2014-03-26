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


        [OperationContract(Name = "Insert_Hrm_Country")]
        Hrm_Country Insert_Hrm_Country(Hrm_Country entity);
        [OperationContract(Name = "Update_Hrm_Country")]
        bool Update_Hrm_Country(Hrm_Country entity);
        [OperationContract(Name = "Delete_Hrm_Country")]
        bool Delete_Hrm_Country(object keyId);
        [OperationContract(Name = "Load_Hrm_Country")]
        string Load_Hrm_Country(object where);
        [OperationContract(Name = "LoadPage_Hrm_Country")]
        string LoadPage_Hrm_Country(int pageIndex, int pageSize, object where, out int rowCount, params object[] aopPara);



        [OperationContract(Name = "Insert_Hrm_Province")]
        Hrm_Province Insert_Hrm_Province(Hrm_Province entity);
        [OperationContract(Name = "Update_Hrm_Province")]
        bool Update_Hrm_Province(Hrm_Province entity);
        [OperationContract(Name = "Delete_Hrm_Province")]
        bool Delete_Hrm_Province(object keyId);
        [OperationContract(Name = "Load_Hrm_Province")]
        string Load_Hrm_Province(object where);
        [OperationContract(Name = "LoadPage_Hrm_Province")]
        string LoadPage_Hrm_Province(int pageIndex, int pageSize, object where, out int rowCount, params object[] aopPara);



        [OperationContract(Name = "Insert_Hrm_City")]
        Hrm_City Insert_Hrm_City(Hrm_City entity);
        [OperationContract(Name = "Update_Hrm_City")]
        bool Update_Hrm_City(Hrm_City entity);
        [OperationContract(Name = "Delete_Hrm_City")]
        bool Delete_Hrm_City(object keyId);
        [OperationContract(Name = "Load_Hrm_City")]
        string Load_Hrm_City(object where);
        [OperationContract(Name = "LoadPage_Hrm_City")]
        string LoadPage_Hrm_City(int pageIndex, int pageSize, object where, out int rowCount, params object[] aopPara);

    }
}
