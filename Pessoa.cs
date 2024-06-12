namespace OOPproject
{
    class Pessoa
    {
        private string nome;
        private string email;
        private string sexo;
        private DateTime dt_nascimento;

        public Pessoa() { } 

        public Pessoa(string nome, string email, string sexo, DateTime dt_nascimento)
        {
            this.nome = nome;
            this.email = email;
            this.sexo = sexo;
            this.dt_nascimento = dt_nascimento;
        }
    }

}
