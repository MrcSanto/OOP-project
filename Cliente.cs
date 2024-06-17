using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Cryptography;
using System.Globalization;

namespace OOPproject
{
    class Cliente : Pessoa //sintaxe para herdar uma classe
    {
        private string CPF;
        private Endereco endereco;
        private string email;
        private string CEP;
        private string telefone;

        public Cliente() { }

        public Cliente(string nome, string sexo, DateTime dt_nascimento, string cPF, Endereco endereco, string email, string cEP, string telefone) 
                : base(nome, sexo, dt_nascimento){
            CPF = cPF;
            this.endereco = endereco;
            this.email = email;
            CEP = cEP;
            this.telefone = telefone;
        }

        public string getCPF() { return CPF; }
        public void setCPF(string cPF) { this.CPF = cPF; }

        public Endereco getEndereco() { return endereco; }
        public void setEndereco(Endereco endereco) { this.endereco = endereco; }

        public string getEmail() { return email; }
        public void setEmail(string email) { this.email = email; }

        public string getCEP() { return CEP; }
        public void setCEP(string CEP) { this.CEP = CEP; }

        public string getTelefone() { return telefone; }
        public void setTelefone(string telefone) { this.telefone = telefone; }

        public override void registrar(List<Pessoa> pessoas)
        {
            setNome(ObterEntrada("Digite o nome do cliente: "));
            setSexo(ObterEntrada("Digite o sexo do cliente: "));
            setDt_nascimento(ObterDataNascimento("Digite a data de nascimento: "));
            setCPF(ObterEntrada("Digite o CPF: "));

            // Cadastrando o endereço
            Endereco end = Endereco.CadastrarEndereco();
            setEndereco(endereco);

            setEmail(ObterEntrada("Digite o email: "));
            setCEP(ObterEntrada("Digite o CEP: "));
            setTelefone(ObterEntrada("Digite o telefone: "));
            pessoas.Add(this);

        }

        private string ObterEntrada(string mensagem)
        {
            Console.Write(mensagem);
            return Console.ReadLine();
        }

        private DateTime ObterDataNascimento(string mensagem)
        {
            DateTime dataNascimento;
            while (true)
            {
                Console.Write(mensagem);
                string entrada = Console.ReadLine();
                if (DateTime.TryParseExact(entrada, "dd/MM/yyyy", null, DateTimeStyles.None, out dataNascimento))
                {
                    return dataNascimento;
                }
                Console.WriteLine("Formato de data inválido. Tente novamente.");
            }
        }
    }
}   
