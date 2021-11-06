using System;
using System.Collections.Generic;

namespace Projeto.Lib.Repositorios
{
    public interface IRepositorio<T>
    {
        void Criar(T t);
        T ObterPorIdentificador(Guid guid);
        T ObterPorNome(string nome);
        List<T> ListarTodos();
        void Atualizar(T t, T novosDados);
        void Apagar(T t);
    }
}
