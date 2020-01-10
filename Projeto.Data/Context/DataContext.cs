using Microsoft.EntityFrameworkCore;
using Projeto.Data.Entity;
using Projeto.Data.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Data.Context
{
    
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
    
            modelBuilder.ApplyConfiguration(new ClienteMap());
            modelBuilder.ApplyConfiguration(new IngressoMap());
            modelBuilder.ApplyConfiguration(new FilmeMap());
        }

    
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Ingresso> Ingresso { get; set; }
        public DbSet<Filme> Filme { get; set; }
    }
}
