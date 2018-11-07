using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalSystem.Models.DTO
{
    public class CustomerCarTimeUsage
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
    }
}