using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Factory.sharp
{
    public class SharpViewEngine : ViewEngine
    {
        public string Render(string viewName, Dictionary<string, object> parameters)
        {
            return "View rendered by Sharp";
        }
    }
}
