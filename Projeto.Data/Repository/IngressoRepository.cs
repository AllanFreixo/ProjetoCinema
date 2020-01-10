using Projeto.Data.Context;
using Projeto.Data.Contracts;
using Projeto.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Data.Repository
{
    public class IngressoRepository : BaseRepository<Ingresso>, IIngressoRepository
    {
        private readonly DataContext context;

        public IngressoRepository(DataContext context) : base(context)
        {
            this.context = context;
        }
    }
}
