using System;

namespace DesignPatterns.State.Exercise
{
<<<<<<< HEAD
    public class Transit : ITravelMode // ConcreteState 
=======
    public class Transit : ITravelMode
>>>>>>> f332b3aa3a1bfab77b451b4fa85c852b05622048
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