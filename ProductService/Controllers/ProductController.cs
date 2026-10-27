using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductService.Models;

namespace ProductService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetProducts()
        {
            var product = new List<ProductModel>()
            {
                new ProductModel{Id = 1, Name="Laptop", Price=150000},
                new ProductModel{Id = 2, Name="LED Screen", Price=50000},
                new ProductModel{Id = 3, Name="Bag", Price=2500},
                new ProductModel{Id = 4, Name="Mouse", Price=4000},
                new ProductModel{Id = 5, Name="Charger", Price=3500}
            };
            return Ok(product);
        }
    }
}
