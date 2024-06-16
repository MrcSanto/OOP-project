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

        public Cliente getCliente() { return cliente; }
        public void setCliente(Cliente cliente) { this.cliente = cliente; }

        public Livro getLivro() { return info_livro; }
        public void setLivro(Livro info_livro) { this.info_livro= info_livro; }

        public int getQuant_livro() { return quant_livro; }
        public void setQuant_livro(int quant_livro) { this.quant_livro = quant_livro; }

        public DateTime getDt_saida() { return dt_saida; }
        public void setDt_saida(DateTime dt_saida) { this.dt_saida= dt_saida; }
        

        public DateTime getDt_devolucao() {return dt_devolucao; }
        public void setDt_devolucao(DateTime dt_devolucao) {this.dt_devolucao= dt_devolucao; }  
    }
}
