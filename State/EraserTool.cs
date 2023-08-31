using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.State
{
    public class EraserTool : Tool
    {
        public void MouseDown()
        {
            Console.WriteLine("Mouse down on Eraser tool");
        }

        public void MouseUp()
        {
            Console.WriteLine("Mouse down on Eraser tool");
        }
    }
}
