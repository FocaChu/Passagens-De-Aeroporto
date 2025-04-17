using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Passagem_Aeroporto
{
    internal class Aeroporto
    {

        public int ID { get; set; }

        static int id = 0;

        public string Nome { get; set; }

        public Endereco Endereco { get; set; }

        public Aeroporto()
        {
            id++;
            this.ID = id;

        }

        public Aeroporto(string nome, Endereco endereco)
        {
            id++;
            this.ID = id;

            this.Nome = nome;
            this.Endereco = endereco;

        }

        public void ExibirDados()
        {
            Console.WriteLine($"Aeroporto ID: {ID}");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Localização: {Endereco.Rua}, Nº {Endereco.Numero}, Bairro {Endereco.Bairro}, {Endereco.Cidade}/{Endereco.Estado}");
            Console.WriteLine($"CEP: {Endereco.CEP}, País: {Endereco.Pais}");
            Console.WriteLine("\n=====\n");
        }

    }
}
