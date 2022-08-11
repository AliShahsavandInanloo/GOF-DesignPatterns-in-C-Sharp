namespace DesignPatterns.Observer
{
    public class DataSource : Subject
    {
        private int _value;

        public int Value
        {
            get => this._value;
            set
            {
                this._value = value;
                //NotifyObservers(this._value);// the push style
                NotifyObservers(); // the pull style
            }
        }
    }
}