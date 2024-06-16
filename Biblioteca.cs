namespace OOPproject
{
    class Biblioteca
    {
        private string nome;
        private Endereco endereco;
        private List<Livro> livros;

        public Biblioteca() { }

        public Biblioteca(string nome, Endereco endereco, List<Livro> livros)
        {
            this.nome = nome;
            this.endereco = endereco;   
            this.livros = livros;
        }
    }

}
