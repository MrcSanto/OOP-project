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
        private List<Livro> livros_emp = new List<Livro>();

        //construtores
        public Cliente() { }

        public Cliente(string nome, string sexo, DateTime dt_nascimento, string cPF, Endereco endereco, string email, string cEP, string telefone) 
                : base(nome, sexo, dt_nascimento){
            CPF = cPF;
            this.endereco = endereco;
            this.email = email;
            CEP = cEP;
            this.telefone = telefone;
        }

        //getters e setters
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

        public List<Livro> getLivros_emp() { return livros_emp; }
        public void setLivros_emp(List<Livro> livros_) { this.livros_emp = livros_; }

        public override void registrar(List<Pessoa> pessoas) //polimorfismo por substituicao
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

        public void emprestarLivro(Livro livro, List<Livro> livrosDisponiveis) //funcao para alugar um livro
        {
            if (livro.getDisponiveis() > 1)
            {
                livro.setDisponiveis(livro.getDisponiveis() - 1); //assumindo que sempre retira-se 1 livro por vez
                livros_emp.Add(livro);
                Console.WriteLine($"\nLivro \"{livro.getTitulo()}\" emprestado com sucesso para {getNome()}.\n");
            }
            else
            {
                Console.WriteLine($"O livro \"{livro.getTitulo()}\" não está disponível para empréstimo.");
            }
        }

        public void devolverLivro(Livro livro, List<Livro> livrosDisponiveis)//funcao para devolver o livro alugado
        {
            livro.setDisponiveis(livro.getDisponiveis() + 1);
            livros_emp.Remove(livro);
            Console.WriteLine($"Livro \"{livro.getTitulo()}\" devolvido com sucesso por {getNome()}.");
        }
    }
}   
