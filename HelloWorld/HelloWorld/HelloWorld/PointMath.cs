using HelloWorld.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class PointMath
    {
        public static Point2D AddPoints(Point2D p1, Point2D p2)
        {
            int x = p1.X + p2.X;
            int y = p1.Y + p2.Y;

            return new Point2D(x, y);
        }



    }
}
