using design_patterns.Factory;
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


////Factory design pattern
////Defer creation of an object to subclasses

//using design_patterns.Factory;

//new ProductsController().GetProducts();

////Console Result            //when MatchaController is inherited in the product controller

////View rendered by matcha



//new ProductsController().GetProducts();

////Console Result            //when SharpController is inherited in the product controller

////View rendered by Sharp