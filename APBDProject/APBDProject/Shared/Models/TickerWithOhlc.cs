using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APBDProject.Shared.Models
{
    public class TickerWithOhlc
    {
        public TickerInfo ticker { get; set; }
        public ICollection<Stock> ohlcs { get; set; }
    }
}
