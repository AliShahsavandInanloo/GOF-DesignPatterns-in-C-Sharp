using System.Collections.Generic;

namespace DesignPatterns.Command.Editor
{
    public class History
    {
        private readonly Queue<IUndoableCommand> _commands = new Queue<IUndoableCommand>();

        public void Push(IUndoableCommand command)
        {
            this._commands.Enqueue(command);
        }

        public IUndoableCommand Pop()
        {
            return this._commands.Dequeue();
        }

        public int Size()
        {
            return this._commands.Count;
        }
    }
}