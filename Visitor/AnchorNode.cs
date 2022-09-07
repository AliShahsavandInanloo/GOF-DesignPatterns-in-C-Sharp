using System;

namespace DesignPatterns.Visitor
{
    public class AnchorNode : IHtmlNode
    {
        public void HighLight()
        {
            Console.WriteLine("highlight-anchor");
        }
    }
}