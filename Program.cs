// See https://aka.ms/new-console-template for more information
using design_patterns.Memento;

Console.WriteLine("Hello, World!");

var textEditor = new TextEditor();
var caretaker = new CareTaker(textEditor);

textEditor.UpdateText("Here is the first text");
Console.WriteLine(textEditor.GetCurrentText());
caretaker.BackUp();

textEditor.UpdateText("Here is the Second text");
Console.WriteLine(textEditor.GetCurrentText());
caretaker.BackUp();


textEditor.UpdateText("Here is the third text");
Console.WriteLine(textEditor.GetCurrentText());
caretaker.BackUp();

caretaker.Revert();
Console.WriteLine(textEditor.GetCurrentText());
caretaker.Revert();
Console.WriteLine(textEditor.GetCurrentText());
caretaker.Revert();
Console.WriteLine(textEditor.GetCurrentText());
caretaker.Revert();
Console.WriteLine(textEditor.GetCurrentText());
