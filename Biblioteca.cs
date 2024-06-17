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

        public string getNome() { return nome; }
        public void setNome(string nome) { this.nome = nome; }
        public Endereco getEndereco() { return endereco; }
        public void setEndereco(Endereco endereco) { this.endereco = endereco; }
        public List<Livro> getLivros() { return livros; }
        public void setLivros(List<Livro> livros) { this.livros = livros; }
    }

}
