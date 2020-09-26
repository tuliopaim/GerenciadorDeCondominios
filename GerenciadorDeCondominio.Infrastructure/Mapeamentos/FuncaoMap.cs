﻿using GerenciadorDeCondominios.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorDeCondominios.Infrastructure.Mapeamentos
{
    public class FuncaoMap : IEntityTypeConfiguration<Funcao>
    {
        public void Configure(EntityTypeBuilder<Funcao> builder)
        {
            builder.Property(f => f.Id).ValueGeneratedOnAdd();
            builder.Property(f => f.Descricao).IsRequired().HasMaxLength(30);

            builder.HasData(new Funcao
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Morador",
                NormalizedName = "MORADOR",
                Descricao = "Morador do Prédio"
            }, 
            new Funcao
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Síndico",
                NormalizedName = "SINDICO",
                Descricao = "Síndico do Prédio"
            },
            new Funcao
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Administrador",
                NormalizedName = "ADMINISTRADOR",
                Descricao = "Administrador do Prédio"
            });

            builder.ToTable("Funcoes");
        }
    }
}
