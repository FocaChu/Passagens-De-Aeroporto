using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Passagem_Aeroporto
{
    internal class Endereco
    {
        public string Pais { get; set; }

        public string Estado { get; set; }

        public string Cidade { get; set; }

        public string Bairro { get; set; }

        public string Rua { get; set; }

        public string CEP { get; set; }

        public int Numero { get; set; }

        public int ID { get; set; }

        static int id = 0;
        

        public Endereco() 
        {
            id++;
            this.ID = id;
        
        }

        public Endereco(string pais, string estado, string cidade, string bairro, string rua, string cep, int numero)
        {
            id++;
            this.ID = id;

            this.Pais = pais;
            this.Estado = estado;
            this.Cidade = cidade;
            this.Bairro = bairro;
            this.Rua = rua;
            this.CEP = cep;
            this.Numero = numero;

        }


    }
}
