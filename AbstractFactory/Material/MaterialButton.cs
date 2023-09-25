using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.AbstractFactory.Material
{
    public class MaterialButton : Button
    {
        public void Render()
        {
            Console.WriteLine("Material Button");
        }
    }
}
