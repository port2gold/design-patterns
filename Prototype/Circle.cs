using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Prototype
{
    public class Circle : Component
    {
        private int radius;

        public int GetRadius()
        {
            return radius;
        }
        public void SetRadius(int radius)
        {
            this.radius = radius;
        }
        public void Render()
        {
            Console.WriteLine($"Circle of radius: {radius}");
        }

        public Component Clone()
        {
            Circle newCircle = new Circle();
            newCircle.SetRadius(radius);
            return newCircle;
        }
    }
}
