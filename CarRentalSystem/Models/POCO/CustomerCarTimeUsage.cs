using System;
namespace CarRentalSystem.Models.POCO
{
    public class CustomerCarTimeUsage
    {
        private int Id;
        private int CarId;
        private int CustomerId;
        private DateTime FromWhen;
        private DateTime FromTo;

        public int Id { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public DateTime FromWhen { get; set; }
        public DateTime FromTo { get; set; }
    }
}