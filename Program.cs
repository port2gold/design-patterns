//Composite Design Pattern 
//we chan easily represent Hierrachy of objects and treat the hierrachy of object the same way

using design_patterns.Composite;
using System.Reflection;

var rectangle1 = new Shape();  //Rectangle
var rectangle2 = new Shape();  //Rectangle

var circle1 = new Shape();  //Circle
var circle2 = new Shape(); //Circle

var group1 = new Group();
group1.Add(rectangle1);
group1.Add(rectangle2);

var group2 = new Group();
group2.Add(circle1);   
group2.Add(circle2);

var group3 = new Group();
group3.Add(group1);
group3.Add(group2);

group3.Render();
//Console Result

//Render Shape
//Render Shape
//Render Shape
//Render Shape



group3.Move();
//Console Result

//Move Shape
//Move Shape
//Move Shape
//Move Shape