using GerenciadorDeCondominios.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorDeCondominios.Infrastructure.Mapeamentos
{
    public class ServicoPredioMap : IEntityTypeConfiguration<ServicoPredio>
    {
        public void Configure(EntityTypeBuilder<ServicoPredio> builder)
        {
            builder.HasKey(s => s.Id);

            builder.Property(s => s.ServicoId).IsRequired();
            builder.Property(s => s.DataExecucao).IsRequired();

            builder.HasOne(s => s.Servico)
                .WithMany(s => s.ServicosPredio)
                .HasForeignKey(s => s.ServicoId);

            builder.ToTable("ServicosPredio");
        }
    }
}
