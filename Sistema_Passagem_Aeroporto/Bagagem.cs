using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Passagem_Aeroporto
{
    enum TipoBagagem
    {
        Mao,
        Despachada
    }

    internal class Bagagem
    {
        public int ID { get; set; }

        static int id = 0;

        public double Peso { get; set; }

        public TipoBagagem Tipo { get; set; }


        public Bagagem()
        {
            id++;
            this.ID = id;
        }

        public Bagagem(double peso, TipoBagagem tipo)
        {
            id++;
            this.ID = id;

            this.Peso = peso;

            this.Tipo = tipo;
        }

        public double CalcularPreco()
        {
            return Tipo == TipoBagagem.Despachada ? 150.0 : 0.0;
            //Terno para definir o preço da bagagem
        }

    }
}
