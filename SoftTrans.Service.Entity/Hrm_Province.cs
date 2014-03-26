using System;

namespace SoftTrans.Service.Entity
{
    [Serializable]
    /// <summary>
    ///  °∑›…Ë÷√
    /// </summary>
    public class Hrm_Province
    {
        public int ID { get; set; }
        public string ProvinceName { get; set; }
        public string ProvinceDesc { get; set; }
        public int CountryId { get; set; }
    }
}
