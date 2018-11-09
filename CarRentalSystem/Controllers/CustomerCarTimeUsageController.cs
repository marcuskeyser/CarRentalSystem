using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CarRentalSystem.Models;
using System.Net.Http;
using System.Net;

namespace CarRentalSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerCarTimeUsageController : ControllerBase
    {
        private readonly CarRentalSystemDBContext _context;

        public CustomerCarTimeUsageController(CarRentalSystemDBContext context)
        {
            _context = context;
        }

        [HttpGet(Name = "GetDTO")]
        public ActionResult<IEnumerable<Models.DTO.CustomerCarTimeUsage>> Get()
        {
            return (
                from CustomerCarTimeUsage in _context.CustomerCarTimeUsages
                join Customer in _context.Customers on CustomerCarTimeUsage.CustomerId equals Customer.Id
                join Car in _context.Cars on CustomerCarTimeUsage.CarId equals Car.Id
                join CarType in _context.CarTypes on Car.CarTypeId equals CarType.Id
                select new Models.DTO.CustomerCarTimeUsage()
                {
                    Make = Car.Make,
                    Model = Car.Model,
                    Type = CarType.Name,
                    Description = CarType.Description,
                    Name = Customer.Name,
                    From = CustomerCarTimeUsage.FromWhen,
                    To = CustomerCarTimeUsage.ToWhen
                }).ToList();
        }

        [HttpGet("{id}", Name = "GetCustomerCarTimeUsage")]
        public ActionResult<Models.POCO.CustomerCarTimeUsage> Get(int id)
        {
            var item = _context.CustomerCarTimeUsages.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }

        [HttpPost]
        public IActionResult Post(Models.POCO.CustomerCarTimeUsage item)
        {
            //check to make sure the same car isn't used at the same time
            var Conflict = _context.CustomerCarTimeUsages.Where(
                a => a.CarId == item.CarId 
                && ((item.FromWhen >= a.FromWhen && item.FromWhen <= a.ToWhen)
                || (item.ToWhen >= a.FromWhen && item.ToWhen <= a.ToWhen))
                ).FirstOrDefault();
            if (Conflict == null)
            {
                _context.CustomerCarTimeUsages.Add(item);
                _context.SaveChanges();
                
                //return CreatedAtRoute("GetCustomerCarTimeUsage", new { id = item.Id }, item);
                return CreatedAtRoute("GetDTO", item);
            }
            else
            {
                return BadRequest("The Car is not available at the specified date and time");
            }
            
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
