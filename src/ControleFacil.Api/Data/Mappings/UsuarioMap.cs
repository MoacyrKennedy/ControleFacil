using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleFacil.Api.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleFacil.Api.Data.Mappings
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Usuario> builder)
        {
           builder.ToTable("Usuario")
           .HasKey(p => p.Id);

            builder.Property(p => p.Email)
            .HasColumnType("varchar")
            .IsRequired();

            builder.Property(p => p.Senha)
            .HasColumnType("varchar")
            .IsRequired();

            builder.Property(p => p.DataCadastro)
            .HasColumnType("timestamp")
            .IsRequired();

              builder.Property(p => p.DataInativacao)
            .HasColumnType("timestamp");
        }
    }
}