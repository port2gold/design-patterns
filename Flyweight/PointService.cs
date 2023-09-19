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
