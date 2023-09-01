using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Strategy
{
    internal class ImageStorage
    {
        private Compressor compressor;
        private Filter filter;
        public ImageStorage(Compressor compressor, Filter filter)
        {
            this.compressor = compressor;
            this.filter = filter;
        }

        public void StoreImage(string fileName)
        {
            compressor.Compress(fileName);
            filter.Apply(fileName);
        }
    }
}
