// See https://aka.ms/new-console-template for more information
//Iterator design better is best for implementation for iterating over items without worrying over underlying data structure

using design_patterns.Iterator;
//List Iterator
var list = new ListIterator<string>();
list.Add("1");
list.Add("2");
list.Add("3");
list.Add("4");
list.Add("5");
list.Add("6");


Console.WriteLine("using ListIterator");
while(list.HasNext())
{
    Console.WriteLine(list.Current());
    list.Next();
    
}

Console.WriteLine();
//ArrayIterator

var array = new ArrayIterator<string>();
list.Add("1");
list.Add("2");
list.Add("3");
list.Add("4");
list.Add("5");
list.Add("6");


Console.WriteLine("using ArrayIterator");
while (list.HasNext())
{
    Console.WriteLine(list.Current());
    list.Next();

}


//Result from Console
//using ListIterator
//1
//2
//3
//4
//5
//6

//using ArrayIterator
//1
//2
//3
//4
//5
//6