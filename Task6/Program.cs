namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Address address = new Address(25 , "USA" , "New York" , "Broadway" , "45a" , "23d");
            //address.Print();
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
