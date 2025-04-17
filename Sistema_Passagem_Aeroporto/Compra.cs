using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Passagem_Aeroporto
{
    enum FormaPagamento
    {
        Cartao_Credito,
        Cartao_Debito,
        Pix,
        Boleto
    }

    internal class Compra
    {
        public int ID { get; set; }

        static int id = 0;

        public Passageiro Comprador { get; set; }

        public List<Passagem> Passagens { get; set; }

        public FormaPagamento FormaDePagamento { get; set; }

        public DateTime DataCompra { get; set; }


        public Compra()
        {
            id++;
            this.ID = id;

        }

        public Compra(Passageiro comprador, List<Passagem> passagens, FormaPagamento formaPagamento, DateTime dataCompra)
        {
            id++;
            this.ID = id;

            this.Comprador = comprador;

            this.Passagens = passagens;

            this.FormaDePagamento = formaPagamento;

            this.DataCompra = dataCompra;

        }

        public double CalcularValorTotal()
        {
            return Passagens.Sum(p => p.CalcularPreco());
            //codigo pra fazer os calculos do preço final das passagems

        }
    }
}
