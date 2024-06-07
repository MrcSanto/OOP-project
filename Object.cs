namespace Library
{
    class Book
    {
        private string nameBook;
        private string author;
        private string publisher;
        private int numberPages;
        private int remaining;

        public Book(string nameBook, string author, string publisher, int numberPages, int remaining)
        {
            this.nameBook = nameBook;
            this.author = author;
            this.publisher = publisher;
            this.numberPages = numberPages;
            this.remaining = remaining;
        }

        public Book() { }

        //get e set
        public string NomeLivro
        {
            get { return nameBook; }
            set { nameBook = value; }
        }

        public string Autor
        {
            get { return author; }
            set { author = value; }
        }

        public string Editora
        {
            get { return author; }
            set { author = value; }
        }

        public int NumeroPaginas
        {
            get { return numberPages; }
            set { numberPages = value; }
        }

        public int Remanescentes
        {
            get { return remaining; }
            set { remaining = value; }
        }

        public void showInfo()
        {
            if (nameBook != null)
            {
                Console.WriteLine($"Nome: {nameBook}, Autor: {author}");
            }
            else
            {
                Console.WriteLine("Livro nulo!");
            }
        }
    }
}
