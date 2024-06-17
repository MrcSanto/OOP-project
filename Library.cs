using System;
using System.Collections.Generic;

namespace OOPproject 
{
    class Library 
    {
        static void Main(string[] args)
        {
            
            List<Livro> Massis = new List<Livro>();
            List<Livro> Jausten = new List<Livro>();
            List<Livro> Ltolstoy = new List<Livro>();
            List<Livro> livros = new List<Livro>();
            List<Pessoa> pessoas = new List<Pessoa>();
            List<Editora> editoras = new List<Editora>();

            Endereco e1 = new Endereco("Rua A", 333, "Bairro C");
            Endereco e2 = new Endereco("Rua B", 343, "Bairro C");
            Endereco e3 = new Endereco("Rua C", 363, "Bairro G");

            DateTime d1 = new DateTime(1990, 5, 20);
            DateTime d2 = new DateTime(2010, 12, 5);
            DateTime d3 = new DateTime(1997, 3, 22);

            Cliente c1 = new Cliente("João", "Masculino", d1, "029", e1, "joao@email.com", "99900-000", "5555-5555");
            pessoas.Add(c1);
            Cliente c2 = new Cliente("Maria", "Feminino", d2, "030", e2, "maria@email.com", "99900-001", "5555-5556");
            pessoas.Add(c2);   
            Cliente c3 = new Cliente("Pedro", "Masculino", d3, "031", e3, "pedro@email.com", "99900-002", "5555-5557"); 
            pessoas.Add(c3);


            Autor a1 = new Autor("Machado de Assis", "Masculino", new DateTime(1839, 6, 21), "Brasileiro"); 
            pessoas.Add(a1);
            Autor a2 = new Autor("Jane Austen", "Feminino", new DateTime(1775, 12, 16), "Britânica");
            pessoas.Add (a2);
            Autor a3 = new Autor("Leo Tolstoy", "Masculino", new DateTime(1828, 9, 9), "Russo");
            pessoas.Add(a3);


            Editora ed1 = new Editora("Editora A", "EdA", "123456789", "555-5555", "Brasileira");
            editoras.Add(ed1);
            Editora ed2 = new Editora("Editora B", "EdB", "987654321", "666-6666", "Americana");
            editoras.Add(ed2); 
            Editora ed3 = new Editora("Editora C", "EdC", "654321987", "777-7777", "Inglesa");
            editoras.Add(ed3);

            Livro l1 = new Livro("Dom Casmurro", a1, ed1, 300, 10);
            Massis.Add(l1);
            livros.Add(l1);
            Livro l2 = new Livro("Orgulho e Preconceito", a2, ed2, 350, 8);
            Jausten.Add(l2);
            livros.Add(l2);
            Livro l3 = new Livro("Guerra e Paz", a3, ed3, 1200, 5);
            Ltolstoy.Add(l3);
            livros.Add(l3);  

            Biblioteca lib1 = new Biblioteca("Biblioteca Municipal de Passo Fundo", e3, livros);

            Console.WriteLine($"Bem vindo a {lib1.getNome()}!");
            while (true)
            {
                Console.WriteLine("1 - Listar Livros");
                Console.WriteLine("2 - Listar Autores");
                Console.WriteLine("3 - Listar Clientes");
                Console.WriteLine("4 - Cadastrar Livro");
                Console.WriteLine("5 - Cadastrar Autor");
                Console.WriteLine("6 - Cadastrar Cliente");
                Console.WriteLine("7 - Encontrar Livro");
                Console.WriteLine("0 - Sair do Programa");
                Console.WriteLine();
                Console.Write("Insira um número: ");
                int numero = int.Parse(Console.ReadLine());

                switch (numero)
                {
                    case 0:
                        Console.WriteLine("Saindo do programa");
                        return;
                    case 1:
                        Console.WriteLine("Lista de Livros: \n");
                        Livro li = new Livro();
                        li.listarLivro(livros);
                        break;
                    case 2:
                        Console.WriteLine("Lista de Autores:\n");
                        foreach (Pessoa p in pessoas)
                        {
                            if(p is Autor)
                            {   
                                Autor at = (Autor)p;
                                Console.Write($"Nome do Autor: {at.getNome()}\n");
                                Console.Write($"Data de Nascimento: {at.getDt_nascimento()}\n");
                                Console.Write($"Nacionalidade: {at.getNacionalidade()}\n\n");
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine("Lista de Clientes: \n");
                        
                            foreach (Pessoa p in pessoas)
                        {
                            if(p is Cliente)
                            {
                                Cliente cl = (Cliente)p;
                                Console.Write($"Nome: {cl.getNome()}\n");
                                Console.Write($"CPF: {cl.getCPF()}\n");
                                Console.Write($"Data de nascimento: {cl.getDt_nascimento()}\n");
                                Console.Write($"Email: {cl.getEmail()}\n\n");
                            }
                        }
                        break;
                    case 4:
                        Livro l = new Livro();
                        l.addLivro(livros, pessoas, editoras);
                        break;
                    case 5:
                        Autor a = new Autor();
                        a.registrar(pessoas);
                        break;
                    case 6:
                        Cliente c = new Cliente();
                        c.registrar(pessoas);
                        break;
                    case 7:
                        Livro liv = new Livro();
                        Console.Write("Digite o titulo do livro a ser encontrado: ");
                        string title = Console.ReadLine();
                        liv.encontrarLivro(title, livros);
                        break;
                    default:
                        Console.WriteLine("Tente Novamente!");
                        break;

                }
                Console.WriteLine("------------------------");
            }

        }

    }
}

