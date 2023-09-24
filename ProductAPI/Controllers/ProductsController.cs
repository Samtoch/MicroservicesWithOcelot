using Microsoft.AspNetCore.Mvc;
using ProductAPI.Data.Models;
using ProductAPI.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductServices _productServices;

        public ProductsController(IProductServices productServices)
        {
            _productServices = productServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var user = await _productServices.GeProducts();
            return Ok(user);
        }


        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] Product request)
        {
            var user = await _productServices.CreateProduct(request);
            if (user)
            {
                return Ok("Product successfully created");
            }
            return BadRequest("Input is invalid");
        }
    }
}
