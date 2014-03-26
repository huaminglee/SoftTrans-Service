using CYQ.Data;
using SoftTrans.Service.Entity;
using SoftTrans.Service.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftTrans.Service.DAL
{
    public class CityRepository : BaseRepository<Hrm_City>, ICityRepository
    {
        public CityRepository()
        {
            this.TableName = Entity.Enum.TableNames.Hrm_City;
        }

        Hrm_City IBaseRepository<Hrm_City>.Insert(Hrm_City entity)
        {
            using (MProc proc = new MProc("P_Hrm_City_Add"))
            {
                proc.Set("cityname", entity.cityname);
                proc.Set("ProvinceId", entity.ProvinceId);
                proc.SetCustom("ID", CYQ.Data.DAL.ParaType.OutPut, entity.ID);
                proc.SetCustom("CountryId", CYQ.Data.DAL.ParaType.OutPut, entity.CountryId);
                proc.ExeNonQuery();

                var obj = proc.OutPutValue as Dictionary<string, object>;

                entity.CountryId = Convert.ToInt32(obj["CountryId"]);
                entity.ID = Convert.ToInt32(obj["ID"]);
            }
            return entity;
        }
    }
}
