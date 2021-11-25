using System;

namespace Projeto.DataAccessLayer.Entidades
{
    public abstract class Entidade
    {
        public Guid Identificador { get; set; }
        public string Nome { get; set; }
        public DateTime DataAlteracao { get; set; }
        public bool Ativo { get; set; }

        protected Entidade()
        {
            DataAlteracao = DateTime.Now;
            Identificador = Guid.NewGuid();
            Ativo = true;
        }
    }
}