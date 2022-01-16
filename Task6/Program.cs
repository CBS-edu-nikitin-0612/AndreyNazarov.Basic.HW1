using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            var address = new Address()
            {
                Index = 123456,
                Country = "USA",
                City = "New York",
                Street = "Broadway",
                House = "45a",
                Appartment = "23d"
            };
            address.Print();
        }
    }
}
