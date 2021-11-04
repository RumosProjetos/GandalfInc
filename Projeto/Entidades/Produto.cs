using System;

namespace Projeto.Lib.Entidades
{
    public class Produto : Entidade
    {
        public decimal PrecoUnitario { get; set; }        
        public string Fabricante { get; set; }
        public Fornecedor Fornecedor { get; set; }
        public CategoriaProduto CategoriaProduto { get; set; }
        public bool Ativo { get; set; }
        public string ReferenciaInternacionalProduto { get; set; } //EAN
    }
}
