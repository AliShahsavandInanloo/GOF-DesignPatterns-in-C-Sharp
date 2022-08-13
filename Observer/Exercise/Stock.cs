using System.Collections.Generic;

namespace DesignPatterns.Observer.Exercise
{
    public class Stock
    {
        private readonly List<IObserver> _observers = new List<IObserver>();
        private readonly string          _symbol;

        private float _price;

        public Stock(string symbol, float price)
        {
            this._symbol = symbol;
            this._price  = price;
        }

        public float Price
        {
            get => this._price;
            set
            {
                this._price = value;
                NotifyObservers();
            }
        }

        public void AddObserver(IObserver observer)
        {
            this._observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            this._observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in this._observers) observer.PriceChanged();
        }

        public override string ToString()
        {
            return "Stock{" + "Symbol='" + this._symbol + '\'' + ", Price=" + this.Price + '}';
        }
    }
}