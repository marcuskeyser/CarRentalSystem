using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CarRentalSystem.Models;

namespace CarRentalSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly CarRentalSystemDBContext _context;

        public CustomerController(CarRentalSystemDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Models.POCO.Customer>> Get()
        {
            return _context.Customers.ToList();
        }

        [HttpGet("{id}", Name = "GetCustomer")]
        public ActionResult<Models.POCO.Customer> Get(int id)
        {
            var item = _context.Customers.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }

        [HttpPost]
        public IActionResult Post(Models.POCO.Customer item)
        {
            _context.Customers.Add(item);
            _context.SaveChanges();

            return CreatedAtRoute("GetCustomer", new { id = item.Id }, item);
        }


        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
