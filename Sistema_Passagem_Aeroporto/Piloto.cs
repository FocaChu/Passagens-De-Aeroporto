using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Passagem_Aeroporto
{
    internal class Piloto : Pessoa
    {
        public string Especializacao { get; set; }


        public Piloto(string especializacao, string nome, DateTime dataNascimento, Genero genero, string cpf, string telefone, string email) : base(nome, dataNascimento, genero, cpf, telefone, email)
        {
            this.Especializacao = especializacao;

            base.Nome = nome;
            base.DataNascimento = dataNascimento;
            base.Genero = genero;
            base.CPF = cpf;
            base.Telefone = telefone;
            base.Email = email;
        }

        public void ExibirDadosPiloto()
        {
            Console.WriteLine($"ID: {this.ID}");
            Console.WriteLine($"Nome: {this.Nome}");
            Console.WriteLine($"Data de Nascimento: {this.DataNascimento.ToShortDateString()}");
            Console.WriteLine($"Gênero: {this.Genero}");
            Console.WriteLine($"CPF: {this.CPF}");
            Console.WriteLine($"Telefone: {this.Telefone}");
            Console.WriteLine($"Email: {this.Email}");
            Console.WriteLine($"Especialização: {this.Especializacao}");
            Console.WriteLine("\n=====\n");
        }


    }
}
