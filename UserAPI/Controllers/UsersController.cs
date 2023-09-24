using Microsoft.AspNetCore.Mvc;
using UserAPI.Data.Models;
using UserAPI.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserServices _userServices;

        public UsersController(IUserServices userServices)
        {
            _userServices = userServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var user = await _userServices.GetUsers();
            return Ok(user);
        }

        
        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] User request)
        {
            var user = await _userServices.CreateUser(request);
            if (user)
            {
                return Ok("User successfully created");
            }
            return BadRequest("Input is invalid");
        }
      
    }
}
