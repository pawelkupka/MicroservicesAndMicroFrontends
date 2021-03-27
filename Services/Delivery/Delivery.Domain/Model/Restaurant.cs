using System;

namespace Delivery.Domain.Model
{
    public class Restaurant
    {
        public Restaurant(string name, Address address)
        {
            RestaurantId = Guid.NewGuid();
            Name = name;
            Address = address;
        }

        public Guid RestaurantId { get; }
        public string Name { get; }
        public Address Address { get; }
    }
}
