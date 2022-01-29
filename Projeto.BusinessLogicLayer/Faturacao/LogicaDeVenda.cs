using Projeto.DataAccessLayer.Faturacao;
using Projeto.Lib.Infraestrutura;
using System.Text;

namespace Projeto.Lib.Faturacao
{
    public class LogicaDeVenda : IImpressora
    {
        private Venda _venda { get; set; }
        public LogicaDeVenda(Venda  venda)
        {
            _venda = venda;
        }

        public void GerarRecibo()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Fatura Recibo FRD {_venda.DataHoraVenda.Year}/{_venda.NumeroSerie}");
            sb.AppendLine($"Loja: {_venda.PontoDeVenda.Loja.NumeroFiscal} - Ponto de Venda: {_venda.PontoDeVenda.Id} ");
            sb.AppendLine($"Loja: {_venda.PontoDeVenda.Loja.Endereco}");
            sb.AppendLine($"Vendedor: {_venda.Vendedor.Nome} Identificador: {_venda.Vendedor.Identificador} ");
            sb.AppendLine($"Data da Fatura/Recibo: {_venda.DataHoraVenda} ");
            sb.AppendLine($"Tipo Pagamento: {_venda.TipoPagamento} "); //TODO: TRocar enumerador por string
            sb.AppendLine($"Valor Pagamento: {_venda.ValorPagamento} ");
            foreach (var item in _venda.DetalheVenda.Produtos)
            {
                sb.AppendLine($"Nome: {item.Nome}  - Valor Unitario: {item.PrecoUnitario} - Número de Série: {item.NumeroSerie}");
            }

            //Poderíamos escrever usando a notação LINQ
            //DetalheVenda.Produtos.Select(x => sb.AppendLine($"Nome: {x.Nome}  - Valor Unitario: {x.PrecoUnitario} - Número de Série: {x.NumeroSerie}"))
        }
    }
}
