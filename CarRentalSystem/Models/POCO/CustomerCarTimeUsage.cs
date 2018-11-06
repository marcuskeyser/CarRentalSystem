using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalSystem.Models.POCO
{
    public class CustomerCarTimeUsage
    {
        public CustomerCarTimeUsage(int CarId, int CustomerId, DateTime FromWhen, DateTime FromTo)
        {
            this.CarId= CarId;
            this.CustomerId= CustomerId;
            this.FromWhen= FromWhen;
            this.FromTo= FromTo;
            this.Id = new Guid();
        }

        public readonly Guid Id;
        public int CarId;
        public int CustomerId;
        public DateTime FromWhen;
        public DateTime FromTo;

    }
}