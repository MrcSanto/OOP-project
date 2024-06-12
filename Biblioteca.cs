namespace OOPproject
{
    class Biblioteca
    {
        private string nome;
        private string endereco;
        private List<Livro> livros;

        public Biblioteca() { }

        public Biblioteca(string nome, string endereco, List<Livro> livros)
        {
            this.nome = nome;
            this.endereco = endereco;
            this.livros = livros;
        }
    }

}
