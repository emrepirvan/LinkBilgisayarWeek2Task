using EFCoreLink.API.Interfaces;
using EFCoreLink.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreLink.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _products;

        public ProductController(IProductRepository products)
        {
            _products = products;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _products.GetAll());
        }
        [HttpPost]
        public async Task<IActionResult> AddProduct(Product product)
        {
            
            return Ok(await _products.AddProduct(product)); 
        }
        [HttpGet("{Id}")]
        public async Task<IActionResult> GetByID(int Id)
        {
            if (await _products.GetByIdAsync(Id) == null)
            {
                return BadRequest("Not Found");
            }else
            return Ok(await _products.GetByIdAsync(Id));
        }
        [HttpPut]
        public async Task<IActionResult> UpdateProduct(Product UpdateProduct)
        {
                return Ok(await _products.UpdateProduct(UpdateProduct));
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            if (await _products.GetByIdAsync(id) == null)
            {
                return BadRequest("Not Found");
            }
            else
                return Ok(await _products.Delete(id));
        }
    }
}
