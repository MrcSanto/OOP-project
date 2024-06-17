using System;
using System.Collections.Generic;

namespace OOPproject
{
    abstract class Pessoa
    {
        public string nome;
        public string sexo;
        public DateTime dt_nascimento;
        public Pessoa() { }

        public Pessoa(string nome, string sexo, DateTime dt_nascimento)
        {
            this.nome = nome;
            this.sexo = sexo;
            this.dt_nascimento = dt_nascimento;
        }

        public string getNome() { return nome; }
        public void setNome(string nome) { this.nome = nome; }

        public string getSexo() { return sexo; }
        public void setSexo(string sexo) { this.sexo = sexo; }

        public DateTime getDt_nascimento() { return dt_nascimento; }
        public void setDt_nascimento(DateTime dt_nascimento) { this.dt_nascimento = dt_nascimento; }

        public abstract void registrar(List<Pessoa> pessoas); //funcao para registrar dentro do switch-case

      
    }

}
