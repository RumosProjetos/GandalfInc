using Projeto.DataAccessLayer.Entidades.Produtos;
using System.Collections.Generic;

namespace Projeto.DataAccessLayer.Faturacao
{
    public class DetalheVenda
    {
        public List<Produto> Produtos { get; set; }
    }
}