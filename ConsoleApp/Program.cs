using SoftTrans.Service.DAL;
using SoftTrans.Service.Entity;
using SoftTrans.Service.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            IExchangeRateRepository db = RepositoryFactory.ExchangeRateRepository;

            //查询示例
            var obj = db.LoadEntities(null);

            //查询分页示例
            int rowCount;
            var ojbPaged = db.LoadPageEntities(1, 50, null, out rowCount);

            //新增示例 普通不涉及其它业务
            var insert = new T_baseBalanceExchange_Rate { Balance_Currency = "abc", Exchange_Rate = 1, Contract_Currency = "def", Recorder = "小伙伴" };
            var inserted = db.Insert(insert);


            //更新示例
            var objFinded = db.LoadEntities(192)[0];
            objFinded.Contract_Currency = "damn it!";
            var result = db.Update(objFinded);

            //删除示例
            var keyId = 192;
            var deleted = db.Delete(keyId);





        }
    }
}
