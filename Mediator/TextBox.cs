namespace DesignPatterns.Mediator
{
    public class TextBox : UiControl
    {
        private string _content;

        public TextBox(DialogBox owner) : base(owner)
        {
        }

        public string Content
        {
            get => this._content;
            set
            {
                this._content = value;
                this.Owner.Changed(this);
            }
        }
    }
}