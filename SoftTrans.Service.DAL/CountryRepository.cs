using SoftTrans.Service.Entity;
using SoftTrans.Service.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftTrans.Service.DAL
{
    public class CountryRepository : BaseRepository<Hrm_Country>, ICountryRepository
    {
        public CountryRepository()
        {
            this.TableName = Entity.Enum.TableNames.Hrm_Country;
        }
    }
}
