using SoftTrans.Service.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftTrans.Service.DAL
{
    public class RepositoryFactory
    {
        #region 基础档案
        public static IExchangeRateRepository ExchangeRateRepository
        {
            get { return new ExchangeRateRepository(); }
        }

        public static ICountryRepository CountryRepository
        {
            get { return new CountryRepository(); }
        }

        public static IProvinceRepository ProvinceRepository
        {
            get { return new ProvinceRepository(); }
        }

        public static ICityRepository CityRepository
        {
            get { return new CityRepository(); }
        }
        #endregion
    }
}
