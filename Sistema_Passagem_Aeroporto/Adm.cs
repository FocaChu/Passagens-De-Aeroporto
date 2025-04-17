using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Passagem_Aeroporto
{
    internal class Adm
    {
        public int ID { get; set; }

        static int id = 0;


        public string Nick { get; set; }


        public Adm() 
        {
            id++;
            this.ID = id;
        }

        public Adm(string nick)
        {
            id++;
            this.ID = id;

            Nick = nick;
        }
    }
}
