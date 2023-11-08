namespace Patterns.Behavioral.Command.Garage;
    internal class NoCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("No Command Assigned");
        }

        public void Undo()
        {
            Execute();
        }
    }
