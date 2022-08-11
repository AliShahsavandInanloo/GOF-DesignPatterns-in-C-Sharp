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

        //public void NotifyObservers(int value) // the push style
        //{
        //    foreach (var observer in this._observers) observer.Update(value);
        //}

        public void NotifyObservers() // the pull style
        {
            foreach (var observer in this._observers) observer.Update();
        }
    }
}