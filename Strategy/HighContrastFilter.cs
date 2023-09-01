using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Strategy
{
    internal class HighContrastFilter : Filter
    {
        public void Apply(string fileName)
        {
            Console.WriteLine($"Using the High Contrast filter on {fileName}");
        }
    }
}
