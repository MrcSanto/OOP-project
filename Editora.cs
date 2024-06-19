namespace OOPproject
{
    class Editora
    {
        private string razao_social;
        private string nome_fantasia;
        private string CNPJ;
        private string telefone;
        private string nacionalidade;

        //construtores
        public Editora() { }

        public Editora(string razao_social, string nome_fantasia, string cNPJ, string telefone, string nacionalidade)
        {
            this.razao_social = razao_social;
            this.nome_fantasia = nome_fantasia;
            this.CNPJ = cNPJ;
            this.telefone = telefone;
            this.nacionalidade = nacionalidade;
        }

        //getters e setters
        public string getRazaoSocial() { return razao_social; }
        public void setRazaoSocial(string razao_social) { this.razao_social = razao_social; }

        public string getNomeFantasia() { return nome_fantasia; }
        public void setNomeFantasia(string nome_fantasia) { this.nome_fantasia = nome_fantasia; }

        public string getCNPJ() { return CNPJ; }
        public void setCNPJ(string CNPJ) { this.CNPJ = CNPJ; }

        public string getTelefone() { return telefone; }
        public void setTelefone(string telefone) { this.telefone = telefone; }
    }
}
