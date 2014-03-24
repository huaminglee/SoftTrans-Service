using CYQ.Data;
using SoftTrans.Service.Entity;
using SoftTrans.Service.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftTrans.Service.DAL
{
    public class ExchangeRateRepository : BaseRepository<T_baseBalanceExchange_Rate>, IExchangeRateRepository
    {
        public ExchangeRateRepository()
        {
            this.TableName = Entity.Enum.TableNames.T_baseBalanceExchange_Rate;
        }




        T_baseBalanceExchange_Rate IBaseRepository<T_baseBalanceExchange_Rate>.Insert(T_baseBalanceExchange_Rate entity)
        {

            using (MAction action = new MAction(TableName, "Data Source=POPEYE-PC;Initial Catalog=PopeyeMaster;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False"))
            {
                //业务逻辑 带事务
                action.BeginTransation();
                action.Data.SetFromEntity(entity);
                action.Insert();

                //插入完成 执行步骤2

                action.ResetTable("T_baseBalance_CurrencyType");
                action.Fill("CIQCode=110");
                action.Set("Currency_Sign", "HHKD");
                action.Update();

                action.EndTransation();
            }

            return entity;
        }


    }
}
