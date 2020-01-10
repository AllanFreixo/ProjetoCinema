using Projeto.Data.Context;
using Projeto.Data.Contracts;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Text;
using System.Linq;

namespace Projeto.Data.Repository
{
    public class BaseRepository<T> : IBaseRepository<T>
        where T : class
    {
        private readonly DataContext context;

        public BaseRepository(DataContext context)
        {
            this.context = context;
        }

        public void Alterar(T obj)
        {
            context.Entry(obj).State = EntityState.Modified;
            context.SaveChanges();

        }

        public void Excluir(int Id)
        {
            var obj = context.Set<T>().Find(Id);
            context.Entry(obj).State = EntityState.Deleted;
            context.SaveChanges();
               
        }

        public void Inserir(T obj)
        {
            context.Entry(obj).State = EntityState.Added;
            context.SaveChanges();
        }

        public T PesquisarId(int Id)
        {
            return context.Set<T>().Find(Id);
        }

        public List<T> PesquisarTodos()
        {
            return context.Set<T>().ToList();
        }
    }
}
