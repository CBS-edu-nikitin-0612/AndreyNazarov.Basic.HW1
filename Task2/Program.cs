using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type sides of rectangle to receiving area and  perimeter (use space as separator)");
            var str = Console.ReadLine().Split(' ');
            double side1;
            double side2;
            if (double.TryParse(str[0], out side1) && double.TryParse(str[1], out side2))
            {
                var rect = new Rectangle(side1, side2);
                Console.WriteLine($"perimeter = {rect.Perimeter}");
                Console.WriteLine($"area = {rect.Area}");
            }
            else
            {
                Console.WriteLine("Incorect data");
            }
        }
    }
}
