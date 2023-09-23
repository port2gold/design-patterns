using design_patterns.Factory.matcha;
using design_patterns.Factory.sharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Factory
{
    public class ProductsController : MatchaController
    {
        public void GetProducts()
        {
            //Get Products from db
            Dictionary<string, object> products = new Dictionary<string, object>();
            //context.add(products);
            Render("product.html", products);
        }
    }
}
