using LivestockMgmt.contexts;
using LivestockMgmt.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LivestockMgmt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivestockController : ControllerBase
    {
        private readonly ApiDbContext _apiDbContext;

        public LivestockController(ApiDbContext apiDbContext)
        {
            _apiDbContext = apiDbContext;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Livestock>>> GetAllLiveStocks()
        {
            return await _apiDbContext.Livestocks.ToListAsync();

        }

        [HttpGet("view-livestock")]
        
        public async Task<ActionResult<Livestock>> getLivestockById(int stock_id)
        {
            var stock =  await _apiDbContext.Livestocks.FindAsync(stock_id);
            if (stock == null)
            {
                return NotFound();
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(stock);
        }

        [HttpPost("add-livestock")]
        public async Task<ActionResult> addLivestock(Livestock livestock)
        {
            _apiDbContext.Livestocks.Add(livestock);
            await _apiDbContext.SaveChangesAsync();
            return Ok(livestock);
        }


        [HttpPost("remove-livestock")]
        public async Task<ActionResult> removeLivestock(int stock_id)
        {
            var stock = await _apiDbContext.Livestocks.FindAsync(stock_id);
            if(stock == null)
            {
                ModelState.AddModelError("message","live stock not found");
                return BadRequest(ModelState);
            }

            _apiDbContext.Livestocks.Remove(stock);
            await _apiDbContext.SaveChangesAsync();

            return Ok();
        }

        [HttpPost("update-livestock")]
        public async Task<ActionResult> updateLiveStock(Livestock livestock)
        {
            var stock = _apiDbContext.Livestocks.FirstOrDefault(ls=>ls.stock_id == livestock.stock_id);


            _apiDbContext.Entry(stock).CurrentValues.SetValues(livestock);


            await _apiDbContext.SaveChangesAsync();
            return Ok(livestock);
     
        }


       
    }
}
