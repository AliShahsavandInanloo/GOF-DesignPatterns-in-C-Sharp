using System;

namespace DesignPatterns.State
{
    public class Brush : ITool
    {
        public void MouseDown()
        {
            Console.WriteLine("Selection icon");
        }

        public void MouseUp()
        {
            Console.WriteLine("Draw a line");
        }
    }
}