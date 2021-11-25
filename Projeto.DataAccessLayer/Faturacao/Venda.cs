using Projeto.DataAccessLayer.Entidades;
using Projeto.DataAccessLayer.Entidades.Pessoas;
using System;


namespace Projeto.DataAccessLayer.Faturacao
{
    public class Venda
    {
        public Usuario Vendedor { get; set; }
        public Cliente Cliente { get; set; }
        public PontoDeVenda PontoDeVenda { get; set; }
        public DateTime DataHoraVenda { get; set; }
        public int NumeroSerie { get; set; }
        public TipoPagamento TipoPagamento { get; set; }
        public decimal ValorPagamento { get; set; }
        public DetalheVenda DetalheVenda { get; set; }
    }
}
