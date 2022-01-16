using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string title;
            string author;
            string content;
            Book book;
            
            Console.WriteLine("Please type title of book;");
            title = Console.ReadLine();
            Console.WriteLine("Please type author of book;");
            author = Console.ReadLine();
            Console.WriteLine("Please type content of book;");
            content = Console.ReadLine();
            book = new Book(title, content, author);
            book.Show();
        }
    }
}
