using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.AbstractFactory.Ant
{
    public class AntTextBox : TextBox
    {
        public void Render()
        {
            Console.WriteLine("Ant TextBox");
        }
    }
}
