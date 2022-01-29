using Projeto.DataAccessLayer.Entidades.Pessoas;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto.DataAccessLayer.Faturacao
{
    public class PontoDeVenda
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public Loja Loja { get; set; }
    }
}
