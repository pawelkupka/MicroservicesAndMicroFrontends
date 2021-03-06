using System;

namespace Delivery.Domain.Model.Restuarants
{
    using Common.Domain.Model;

    public class Restaurant : AggregateRoot
    {
        public Restaurant(string name, RestaurantAddress address)
        {
            RestaurantId = Guid.NewGuid();
            Name = name;
            Address = address;
            AddDomainEvent(new RestaurantCreated(RestaurantId, Name, Address));
        }

        public Guid RestaurantId { get; }
        public string Name { get; }
        public RestaurantAddress Address { get; }
    }
}
