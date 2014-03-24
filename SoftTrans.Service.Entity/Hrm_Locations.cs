using System;

namespace SoftTrans.Service.Entity
{
    /// <summary>
    /// 办公地点
    /// </summary>
    public class Hrm_Locations 
    {
        public int ID { get; set; }
        public string LocationName { get; set; }
        public string LocationDesc { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public string PostCode { get; set; }
        public int LocationCity { get; set; }
        public int CountryId { get; set; }
        public int ShowOrder { get; set; }
    }
}
