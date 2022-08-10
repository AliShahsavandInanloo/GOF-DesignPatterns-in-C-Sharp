using System;

namespace DesignPatterns.TemplateMethod.Exercise
{
    public class ChatWindow : Window
    {
        protected override void OnClosing()
        {
            Console.WriteLine("Closing Chat Window");
        }

        protected override void OnClosed()
        {
            Console.WriteLine("Closed Chat Window");
        }
    }
}