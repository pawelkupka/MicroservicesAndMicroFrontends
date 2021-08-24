using System;

namespace Delivery.Domain.Model.Restuarants
{
    using Common.Domain.Model;

    public record RestaurantCreated : IDomainEvent
    {
        public RestaurantCreated(Guid restaurantId, string name, RestaurantAddress address)
        {
            RestaurantId = restaurantId;
            Name = name;
            Address = address;
        }

        public Guid RestaurantId { get; }
        public string Name { get; }
        public RestaurantAddress Address { get; }
    }
}
