using SoftTrans.Service.UI.BaseFileService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace SoftTrans.Service.UI.Proxy
{
    public class BaseFileProxy : ClientBase<IBaseFileServiceChannel>
    {
        /// <summary>
        /// 硬编码定义绑定
        /// </summary>
        public static readonly EndpointAddress CommonAddress = new EndpointAddress(new Uri("http://localhost:2956/BaseFileService.svc"));

        public BaseFileProxy() : base("BasicHttpBinding_IBaseFileService", CommonAddress) { }





        #region 汇率档案
        public Entity.T_baseBalanceExchange_Rate Insert(Entity.T_baseBalanceExchange_Rate entity)
        {
            return Channel.Insert_T_baseBalanceExchange_Rate(entity);
        }

        public bool Update(Entity.T_baseBalanceExchange_Rate entity)
        {
            return Channel.Update_T_baseBalanceExchange_Rate(entity);
        }

        public bool Delete(object keyId)
        {
            return Channel.Delete_T_baseBalanceExchange_Rate(keyId);
        }

        public List<Entity.T_baseBalanceExchange_Rate> LoadEntities(object where)
        {
            var obj = Channel.Load_T_baseBalanceExchange_Rate(where);
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Entity.T_baseBalanceExchange_Rate>>(obj);
        }

        public List<Entity.T_baseBalanceExchange_Rate> LoadPageEntities(out int rowCount, int pageIndex, int pageSize, object where, params object[] aopPara)
        {
            var obj = Channel.LoadPage_T_baseBalanceExchange_Rate(out rowCount, pageIndex, pageSize, where, aopPara);
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Entity.T_baseBalanceExchange_Rate>>(obj);
        }
        #endregion

        #region 国家设置
        public Entity.Hrm_Country Insert_Hrm_Country(Entity.Hrm_Country entity)
        {
            return Channel.Insert_Hrm_Country(entity);
        }

        public bool Update_Hrm_Country(Entity.Hrm_Country entity)
        {
            return Channel.Update_Hrm_Country(entity);
        }

        public bool Delete_Hrm_Country(object keyId)
        {
            return Channel.Delete_Hrm_Country(keyId);
        }

        public List<Entity.Hrm_Country> Load_Hrm_Country(object where)
        {
            var obj = Channel.Load_Hrm_Country(where);
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Entity.Hrm_Country>>(obj);
        }

        public List<Entity.Hrm_Country> LoadPage_Hrm_Country(out int rowCount, int pageIndex, int pageSize, object where, params object[] aopPara)
        {
            var obj = Channel.LoadPage_Hrm_Country(out rowCount, pageIndex, pageSize, where, aopPara);
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Entity.Hrm_Country>>(obj);
        }
        #endregion

        #region 省份设置
        public Entity.Hrm_Province Insert_Hrm_Province(Entity.Hrm_Province entity)
        {
            return Channel.Insert_Hrm_Province(entity);
        }

        public bool Update_Hrm_Province(Entity.Hrm_Province entity)
        {
            return Channel.Update_Hrm_Province(entity);
        }

        public bool Delete_Hrm_Province(object keyId)
        {
            return Channel.Delete_Hrm_Province(keyId);
        }

        public List<Entity.Hrm_Province> Load_Hrm_Province(object where)
        {
            var obj = Channel.Load_Hrm_Province(where);
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Entity.Hrm_Province>>(obj);
        }

        public List<Entity.Hrm_Province> LoadPage_Hrm_Province(out int rowCount, int pageIndex, int pageSize, object where, params object[] aopPara)
        {
            var obj = Channel.LoadPage_Hrm_Province(out rowCount, pageIndex, pageSize, where, aopPara);
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Entity.Hrm_Province>>(obj);
        }
        #endregion


        #region 城市设置
        public Entity.Hrm_City Insert_Hrm_City(Entity.Hrm_City entity)
        {
            return Channel.Insert_Hrm_City(entity);
        }

        public bool Update_Hrm_City(Entity.Hrm_City entity)
        {
            return Channel.Update_Hrm_City(entity);
        }

        public bool Delete_Hrm_City(object keyId)
        {
            return Channel.Delete_Hrm_City(keyId);
        }

        public List<Entity.Hrm_City> Load_Hrm_City(object where)
        {
            var obj = Channel.Load_Hrm_City(where);
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Entity.Hrm_City>>(obj);
        }

        public List<Entity.Hrm_City> LoadPage_Hrm_City(out int rowCount, int pageIndex, int pageSize, object where, params object[] aopPara)
        {
            var obj = Channel.LoadPage_Hrm_City(out rowCount, pageIndex, pageSize, where, aopPara);
            return Newtonsoft.Json.JsonConvert.DeserializeObject<List<Entity.Hrm_City>>(obj);
        }
        #endregion
    }
}
