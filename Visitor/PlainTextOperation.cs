using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Visitor
{
    public class PlainTextOperation : Visitor
    {
        public void Visit(HeadingNode headingNode)
        {
            Console.WriteLine("Plaintext-Heading");
        }

        public void Visit(AnchorNode anchorNode)
        {
            Console.WriteLine("Plaintext-Anchor");
        }
    }
}
