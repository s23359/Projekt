using APBDProject.Server.Models;
using APBDProject.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBDProject.Server.Services
{
    public interface IWatchlistService
    {
        public Task<IEnumerable<Ticker>> GetWatchedAsync(string id);
        public Task<int> AddToWatchListAsync(string id, Ticker ticker);
        public Task<int> RemoveFromWatchlist(string id, Ticker ticker);
    }
}
