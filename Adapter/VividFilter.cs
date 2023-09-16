using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Adapter
{
    internal class VividFilter : Filter
    {
        public void Apply(Image image)
        {
            Console.WriteLine("Applying Vivid Filter"); 
        }
    }
}
