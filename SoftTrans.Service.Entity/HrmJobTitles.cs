using System;

namespace SoftTrans.Service.Entity
{
    public class HrmJobTitles 
    {
        public int ID { get; set; }
        public string JobTitleName { get; set; }
        public string JobTitleMark { get; set; }
        public int JobActivityId { get; set; }
        public int JobDepartmentId { get; set; }
    }
}
