using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfPrøveEksamen
{
    [DataContract]
    public class Auction
    {
        [DataMember]
        public string Varenummer { get; set; }
        [DataMember]
        public string Varebetegnelse { get; set; }
        [DataMember]
        public int Vurdering { get; set; }
        [DataMember]
        public int BudPris { get; set; }
        [DataMember]
        public string BudKundeNavn { get; set; }
        [DataMember]
        public string BudKundeTelefon { get; set; }
        [DataMember]
        public DateTime BudTidspunkt { get; set; }

    }
}
