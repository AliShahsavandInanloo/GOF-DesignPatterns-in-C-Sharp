namespace DesignPatterns.ChainOfResponsibility
{
    public class WebServer
    {
        private readonly Handler _handler;

        public WebServer(Handler handler)
        {
            this._handler = handler;
        }

        public void Handle(HttpRequest request)
        {
            this._handler.Handle(request);
        }
    }
}