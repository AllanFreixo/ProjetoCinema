using Projeto.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using Projeto.Data.Contracts;
using Projeto.Data.Context;

namespace Projeto.Data.Repository
{
    public class FilmeRepository
        : BaseRepository<Filme>, IFilmeRepository
    {
        private readonly DataContext context;

        public FilmeRepository(DataContext context) : base(context)
        {
            this.context = context;
        }
    }
}
