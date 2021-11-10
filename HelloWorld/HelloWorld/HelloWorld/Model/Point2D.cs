using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Model
{
    class Point2D
    {

        public int X { get; set; }
        public int Y { get; set; }
        public Point2D(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int AreaCalc()
        {
            return (int)(X * Y);
        }

        public override string ToString()
        {
            return $"Plocha mezi souřadnicemi {X} a {Y} je {AreaCalc()}";
        }
    }
}
