using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBDProject.Shared.Models
{
    public class SearchTickersResponse
    {
        public List<TickerSearch> results { get; set; }      
        public string next_url { get; set; }
    }
}
