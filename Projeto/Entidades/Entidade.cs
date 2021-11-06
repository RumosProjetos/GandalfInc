using System;

namespace Projeto.Lib.Entidades
{
    public abstract class Entidade
    {
        public Guid Identificador { get; set; }
        public string Nome { get; set; }
        public DateTime DataAlteracao { get; set; }
        public bool Ativo { get; set; }

        public Entidade()
        {
            DataAlteracao = DateTime.Now;
            Identificador = Guid.NewGuid();
            Ativo = true;
        }
    }
}