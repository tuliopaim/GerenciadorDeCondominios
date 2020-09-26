using GerenciadorDeCondominios.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorDeCondominio.Infrastructure.Mapeamentos
{
    public class MesMap : IEntityTypeConfiguration<Mes>
    {
        public void Configure(EntityTypeBuilder<Mes> builder)
        {
            builder.HasKey(m => m.Id);
            builder.Property(m => m.Id).ValueGeneratedNever();

            builder.Property(m => m.Nome).IsRequired().HasMaxLength(30);
            builder.HasIndex(m => m.Nome).IsUnique();

            builder.HasMany(m => m.Alugueis).WithOne(m => m.Mes);
            builder.HasMany(m => m.HistoricoRecurso).WithOne(m => m.Mes);

            builder.ToTable("Meses");

            builder.HasData(
                new Mes
                {
                    Id = 1,
                    Nome = "janeiro"
                },
                new Mes
                {
                    Id = 2,
                    Nome = "fevereiro"
                },
                new Mes
                {
                    Id = 3,
                    Nome = "março"
                },
                new Mes
                {
                    Id = 4,
                    Nome = "abril"
                },
                new Mes
                {
                    Id = 5,
                    Nome = "maio"
                },
                new Mes
                {
                    Id = 6,
                    Nome = "junho"
                },
                new Mes
                {
                    Id = 7,
                    Nome = "julho"
                },
                new Mes
                {
                    Id = 8,
                    Nome = "agosto"
                },
                new Mes
                {
                    Id = 9,
                    Nome = "setembro"
                },
                new Mes
                {
                    Id = 10,
                    Nome = "outubro"
                },
                new Mes
                {
                    Id = 11,
                    Nome = "novembro"
                },
                new Mes
                {
                    Id = 12,
                    Nome = "dezembro"
                });
        }
        
    }
}
