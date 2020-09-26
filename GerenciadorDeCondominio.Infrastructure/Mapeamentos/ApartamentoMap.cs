using GerenciadorDeCondominios.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorDeCondominio.Infrastructure.Mapeamentos
{
    public class ApartamentoMap : IEntityTypeConfiguration<Apartamento>
    {
        public void Configure(EntityTypeBuilder<Apartamento> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Numero).IsRequired();
            builder.Property(a => a.Andar).IsRequired();
            builder.Property(a => a.Foto).IsRequired();
            builder.Property(a => a.ProprietarioId).IsRequired();
            builder.Property(a => a.MoradorId).IsRequired();

            builder.HasOne(a => a.Proprietario)
                .WithMany(a => a.ProprietarioApartamentos)
                .HasForeignKey(a => a.ProprietarioId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.HasOne(a => a.Morador)
                .WithMany(a => a.MoradorApartamentos)
                .HasForeignKey(a => a.MoradorId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.ToTable("Apartamentos");
        }
    }
}
