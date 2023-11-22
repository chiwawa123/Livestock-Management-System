using LivestockMgmt.contexts;
using LivestockMgmt.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LivestockMgmt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FarmController : ControllerBase
    {
        private readonly ApiDbContext _context;
        public FarmController(ApiDbContext dbContext) {
            _context = dbContext;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Farm>>> getFarms()
        {
            return await _context.Farms.ToListAsync();
        }

        [HttpGet("FarmById")]
        public async Task<ActionResult<Farm>> getFarmById(int farm_id)
        {
            var farmId = await _context.Farms.FindAsync(farm_id);

            if (farmId == null)
            {
                return NotFound();
            }
            return Ok(farmId);

        }
        [HttpPost("addFarm")]

        public async Task<ActionResult> addFarm(Farm farm)
        {
            _context.Farms.Add(farm);
            await _context.SaveChangesAsync();

            return Ok(farm);
        }

        [HttpPost("deleteFarm")]
        public async Task<IActionResult> deleteFarm(int farm_id)
        {
            var get_farm_id = await _context.Farms.FindAsync(farm_id);
            if (get_farm_id == null)
            {
                return NotFound();

            }


            _context.Farms.Remove(get_farm_id);
            await _context.SaveChangesAsync();

            return Ok();
        }
        [HttpPost("updateFarm")]
        public async Task<IActionResult> putProgramme(Farm farm)
        {
            int farm_id = farm.farm_id;

            _context.Entry(farm).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FarmExists(farm_id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return Ok(farm);


        }

        private bool FarmExists(int farm_id)
        {
            throw new NotImplementedException();
        }


    }
}
