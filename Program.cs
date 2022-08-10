using DesignPatterns.TemplateMethod;

namespace DesignPatterns
{
    internal class Program
    {
        // The Memento pattern
        //private static void Main(string[] args)
        //{
        //    var editor  = new Editor();
        //    var history = new History();

        //    var document = new MicrosoftWord();

        //    document.Content  = "just some random content";
        //    document.FontName = "monolith";
        //    document.FontSize = 23;

        //    var documentHistory = new DocumentHistory();


        //    document.Content  = "i changed the document contents.";
        //    document.FontName = "testFont";
        //    document.FontSize = 54;
        //    document.FontSize = 34;
        //    document.FontSize = 334;

        //    documentHistory.Push(document.CreateDocumentState());

        //    document.RestoreDocumentState(documentHistory.Pop());

        //    Console.WriteLine(document.FontSize);

        //    editor.Content = "a";
        //    history.Push(editor.CreateState());

        //    editor.Content = "b";
        //    history.Push(editor.CreateState());

        //    editor.Content = "c";
        //    history.Push(editor.CreateState());

        //    editor.Restore(history.Pop());
        //    editor.Restore(history.Pop());

        //    Console.WriteLine(editor.Content);
        //}

        // The State pattern
        //private static void Main(string[] args)
        //{
        //    var canvas = new Canvas
        //                 {
        //                     CurrentTool = new Selection()
        //                 };

        //    canvas.MouseDown();
        //    canvas.MouseUp();
        //}

        // The State pattern Exercise
        //private static void Main(string[] args)
        //{
        //    var directionService = new DirectionService
        //                           {
        //                               TravelMode = new Walking()
        //                           };

        //    directionService.GetDirection();
        //    directionService.GetEta();
        //}

        // The Iterator Pattern
        //private static void Main(string[] args)
        //{
        //    var history = new BrowsHistory();
        //    history.Push("a");
        //    history.Push("b");
        //    history.Push("c");

        //    var iterator = history.CreateIterator();

        //    while (iterator.HastNext())
        //    {
        //        var url = iterator.Current();
        //        Console.WriteLine(url);
        //        iterator.Next();
        //    }

        //    Console.WriteLine("-----------------------");
        //    Console.WriteLine(history.Pop());
        //    Console.WriteLine(history.Pop());
        //}

        // The Iterator Pattern Exercise
        //private static void Main(string[] args)
        //{
        //    var productCollection = new ProductCollection();
        //    var productIterator   = productCollection.CreateIterator();

        //    productCollection.Push(new Product(1, "Book1"));
        //    productCollection.Push(new Product(2, "Book2"));
        //    productCollection.Push(new Product(3, "Book3"));


        //    while (productIterator.HasNext())
        //    {
        //        Console.WriteLine(productIterator.Current().ToString());

        //        productIterator.Next();
        //    }
        //}

        //// The Strategy Pattern
        //private static void Main(string[] args)
        //{
        //    var imageStorage = new ImageStorage();
        //    imageStorage.Store("a", new JpegCompressor(), new BlackAndWhiteFilter());
        //    imageStorage.Store("a", new PngCompressor(), new BlackAndWhiteFilter());
        //}

        // The Strategy Pattern Exercise
        //private static void Main(string[] args)
        //{
        //    var chatClient = new ChatClient();
        //    chatClient.Send("This is a test message.", new Des());
        //}

        // The Template Method pattern
        private static void Main(string[] args)
        {
            var task  = new TransferMoneyTask();
            var task2 = new GenerateReportTask();

            task2.Execute();
            task.Execute();
        }
    }
}