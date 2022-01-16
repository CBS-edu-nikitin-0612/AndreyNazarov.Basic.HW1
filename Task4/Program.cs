using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Point(0, 0, "a");
            var b = new Point(0, 2, "b");
            var c = new Point(2, 2, "c");
            var d = new Point(2, 4, "d");
            var e = new Point(4, 6, "e");
            var figure = new Figure("figure 5 points", a, b, c, d, e);
            figure.PrintName();
            figure.PerimeterCalculator();
        }
    }
}
