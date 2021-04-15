using System;

namespace Delivery.Domain.Model.Restuarants
{
    public class Restaurant
    {
        public Restaurant(string name, RestaurantAddress address)
        {
            RestaurantId = Guid.NewGuid();
            Name = name;
            Address = address;
        }

        public Guid RestaurantId { get; }
        public string Name { get; }
        public RestaurantAddress Address { get; }
    }
}
