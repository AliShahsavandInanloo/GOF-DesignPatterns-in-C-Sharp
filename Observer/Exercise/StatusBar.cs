using System;
using System.Collections.Generic;

namespace DesignPatterns.Observer.Exercise
{
    public class StatusBar : IObserver
    {
        private readonly List<Stock> _stocks = new List<Stock>();

        public void PriceChanged()
        {
            Console.WriteLine("Price Changed - Refreshing StatusBar");
            Show();
        }

        public void AddStock(Stock stock)
        {
            this._stocks.Add(stock);
            stock.AddObserver(this);
        }

        public void Show()
        {
            Console.WriteLine("Status Bar");
            foreach (var stock in this._stocks) Console.WriteLine(stock);
        }
    }
}