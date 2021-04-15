using System;

namespace Order.Domain.Model.Orders
{
    public record DeliveryInformation
    {
        public DeliveryInformation(
            DateTime deliveryTime, 
            string line1, 
            string line2, 
            string city, 
            string postalCode)
        {
            DeliveryTime = deliveryTime;
            Line1 = line1;
            Line2 = line2;
            City = city;
            PostalCode = postalCode;
        }

        public DateTime DeliveryTime { get; init; }
        public string Line1 { get; init; }
        public string Line2 { get; init; }
        public string City { get; init; }
        public string PostalCode { get; init; }
    }
}
