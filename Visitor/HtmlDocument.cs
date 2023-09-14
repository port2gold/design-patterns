using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Visitor
{
    public class HtmlDocument
    {
        private List<HtmlNode> nodes = new List<HtmlNode>();

        public void Add(HtmlNode node)
        {
            nodes.Add(node);
        }

        public void Execute(Visitor visitor)
        {
            foreach (HtmlNode node in nodes)
            {
                node.Visit(visitor);
            }
        }
    }
}
