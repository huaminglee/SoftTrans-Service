using System;

namespace SoftTrans.Service.Entity
{
    [Serializable]
    /// <summary>
    /// ��������
    /// </summary>
    public class Hrm_Country
    {
        public int ID { get; set; }
        public string CountryName { get; set; }
        public string CountryDesc { get; set; }
    }
}
