using System;

namespace DesignPatterns.TemplateMethod.Exercise
{
    public class Window
    {
        public void Close()
        {
            OnClosing();
            Console.WriteLine("Removing the window from the screen.");
            OnClosed();
        }

        protected virtual void OnClosing()
        {
            Console.WriteLine("Closing Window");
        }

        protected virtual void OnClosed()
        {
            Console.WriteLine("Closed Window");
        }
    }
}