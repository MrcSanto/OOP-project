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
        {
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
            string texto;
            Console.Write("Digite o nome do cliente: ");
            texto = Console.ReadLine();
            setNome(texto);

            Console.Write("Digite o sexo do cliente: ");
            texto = Console.ReadLine();
            setSexo(texto);

            Console.Write("Digite a data de nascimento do cliente (dd/MM/yyyy): ");
            texto = Console.ReadLine();
            if (DateTime.TryParseExact(texto, "dd/MM/yyyy", null, DateTimeStyles.None, out DateTime dataNascimento))
            {
                setDt_nascimento(dataNascimento);
            }
            else
            {
                Console.WriteLine("Formato de data inválido. Tente novamente.");
                return;
            }

            Console.Write("Digite o CPF do cliente: ");
            texto = Console.ReadLine();
            setCPF(texto);

            // Cadastrando o endereço
            Endereco end = Endereco.CadastrarEndereco();
            setEndereco(endereco);

            Console.Write("Digite o email do cliente: ");
            texto = Console.ReadLine();
            setEmail(texto);

            Console.Write("Digite o CEP do cliente: ");
            texto = Console.ReadLine();
            setCEP(texto);

            Console.Write("Digite o telefone do cliente: ");
            texto = Console.ReadLine();
            setTelefone(texto);

            pessoas.Add(this);

        }


    }
}   
