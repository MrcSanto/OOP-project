using System.Runtime.InteropServices.Marshalling;

namespace OOPproject
{
    class Livro
    {
        private string titulo;
        private Autor autor;  //agregação
        private Editora editora; //agregação 
        private int n_paginas;
        private int disponiveis;

        //construtores
        public Livro(string titulo, Autor autor, Editora editora, int n_paginas, int disponiveis)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.editora = editora;
            this.n_paginas = n_paginas;
            this.disponiveis = disponiveis;
        }

        public Livro() { }

        //getters e setters
        public string getTitulo() { return titulo; }
        public void setTitulo(string titulo) { this.titulo = titulo; }

        public Autor getAutor() { return autor; }
        public void setAutor(Autor autor) { this.autor = autor; }

        public Editora getEditora() { return editora; }
        public void setEditora(Editora editora) { this.editora = editora; }

        public int getN_paginas() {  return n_paginas; }
        public void setN_paginas(int n_paginas) { this.n_paginas= n_paginas; }

        public int getDisponiveis() { return disponiveis; }
        public void setDisponiveis(int disponiveis) { this.disponiveis = disponiveis; }

        public void addCopias(int number)
        {
            disponiveis += number;
            Console.WriteLine($"Adicionado {number} novos livros. Nome: {titulo}. Total agora: {disponiveis}");
        }

        public void addLivro(List<Livro> livros, List<Pessoa> pessoas, List<Editora> editoras)
        {
            Console.Write("Digite o título do livro: ");
            string titulo = Console.ReadLine();


            Console.WriteLine("Escolha o autor pelo número: \n");
            int count = 0;
            List<Autor> autoresDisponiveis = new List<Autor>();
            foreach(Pessoa p in pessoas)
            {
                if(p is Autor)
                {   
                    autoresDisponiveis.Add((Autor)p);
                    Console.WriteLine($"{(count++) + 1} -- {p.getNome()}");
                }
            }
            int autIndex = int.Parse(Console.ReadLine()) - 1;
            if (autIndex >= count || autIndex <0)
            {
                Console.WriteLine($"Selecione o número corrreto: 0 < n < {count}.");
                return;
            }
            Autor autor = autoresDisponiveis[autIndex];

            Console.WriteLine("Escolha a editora pelo número: \n");
            count = 0;
            foreach(Editora ed in editoras)
            {
                Console.WriteLine($"{(count++) + 1} -- {ed.getNomeFantasia()}");
            }
            int edIndex = int.Parse(Console.ReadLine()) - 1;
            if(edIndex < 0 || edIndex >= count)
            {
                Console.WriteLine($"Escolha o número correto: 0 < n < {count}");
                return;
            }
            Editora editora = editoras[edIndex];

            Console.Write("Digite o número de páginas do livro: ");
            int n_paginas = int.Parse(Console.ReadLine());

            Console.Write("Digite quantos exemplares tem disponíveis: ");
            int disponiveis = int.Parse(Console.ReadLine());

            Livro addLivro = new Livro(titulo, autor, editora, n_paginas, disponiveis);
            livros.Add(addLivro);
            autor.addLivro(addLivro);


        }

        public void encontrarLivro(string titulo, List<Livro> livros)
        {
            bool encontrado = false;
            foreach (Livro livro in livros)
            {
                if (livro.getTitulo().Equals(titulo, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Titulo: {livro.getTitulo()}");
                    Console.WriteLine($"Autor: {livro.getAutor().getNome()}");
                    Console.WriteLine($"Editora: {livro.getEditora().getNomeFantasia()}");
                    Console.WriteLine($"Numero de páginas: {livro.getN_paginas()}");
                    Console.WriteLine($"Exemplares: {livro.getDisponiveis()}\n");
                    encontrado = true;
                    break;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("Livro não encontrado.");
            }
        }

        public void listarLivro(List<Livro> livros, List<Pessoa> pessoas)
        {
            foreach (Pessoa p in pessoas)
            {
                if (p is Autor at)
                {
                    Console.WriteLine($"Nome: {at.getNome()}");

                    List<Livro> livrosDoAutor = at.getLivros();
                    if (livrosDoAutor.Count == 0)
                    {
                        Console.WriteLine("Autor sem livros cadastrados.");
                    }
                    else
                    {
                        foreach (Livro l in livrosDoAutor)
                        {
                            Console.Write($"Titulo: {l.getTitulo()}\n");
                            Console.Write($"Autor: {l.getAutor().getNome()}\n");
                            Console.Write($"Editora : {l.getEditora().getNomeFantasia()}\n");
                            Console.Write($"Numero de páginas: {l.getN_paginas()}\n");
                            Console.Write($"Exemplares: {l.getDisponiveis()}\n\n");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }


    }
}
