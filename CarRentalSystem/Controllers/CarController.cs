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
    public class CarController : ControllerBase
    {
        private readonly CarRentalSystemDBContext _context;

        public CarController(CarRentalSystemDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Models.POCO.Car>> Get()
        {
            return _context.Cars.ToList();
        }

        [HttpGet("{id}", Name = "GetCar")]
        public ActionResult<Models.POCO.Car> Get(int id)
        {
            var item = _context.Cars.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }

        [HttpPost]
        public IActionResult Post(Models.POCO.Car item)
        {
            _context.Cars.Add(item);
            _context.SaveChanges();

            return CreatedAtRoute("GetCar", new { id = item.Id }, item);
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
