using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftTrans.Service.Entity
{
    [Serializable]
    public class T_baseBalanceExchange_Rate
    {
   
        public decimal RowID { get; set; }
        public string Contract_Currency { get; set; }
        public string Balance_Currency { get; set; }
        public decimal Exchange_Rate { get; set; }
        public string Rate_Date { get; set; }
        public string Recorder { get; set; }
        public DateTime? RecordDate { get; set; }
        public string Modifier { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}
