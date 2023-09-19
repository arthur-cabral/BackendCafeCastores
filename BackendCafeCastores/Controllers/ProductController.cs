using Application.DTOs.Products;
using Application.DTOs.Response;
using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;
        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetProductDTO>>> GetProducts()
        {
            var products = await productService.GetProducts();
            return Ok(products);
        }

        [HttpGet("id/{id}", Name = "GetProductById")]
        public async Task<ActionResult<GetProductDTO>> GetProductById(int id)
        {
            var products = await productService.GetProductById(id);
            if (products == null)
            {
                return NotFound();
            }
            return Ok(products);
        }

        [HttpGet("name/{name}", Name = "GetProductByName")]
        public async Task<ActionResult<GetProductDTO>> GetProductByName(string name)
        {
            var product = await productService.GetProductByName(name);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpPost]
        public async Task<MessageResponseDTO> CreateProduct(
            [FromBody] CreateProductDTO request)
        {
            return await productService.CreateProduct(request);
        }

        [HttpPut("{id}")]
        public async Task<MessageResponseDTO> UpdateProduct(int id,
            [FromBody] CreateProductDTO request)
        {
            return await productService.UpdateProduct(id, request);
        }

        [HttpDelete("{id}")]
        public async Task<MessageResponseDTO> DeleteProduct(int id)
        {
            return await productService.DeleteProduct(id);
        }
    }
}
