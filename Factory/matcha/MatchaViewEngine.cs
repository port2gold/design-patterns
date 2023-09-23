using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Factory.matcha
{
    public class MatchaViewEngine : ViewEngine
    {
        public string Render(string viewName, Dictionary<string, object> parameters)
        {
            return "View rendered by matcha";
        }
    }
}
