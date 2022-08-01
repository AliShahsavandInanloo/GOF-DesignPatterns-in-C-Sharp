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

            var document = new MicrosoftWord();

            document.Content  = "just some random content";
            document.FontName = "monolith";
            document.FontSize = 23;

            var documentHistory = new DocumentHistory();


            document.Content  = "i changed the document contents.";
            document.FontName = "testFont";
            document.FontSize = 54;
            document.FontSize = 34;
            document.FontSize = 334;

            documentHistory.Push(document.CreateDocumentState());

            document.RestoreDocumentState(documentHistory.Pop());

            Console.WriteLine(document.FontSize);

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