using APBDProject.Server.Models;
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
    [Route("Watchlist")]
    public class WatchlistController : ControllerBase
    {
        private readonly ILogger<WatchlistController> _logger;
        private readonly IWatchlistService _service;
        public WatchlistController(ILogger<WatchlistController> logger, IWatchlistService service)
        {
            _logger = logger;
            _service = service;
        }
        [HttpGet("{id}")]
        public async Task<IEnumerable<Ticker>> GetWatchedAsync(string id)
        {
            return await _service.GetWatchedAsync(id);
        }

        [HttpPost("{id}")]
        public async Task<IActionResult> AddToWatchListAsync(string id, Ticker ticker)
        {
            string[] lines = { ticker.ticker, ticker.name };
            int response = await _service.AddToWatchListAsync(id, ticker);
            return Ok(response);
        }

        [HttpPost("delete/{id}")]
        public async Task<IActionResult> RemoveFromWatchlistAsync(string id, Ticker ticker)
        {
            int response = await _service.RemoveFromWatchlist(id, ticker);
            return Ok(response);
        }
    }
}
