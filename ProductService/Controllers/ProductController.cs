using Microsoft.AspNetCore.Mvc;
using ProductService.Models;
using System.Collections.Generic;

namespace ProductService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private static List<Product> _products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Price = 1200 },
            new Product { Id = 2, Name = "Smartphone", Price = 800 }
        };

        [HttpGet]
        public IEnumerable<Product> Get() => _products;

        [HttpPost]
        public IActionResult Post([FromBody] Product product)
        {
            _products.Add(product);
            return Ok();
        }
    }
}
