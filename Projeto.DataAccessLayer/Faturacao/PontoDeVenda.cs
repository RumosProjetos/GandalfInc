using Projeto.DataAccessLayer.Entidades.Pessoas;
using System;

namespace Projeto.DataAccessLayer.Faturacao
{
    public class PontoDeVenda
    {
        public Guid Identificador { get; set; }
        public Loja Loja { get; set; }
    }
}
