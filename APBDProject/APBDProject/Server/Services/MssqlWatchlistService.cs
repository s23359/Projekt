using APBDProject.Server.Data;
using APBDProject.Server.Models;
using APBDProject.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBDProject.Server.Services
{
    public class MssqlWatchlistService : IWatchlistService
    {
        private readonly ApplicationDbContext _context;
        public MssqlWatchlistService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> AddToWatchListAsync(string id, Ticker t)
        {
            using (var transaction = await _context.Database.BeginTransactionAsync())
            {
                try
                {
                    var isTicker = await _context.Tickers.Where(e => e.ticker.Equals(t.ticker)).ToListAsync();
                    if (isTicker.Count == 0)
                    {
                        await _context.Tickers.AddAsync(t);
                        await _context.SaveChangesAsync();
                    }

                    var isObserved = await _context.Observations.Where(e => e.TickerName.Equals(t.ticker) && e.UserId.Equals(_context.Users.Where(u => u.UserName.Equals(id)).Select(u => u.Id).First())).ToListAsync();
                    if (isObserved.Count != 0)
                        throw new Exception("It's already on your watchlist!");

                    await _context.Observations.AddAsync(new Observed
                    {
                        TickerName = t.ticker,
                        UserId = _context.Users.Where(e => e.UserName.Equals(id)).Select(e => e.Id).First()
                    });
                    await _context.SaveChangesAsync();
                    await transaction.CommitAsync();
                }
                catch (Exception e)
                {
                    await transaction.RollbackAsync();
                    return -1;
                }
            }
            return 0;
        }

        public async Task<IEnumerable<Ticker>> GetWatchedAsync(string id)
        {
            var userInfo = await _context.Users.Include(e => e.ObservedTickers).Where(e => e.UserName.Equals(id)).Select(e => new
            {
                watchedTickers = _context.Tickers.Where(t => e.ObservedTickers.Select(s => s.Ticker).Contains(t)).ToList()
            }).ToArrayAsync();

            var watchlist = userInfo.First().watchedTickers;
            return watchlist;
        }

        public async Task<int> RemoveFromWatchlist(string id, Ticker ticker)
        {
            using(var transaction = await _context.Database.BeginTransactionAsync())
            {
                try
                {
                    var ons = await _context.Observations.FirstAsync(e => e.TickerName.Equals(ticker.ticker) && e.UserId.Equals(_context.Users.First(u => u.UserName.Equals(id)).Id));
                    ons.Ticker = null;
                    ons.TickerName = null;
                    ons.UserId = null;
                    ons.User = null;
                    await _context.SaveChangesAsync();
                    await transaction.CommitAsync();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    await transaction.RollbackAsync();
                    return -1;
                }
            }

            return 0;
        }
    }
}
