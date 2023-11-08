namespace Patterns.Behavioral.Command.Garage;
    internal interface ICommand
    {
        void Execute();
        void Undo();
    }
