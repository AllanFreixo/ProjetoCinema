using Projeto.Data.Context;
using Projeto.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Data.Repository
{
    public class UnityOfWork : IUnityOfWork
    {
        private readonly DataContext context;
        public UnityOfWork(DataContext context)
        {
            this.context = context;
        }

        public IFilmeRepository FilmeRepository => new FilmeRepository(context);

        public IClienteRepository ClienteRepository => new ClienteRepository(context);

        public IIngressoRepository IngressoReposioty => new IngressoRepository(context);
    }
}
