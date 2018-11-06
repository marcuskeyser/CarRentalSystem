using Microsoft.EntityFrameworkCore;
using CarRentalSystem.Models.POCO;

namespace CarRentalSystem.Models
{
    public class CarRentalSystemDBContext : DbContext
    {
        public CarRentalSystemDBContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarType> CarTypes { get; set; }
        public DbSet<CustomerCarTimeUsage> CustomerCarTimeUsages { get; set; }
    }
}