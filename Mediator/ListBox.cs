namespace DesignPatterns.Mediator
{
    public class ListBox : UiControl
    {
        public ListBox(DialogBox owner) : base(owner)
        {
        }

        private string _selection;

        public string Selection
        {
            get => this._selection;
            set
            {
                this._selection = value;
                this.Owner.Changed(this);
            }
        }
    }
}