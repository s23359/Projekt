using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBDProject.Server.Models
{
    public class Ticker
    {
        public string ticker { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string homepage_url { get; set; }
        public string market { get; set; }
        public string locale { get; set; }

        public virtual ICollection<Observed> Users { get; set; }
        public virtual ICollection<TickerOhlc> Ohlcs { get; set; }
    }
}
