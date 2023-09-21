//Prototype design pattern 
//Used when you want to create new object by copying existing object


using design_patterns.Prototype;

var circle = new Circle();
circle.SetRadius(7);

var newCircle = circle.Clone();


circle.Render();
newCircle.Render();

//Console Result

//Circle of radius: 7
//Circle of radius: 7



var square = new Square();
square.SetLength(5);

var newSquare = square.Clone();


square.Render();
newSquare.Render();

//Console Result

//Square of Length: 5
//Square of Length: 5