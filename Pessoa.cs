using System.Security.AccessControl;

namespace OOPproject
{
    abstract class Pessoa
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

        public string getNome() { return nome; }
        public void setNome(string nome) { this.nome = nome; }
        public string getEmail() { return email; }
        public void setEmail(string email) { this.email = email; }
        public string getSexo() { return sexo; }
        public void setSexo(string sexo) {  this.sexo = sexo; }
        public DateTime getDt_nascimento() { return dt_nascimento; }
        public void setDt_nascimento(DateTime dt_nascimento) { this.dt_nascimento = dt_nascimento; }

        //public abstract void registrar();
    }

}
