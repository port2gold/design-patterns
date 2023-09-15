using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Composite
{
    public class Shape : Component
    {
        public void Move()
        {
            Console.WriteLine("Move Shape");
        }

        public void Render()
        {
            Console.WriteLine("Render Shape");
        }
    }
}
