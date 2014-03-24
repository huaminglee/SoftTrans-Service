using System;

namespace SoftTrans.Service.Entity
{
    /// <summary>
    /// ≤ø√≈…Ë÷√
    /// </summary>
    public class HrmDepartment 
    {
        public int ID { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentMark { get; set; }
        public int SubCompanyId { get; set; }
        public int SupDepId { get; set; }
        public int ShowOrder { get; set; }
    }
}
