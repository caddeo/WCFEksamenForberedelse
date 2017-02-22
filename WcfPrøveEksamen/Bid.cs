using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfPrøveEksamen
{
    [DataContract]
    public class Bid
    {
        [DataMember]
        public int Price { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Phone { get; set; }
        [DataMember]
        public DateTime Time { get; set; }

        public Bid()
        {
            this.Price = 0;
        }
    }
}
