using System;

namespace SoftTrans.Service.Entity
{
    /// <summary>
    /// ��λ����
    /// </summary>
    public class HrmJobActivities 
    {
        public int ID { get; set; }
        public string JobActivityName { get; set; }
        public string JobActivityMark { get; set; }
        public int JobGroupId { get; set; }
    }
}
