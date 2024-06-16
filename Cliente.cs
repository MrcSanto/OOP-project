namespace OOPproject
{
    class Cliente : Pessoa //sintaxe para herdar uma classe
    {
        private string CPF;
        private Endereco endereco;
        private string CEP;
        private string telefone;
        private List<Emprestimo> livros_emp;


        public Cliente() { }

        public Cliente(string cPF, Endereco endereco, string cEP, string telefone, List<Emprestimo> livros_emp)
        {
            CPF = cPF;
            this.endereco = endereco;
            CEP = cEP;
            this.telefone = telefone;
            this.livros_emp = livros_emp;
        }

        public string getCPF() { return CPF; }
        public void setCPF(string cPF) { this.CPF = cPF; }

        public Endereco getEndereco() { return endereco; }
        public void setEndereco(Endereco endereco) { this.endereco = endereco;}

        public string getCEP() { return CEP; }
        public void setCEP(string CEP) { this.CEP = CEP; }

        public string getTelefone() { return telefone; }
        public void setTelefone(string telefone) { this.telefone = telefone; }

        public List<Emprestimo> getLivros() { return livros_emp}
        public void setLivros(List<Emprestimo> livros) { this.livros_emp =livros;}
    }
}   
