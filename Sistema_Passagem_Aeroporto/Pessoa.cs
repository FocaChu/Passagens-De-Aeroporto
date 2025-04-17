using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Passagem_Aeroporto
{

    enum Genero
    {
        Feminino = 1,
        Masculino = 2,
        Não_Binárie = 3,
        Não_Informado = 4,
        Outro = 5
    }

    internal abstract class Pessoa
    {

        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }

        public Genero Genero { get; set; }

        public string CPF { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }


        public int ID { get; set; }

        static int id = 0;

        public Pessoa(string nome, DateTime dataNascimento, Genero genero, string cpf, string telefone, string email)
        {
            id++;
            this.ID = id;

            this.Nome = nome;
            this.DataNascimento = dataNascimento;
            this.Genero = genero;
            this.CPF = cpf;
            this.Telefone = telefone;
            this.Email = email;

        }

    }
}
