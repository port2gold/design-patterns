using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Prototype
{
    public class ContentMenu
    {
        public void Duplicate(Component component)
        {
            component.Clone();
        }
    }
}
