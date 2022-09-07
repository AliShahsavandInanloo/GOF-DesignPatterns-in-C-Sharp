using System;

namespace DesignPatterns.Visitor
{
    public class HeadingNode : IHtmlNode
    {
        public void HighLight()
        {
            Console.WriteLine("highlight-heading");
        }
    }
}