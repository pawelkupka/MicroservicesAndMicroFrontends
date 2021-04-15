namespace Restaurant.Domain.Model.Restaurants
{
    public record RestaurantAddress
    {
        public RestaurantAddress(
            string line1, 
            string line2, 
            string city, 
            string postalCode)
        {
            Line1 = line1;
            Line2 = line2;
            City = city;
            PostalCode = postalCode;
        }

        public string Line1 { get; init; }
        public string Line2 { get; init; }
        public string City { get; init; }
        public string PostalCode { get; init; }
    }
}
