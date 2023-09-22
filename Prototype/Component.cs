using design_patterns.Prototype;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Prototype
{
    public interface Component
    {
        void Render();
        Component Clone();
    }
}

////Prototype design pattern 
////Used when you want to create a new object by copying an existing object


//using design_patterns.Prototype;

//var circle = new Circle();
//circle.SetRadius(7);

//var newCircle = circle.Clone();


//circle.Render();
//newCircle.Render();

////Console Result

////Circle of radius: 7
////Circle of radius: 7



//var square = new Square();
//square.SetLength(5);

//var newSquare = square.Clone();


//square.Render();
//newSquare.Render();

////Console Result

////Square of Length: 5
////Square of Length: 5