namespace Apartments.Models
{
    public class Apartment
    {
        public int Id { get; set; }

        public int Meters { get; set; }

        public string Status { get; set; }

        public int Floor { get; set; }

        public string Construction { get; set; }

        public string Electricity { get; set; }

        public string Features { get; set; }

        public decimal Price { get; set; }

        public string City { get; set; }
    }
}
