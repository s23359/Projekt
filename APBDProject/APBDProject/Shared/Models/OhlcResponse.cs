﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APBDProject.Shared.Models
{
    public class OhlcResponse
    {
        public List<OHLC> results { get; set; }
        public int resultsCount { get; set; }
    }
}
