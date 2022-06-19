using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBDProject.Server.Models
{
    public class TickerOhlc
    {
        public int OhlcId { get; set; }
        public string Ticker { get; set; }

        public string Time { get; set; }
        public double O { get; set; }
        public double C { get; set; }
        public double H { get; set; }
        public double L { get; set; }
        public double V { get; set; }

        public virtual Ticker MyTicker { get; set; }
    }
}
