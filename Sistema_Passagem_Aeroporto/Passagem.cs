using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Passagem_Aeroporto
{
    internal class Passagem
    {
        public int ID { get; set; }

        static int id = 0;


        public Passageiro Passageiro { get; set; }

        public Voo Voo { get; set; }

        public Assento Assento { get; set; }

        public decimal Preco { get; set; }


        public Passagem()
        {
            id++;
            this.ID = id;

        }

        public Passagem(Passageiro passageiro, Voo voo, Assento assento, decimal preco)
        {
            id++;
            this.ID = id;
            
            this.Passageiro = passageiro;

            this.Voo = voo;

            this.Assento = assento;

            this.Preco = preco;

        }

        public double CalcularPreco()
        {
            double precoAssento = Assento.PrecoBase();
            double precoBagagens = Passageiro.Bagagens.Sum(b => b.CalcularPreco());
            return precoAssento + precoBagagens;
            /* 1 - Ta chamando o codigo que define o preço do assento
               2 - Ta fazendo uma birosca que retorna o preço das passagems somados
               Por fim ta devolvendo a soma dos dois pro preço final da compra
             */

        }
    }
}
