using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APBDProject.Shared.Models
{
    public class TickerInfo
    {
        public string ticker { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string homepage_url { get; set; }
        public string locale { get; set; }
        public string market { get; set; }
        public Branding branding { get; set; } 
    }
}
