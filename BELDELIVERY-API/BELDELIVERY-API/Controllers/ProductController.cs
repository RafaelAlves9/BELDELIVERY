using Microsoft.AspNetCore.Mvc;
using BELDELIVERY_API.Domain.Interfaces;
using BELDELIVERY_API.Models;

namespace BELDELIVERY_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepositorie _product;

        public ProductController(IProductRepositorie product)
        {
            _product = product;
        }

        [HttpGet("get-all")]
        public async Task<ActionResult<List<Product>>> GetAll()
        {
            List<Product> ProductById = await _product.GetAll();
            return Ok(ProductById);
        }

        [HttpGet("get-by-id/{id}")]
        public async Task<ActionResult<Product>> GetById(int id)
        {
            Product ProductById = await _product.GetById(id);
            return Ok(ProductById);
        }

        [HttpPost("create")]
        public async Task<ActionResult<Product>> Create([FromBody] Product Product)
        {

            Product ProductById = await _product.Create(Product);
            return Ok(ProductById);
        }

        [HttpPost("delete/{id}")]
        public async Task<ActionResult<bool>> Delete(int id)
        {
            bool ProductById = await _product.Delete(id);

            return Ok(ProductById);
        }

        [HttpPost("update/{id}")]
        public async Task<ActionResult<Product>> Update([FromBody] Product Product, int id)
        {
            Product ProductById = await _product.Update(Product, id);
            return Ok(ProductById);
        }
    }
}