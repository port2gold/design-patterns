using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.State
{
    public class BrushTool : Tool
    {
        public void MouseDown()
        {
            Console.WriteLine("Mouse down on brush tool");

        }

        public void MouseUp()
        {
            Console.WriteLine("Mouse up on brush tool");

        }
    }
}
