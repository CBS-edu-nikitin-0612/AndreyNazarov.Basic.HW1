using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var rect = new Rectangle(10, 20);
            Console.WriteLine($"perimeter = {rect.Perimeter}");
            Console.WriteLine($"area = {rect.Area}");
        }
    }
}
