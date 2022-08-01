using System;
using DesignPatterns.Memento;

namespace DesignPatterns
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var editor  = new Editor();
            var history = new History();

            editor.Content = "a";
            history.Push(editor.CreateState());

            editor.Content = "b";
            history.Push(editor.CreateState());

            editor.Content = "c";
            history.Push(editor.CreateState());

            editor.Restore(history.Pop());
            editor.Restore(history.Pop());

            Console.WriteLine(editor.Content);
        }
    }
}