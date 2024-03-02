using Microsoft.AspNetCore.Mvc;
using ProductAPI.Repositories;
using ProductCore.Models;

namespace ProductAPI.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IRepository<Product> _productRepository;

        public ProductsController(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public async Task<IActionResult> Menu()
        {
            return Ok(await _productRepository.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await _productRepository.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct([FromBody] Product product)
        {
            var productId = await _productRepository.Add(product);

            if (productId > 1)
                return CreatedAtAction(nameof(Menu), "Product added");

            return BadRequest("Something went wrong");
        }

        [HttpPatch("{id}")]
        public async Task<IActionResult> UpdateProduct(int id, [FromBody] Product product)
        {
            var prod = await _productRepository.GetById(id);
            if (prod == null)
                return BadRequest("Product not found");

            product.Id = id;
            if (await _productRepository.Update(product))
                return Ok("Product Updated !");

            return BadRequest("Something went wrong...");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> RemoveProduct(int id)
        {
            var prod = await _productRepository.GetById(id);
            if (prod == null)
                return BadRequest(new { message = "Product not found" });

            if (await _productRepository.Delete(id))
                return Ok(new { message = "Product Deleted !" });

            return BadRequest(new { message = "Something went wrong..." });
        }
    }
}
