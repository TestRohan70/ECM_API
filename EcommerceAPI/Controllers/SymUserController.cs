using EcommerceAPI.Services;
using EcommerceAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SymUserController : ControllerBase
    {
        private readonly ISymUserService _symUserService;

        public SymUserController(ISymUserService symUserService)
        {
            _symUserService = symUserService;
        }
        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var users = await _symUserService.GetAllUsersAsync();

            return Ok(users);
        }


    
    [HttpGet("{ID}")]
    public async Task<IActionResult> GetUserByID(int  ID)
    {
        var users = await _symUserService.GetUserByID(ID);

        return Ok(users);
    }

}
}
