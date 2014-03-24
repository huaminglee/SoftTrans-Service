using CYQ.Data.Tool;
using SoftTrans.Service.Entity.Enum;
using SoftTrans.Service.UI.CommonService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace SoftTrans.Service.UI
{
    public class InitBaesData
    {

        public static void LoadBaseData()
        {
            //using (CommonProxy proxy = new CommonProxy())
            //{

            //    //币制
            //    var currencyType = proxy.Select(TableNames.T_baseBalance_CurrencyType, null);
            //    CYQ.Data.Cache.CacheManage.Instance.Add("currencyType", currencyType);

            //    //汇率
            //    var currencyRate = proxy.Select(TableNames.T_baseBalanceExchange_Rate, null);
            //    CYQ.Data.Cache.CacheManage.Instance.Add("currencyRate", currencyType);


            //}
        }


        public static object GetCache(string key)
        {
            if (!CYQ.Data.Cache.CacheManage.Instance.Contains(key))
            {
                //TODO:不存在 重设缓存
                TableNames t = (TableNames)Enum.Parse(typeof(TableNames), key, false);

                using (CommonProxy proxy = new CommonProxy())
                {
                    //币制
                    var currencyType = proxy.Select(TableNames.T_baseBalance_CurrencyType, null);
                    CYQ.Data.Cache.CacheManage.Instance.Add("currencyType", currencyType);

                }

            }
            return CYQ.Data.Cache.CacheManage.Instance.Get(key);
        }


        public static object GetCache(TableNames tabName)
        {
            string key = tabName.ToString();

            if (!CYQ.Data.Cache.CacheManage.Instance.Contains(key))
            {

                using (CommonProxy proxy = new CommonProxy())
                {
                    //币制
                    var currencyType = proxy.Select(tabName, null);
                    CYQ.Data.Cache.CacheManage.Instance.Add(key, currencyType);

                }

            }
            return CYQ.Data.Cache.CacheManage.Instance.Get(key);
        }

        public static void SetCache(string key, object value)
        {
            CYQ.Data.Cache.CacheManage.Instance.Set(key, value);
        }
    }
}
