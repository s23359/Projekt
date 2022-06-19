using APBDProject.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APBDProject.Server.Models
{
    public class Observed
    {
        public int ObservationId { get; set; }
        public string UserId { get; set; }
        public string TickerName { get; set; }

        public virtual ApplicationUser User { get; set; }
        public virtual Ticker Ticker { get; set; }
    }
}
