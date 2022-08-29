namespace DesignPatterns.Command.Exercise
{
    public class ChangeTextCommand : IUndoableCommand
    {
        private readonly VideoEditor _videoEditor;
        private readonly History     _history;
        private readonly string      _newText;

        private string _preText;

        public ChangeTextCommand(VideoEditor videoEditor, History history, string newText)
        {
            this._videoEditor = videoEditor;
            this._history     = history;
            this._newText     = newText;
        }

        public void Execute()
        {
            this._preText          = this._videoEditor.Text;
            this._videoEditor.Text = this._newText;
            this._history.Push(this);
        }

        public void UnExecute()
        {
            this._videoEditor.Text = this._preText;
        }
    }
}