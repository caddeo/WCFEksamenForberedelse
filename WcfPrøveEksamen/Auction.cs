﻿using System;
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
        public string Id { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public int Rating { get; set; }
        [DataMember]
        public Bid Bid { get; set; }

        public Auction()
        {
            Bid = new Bid();
        }

    }
}
