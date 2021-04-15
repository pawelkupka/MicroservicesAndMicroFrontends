namespace Delivery.Domain.Model.Couriers
{
    public class ActionType
    {
        public static ActionType Pickup = new ActionType(1, "Pickup");
        public static ActionType Dropoff = new ActionType(2, "Dropoff");

        public ActionType(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; }
        public string Name { get; }
    }
}
