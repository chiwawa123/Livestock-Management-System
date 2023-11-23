using LivestockMgmt.contexts;
using LivestockMgmt.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LivestockMgmt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class stockStatesController : ControllerBase
    {
        private readonly ApiDbContext _context;

        [HttpGet]
        public async Task<ActionResult<IEnumerable<StockState>>> getstates()
        {
            return await _context.StockStates.ToListAsync();
        }


        [HttpGet("getLast")]
        public async Task<ActionResult<Farmer>> getlaststate(int stock_id)
        {
            var farmer = await _context.StockStates.Where(x => x.livestock_id == stock_id).LastOrDefaultAsync();

            if (farmer == null)
            {
                return NotFound();
            }
            return Ok(farmer);

        }


        [HttpPost("addstates")]


        public async Task<ActionResult> addFarmer(StockState _state)
        {
            _context.StockStates.Add(_state);
            await _context.SaveChangesAsync();

            return Ok(_state);
        }
    }
}
