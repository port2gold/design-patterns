//Abstract Factory Design Pattern 
//Provide an interface for creating families of related objects

using design_patterns.AbstractFactory;
using design_patterns.AbstractFactory.Ant;
using design_patterns.AbstractFactory.Material;

new ContactForm().Render(new MaterialWidgetFactory());


//Console Result 

//Material TextBox
//Material Button



new ContactForm().Render(new AntWidgetFactory());

//Console Result

//Ant TextBox
//Ant Button