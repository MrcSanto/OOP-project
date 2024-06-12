namespace OOPproject
{
    class Autor : Pessoa //sintaxe para herdar uma classe
    {
        private string nacionalidade;
        private List<Livro> livros; // agregação por composição
        private string epoca_literaria;

        public Autor() { }

        public Autor(string nacionalidade, string epoca_literaria, List<Livro> livros)
        {
            this.nacionalidade = nacionalidade;
            this.epoca_literaria = epoca_literaria;
            this.livros = livros;
        }
    }
}
