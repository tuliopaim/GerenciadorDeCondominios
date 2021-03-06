﻿using GerenciadorDeCondominios.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorDeCondominios.Infrastructure.Mapeamentos
{
    public class ServicoMap : IEntityTypeConfiguration<Servico>
    {
        public void Configure(EntityTypeBuilder<Servico> builder)
        {
            builder.HasKey(s => s.Id);

            builder.Property(s => s.Nome).IsRequired().HasMaxLength(30);
            builder.Property(s => s.Valor).IsRequired().HasColumnType("NUMERIC(10,2)");
            builder.Property(s => s.Status).IsRequired();
            builder.Property(s => s.UsuarioId).IsRequired();

            builder.HasOne(s => s.Usuario)
                .WithMany(s => s.Servicos)
                .HasForeignKey(s => s.UsuarioId);

            builder.HasMany(s => s.ServicosPredio)
                .WithOne(s => s.Servico);

            builder.ToTable("Servicos");
        }
    }
}
