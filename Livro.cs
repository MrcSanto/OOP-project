using System.Runtime.InteropServices.Marshalling;

namespace OOPproject
{
    class Livro
    {
        private string titulo;
        private Autor autor;  //agregação por composição
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

        public Livro() { }

        public string getTitulo() { return titulo; }
        public void setTitulo(string titulo) { this.titulo = titulo; }

        public Autor getAutor() { return autor; }
        public void setAutor(Autor autor) { this.autor = autor; }

        public Editora getEditora() { return editora; }
        public void setEditora(Editora editora) { this.editora = editora; }

        public int getDisponiveis() { return disponiveis; }
        public void setDisponiveis(int disponiveis) { this.disponiveis = disponiveis; }

        public void addCopias(int number)
        {
            disponiveis += number;
            Console.WriteLine($"Adicionado {number} novos livros. Nome: {titulo}. Total agora: {disponiveis}");
        }

        public void addLivro(List<Livro> livros, List<Pessoa> pessoas, List<Editora> editoras)
        {
            string titulo = ObterEntrada("Digite o título do livro: ");

            Console.WriteLine("Escolha o autor pelo número: \n");
            int count = 1;
            List<Autor> autoresDisponiveis = new List<Autor>();
            foreach(Pessoa p in pessoas)
            {
                if(p is Autor)
                {   
                    autoresDisponiveis.Add((Autor)p);
                    Console.WriteLine($"{count++} -- {p.getNome()}");
                }
            }
            int autIndex = int.Parse(Console.ReadLine());
            if (autIndex <= 0 || autIndex >= count)
            {
                Console.WriteLine($"Selecione o número corrreto: 0 < n < {count}.");
                return;
            }
            Autor autor = autoresDisponiveis[autIndex];

            Console.WriteLine("Escolha a editora pelo número: \n");
            count = 1;
            foreach(Editora ed in editoras)
            {
                Console.WriteLine($"{count++} -- {ed.getNomeFantasia()}");
            }
            int edIndex = int.Parse(Console.ReadLine());
            if(edIndex <= 0 || edIndex >= count)
            {
                Console.WriteLine($"Escolha o número correto: 0 < n < {count}");
                return;
            }
            Editora editora = editoras[edIndex];
            
            
            
        }

        private string ObterEntrada(string mensagem)
        {
            Console.Write(mensagem);
            return Console.ReadLine();
        }

    }
}
