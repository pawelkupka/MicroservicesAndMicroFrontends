namespace Delivery.Domain.Model
{
    public class DeliveryActionType
    {
        public static DeliveryActionType Pickup = new DeliveryActionType(1, "Pickup");
        public static DeliveryActionType Dropoff = new DeliveryActionType(2, "Dropoff");

        public DeliveryActionType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; }
        public string Name { get; }
    }
}
