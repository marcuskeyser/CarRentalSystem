using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalSystem.Models.POCO
{
    public class Car
    {
        public Car(string Make, string Model, int CarTypeId)
        {
            this.Make=Make;
            this.Model=Model;
            this.CarTypeId=CarTypeId;
            this.Id = new Guid();
        }

        public readonly Guid Id;
        public string Make;
        public string Model;
        public int CarTypeId;
    }
}