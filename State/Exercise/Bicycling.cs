using System;

namespace DesignPatterns.State.Exercise
{
<<<<<<< HEAD
    public class Bicycling : ITravelMode // ConcreteState 
=======
    public class Bicycling : ITravelMode
>>>>>>> f332b3aa3a1bfab77b451b4fa85c852b05622048
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