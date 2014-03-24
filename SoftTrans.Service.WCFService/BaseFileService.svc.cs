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
        private IExchangeRateRepository db = RepositoryFactory.ExchangeRateRepository;

        public Entity.T_baseBalanceExchange_Rate Insert(Entity.T_baseBalanceExchange_Rate entity)
        {
            return db.Insert(entity);
        }

        public bool Update(Entity.T_baseBalanceExchange_Rate entity)
        {
            return db.Update(entity);
        }

        public bool Delete(object keyId)
        {
            return db.Delete(keyId);
        }

        public string LoadEntities(object where)
        {
            var obj = db.LoadEntities(where);
            return Newtonsoft.Json.JsonConvert.SerializeObject(obj);
        }

        public string LoadPageEntities(int pageIndex, int pageSize, object where, out int rowCount, params object[] aopPara)
        {
            var obj = db.LoadPageEntities(pageIndex, pageSize, where, out rowCount, aopPara);
            return Newtonsoft.Json.JsonConvert.SerializeObject(obj);
        }
    }
}
