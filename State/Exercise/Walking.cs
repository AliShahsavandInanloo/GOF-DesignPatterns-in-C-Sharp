using System;

namespace DesignPatterns.State.Exercise
{
    public class Walking : ITravelMode

    {
        public object GetEta()
        {
            Console.WriteLine("Calculating ETA (walking).");
            return 4;
        }

        public object GetDirection()
        {
            Console.WriteLine("Calculating Direction (walking).");
            return 4;
        }
    }
}