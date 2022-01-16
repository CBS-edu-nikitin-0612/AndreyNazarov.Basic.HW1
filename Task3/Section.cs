using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    abstract class Section
    {
        protected string text;
        protected ConsoleColor consoleColor;
        public string Text
        {
            get { return text; }
            set { text = value; }
        }

        public void Show()
        {
            Console.ForegroundColor = consoleColor;
            Console.WriteLine(text);
            Console.ResetColor();
        }
        public Section(string text, ConsoleColor consoleColor)
        {
            this.text = text;
            this.consoleColor = consoleColor;
        }
    }
}
