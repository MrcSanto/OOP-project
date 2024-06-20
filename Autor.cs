using System;
using System.Collections.Generic;
using System.Globalization;
namespace OOPproject;
class Autor : Pessoa //sintaxe para herdar uma classe
{
    private string nacionalidade;
    private List<Livro> livros = new List<Livro>(); // agregação por composição

    //construtores       
    public Autor() { }

    public Autor(string nome, string sexo, DateTime dt_nascimento, string nacionalidade) : base(nome, sexo, dt_nascimento)
    {
        this.nacionalidade = nacionalidade;
    }

    //getters e setters
    public string getNacionalidade() { return nacionalidade; }
    public void setNacionalidade(string nacionalidade) { this.nacionalidade = nacionalidade; }

    public List<Livro> getLivros() {  return livros; }
    public void setLivros(List<Livro> livros) { this.livros = livros; }

    public void addLivro(Livro l) //funcao para adicionar livro a lista de livros do autor
    {
        livros.Add(l);
    }

    public override void registrar(List<Pessoa> pessoas) //funcao herdada de Pessoa, para registrar ou cadastrar um novo autor.
    {//polimorfismo por substituicao
        setNome(ObterEntrada("Digite o nome do autor: "));
        setSexo(ObterEntrada("Digite o sexo do autor: "));
        setDt_nascimento(ObterDataNascimento("Digite a data de nascimento do autor (dd/MM/yyyy):"));
        setNacionalidade(ObterEntrada("Digite a nacionalidade do autor: "));

        pessoas.Add(this);
    }

    private string ObterEntrada(string mensagem) //funcao usada para diminuir o codigo
    {
        Console.Write(mensagem);
        return Console.ReadLine();
    } 

    private DateTime ObterDataNascimento(string mensagem) //funcao usada para diminuir o codigo
    {
        DateTime dataNascimento;
        while (true)
        {
            Console.Write(mensagem);
            string entrada = Console.ReadLine();
            if (DateTime.TryParseExact(entrada, "dd/MM/yyyy", null, DateTimeStyles.None, out dataNascimento))
            {
                return dataNascimento;
            }
            Console.WriteLine("Formato de data inválido. Tente novamente.");
        }
    }

    
}

