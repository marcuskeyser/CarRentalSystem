namespace CarRentalSystem.Models.POCO
{
    public class Car
    {
        private int Id;
        private string Make;
        private string Model;
        private int CarTypeId;

        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int CarTypeId { get; set; }
    }
}