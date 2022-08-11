using System;

namespace DesignPatterns.Observer
{
    public class SpreadSheet : IObserver
    {
        private readonly DataSource _dataSource;

        public SpreadSheet(DataSource dataSource)
        {
            this._dataSource = dataSource;
        }

        //public void Update(int value) // the push style
        //{
        //    Console.WriteLine("SpreadSheet Got Notified: " + value);
        //}
        public void Update()
        {
            Console.WriteLine("SpreadSheet Got Notified: " +
                              this._dataSource.Value); // the pull style
        }
    }
}