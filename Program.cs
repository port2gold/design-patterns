//Command design pattern

using design_patterns.Command;
using design_patterns.Command.Editor;
using design_patterns.Command.fx;
using System.Drawing;

var service = new CustomerService();
var command = new AddCustomerCommand(service);
var button = new Button(command);

button.Click();

// Console Returns 
// Add Customer





//Record Actions with command pattern 
var composite = new CompositeCommand();
composite.AddCommand(new ResizeCommand());
composite.AddCommand(new BlackAndWhiteCommand());
composite.Execute();

//Console Result
//Resize
//Black and White

//These can also be re executed multiple times
composite.Execute(); 
composite.Execute(); 
composite.Execute();

//Console Result
//Black and White
//Resize
//Black and White
//Resize
//Black and White



//Undoable commands

var history = new History();
var document = new HtmlDocument();
document.SetContent("Hello World");

var boldCommand = new BoldCommand(document, history);
boldCommand.Execute();
boldCommand.Execute();
Console.WriteLine(document.GetContent());

//Console Result

//< b >< b > Hello World </ b ></ b >



var italicsCommand = new ItalicsCommand(document, history);
italicsCommand.Execute();
italicsCommand.Execute();
Console.WriteLine(document.GetContent());

//Console Result
//< i >< i >< b >< b > Hello World </ b ></ b ></ i ></ i >

var undoCommand = new UndoCommand(history);
undoCommand.Execute();
undoCommand.Execute();
undoCommand.Execute();
Console.WriteLine(document.GetContent());

//Console Result 
//< b > Hello World </ b >