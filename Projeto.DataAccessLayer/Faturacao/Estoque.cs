using Projeto.DataAccessLayer.Entidades.Produtos;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto.DataAccessLayer.Faturacao
{
    public class Estoque
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public List<Produto> ProdutosParaVenda { get; set; }
    }
}
