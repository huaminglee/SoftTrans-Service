using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftTrans.Service.Entity
{
    public class UserConfig : CYQ.Data.Orm.OrmBase
    {
        public UserConfig()
        {
            base.SetInit(this, "Settings.db", "txt path={0};ts=0");
        }
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
