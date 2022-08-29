namespace DesignPatterns.Command.Exercise
{
    public class UndoCommand : ICommand
    {
        private readonly History _history;

        public UndoCommand(History history)
        {
            this._history = history;
        }

        public void Execute()
        {
            if (this._history.Size() > 0) this._history.Pop().UnExecute();
        }
    }
}