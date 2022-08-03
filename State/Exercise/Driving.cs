using System;

namespace DesignPatterns.State.Exercise
{
    public class Driving : ITravelMode // ConcreteState 
    {
        public object GetEta()
        {
            Console.WriteLine("Calculating ETA (driving).");
            return 1;
        }

        public object GetDirection()
        {
            Console.WriteLine("Calculating Direction (driving).");
            return 1;
        }
    }
}