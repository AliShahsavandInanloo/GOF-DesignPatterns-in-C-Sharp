using System;
using System.Collections.Generic;

namespace DesignPatterns.Observer.Exercise
{
    public class StockListView : IObserver
    {
        private readonly List<Stock> _stocks = new List<Stock>();

        public void PriceChanged()
        {
            Console.WriteLine("Price Changed - Refreshing StockListView");
            Show();
        }

        public void AddStock(Stock stock)
        {
            this._stocks.Add(stock);
            stock.AddObserver(this);
        }

        public void Show()
        {
            Console.WriteLine("Stock List View");
            foreach (var stock in this._stocks) Console.WriteLine(stock);
        }
    }
}