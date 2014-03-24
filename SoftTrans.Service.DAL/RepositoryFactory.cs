using SoftTrans.Service.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftTrans.Service.DAL
{
    public class RepositoryFactory
    {
        public static IExchangeRateRepository ExchangeRateRepository
        {
            get { return new ExchangeRateRepository(); }
        }
    }
}
