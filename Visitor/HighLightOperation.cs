using System;

namespace DesignPatterns.Visitor
{
    public class HighLightOperation : IOperation
    {
        public void Apply(HeadingNode heading)
        {
            Console.WriteLine("highlight-heading");
        }

        public void Apply(AnchorNode anchor)
        {
            Console.WriteLine("highlight-anchor");
        }
    }
}