using Microsoft.AspNetCore.Mvc;
using EcommerceAPI.Models;
    using EcommerceAPI.DTOs;
using EcommerceAPI.Services.Interfaces;

namespace EcommerceAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly EcommerceDbContext _context;
        private readonly IProductService _productService;

        public ProductsController(EcommerceDbContext context, IProductService productService)
        {
            _context = context;
            _productService = productService;

        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = _context.Products.ToList();

            return Ok(products);
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(CreateProductDto dto)
        {
            var productId = await _productService.CreateProductAsync(dto);

            return Ok(productId);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, Product updatedProduct)
        {
            var product = _context.Products.Find(id);

            if (product == null)
            {
                return NotFound();
            }

            product.ProductName = updatedProduct.ProductName;
            product.Description = updatedProduct.Description;
            product.Price = updatedProduct.Price;
           // product.StockQty = updatedProduct.StockQty;
            product.ImageUrl = updatedProduct.ImageUrl;
            product.CategoryId = updatedProduct.CategoryId;

            _context.SaveChanges();

            return Ok(product);
        }



        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var product = _context.Products.Find(id);

            if (product == null)
            {
                return NotFound();
            }

            _context.Products.Remove(product);

            _context.SaveChanges();

            return Ok("Product Deleted Successfully");
        }


        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            var product = _context.Products.Find(id);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }


    }
}