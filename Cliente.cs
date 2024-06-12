namespace OOPproject
{
    class Cliente : Pessoa //sintaxe para herdar uma classe
    {
        private string CPF;
        private string endereco;
        private string CEP;
        private string telefone;
        private List<Emprestimo> livros_emp;


        public Cliente() { }

       public Cliente(string cPF, string endereco, string cEP, string telefone, List<Emprestimo> livros_emp)
        {
            CPF = cPF;
            this.endereco = endereco;
            CEP = cEP;
            this.telefone = telefone;
            this.livros_emp = livros_emp;
        }
    }
}
