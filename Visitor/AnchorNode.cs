using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Visitor
{
    public class AnchorNode : HtmlNode
    {
        public void Visit(Visitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
