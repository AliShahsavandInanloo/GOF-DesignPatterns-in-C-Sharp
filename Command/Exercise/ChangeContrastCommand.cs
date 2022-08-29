namespace DesignPatterns.Command.Exercise
{
    public class ChangeContrastCommand : IUndoableCommand
    {
        private readonly VideoEditor _videoEditor;
        private readonly History     _history;
        private readonly float       _newValue;

        private float _preValue;

        public ChangeContrastCommand(VideoEditor videoEditor, History history, float newValue)
        {
            this._videoEditor = videoEditor;
            this._history     = history;
            this._newValue    = newValue;
        }

        public void Execute()
        {
            this._preValue             = this._videoEditor.Contrast;
            this._videoEditor.Contrast = this._newValue;
            this._history.Push(this);
        }

        public void UnExecute()
        {
            this._videoEditor.Contrast = this._preValue;
        }
    }
}