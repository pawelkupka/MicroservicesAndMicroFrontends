namespace Delivery.Domain.Model
{
    public class DeliveryStatus
    {
        public static DeliveryStatus Pending = new DeliveryStatus(1, "Pending");
        public static DeliveryStatus Scheduled = new DeliveryStatus(2, "Scheduled");
        public static DeliveryStatus Cancelled = new DeliveryStatus(3, "Cancelled");

        public DeliveryStatus(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; }
        public string Name { get; }
    }
}
