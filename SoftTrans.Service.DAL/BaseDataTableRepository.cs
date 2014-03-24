using CYQ.Data;
using SoftTrans.Service.Entity.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftTrans.Service.DAL
{
    public class BaseDataTableRepository
    {
        public bool Delete(TableNames t, object where, params object[] aopPara)
        {
            bool result = false;
            using (MAction action = new MAction(t))
            {
                result = action.Delete(where, aopPara);
            }
            return result;
        }




    }
}
