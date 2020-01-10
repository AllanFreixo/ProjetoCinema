using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Data.Mapping
{
    public class IngressoMap : IEntityTypeConfiguration<Ingresso>
    {
        public void Configure(EntityTypeBuilder<Ingresso> builder)
        {
            #region Nome da Tabela
            builder.ToTable("Ingresso");
            #endregion

            #region Chave Primaria
            builder.HasKey(i => i.IdIngresso);
            #endregion

            #region Campos da Tabela
            builder.Property(i => i.IdIngresso)
                .HasColumnName("IdIngresso");

            builder.Property(i => i.DataSessao)
               .HasColumnName("DataSessao")
               .IsRequired();

            builder.Property(i => i.IdCliente)
               .HasColumnName("IdCliente")
               .IsRequired();
               

            builder.Property(i => i.IdFilme)
               .HasColumnName("IdFilme")
               .IsRequired();

            builder.Property(i => i.Preco)
               .HasColumnName("Preco")
               .HasColumnType("decimal(18,2)")
               .IsRequired();

            builder.Property(i => i.SalaCinema)
               .HasColumnName("SalaCinema")
               .HasMaxLength(150)
               .IsRequired();

            #endregion


            #region Chave Estangeiras

            builder.HasOne(i => i.Cliente)
               .WithMany(c => c.Ingresso)
               .HasForeignKey(i => i.IdCliente);

            builder.HasOne(i => i.Filme)
               .WithMany(f => f.Ingresso)
               .HasForeignKey(i => i.IdFilme);

            #endregion
        }
    }
}

   
