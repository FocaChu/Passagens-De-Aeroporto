using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Passagem_Aeroporto
{
    internal class Passageiro : Pessoa
    {
        public List<Bagagem> Bagagens { get; set; }


        public Passageiro(List<Bagagem> bagagems, string nome, DateTime dataNascimento, Genero genero, string cpf, string telefone, string email) : base (nome, dataNascimento, genero, cpf, telefone, email)
        {
            this.Bagagens = bagagems;

            base.Nome = nome;
            base.DataNascimento = dataNascimento;
            base.Genero = genero;
            base.CPF = cpf;
            base.Telefone = telefone;
            base.Email = email;

        }
    }
}
