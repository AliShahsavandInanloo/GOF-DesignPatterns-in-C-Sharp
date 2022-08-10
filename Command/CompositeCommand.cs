using System.Collections.Generic;
using DesignPatterns.Command.fx;

namespace DesignPatterns.Command
{
    public class CompositeCommand : ICommand
    {
        private readonly List<ICommand> _commands = new List<ICommand>();

        public void Execute()
        {
            foreach (var command in this._commands) command.Execute();
        }

        public void Add(ICommand command)
        {
            this._commands.Add(command);
        }
    }
}