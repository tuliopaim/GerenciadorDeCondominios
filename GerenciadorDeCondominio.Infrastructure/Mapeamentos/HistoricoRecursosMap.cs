using System;
using System.Collections.Generic;
using System.Text;
using GerenciadorDeCondominios.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GerenciadorDeCondominio.Infrastructure.Mapeamentos
{
    public class HistoricoRecursosMap : IEntityTypeConfiguration<HistoricoRecursos>
    {
        public void Configure(EntityTypeBuilder<HistoricoRecursos> builder)
        {
            builder.HasKey(v => v.Id);

            builder.Property(h => h.Valor).IsRequired();
            builder.Property(h => h.Tipo).IsRequired();
            builder.Property(h => h.Dia).IsRequired();
            builder.Property(h => h.Ano).IsRequired();
            builder.HasIndex(h => h.MesId).IsUnique();

            builder.HasOne(h => h.Mes)
                .WithMany(h => h.HistoricoRecurso)
                .HasForeignKey(h => h.MesId);

            builder.ToTable("HistoricoRecursos");

        }
    }
}
