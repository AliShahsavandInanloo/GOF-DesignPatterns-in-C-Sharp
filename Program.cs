using DesignPatterns.ChainOfResponsibility;

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
        //private static void Main(string[] args)
        //{
        //    var task  = new TransferMoneyTask();
        //    var task2 = new GenerateReportTask();

        //    task2.Execute();
        //    task.Execute();
        //}

        // The Template Method pattern Exercise
        //private static void Main(string[] args)
        //{
        //    var window = new ChatWindow();
        //    window.Close();
        //}

        // The Command pattern
        //private static void Main(string[] args)
        //{
        //    var service = new CustomerService();
        //    var command = new AddCustomerCommand(service);
        //    var button  = new Button(command);

        //    button.Click();

        //    for (var i = 0; i < 20; i++) Console.Write("*");
        //    Console.WriteLine();

        //    var composite = new CompositeCommand();
        //    composite.Add(new ResizeCommand());
        //    composite.Add(new BlackAndWhiteCommand());
        //    composite.Execute();
        //}

        // The Undo Mechanism with Command Pattern
        //private static void Main(string[] args)
        //{
        //    var history = new History();
        //    var document = new HtmlDocument
        //                   {
        //                       Content = "Hello World"
        //                   };
        //    var boldCommand = new BoldCommand(document, history);

        //    boldCommand.Execute();
        //    Console.WriteLine(document.Content);

        //    var undoCommand = new UndoCommand(history);
        //    undoCommand.Execute();

        //    Console.WriteLine(document.Content);
        //}

        // The Command Pattern Exercise
//        private static void Main(string[] args)
//        {
//            var videoEditor = new VideoEditor {Text = "Hello World!"};
//            var history     = new History();
//
//            var changeTextCommand     = new ChangeTextCommand(videoEditor, history, "Hello");
//            var changeContrastCommand = new ChangeContrastCommand(videoEditor, history, 10f);
//
//            changeTextCommand.Execute();
//            Console.WriteLine(videoEditor);
//
//            changeContrastCommand.Execute();
//            changeContrastCommand.Execute();
//
//            var undoCommand = new UndoCommand(history);
//
//            undoCommand.Execute();
//            Console.WriteLine(videoEditor);
//
//            undoCommand.Execute();
//            Console.WriteLine(videoEditor);
//
//            undoCommand.Execute();
//            Console.WriteLine(videoEditor);
//        }

        // The Observer Pattern
        //private static void Main(string[] args)
        //{
        //    var dataSource = new DataSource();
        //    var sheet1     = new SpreadSheet(dataSource);
        //    var sheet2     = new SpreadSheet(dataSource);
        //    var chart      = new Chart(dataSource);

        //    dataSource.AddObserver(sheet1);
        //    dataSource.AddObserver(sheet2);
        //    dataSource.AddObserver(chart);

        //    dataSource.Value = 1;
        //}

        // The Observer Pattern Exercise
//        private static void Main(string[] args)
//        {
//            var statusBar     = new StatusBar();
//            var stockListView = new StockListView();
//
//            var stock1 = new Stock("stock1", 10);
//            var stock2 = new Stock("stock2", 20);
//            var stock3 = new Stock("stock3", 30);
//
//            statusBar.AddStock(stock1);
//            statusBar.AddStock(stock2);
//
//            stockListView.AddStock(stock1);
//            stockListView.AddStock(stock2);
//            stockListView.AddStock(stock3);
//
//            stock2.Price = 21;
//            stock3.Price = 9;
//        }
//      The Mediator Pattern
//        private static void Main(string[] args)
//        {
//            var dialog = new ArticleDialogBox();
//            dialog.SimulateUserInteraction();
//        }
//      The Chain of Responsibility Pattern
        private static void Main(string[] args)
        {
            // authenticator -> logger -> compressor
            var compressor    = new Compressor(null);
            var logger        = new Logger(compressor);
            var authenticator = new Authenticator(logger);
            var webServer     = new WebServer(authenticator);

            webServer.Handle(new HttpRequest("admin", "1234"));
        }
    }
}