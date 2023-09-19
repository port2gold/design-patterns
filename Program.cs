//Flyweight design pattern
//It can be used the amout of memory being used. //Object we can share in different context.


using design_patterns.Flyweight;

var service = new PointService(new PointIconFactory());

foreach(var point in service.GetPoints())
{
    point.Draw();
}


//Console Result 

//Cafe at (1,2)     Same Result  but if we have more than 10000 Points new object are not created for the which inturns save memory  -> Point Icons are managed by the Point Icon Factory
