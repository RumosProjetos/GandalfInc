using Projeto.Lib.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Projeto.Lib.Repositorios
{
    public class RepositorioEntidade : IRepositorio<Entidade>
    {
        private readonly List<Entidade> entidades;
        public RepositorioEntidade()
        {
            entidades = new List<Entidade>();
        }

        public void Criar(Entidade t)
        {
            entidades.Add(t);
        }
        public void Apagar(Entidade t)
        {
            entidades.Remove(t);
        }

        public void Atualizar(Entidade t, Entidade novosDados)
        {
            var temp = t.Identificador;
            t = novosDados;
            t.Identificador = temp;
        }

        public List<Entidade> ListarTodos()
        {
            return entidades;
        }

        public Entidade ObterPorIdentificador(Guid guid)
        {
            return entidades.FirstOrDefault(x => x.Identificador == guid);
        }

        public Entidade ObterPorNome(string nome)
        {
            return entidades.FirstOrDefault(x => x.Nome == nome);
        }
    }
}
