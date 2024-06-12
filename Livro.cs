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



    }
}
