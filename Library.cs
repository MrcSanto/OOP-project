using System;
using Library;

namespace OOPproject
{
    class Library
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Book livro1 = new Book("O Senhor dos Anéis", "J.R.R. Tolkien", "HarperCollins", 1216, 100);

            livro1.showInfo();

            Book livro2 = new Book();
            livro2.showInfo();
        }
    }
}

