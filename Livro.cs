using System.Runtime.InteropServices.Marshalling;

namespace OOPproject
{
    class Livro
    {
        private string titulo;
        private Autor autor; //agregação por composição
        private Editora editora; //agregação 
        private int n_paginas;
        private int disponiveis;

        public Livro(string titulo, Autor autor, Editora editora, int n_paginas, int disponiveis)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.editora = editora;
            this.n_paginas = n_paginas;
            this.disponiveis = disponiveis;
        }

        public string getTitulo() {  return titulo; }
        public void setTitulo(string titulo) { this.titulo = titulo; }

        public Autor getAutor() { return autor; }
        public void setAutor(Autor autor) { this.autor = autor; }

        public Editora getEditora() { return editora; }
        public void setEditora(Editora editora) { this.editora = editora; }

        public int getDisponiveis() { return disponiveis; }
        public void setDisponiveis(int disponiveis) { this.disponiveis = disponiveis; }



    }
}
