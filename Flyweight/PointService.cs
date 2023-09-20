using design_patterns.Flyweight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Flyweight
{
    public class PointService
    {
        private PointIconFactory iconFactory;

        public PointService(PointIconFactory iconFactory)
        {
            this.iconFactory = iconFactory;
        }
        public List<Point> GetPoints()
        {
            var points = new List<Point>();

            var point = new Point(1, 2, PointType.Cafe, iconFactory.GetPointIcon(PointType.Cafe));
            points.Add(point);

            return points;
        }
    }
}
//Flyweight design pattern
//It can be used the amout of memory being used. //Object we can share in different context.


//using design_patterns.Flyweight;

//var service = new PointService(new PointIconFactory());

//foreach (var point in service.GetPoints())
//{
//    point.Draw();
//}


//Console Result 

//Cafe at (1,2)     Same Result  but if we have more than 10000 Points new object are not created for the which inturns save memory  -> Point Icons are managed by the Point Icon Factory
