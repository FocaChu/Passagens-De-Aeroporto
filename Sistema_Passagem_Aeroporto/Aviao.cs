using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Passagem_Aeroporto
{
    internal class Aviao
    {
        public int ID;

        static int id = 0;


        public string Nome { get; set; }

        public string Modelo { get; set; }

        public List<Assento> Assentos { get; set; }


        public Aviao()
        {
            id++;
            this.ID = id;

            this.Assentos = new List<Assento>();
        }

        public Aviao(string nome, string modelo, List<Assento> assentos)
        {
            id++;
            this.ID = id;


            this.Nome = nome;   

            this.Modelo = modelo;

            this.Assentos = assentos;
        }

        public void ExibirDadosAviao()
        {
            Console.WriteLine($"ID: {this.ID}");
            Console.WriteLine($"Nome: {this.Nome}");
            Console.WriteLine($"Modelo: {this.Modelo}");
            Console.WriteLine($"Quantidade de Assentos: {this.Assentos.Count}");

            foreach (var assento in this.Assentos)
            {
                Console.WriteLine($"  - Assento ID: {assento.ID}, Fileira: {assento.Fileira}, Número: {assento.Numero}, Classe: {assento.Classe}");
            }

            Console.WriteLine("\n=====\n");
        }


    }
}
