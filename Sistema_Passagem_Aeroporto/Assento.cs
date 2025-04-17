using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Passagem_Aeroporto
{
    enum ClasseAssento
    {
        Economica,
        Executiva
    }

    internal class Assento
    {

        public int ID { get; set; }

        static int id = 0;

        public string Fileira;

        public string Numero;

        public ClasseAssento Classe { get; set; }


        public Assento()
        {
            id++;
            this.ID = id;

        }

        public Assento(string fileira, string numero, ClasseAssento classe)
        {
            id++;
            this.ID = id;

            this.Fileira = fileira;
            this.Numero = numero;
            this.Classe = classe;
        }

        public double PrecoBase()
        {
            return Classe == ClasseAssento.Executiva ? 1500.0 : 800.0;
            //Terno pra definir o preço do assento
        }

    }
}
