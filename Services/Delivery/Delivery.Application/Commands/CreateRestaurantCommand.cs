namespace Delivery.Application.Commands
{
    using Common.Application.Commands;

    public class CreateRestaurantCommand : ICommand
    {
        public CreateRestaurantCommand(
            string name, 
            string street, 
            string city, 
            string state, 
            string zip)
        {
            Name = name;
            Street = street;
            City = city;
            State = state;
            Zip = zip;
        }

        public string Name { get; }
        public string Street { get; }
        public string City { get; }
        public string State { get; }
        public string Zip { get; }
    }
}
