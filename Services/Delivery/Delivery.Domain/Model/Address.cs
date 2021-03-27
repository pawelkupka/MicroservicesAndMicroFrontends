namespace Delivery.Domain.Model
{
    public class Address
    {
        public Address(string street, string city, string state, string zip)
        {
            Street = street;
            City = city;
            State = state;
            Zip = zip;
        }

        public string Street { get; }
        public string City { get; }
        public string State { get; }
        public string Zip { get; }
    }
}
