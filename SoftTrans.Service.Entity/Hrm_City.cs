using System;

namespace SoftTrans.Service.Entity
{
    /// <summary>
    /// ��������
    /// </summary>
    public class Hrm_City 
    {
        public int ID { get; set; }
        public string cityname { get; set; }
        public int ProvinceId { get; set; }
        public int CountryId { get; set; }
    }
}
