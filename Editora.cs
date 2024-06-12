namespace OOPproject
{
    class Editora
    {
        private string razao_social;
        private string nome_fantasia;
        private string CNPJ;
        private string telefone;
        private string nacionalidade;

        public Editora() { }

        public Editora(string razao_social, string nome_fantasia, string cNPJ, string telefone, string nacionalidade)
        {
            this.razao_social = razao_social;
            this.nome_fantasia = nome_fantasia;
            this.CNPJ = cNPJ;
            this.telefone = telefone;
            this.nacionalidade = nacionalidade;
        }
    }
}
