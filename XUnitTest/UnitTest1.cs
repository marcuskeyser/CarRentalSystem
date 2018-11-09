using Microsoft.EntityFrameworkCore;
using System;
using Xunit;
using CarRentalSystem.Controllers;
using CarRentalSystem.Models;
using CarRentalSystem.Models.POCO;


namespace XUnitTest
{
    public class CarRentalSystemUnitTest
    {
        #region constructor
        public CarRentalSystemUnitTest()
        {
            InitContext();
            AddTestData(_Context);
        }
        #endregion constructor

        #region private members
        private CarRentalSystemDBContext _Context;
        private void InitContext()
        {
            var builder = new DbContextOptionsBuilder<CarRentalSystemDBContext>()
                .UseInMemoryDatabase("CarRentalSystemDBContext");

            var context = new CarRentalSystemDBContext(builder.Options);
            _Context = context;
        }
        private static void AddTestData(CarRentalSystemDBContext context)
        {
            //CustomerCarTimeUsages
            context.CustomerCarTimeUsages.Add(new CustomerCarTimeUsage { Id = 1, CarId = 1, CustomerId = 1, FromWhen = new DateTime(2020, 1, 1, 12, 0, 0), ToWhen = new DateTime(2020, 1, 2, 12, 0, 0) });

            //CarTypes
            context.CarTypes.Add(new CarType { Id = 1, Name = "Economy", Description = "Suzuki Swift, Hyundai Accent, Chevrolet Metro * 2 adults, 2 children 1 large, 1 small suitcase 33-36mpg" });
            context.CarTypes.Add(new CarType { Id = 2, Name = "Compact", Description = "Ford Escort, Chevrolet Cavalier *2 Adults, 2 Children 1 Large, 2 Small Suitcases 30mpg" });
            context.CarTypes.Add(new CarType { Id = 3, Name = "Midsize", Description = "Daewoo Leganza, Mazda 626 * 4 Adults, 1 child 1 Large, 2 Small Suitcases 26mpg" });
            context.CarTypes.Add(new CarType { Id = 4, Name = "Standard Size", Description = "Nissan Altima, Pontiac Grand Am * 5 Adults 2 Large, 2 Small Suitcase 25mpg" });
            context.CarTypes.Add(new CarType { Id = 5, Name = "Full Size", Description = "Ford Taurus, Buick Century * 5 Adults 2 Large, 3 Small Suitcases 23mpg" });
            context.CarTypes.Add(new CarType { Id = 6, Name = "Convertible", Description = "Ford Mustang, Chevrolet Camaro * 2 Adults, 2 Children 2 Small Suitcases 21mpg" });
            context.CarTypes.Add(new CarType { Id = 7, Name = "Premium", Description = "Grand Marquis, Buick LeSabre * 5 adults, 1 child 3 Large, 2 Small Suitcases 21mpg" });
            context.CarTypes.Add(new CarType { Id = 8, Name = "Luxury", Description = "Lincoln Town Car, Buick Park Avenue * 6 Adults 4 Large, 2 Small Suitcases 21mpg" });
            context.CarTypes.Add(new CarType { Id = 9, Name = "SUV", Description = "Ford Sport Trac, Chevrolet Blazer * 4 Adults, 1 child 4 Large, 3 Small Suitcases 19mpg" });
            context.CarTypes.Add(new CarType { Id = 10, Name = "SUV-Premium", Description = "Ford Explorer * 5 adults 5 large suitcases 19mpg" });
            context.CarTypes.Add(new CarType { Id = 11, Name = "Minivan", Description = "Chrysler Caravan * 8 adults 2 Large, 2 Small Suitcases 15mpg" });
            context.CarTypes.Add(new CarType { Id = 12, Name = "Full Size Van", Description = "Ford Full Size Van 15 Passengers * 15 adults 2 large suitcases 13mpg" });

            //Cars
            context.Cars.Add(new Car { Id = 1, Make = "Suzuki", Model = "Swift", CarTypeId = 1 });
            context.Cars.Add(new Car { Id = 2, Make = "Hyundai", Model = "Accent", CarTypeId = 1 });
            context.Cars.Add(new Car { Id = 3, Make = "Chevrolet", Model = "Metro", CarTypeId = 1 });
            context.Cars.Add(new Car { Id = 4, Make = "Ford", Model = "Escort", CarTypeId = 2 });
            context.Cars.Add(new Car { Id = 5, Make = "Chevrolet", Model = "Cavalier", CarTypeId = 2 });
            context.Cars.Add(new Car { Id = 6, Make = "Daewoo", Model = "Leganza", CarTypeId = 3 });
            context.Cars.Add(new Car { Id = 7, Make = "Mazda", Model = "626", CarTypeId = 3 });
            context.Cars.Add(new Car { Id = 8, Make = "Nissan", Model = "Altima", CarTypeId = 4 });
            context.Cars.Add(new Car { Id = 9, Make = "Pontiac", Model = "Grand Am", CarTypeId = 4 });
            context.Cars.Add(new Car { Id = 10, Make = "Ford", Model = "Taurus", CarTypeId = 5 });
            context.Cars.Add(new Car { Id = 11, Make = "Buick", Model = "Century", CarTypeId = 5 });
            context.Cars.Add(new Car { Id = 12, Make = "Ford", Model = "Mustang", CarTypeId = 6 });
            context.Cars.Add(new Car { Id = 13, Make = "Chevrolet", Model = "Camaro", CarTypeId = 6 });
            context.Cars.Add(new Car { Id = 14, Make = "Grand", Model = "Marquis", CarTypeId = 7 });
            context.Cars.Add(new Car { Id = 15, Make = "Buick", Model = "LeSabre", CarTypeId = 7 });
            context.Cars.Add(new Car { Id = 16, Make = "Lincoln", Model = "Town Car", CarTypeId = 8 });
            context.Cars.Add(new Car { Id = 17, Make = "Buick", Model = "Park Avenue", CarTypeId = 8 });
            context.Cars.Add(new Car { Id = 18, Make = "Ford", Model = "Sport Trac", CarTypeId = 9 });
            context.Cars.Add(new Car { Id = 19, Make = "Chevrolet", Model = "Blazer", CarTypeId = 9 });
            context.Cars.Add(new Car { Id = 20, Make = "Ford", Model = "Explorer", CarTypeId = 10 });
            context.Cars.Add(new Car { Id = 21, Make = "Chrysler", Model = "Caravan", CarTypeId = 11 });

            //Customers
            context.Customers.Add(new Customer { Id = 1, Name = "Ben" });
            context.Customers.Add(new Customer { Id = 2, Name = "Sophie" });
            context.Customers.Add(new Customer { Id = 3, Name = "Alexander" });
            context.Customers.Add(new Customer { Id = 4, Name = "Joseph" });
            context.Customers.Add(new Customer { Id = 5, Name = "Harris" });
            context.Customers.Add(new Customer { Id = 6, Name = "Jeffie" });
            context.Customers.Add(new Customer { Id = 7, Name = "Desmond" });
            context.Customers.Add(new Customer { Id = 8, Name = "Rhonda" });
            context.Customers.Add(new Customer { Id = 9, Name = "Pilar" });
            context.Customers.Add(new Customer { Id = 10, Name = "Stanton" });

            context.SaveChanges();
        }
        #endregion private members


        [Fact]
        public void TestGetCarById()
        {
            string expectedMake = "Hyundai";
            var controller = new CarController(_Context);
            Car result = controller.Get(2).Value;
            Assert.Equal(expectedMake, result.Make);
        }

    }
}
