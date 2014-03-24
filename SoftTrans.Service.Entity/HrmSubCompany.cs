using System;

namespace SoftTrans.Service.Entity
{
    public class HrmSubCompany 
    {
        public int ID { get; set; }
        public string SubCompanyName { get; set; }
        public string SubCompanyDesc { get; set; }
        public int Companyid { get; set; }
        public int SupSubcomid { get; set; }
        public int ShowOrder { get; set; }
    }
}
