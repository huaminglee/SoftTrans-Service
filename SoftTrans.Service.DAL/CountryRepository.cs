using CYQ.Data;
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

        Hrm_Country IBaseRepository<Hrm_Country>.Insert(Hrm_Country entity)
        {
            using (MProc proc = new MProc("P_Hrm_Country_Add"))
            {
                proc.Set("CountryName", entity.CountryName);
                proc.Set("CountryDesc", entity.CountryDesc);
                proc.SetCustom("ID", CYQ.Data.DAL.ParaType.OutPut, -1);
                proc.ExeNonQuery();
                entity.ID = Convert.ToInt32(proc.OutPutValue);
            }
            return entity;
        }
    }
}
