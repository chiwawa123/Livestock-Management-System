using LivestockMgmt.contexts;
using LivestockMgmt.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LivestockMgmt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockWeightController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public StockWeightController(ApiDbContext dbContext)
        {
            _context = dbContext;
        }

        [HttpGet("getAllStockWeights")]
        public async Task<ActionResult<IEnumerable<StockWeight>>> getStockWeights()
        {
            return await _context.StockWeights.ToListAsync();
        }

        [HttpGet("getStockWeightById")]
        public async Task<ActionResult<StockWeight>> getStockWeightId(int stock_weight_id)
        {
            var stockWeightId = await _context.Farms.FindAsync(stock_weight_id);

            if (stockWeightId == null)
            {
                return NotFound();
            }
            return Ok(stockWeightId);
        }

        [HttpPost("addStockWeight")]
        public async Task<ActionResult> addStockWeight(StockWeight stockWeight)
        {
            _context.StockWeights.Add(stockWeight);
            await _context.SaveChangesAsync();

            return Ok(stockWeight);
        }

        [HttpPost("deleteStockWeight")]
        public async Task<IActionResult> deleteStockWeight(int stock_weight_id)
        {
            var get_stock_weight_id = await _context.StockWeights.FindAsync(stock_weight_id);
            if (get_stock_weight_id == null)
            {
                return NotFound();
            }

            _context.StockWeights.Remove(get_stock_weight_id);
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpPost("updateStockWeight")]
        public async Task<IActionResult> updateStockWeight(StockWeight stockWeight)
        {
            int stock_weight_id = stockWeight.stock_weight_id;

            _context.Entry(stockWeight).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!stockweight(stock_weight_id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return Ok(stockWeight);
        }

        private bool stockweight(int stock_weight_id)
        {
            throw new NotImplementedException();
        }
    }
}
