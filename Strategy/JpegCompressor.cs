using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Strategy
{
    internal class JpegCompressor : Compressor
    {
        public void Compress(string fileName)
        {
             Console.WriteLine($"Using the Jpeg Compressor to compress {fileName}");
        }
    }
}
