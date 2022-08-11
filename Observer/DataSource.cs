namespace DesignPatterns.Observer
{
    internal class DataSource : Subject
    {
        private int _value;

        public int Value
        {
            get => this._value;
            set
            {
                this._value = value;
                NotifyObservers();
            }
        }
    }
}