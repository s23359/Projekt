using APBDProject.Server.Services;
using APBDProject.Shared.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBDProject.Server.Controllers
{
    [Authorize]
    [ApiController]
    [Route("tickers")]
    public class TickersController : ControllerBase
    {
        private readonly ILogger<TickersController> _logger;
        private readonly ITickersService _service;
        public TickersController(ILogger<TickersController> logger, ITickersService service)
        {
            _logger = logger;
            _service = service;
        }
        
        [HttpGet("{id}")]
        public async Task<IEnumerable<TickerSearch>> GetSearchTickers(string id)
        {
            var result = await _service.GetSearchTickers(id);
            return result;
        }

        [HttpGet("info/{id}")]
        public async Task<TickerInfo> GetTickerInfo(string id)
        {
            var result = await _service.GetTickerInfo(id);
            return result;
        }

        [HttpGet("ohlc/{id}")]
        public async Task<IEnumerable<Stock>> GetTickerOHLC(string id)
        {
            var result = await _service.GetTickerOHLC(id);
            return result;
        }

        [HttpPost]
        public async Task<int> AddTickerAndOhlc(TickerWithOhlc ticker)
        {
            var result = await _service.AddTickerInfo(ticker);
            return result;
        }
    }
}
