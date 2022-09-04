namespace DesignPatterns.ChainOfResponsibility
{
    public class HttpRequest
    {
        public HttpRequest(string userName, string passWord)
        {
            this.UserName = userName;
            this.PassWord = passWord;
        }

        public string UserName { get; }

        public string PassWord { get; }
    }
}