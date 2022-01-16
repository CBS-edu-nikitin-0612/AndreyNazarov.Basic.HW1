using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Book
    {
        private Title title;
        private Content content;
        private Author author;

        public Book(string title, string content, string author)
        {
            this.title = new Title(title, ConsoleColor.Red);
            this.content = new Content(content, ConsoleColor.Yellow);
            this.author = new Author(author, ConsoleColor.White);
        }

        public void Show()
        {
            title.Show();
            content.Show();
            author.Show();
        }

    }
}
