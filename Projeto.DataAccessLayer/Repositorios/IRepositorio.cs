using System;
using System.Collections.Generic;

namespace Projeto.DataAccessLayer.Repositorios
{
    public interface IRepositorio<T>
    {
        void Criar(T t);
        T ObterPorIdentificador(Guid guid);
        T ObterPorNome(string nome);
        List<T> ListarTodos();
        void Atualizar(Guid id, T novosDados);
        void Apagar(T t);
    }
}
