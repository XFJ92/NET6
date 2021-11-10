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

        /// <summary>
        /// Pricte vstupni bod k tomuto bodu a vysledek vrati jako novy bod.
        /// </summary>
        /// <param name="point"></param>
        /// <returns></returns>

        public Point2D AddAnotherPoints(Point2D point)
        {
            Point2D soucetBodu = new Point2D(X + point.X, Y + point.Y);
            return soucetBodu;
        }

        /// <summary>
        /// Modifikuje tento bod, pricte hodnotu vstupniho parametru point k tomuto bodu.
        /// </summary>
        /// <param name="point"></param>

        public void AddPoints(Point2D point)
        {
            X += point.X;
            Y += point.Y;
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
