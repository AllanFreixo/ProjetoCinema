using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto.Data.Entity;

namespace Projeto.Data.Mapping
{
    public class ClienteMap : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            #region Nome da Tabela
            builder.ToTable("Cliente");
            #endregion

            #region Chave Primaria
            builder.HasKey(c => c.IdCliente);
            #endregion

            #region Campos da Tabela
            builder.Property(c => c.IdCliente)
                .HasColumnName("IdCliente");

            builder.Property(c => c.Nome)
               .HasColumnName("Nome")
               .HasMaxLength(150)
               .IsRequired();

            builder.Property(c => c.CPF)
               .HasColumnName("CPF")
               .HasMaxLength(25)
               .IsRequired();

            builder.Property(c => c.Email)
               .HasColumnName("Email")
               .HasMaxLength(150)
               .IsRequired();
            #endregion

        }
    }
}
