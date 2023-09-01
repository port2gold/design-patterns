using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Strategy
{
    internal interface Compressor
    {
        void Compress(string filename);
    }
}
