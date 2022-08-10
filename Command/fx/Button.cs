namespace DesignPatterns.Command.fx
{
    internal class Button
    {
        private readonly ICommand _command;

        public Button(ICommand command)
        {
            this._command = command;
        }

        public string Label { get; set; }

        public void Click()
        {
            this._command.Execute();
        }
    }
}