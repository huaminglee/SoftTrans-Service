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
        private ProvinceRepository()
        {
            this.TableName = TableNames.Hrm_Province;
        }
    }
}
