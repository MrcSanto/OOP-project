namespace OOPproject
{
    class Emprestimo
    {
        private Cliente cliente;
        private Livro info_livro;
        private int quant_livro;
        private DateTime dt_saida;
        private DateTime dt_devolucao;

        public Emprestimo() { }

        public Emprestimo(Cliente cliente, Livro info_livro, int quant_livro, DateTime dt_saida, DateTime dt_devolucao)
        {
            this.cliente = cliente;
            this.info_livro = info_livro;
            this.quant_livro = quant_livro;
            this.dt_saida = dt_saida;
            this.dt_devolucao = dt_devolucao;
        }
    }
}
