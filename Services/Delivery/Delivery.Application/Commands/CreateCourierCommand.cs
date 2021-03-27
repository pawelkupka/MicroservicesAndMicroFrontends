namespace Delivery.Application.Commands
{
    using Common.Application.Commands;

    public class CreateCourierCommand : ICommand
    {
        public CreateCourierCommand(string name, bool available)
        {
            Name = name;
            Available = available;
        }

        public string Name { get; }
        public bool Available { get; }
    }
}
