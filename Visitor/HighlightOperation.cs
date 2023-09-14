using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Visitor
{
    public class HighlightOperation : Visitor
    {
        public void Visit(AnchorNode anchorNode)
        {
            Console.WriteLine("Highligth-Anchor");
        }

        public void Visit(HeadingNode headingNode)
        {
            Console.WriteLine("Highlight-Heading");
        }
    }
}
