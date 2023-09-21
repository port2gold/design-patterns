using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Prototype
{
    public interface Component
    {
        void Render();
        Component Clone();
    }
}
