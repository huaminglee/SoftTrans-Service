using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace SoftTrans.Service.Entity
{
    [DataContract]
    public class DataFileds
    {
        public DataFileds(object key, object value)
        {
            this.Key = key;
            this.Value = value;
        }
        [DataMember]
        public object Key { get; set; }
        [DataMember]
        public object Value { get; set; }

    }
}
