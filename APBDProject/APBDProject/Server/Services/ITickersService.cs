using APBDProject.Server.Models;
using APBDProject.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBDProject.Server.Services
{
    public interface ITickersService
    {
        public Task<IEnumerable<TickerSearch>> GetSearchTickers(string like);
        public Task<TickerInfo> GetTickerInfo(string ticker);
        public Task<IEnumerable<Stock>> GetTickerOHLC(string ticker);
        public Task<int> AddTickerInfo(TickerWithOhlc ticker);
    }
}
