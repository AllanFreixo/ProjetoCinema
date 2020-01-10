using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Data.Mapping
{
    public class FilmeMap : IEntityTypeConfiguration<Filme>
    {
        public void Configure(EntityTypeBuilder<Filme> builder)
        {
            #region Nome Tabela
            builder.ToTable("Filme");
            #endregion

            #region Chave Primária
            builder.HasKey("IdFilme");

            #endregion

            #region Campos da Tabela
            builder.Property(f => f.IdFilme)
                .HasColumnName("IdFilme")
                .IsRequired();
            builder.Property(f => f.Genero)
                .HasColumnName("Genero")
                .HasMaxLength(150);

            builder.Property(f => f.Sinopse)
                .HasColumnName("Sinopse")
                .HasMaxLength(250);

            builder.Property(f => f.Titulo)
                .HasColumnName("Titulo")
                .HasMaxLength(100);

            #endregion

        }
    }
}
