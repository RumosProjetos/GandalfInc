using Projeto.DataAccessLayer.Entidades.Pessoas;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto.DataAccessLayer.Entidades.Produtos
{
    [Table("Produto")]
    public class Produto : Entidade
    {
        [Display(Name = "Preço Unitário")]
        public decimal PrecoUnitario { get; set; }
        public string Fabricante { get; set; }
        public Fornecedor Fornecedor { get; set; }
        
        [Display(Name = "Categoria do Produto")]
        public CategoriaProduto CategoriaProduto { get; set; }

        [Display(Name = "Referência Internacional do Produto")]
        [MaxLength(15)]
        public string ReferenciaInternacionalProduto { get; set; } //EAN

        [Display(Name = "Número de Série")]
        public string NumeroSerie { get; set; }
    }
}
