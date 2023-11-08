namespace Patterns.Behavioral.Command.Garage;
    internal class MacroCommand : ICommand
    {
        private readonly ICommand[] _commands;

        public MacroCommand(ICommand[] commands)
        {
            _commands = commands;
        }

        public void Execute()
        {
            foreach (var item in _commands)
                item.Execute();
        }

        public void Undo()
        {
            foreach (var item in _commands)
                item.Undo();
        }
    }
