using LivestockMgmt.contexts;
using LivestockMgmt.Models;
using LivestockMgmt.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LivestockMgmt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly ApiDbContext _context;
        public AuthController(IAuthService authService,ApiDbContext apiDbContext)
        {
            _authService = authService;
            _context = apiDbContext;
        }

        [HttpPost("Register")]
        public async Task<IActionResult> Register(LoginUser user)
        {
            if (await _authService.RegisterUser(user))
            {
                return Ok("sucesss");
            }

            return BadRequest("Something Went Wrong");
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginUser user)
        {

            var result = await _authService.Login(user);

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            if (result == true)
            {
                var tokenString = _authService.GenerateTokenString(user);
                var query = $"SELECT * FROM farmers WHERE farmers.user_id = '4a5a0d27-2c18-4fe0-8aaa-127895afd723'";
   

                var user_farmer = _context.Farmers.FromSqlRaw(query).First();

                return Ok(new
                {
                    token = tokenString,
                    user = user,
                    farmer=user_farmer
               
                });
            }
            return BadRequest();
        }
    }
}
