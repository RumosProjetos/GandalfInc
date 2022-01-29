using Projeto.DataAccessLayer.Entidades.Produtos;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto.DataAccessLayer.Faturacao
{
    public class DetalheVenda
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public List<Produto> Produtos { get; set; }
    }
}