namespace DesignPatterns.Mediator
{
    public class Button : UiControl
    {
        private bool _isEnabled;

        public Button(DialogBox owner) : base(owner)
        {
        }

        public bool Enabled
        {
            get => this._isEnabled;
            set
            {
                this._isEnabled = value;
                this.Owner.Changed(this);
            }
        }
    }
}