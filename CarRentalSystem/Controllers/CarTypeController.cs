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
    public class CarTypeController : ControllerBase
    {
        private readonly CarRentalSystemDBContext _context;

        public CarTypeController(CarRentalSystemDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Models.POCO.CarType>> Get()
        {
            return _context.CarTypes.ToList();
        }

        [HttpGet("{id}", Name = "GetCarType")]
        public ActionResult<Models.POCO.CarType> Get(int id)
        {
            var item = _context.CarTypes.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }

        [HttpPost]
        public IActionResult Post(Models.POCO.CarType item)
        {
            _context.CarTypes.Add(item);
            _context.SaveChanges();

            return CreatedAtRoute("GetCarType", new { id = item.Id }, item);
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
