using GerenciadorDeCondominios.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorDeCondominios.Infrastructure.Mapeamentos
{
    public class PagamentoMap : IEntityTypeConfiguration<Pagamento>
    {
        public void Configure(EntityTypeBuilder<Pagamento> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Status).IsRequired();
            builder.Property(p => p.AluguelId).IsRequired();
            builder.Property(p => p.UsuarioId).IsRequired();

            builder.HasOne(p => p.Aluguel)
                .WithMany(p => p.Pagamentos)
                .HasForeignKey(p => p.AluguelId);

            builder.HasOne(p => p.Usuario)
                .WithMany(p => p.Pagamentos)
                .HasForeignKey(p => p.UsuarioId);

            builder.ToTable("Pagamentos");

        }
    }
}
