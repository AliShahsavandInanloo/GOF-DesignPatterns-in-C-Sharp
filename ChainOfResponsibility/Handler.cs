namespace DesignPatterns.ChainOfResponsibility
{
    public abstract class Handler
    {
        private readonly Handler _next;

        public Handler(Handler next)
        {
            this._next = next;
        }

        public void Handle(HttpRequest request)
        {
            if (DoHandle(request)) return;

            this._next?.Handle(request);
        }

        public abstract bool DoHandle(HttpRequest request);
    }
}