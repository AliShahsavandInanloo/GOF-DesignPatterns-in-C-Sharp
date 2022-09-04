using System;

namespace DesignPatterns.ChainOfResponsibility
{
    public class Authenticator : Handler
    {
        public Authenticator(Handler next) : base(next)
        {
        }

        public override bool DoHandle(HttpRequest request)
        {
            var isValid = request.UserName == "admin" && request.PassWord == "1234";

            Console.WriteLine("Authentication");

            return !isValid;
        }
    }
}