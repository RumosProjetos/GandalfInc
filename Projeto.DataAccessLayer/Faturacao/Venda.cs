using Projeto.DataAccessLayer.Entidades;
using Projeto.DataAccessLayer.Entidades.Pessoas;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto.DataAccessLayer.Faturacao
{
    public class Venda
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public Usuario Vendedor { get; set; }
        public Cliente Cliente { get; set; }
        public PontoDeVenda PontoDeVenda { get; set; }
        public DateTime DataHoraVenda { get; set; }
        public int NumeroSerie { get; set; }

        [NotMapped]
        public TipoPagamento TipoPagamento { get; set; }


        private string _tipoPagamentoDescricao;

        public string TipoPagamentoDescricao
        {
            get { return _tipoPagamentoDescricao; }
            set {
                string resultado = "";
                switch (TipoPagamento)
                {
                    case TipoPagamento.Indefinido:
                        resultado = "";
                        break;
                    case TipoPagamento.Multibanco:
                        resultado = "Multibanco";
                        break;
                    case TipoPagamento.Dinheiro:
                        resultado = "Dinheiro";
                        break;
                    case TipoPagamento.MbWay:
                        resultado = "MbWay";
                        break;
                    default:
                        break;
                }

                _tipoPagamentoDescricao = resultado; 
            }
        }



        public decimal ValorPagamento { get; set; }
        public DetalheVenda DetalheVenda { get; set; }
    }
}
