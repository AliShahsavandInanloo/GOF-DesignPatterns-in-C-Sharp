using System.Collections.Generic;

namespace DesignPatterns.Visitor
{
    public class HtmlDocument
    {
        private readonly List<IHtmlNode> _nodes = new List<IHtmlNode>();

        public void Add(IHtmlNode node)
        {
            this._nodes.Add(node);
        }

        public void Execute(IOperation operation)
        {
            foreach (var node in this._nodes) node.Execute(operation);
        }
    }
}