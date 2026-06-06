using EcommerceAPI.Models;
using EcommerceAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly ISymUserService _userService;
        private readonly IJwtService _jwtService;

        public AuthController(
            ISymUserService userService,
            IJwtService jwtService)
        {
            _userService = userService;
            _jwtService = jwtService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginRequest request)
        {
            var user = await _userService
                .ValidateUser(request.UserName, request.Password);

            if (user == null)
                return Unauthorized("Invalid Username or Password");

            var token = _jwtService.GenerateToken(user);

            return Ok(new
            {
                Token = token
            });
        }
    }
}