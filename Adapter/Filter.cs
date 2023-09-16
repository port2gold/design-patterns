using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Adapter
{
    public interface Filter
    {
        void Apply(Image image);
    }
}
