using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalSystem.Models.POCO
{
    public class Customer
    {
        public Customer(string Name)
        {
            this.Name = Name;
            this.Id = new Guid();
        }

        public readonly Guid Id;
        public string Name;
	}
}