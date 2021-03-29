using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using AngularTestSeparate.Models.Context;
using AngularTestSeparate.Models.Order;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace AngularTestSeparate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : Controller
    {
        private readonly OrderContext _context;

        public OrderController(OrderContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("create")]
        public async Task<ActionResult<JsonResult>> InsertOrder()
        {
            var file = await System.IO.File.ReadAllTextAsync("generated.json");
            var data = JsonConvert.DeserializeObject<List<Order>>(file);
            if (data != null)
            {
                await _context.Order.AddRangeAsync(data);
                await _context.SaveChangesAsync();
            }

            return null;
        }

        [HttpGet]
        [Route("getById/{id}")]
        public async Task<ActionResult<Order>> GetOrderById(int id)
        {
            var order = await _context.Order.Where(x => x.Id == id)
                .Include(s => s.Stops)
                .ThenInclude(l => l.Location)
                .ThenInclude(c => c.City)
                .ToListAsync();

            if (order.Any())
                return order[0];

            return null;
        }
    }
}
