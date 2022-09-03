namespace DesignPatterns.Mediator
{
    public class UiControl
    {
        protected DialogBox Owner;

        protected UiControl(DialogBox owner)
        {
            this.Owner = owner;
        }
    }
}