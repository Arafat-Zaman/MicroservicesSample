using Microsoft.AspNetCore.Mvc;
using OrderService.Models;
using System.Collections.Generic;

namespace OrderService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private static List<Order> _orders = new List<Order>();

        [HttpGet]
        public IEnumerable<Order> Get() => _orders;

        [HttpPost]
        public IActionResult Post([FromBody] Order order)
        {
            _orders.Add(order);
            return Ok();
        }
    }
}
