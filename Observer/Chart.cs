using System;

namespace DesignPatterns.Observer
{
    public class Chart : IObserver
    {
        public void Update()
        {
            Console.WriteLine("Chart got Updated");
        }
    }
}