using System;

namespace DesignPatterns.State.Exercise
{
    public class Bicycling : ITravelMode
    {
        public object GetEta()
        {
            Console.WriteLine("Calculating ETA (bicycling).");
            return 2;
        }

        public object GetDirection()
        {
            Console.WriteLine("Calculating Direction (bicycling).");
            return 2;
        }
    }
}