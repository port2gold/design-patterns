using design_patterns.Adapter.ThirdPartyFilter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Adapter
{
    //Caramel Adapters
    public class CaramelFilter : Filter
    {
        private Caramel caramel = new Caramel();
        public void Apply(Image image)
        {
            caramel.Init();
            caramel.Render(image);
        }
    }
}
