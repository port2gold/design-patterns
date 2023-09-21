using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Prototype
{
    public class Square : Component
    {
        private int length;
        
        public void SetLength(int length)
        {
            this.length = length;
        }
        public int GetLength()
        {
            return length;
        }
        public Component Clone()
        {
            Square square = new Square();
            square.SetLength(length);
            return square;
        }

        public void Render()
        {
            Console.WriteLine($"Square of Length: {length}");
        }
    }
}
