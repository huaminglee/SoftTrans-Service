using SoftTrans.Service.DAL;
using SoftTrans.Service.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftTrans.Service.BLL
{
    public class ExchangeRatBusiness
    {
        private IExchangeRateRepository db = RepositoryFactory.ExchangeRateRepository;
    }
}
