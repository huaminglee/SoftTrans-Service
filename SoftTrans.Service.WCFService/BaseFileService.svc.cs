using SoftTrans.Service.DAL;
using SoftTrans.Service.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SoftTrans.Service.WCFService
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码、svc 和配置文件中的类名“BaseFileService”。
    // 注意: 为了启动 WCF 测试客户端以测试此服务，请在解决方案资源管理器中选择 BaseFileService.svc 或 BaseFileService.svc.cs，然后开始调试。
    public class BaseFileService : IBaseFileService
    {


        #region 汇率档案
        public Entity.T_baseBalanceExchange_Rate Insert(Entity.T_baseBalanceExchange_Rate entity)
        {
            return RepositoryFactory.ExchangeRateRepository.Insert(entity);
        }

        public bool Update(Entity.T_baseBalanceExchange_Rate entity)
        {
            return RepositoryFactory.ExchangeRateRepository.Update(entity);
        }

        public bool Delete(object keyId)
        {
            return RepositoryFactory.ExchangeRateRepository.Delete(keyId);
        }

        public string LoadEntities(object where)
        {
            var obj = RepositoryFactory.ExchangeRateRepository.LoadEntities(where);
            return Newtonsoft.Json.JsonConvert.SerializeObject(obj);
        }

        public string LoadPageEntities(int pageIndex, int pageSize, object where, out int rowCount, params object[] aopPara)
        {
            var obj = RepositoryFactory.ExchangeRateRepository.LoadPageEntities(pageIndex, pageSize, where, out rowCount, aopPara);
            return Newtonsoft.Json.JsonConvert.SerializeObject(obj);
        }
        #endregion


        #region 国家设置
        public Entity.Hrm_Country Insert_Hrm_Country(Entity.Hrm_Country entity)
        {
            return RepositoryFactory.CountryRepository.Insert(entity);
        }

        public bool Update_Hrm_Country(Entity.Hrm_Country entity)
        {
            return RepositoryFactory.CountryRepository.Update(entity);
        }

        public bool Delete_Hrm_Country(object keyId)
        {
            return RepositoryFactory.CountryRepository.Delete(keyId);
        }

        public string Load_Hrm_Country(object where)
        {
            var obj = RepositoryFactory.CountryRepository.LoadEntities(where);
            return Newtonsoft.Json.JsonConvert.SerializeObject(obj);
        }

        public string LoadPage_Hrm_Country(int pageIndex, int pageSize, object where, out int rowCount, params object[] aopPara)
        {
            var obj = RepositoryFactory.CountryRepository.LoadPageEntities(pageIndex, pageSize, where, out rowCount, aopPara);
            return Newtonsoft.Json.JsonConvert.SerializeObject(obj);
        }
        #endregion


        #region 省份设置
        public Entity.Hrm_Province Insert_Hrm_Province(Entity.Hrm_Province entity)
        {
            return RepositoryFactory.ProvinceRepository.Insert(entity);
        }

        public bool Update_Hrm_Province(Entity.Hrm_Province entity)
        {
            return RepositoryFactory.ProvinceRepository.Update(entity);
        }

        public bool Delete_Hrm_Province(object keyId)
        {
            return RepositoryFactory.ProvinceRepository.Delete(keyId);
        }

        public string Load_Hrm_Province(object where)
        {
            var obj = RepositoryFactory.ProvinceRepository.LoadEntities(where);
            return Newtonsoft.Json.JsonConvert.SerializeObject(obj);
        }

        public string LoadPage_Hrm_Province(int pageIndex, int pageSize, object where, out int rowCount, params object[] aopPara)
        {
            var obj = RepositoryFactory.ProvinceRepository.LoadPageEntities(pageIndex, pageSize, where, out rowCount, aopPara);
            return Newtonsoft.Json.JsonConvert.SerializeObject(obj);
        }
        #endregion


        #region 城市设置
        public Entity.Hrm_City Insert_Hrm_City(Entity.Hrm_City entity)
        {
            return RepositoryFactory.CityRepository.Insert(entity);
        }

        public bool Update_Hrm_City(Entity.Hrm_City entity)
        {
            return RepositoryFactory.CityRepository.Update(entity);
        }

        public bool Delete_Hrm_City(object keyId)
        {
            return RepositoryFactory.CityRepository.Delete(keyId);
        }

        public string Load_Hrm_City(object where)
        {
            var obj = RepositoryFactory.CityRepository.LoadEntities(where);
            return Newtonsoft.Json.JsonConvert.SerializeObject(obj);
        }

        public string LoadPage_Hrm_City(int pageIndex, int pageSize, object where, out int rowCount, params object[] aopPara)
        {
            var obj = RepositoryFactory.CityRepository.LoadPageEntities(pageIndex, pageSize, where, out rowCount, aopPara);
            return Newtonsoft.Json.JsonConvert.SerializeObject(obj);
        }
        #endregion
    }
}
