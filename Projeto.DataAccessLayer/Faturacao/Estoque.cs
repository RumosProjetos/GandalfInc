using Projeto.DataAccessLayer.Entidades.Produtos;
using System.Collections.Generic;


namespace Projeto.DataAccessLayer.Faturacao
{
    public class Estoque
    {
        public List<Produto> ProdutosParaVenda { get; set; }
    }
}
