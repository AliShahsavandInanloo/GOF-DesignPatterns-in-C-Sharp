using System;

namespace DesignPatterns.Observer
{
    public class Chart : IObserver
    {
        private readonly DataSource _dataSource;

        public Chart(DataSource dataSource)
        {
            this._dataSource = dataSource;
        }

        //public void Update(int value) // the push style
        //{
        //    Console.WriteLine("Chart got Updated: " + value);
        //}
        public void Update()
        {
            Console.WriteLine("Chart got Updated: " + this._dataSource.Value); // the pull style
        }
    }
}