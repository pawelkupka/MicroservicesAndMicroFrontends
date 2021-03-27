using System;

namespace Delivery.Application.Commands
{
    using Common.Application.Commands;

    public class CreateDeliveryCommand : ICommand
    {
        public CreateDeliveryCommand(
            Guid orderId, 
            Guid resturantId, 
            string street, 
            string city, 
            string state, 
            string zip)
        {
            OrderId = orderId;
            ResturantId = resturantId;
            Street = street;
            City = city;
            State = state;
            Zip = zip;
        }

        public Guid OrderId { get; }
        public Guid ResturantId { get; }
        public string Street { get; }
        public string City { get; }
        public string State { get; }
        public string Zip { get; }
    }
}
