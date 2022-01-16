using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Figure
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private List<Point> points = new List<Point>();

        public Figure(string name, Point a, Point b, Point c)
        {
            this.name = name;
            points.Add(a);
            points.Add(b);
            points.Add(c);
        }
        public Figure(string name, Point a, Point b, Point c, Point d) : this(name, a, b, c)
        {
            points.Add(d);
        }
        public Figure(string name, Point a, Point b, Point c, Point d, Point e) : this(name, a, b, c, e)
        {
            points.Add(e);
        }

        double LengthSide(Point a, Point b)
        {
            return Math.Sqrt((a.X - b.X) * 2 + (a.Y - b.Y) * 2);
        }
        private void PerimeterCalculator()
        {
            double result = 0;
            for (int i = 1; i < points.Count - 1; i++)
            {
                result += LengthSide(points[i], points[i - 1]);
            }
            result += LengthSide(points[points.Count - 1], points[0]);
            Console.WriteLine($"Perimeter is {result}");
        }
        public void PrintName()
        {
            Console.WriteLine(Name);
        }
    }
}
