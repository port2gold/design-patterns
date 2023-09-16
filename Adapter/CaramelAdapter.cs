using design_patterns.Adapter.ThirdPartyFilter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Adapter
{
    public class CaramelAdapter : Caramel, Filter
    {
        public void Apply(Image image)
        {
            Init();
            Render(image);
        }
    }
}
