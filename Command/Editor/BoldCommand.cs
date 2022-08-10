namespace DesignPatterns.Command.Editor
{
    public class BoldCommand : IUndoableCommand
    {
        private readonly HtmlDocument _document;
        private readonly History      _history;

        private string _prevContent;

        public BoldCommand(HtmlDocument document, History history)
        {
            this._document = document;
            this._history  = history;
        }

        public void Execute()
        {
            this._prevContent = this._document.Content;
            this._document.MakeBold();
            this._history.Push(this);
        }

        public void UnExecute()
        {
            this._document.Content = this._prevContent;
        }
    }
}