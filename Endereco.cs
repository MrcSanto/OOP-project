namespace OOPproject
{
    class Endereco
    {
        private string rua;
        private int numero;
        private string bairro;

        public Endereco() { }

        public Endereco(string rua, int numero, string bairro)
        {
            this.rua = rua;
            this.numero = numero;
            this.bairro = bairro;
        }

        public string getRua() { return rua; }
        public void setRua(string rua) { this.rua = rua; }
        public int getNumero() { return numero; }
        public void setNumero(int numero) { this.numero = numero; }
        public string getBairro() { return bairro; }
        public string setBairro(string bairro) { return bairro; }

        public static Endereco CadastrarEndereco()
        {
            Console.Write("Digite a rua: ");
            string rua = Console.ReadLine();

            Console.Write("Digite o número: ");
            int numero;
            while (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Número inválido. Digite novamente.");
                Console.Write("Digite o número: ");
            }

            Console.Write("Digite o bairro: ");
            string bairro = Console.ReadLine();

            return new Endereco(rua, numero, bairro);
        }
    }
}


