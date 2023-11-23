using LivestockMgmt.contexts;
using LivestockMgmt.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LivestockMgmt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class farmerController : ControllerBase
    {
        private readonly ApiDbContext _context;
        public farmerController(ApiDbContext dbContext)
        {
            _context = dbContext;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Farmer>>> getFarmers()
        {
            return await _context.Farmers.ToListAsync();
        }

        [HttpGet("FarmerById")]
        public async Task<ActionResult<Farmer>> getFarmerById(int farmer_id)
        {
            var farmer = await _context.Farmers.FindAsync(farmer_id);

            if (farmer == null)
            {
                return NotFound();
            }
            return Ok(farmer);

        }


        [HttpPost("addFarmer")]

 
        public async Task<ActionResult> addFarmer(Farmer _farmer)
        {
            _context.Farmers.Add(_farmer);
            await _context.SaveChangesAsync();

            return Ok(_farmer);
        }


        [HttpPost("deleteFarmer")]
        public async Task<IActionResult> deleteFarmer(int farmer_id)
        {
            var farmer = await _context.Farmers.FindAsync(farmer_id);
            if (farmer == null)
            {
                return NotFound();

            }


            _context.Farmers.Remove(farmer);
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpPost("updateFarmer")]
        public async Task<IActionResult> updatefarm(Farmer farmer)
        {
            int farmer_id = farmer.farmer_id;

            _context.Entry(farmer).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (FarmerExistsAsync(farmer_id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return Ok(farmer);


        }


        private bool FarmerExistsAsync(int farmer_id)
        {
            var farmer = _context.Farmers.Find(farmer_id);
            if(farmer == null)
            {
                return false;
            }
            return true;
        }



    }
}
