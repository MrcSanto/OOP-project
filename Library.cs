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
            List<Cliente> clientes = new List<Cliente>();   

            Endereco e1 = new Endereco("Rua A", 333, "Bairro C");
            Endereco e2 = new Endereco("Rua B", 343, "Bairro C");
            Endereco e3 = new Endereco("Rua C", 363, "Bairro G");

            DateTime d1 = new DateTime(1990, 5, 20);
            DateTime d2 = new DateTime(2010, 12, 5);
            DateTime d3 = new DateTime(1997, 3, 22);

            Cliente c1 = new Cliente("João", "Masculino", d1, "029", e1, "joao@email.com", "99900-000", "5555-5555");
            clientes.Add(c1);
            Cliente c2 = new Cliente("Maria", "Feminino", d2, "030", e2, "maria@email.com", "99900-001", "5555-5556");
            clientes.Add(c2);   
            Cliente c3 = new Cliente("Pedro", "Masculino", d3, "031", e3, "pedro@email.com", "99900-002", "5555-5557"); 
            clientes.Add(c3);

            foreach (Cliente cliente in clientes)
            {
                Console.WriteLine($"Nome: {cliente.getNome()}, {cliente.getCPF()}, {cliente.getSexo()}");
            }


            Autor a1 = new Autor("Machado de Assis", "Masculino", new DateTime(1839, 6, 21), "Brasileiro"); pessoas.Add(a1);
            Autor a2 = new Autor("Jane Austen", "Feminino", new DateTime(1775, 12, 16), "Britânica");
            Autor a3 = new Autor("Leo Tolstoy", "Masculino", new DateTime(1828, 9, 9), "Russo");


            Editora ed1 = new Editora("Editora A", "EdA", "123456789", "555-5555", "Brasileira");
            Editora ed2 = new Editora("Editora B", "EdB", "987654321", "666-6666", "Americana");
            Editora ed3 = new Editora("Editora C", "EdC", "654321987", "777-7777", "Inglesa");

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
                int numero = int.Parse(Console.ReadLine());

                switch (numero)
                {
                    case 0:
                        Console.WriteLine("Saindo do programa");
                        return;
                    case 1:
                        Console.WriteLine("Lista de Livros:");
                        lib1.listarLivros();
                        break;
                    case 2:
                        Console.WriteLine("Lista de Autores:");
                        foreach (Pessoa p in pessoas)
                        {
                            if(p is Autor)
                            {   
                                Autor at = (Autor)p;
                                Console.WriteLine($"Nome do autor: {at.getNome()}, Nacionalidade: {at.getNacionalidade()}.");
                                
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine("Lista de Clientes");
                        
                            foreach (Pessoa p in pessoas)
                        {
                            if(p is Cliente)
                            {
                                Cliente cl = (Cliente)p;
                                Console.WriteLine($"Nome: {cl.getNome()}, {cl.getCPF()}");
                            }
                        }
                        break;
                    case 5:
                        Autor a = new Autor();
                        a.registrar(pessoas);
                        break;
                    case 6:
                        Cliente c = new Cliente();
                        c.registrar(pessoas);
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

