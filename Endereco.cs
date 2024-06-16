namespace OOPproject
{
    internal class Endereco
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

        public string getRua() { return rua;}
        public void setRua(string rua) { this.rua = rua; }    
        public int getNumero() { return numero;}
        public void setNumero(int numero) {  this.numero = numero; }
        public string getBairro() { return bairro;} 
        public string setBairro(string bairro) { return bairro;}


        public void regAdress() { }
    }
}

