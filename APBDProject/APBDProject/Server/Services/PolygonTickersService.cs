using APBDProject.Server.Data;
using APBDProject.Shared.Models;
using APBDProject.Server.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace APBDProject.Server.Services
{
    public class PolygonTickersService : ITickersService
    {
        static readonly HttpClient Http = new HttpClient();
        private readonly ApplicationDbContext _context;

        public PolygonTickersService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> AddTickerInfo(TickerWithOhlc ticker)
        {
            using (var transaction = await _context.Database.BeginTransactionAsync())
            {
                try
                {
                    var isTickerInDatabase = await _context.Tickers.Where(e => e.ticker.Equals(ticker.ticker.ticker)).ToListAsync();
                    if (isTickerInDatabase.Count == 0)
                    {
                        await _context.Tickers.AddAsync(new Ticker
                        {
                            ticker = ticker.ticker.ticker,
                            name = ticker.ticker.name,
                            market = ticker.ticker.market,
                            locale = ticker.ticker.locale,
                            description = ticker.ticker.description,
                            homepage_url = ticker.ticker.homepage_url
                        });
                        await _context.SaveChangesAsync();
                    }
                    var oldOhlcs = await _context.Ohlcs.Where(e => e.Ticker.Equals(ticker.ticker.ticker)).ToListAsync();
                    if(oldOhlcs.Count != 0)
                    {
                        oldOhlcs.ForEach(e =>
                        {
                            e.MyTicker = null;
                            e.Ticker = null;
                        });
                        await _context.SaveChangesAsync();
                        _context.RemoveRange(oldOhlcs);
                        await _context.SaveChangesAsync();
                    }

                    await _context.Ohlcs.AddRangeAsync(ticker.ohlcs.Select(e => new TickerOhlc
                    {
                        Ticker = ticker.ticker.ticker,
                        Time = e.Time,
                        O = e.o,
                        H = e.h,
                        L = e.l,
                        C = e.c,
                        V = e.v
                    }));
                    await _context.SaveChangesAsync();
                    await transaction.CommitAsync();
                    return 0;
                }
                catch (Exception e)
                {
                    await transaction.RollbackAsync();
                    return -1;
                }
            }
        }

        public async Task<IEnumerable<TickerSearch>> GetSearchTickers(string like)
        {
            var json = await Http.GetFromJsonAsync<SearchTickersResponse>($"https://api.polygon.io/v3/reference/tickers?active=true&sort=ticker&order=asc&limit=200&search={like}&apiKey=0YTL0kKbNICyA4p7ptpBGeK4aMGp2IjO");
            var tickers = json.results;

            return tickers;
        }

        public async Task<TickerInfo> GetTickerInfo(string ticker)
        {
            try
            {
                var json = await Http.GetFromJsonAsync<TickerInfoResult>($"https://api.polygon.io/v3/reference/tickers/{ticker}?apiKey=0YTL0kKbNICyA4p7ptpBGeK4aMGp2IjO");
                var tickerInfo = json.results;
                return tickerInfo;
            }
            catch(Exception e)
            {
                return await _context.Tickers.Where(e => e.ticker.Equals(ticker)).Select(e => new TickerInfo
                {
                    ticker = e.ticker,
                    name = e.name,
                    market = e.market,
                    locale = e.locale,
                    description = e.description,
                    homepage_url = e.homepage_url
                }).FirstAsync();
            }
        }

        public async Task<IEnumerable<Stock>> GetTickerOHLC(string ticker)
        {
            try
            {
                var dateString1 = DateTime.Now.ToString("yyyy-MM-dd");
                var dateString2 = DateTime.Today.AddMonths(-3).ToString("yyyy-MM-dd");
                var json2 = await Http.GetFromJsonAsync<OhlcResponse>($"https://api.polygon.io/v2/aggs/ticker/{ticker}/range/1/day/{dateString2}/{dateString1}?adjusted=true&sort=asc&limit=120&apiKey=0YTL0kKbNICyA4p7ptpBGeK4aMGp2IjO");
                List<OHLC> data = json2.results;
                if (data == null)
                    throw new Exception("No ohlc");
                double numberOfDays = (DateTime.Parse(dateString1) - DateTime.Parse(dateString2)).TotalDays;
                DateTime startingDate = DateTime.Today.AddMonths(-3);
                int record = data.Count;
                List<Stock> Data = new List<Stock>();
                foreach (OHLC o in data)
                {
                    Data.Add(new Stock
                    {
                        Time = startingDate.AddDays(numberOfDays / record).ToString("yyyy-MM-dd"),
                        o = o.o,
                        h = o.h,
                        c = o.c,
                        l = o.l,
                        v = o.v
                    });

                    startingDate = startingDate.AddDays((numberOfDays / record));
                }
                return Data;
            }
            catch
            {
                return await _context.Ohlcs.Where(e => e.Ticker.Equals(ticker)).Select(e => new Stock
                {
                    Time = e.Time,
                    o = e.O,
                    h = e.H,
                    l = e.L,
                    c = e.C,
                    v = e.V
                }).ToListAsync();
            }
        }

    }
}
