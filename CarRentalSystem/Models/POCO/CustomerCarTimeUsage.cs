using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalSystem.Models.POCO
{
    public class CustomerCarTimeUsage
    {
        [Key]
        public int Id { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public DateTime FromWhen { get; set; }
        public DateTime ToWhen { get; set; }
    }
}