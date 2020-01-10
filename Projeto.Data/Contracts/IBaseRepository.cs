using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Data.Contracts
{
    public interface IBaseRepository <T>
        where T : class
    {
        void Inserir(T obj);
        void Alterar(T obj);
        void Excluir(int Id);
        List<T> PesquisarTodos();
        T PesquisarId(int Id);
    }
}
