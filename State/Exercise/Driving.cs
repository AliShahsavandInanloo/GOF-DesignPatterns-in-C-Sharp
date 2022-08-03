using System;

namespace DesignPatterns.State.Exercise
{
<<<<<<< HEAD
    public class Driving : ITravelMode // ConcreteState 
=======
    public class Driving : ITravelMode
>>>>>>> f332b3aa3a1bfab77b451b4fa85c852b05622048
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