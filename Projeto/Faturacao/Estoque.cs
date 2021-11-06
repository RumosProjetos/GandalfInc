using Projeto.Lib.Entidades.Produtos;
using System.Collections.Generic;
using System.Linq;

namespace Projeto.Lib.Faturacao
{
    public class Estoque
    {
        public List<Produto> ProdutosParaVenda { get; set; }

        public bool ValidarDisponibilidade(List<Produto> produtosSolicitados)
        {
            var quantidadePorProduto = produtosSolicitados
                .GroupBy(x => x.Nome)
                .Select(x =>
                    new
                    {
                        Nome = x.Key,
                        Quantidade = x.Count()
                    }
                ).ToList();


            //Impedir "devolucao de produto"
            var existeAlgumItemComValorInvalido = quantidadePorProduto.Any(x => x.Quantidade <= 0);
            if (existeAlgumItemComValorInvalido || produtosSolicitados.Count <= 0)
            {
                return false;
            }


            foreach (var produtoNoPedido in quantidadePorProduto)
            {
                //Usei nome apenas para simplificar
                var quantidadeEmEstoque = ProdutosParaVenda.Where(x => x.Nome == produtoNoPedido.Nome).Count();
                if (produtoNoPedido.Quantidade > quantidadeEmEstoque)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
