using System;

namespace DesignPatterns.State.Exercise
{
<<<<<<< HEAD
    public class Walking : ITravelMode // ConcreteState 
=======
    public class Walking : ITravelMode
>>>>>>> f332b3aa3a1bfab77b451b4fa85c852b05622048
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