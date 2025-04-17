using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Passagem_Aeroporto
{
    internal class Voo
    {
        public int ID { get; set; }

        static int id = 0;


        public Aviao Aviao { get; set; }

        public Piloto PilotoResponsavel { get; set; }

        public List<Passageiro> Passageiros { get; set; }

        public DateTime DataHoraPartida { get; set; }

        public DateTime DataHoraChegada { get; set; }

        public Aeroporto Origem { get; set; }

        public Aeroporto Destino { get; set; }


        public Voo()
        {
            id++;
            this.ID = id;

            this.Passageiros = new List<Passageiro>();

        }

        public Voo(Aviao aviao, Piloto pilotoResponsavel, DateTime dataHoraPartida, DateTime dataHoraChegada, Aeroporto origem, Aeroporto destino)
        {
            id++;
            this.ID = id;


            this.Aviao = aviao;

            this.PilotoResponsavel = pilotoResponsavel;

            this.Passageiros = new List<Passageiro>();

            this.DataHoraPartida = dataHoraPartida;

            this.DataHoraChegada = dataHoraChegada;

            this.Origem = origem;

            this.Destino = destino;
        }



        public void ExibirDados()
        {
            Console.WriteLine($"Voo ID: {ID}");
            Console.WriteLine($"Avião: {Aviao.Nome} - Modelo: {Aviao.Modelo}");
            Console.WriteLine($"Piloto: {PilotoResponsavel.Nome} - Especialização: {PilotoResponsavel.Especializacao}");
            Console.WriteLine($"Origem: {Origem.Nome} ({Origem.Endereco.Cidade}/{Origem.Endereco.Estado})");
            Console.WriteLine($"Destino: {Destino.Nome} ({Destino.Endereco.Cidade}/{Destino.Endereco.Estado})");
            Console.WriteLine($"Partida: {DataHoraPartida}");
            Console.WriteLine($"Chegada: {DataHoraChegada}");
            Console.WriteLine($"Passageiros: {Passageiros.Count}");
            Console.WriteLine("\n=====\n");
        }
    }
}
