using CYQ.Data;
using SoftTrans.Service.Entity;
using SoftTrans.Service.Entity.Enum;
using SoftTrans.Service.IDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftTrans.Service.DAL
{
    public class ProvinceRepository : BaseRepository<Hrm_Province>, IProvinceRepository
    {
        public ProvinceRepository()
        {
            this.TableName = TableNames.Hrm_Province;
        }

        Hrm_Province IBaseRepository<Hrm_Province>.Insert(Hrm_Province entity)
        {
            using (MProc proc = new MProc("P_Hrm_Province_Add"))
            {
                proc.Set("CountryId", entity.CountryId);
                proc.Set("ProvinceDesc", entity.ProvinceDesc);
                proc.Set("ProvinceName", entity.ProvinceName);
                proc.SetCustom("ID", CYQ.Data.DAL.ParaType.OutPut, entity.ID);
                proc.ExeNonQuery();

                entity.ID = Convert.ToInt32(proc.OutPutValue);
            }
            return entity;
        }
    }
}
