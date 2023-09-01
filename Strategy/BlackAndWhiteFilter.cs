using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Strategy
{
    internal class BlackAndWhiteFilter : Filter
    {
        public void Apply(string fileName)
        {
            Console.WriteLine($"Using black and while filter on {fileName}");
        }
    }
}
