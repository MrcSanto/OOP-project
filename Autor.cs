using System;
using System.Collections.Generic;
using System.Globalization;
namespace OOPproject;
class Autor : Pessoa //sintaxe para herdar uma classe
{
    private string nacionalidade;
    private List<Livro> livros; // agregação por composição

    public Autor() { }

    public Autor(string nome, string sexo, DateTime dt_nascimento, string nacionalidade)
    {
        this.nacionalidade = nacionalidade;
    }

    public string getNacionalidade() { return nacionalidade; }
    public void setNacionalidade(string nacionalidade) { this.nacionalidade = nacionalidade; }

    public List<Livro> getLivros() {  return livros; }
    public void setLivros(List<Livro> livros) { this.livros = livros; }

    public override void registrar(List<Pessoa> pessoas)
    {
        setNome(ObterEntrada("Digite o nome do autor: "));
        setSexo(ObterEntrada("Digite o sexo do autor: "));
        setDt_nascimento(ObterDataNascimento("Digite a data de nascimento do autor (dd/MM/yyyy):"));
        setNacionalidade(ObterEntrada("Digite a nacionalidade do autor: "));

        pessoas.Add(this);
    }

    private string ObterEntrada(string mensagem)
    {
        Console.Write(mensagem);
        return Console.ReadLine();
    }

    private DateTime ObterDataNascimento(string mensagem)
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

