using System;

namespace DesignPatterns.State.Exercise
{
    public class Transit : ITravelMode // ConcreteState 

    {
        public object GetEta()
        {
            Console.WriteLine("Calculating ETA (transit).");
            return 3;
        }

        public object GetDirection()
        {
            Console.WriteLine("Calculating Direction (transit).");
            return 3;
        }
    }
}