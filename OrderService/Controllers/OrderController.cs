using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OrderService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly HttpClient _httpClient;

        public OrderController(IHttpClientFactory factory)
        {
            _httpClient = factory.CreateClient();
        }

        [HttpGet]
        public async Task<IActionResult> GetOrder()
        {
            var product = await _httpClient.GetStringAsync("https://localhost:7252/api/Product");
            return Ok(new
            {
                Message = "Order created successfully!",
                ProductData = product
            });
        }
    }
}
