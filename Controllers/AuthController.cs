using LivestockMgmt.Models;
using LivestockMgmt.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LivestockMgmt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        public AuthController(IAuthService authService)
        {
            _authService = authService;
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

                return Ok(new
                {
                    token = tokenString,
                    user = user,
                });
            }
            return BadRequest();
        }
    }
}
