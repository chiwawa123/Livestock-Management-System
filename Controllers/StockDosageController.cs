using LivestockMgmt.contexts;
using LivestockMgmt.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LivestockMgmt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockDosageController : ControllerBase
    {
        private readonly ApiDbContext _context;

        public StockDosageController(ApiDbContext dbContext)
        {
            _context = dbContext;
        }

        [HttpGet("getStockDosages")]
        public async Task<ActionResult<IEnumerable<StockDosage>>> getStockDosage()
        {
            return await _context.StockDosages.ToListAsync();
        }

        [HttpGet("getStockDosageById")]
        public async Task<ActionResult<StockDosage>> getDosageById(int stock_dosage_id)
        {
            var get_stock_dosage_id = await _context.StockDosages.FindAsync(stock_dosage_id);

            if (get_stock_dosage_id == null)
            {
                return NotFound();
            }

            return Ok(get_stock_dosage_id);
        }

        [HttpPost("addStockDosage")]
        public async Task<ActionResult> addStockDosage(StockDosage stockDosage)
        {
            _context.StockDosages.Add(stockDosage);
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpPost("deleteStockDosage")]
        public async Task<IActionResult> deleteStockDosage(int stock_dosage_id)
        {
            var get_dosage_id = await _context.StockDosages.FindAsync(stock_dosage_id);
            if (get_dosage_id == null)
            {
                return NotFound();
            }

            _context.StockDosages.Remove(get_dosage_id);
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpPost("updateStockDosage")]
        public async Task<IActionResult> updateStockDosage(StockDosage stockDosage)
        {
            int stock_dosage_id = stockDosage.stock_dosage_id;

            _context.Entry(stockDosage).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StockDosage(stock_dosage_id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return Ok(stockDosage);
        }

        private bool StockDosage(int stock_dosage_id)
        {
            throw new NotImplementedException();
        }
    }
}
