using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalSystem.Models.POCO
{
    public class CarType
    {
        public CarType(string Name, string Description)
        {
            this.Name = Name;
            this.Description = Description;
            this.Id = new Guid();
        }

        public readonly Guid Id;
        public string Name;
        public string Description;
    }
}