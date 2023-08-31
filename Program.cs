// See https://aka.ms/new-console-template for more information
using design_patterns.Memento;
using design_patterns.State;

Console.WriteLine("Hello, World!");


var canva = new Canva(new SelectionTool());
canva.MouseUp();
canva.MouseDown();

canva.SetToolType(new BrushTool());
canva.MouseDown();
canva.MouseUp();

canva.SetToolType(new EraserTool());
canva.MouseDown();
canva.MouseUp();


//Result on console.
//Mouse Up on selection tool
//Mouse Down on selection tool
//Mouse down on brush tool
//Mouse up on brush tool
//Mouse down on Eraser tool
//Mouse down on Eraser tool