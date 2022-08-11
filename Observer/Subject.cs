using System.Collections.Generic;

namespace DesignPatterns.Observer
{
    public class Subject // Observable
    {
        private readonly List<IObserver> _observers = new List<IObserver>();

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
            foreach (var observer in this._observers) observer.Update();
        }
    }
}