using GerenciadorDeCondominio.Infrastructure.Mapeamentos;
using GerenciadorDeCondominios.Domain.Entidades;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorDeCondominio.Infrastructure
{
    public class Contexto : IdentityDbContext<Usuario, Funcao, string>
    {
        public Contexto(DbContextOptions<Contexto> opcoes) : base(opcoes)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new AluguelMap());
            builder.ApplyConfiguration(new ApartamentoMap());
            builder.ApplyConfiguration(new EventoMap());
            builder.ApplyConfiguration(new FuncaoMap());
            builder.ApplyConfiguration(new HistoricosRecursosMap());
            builder.ApplyConfiguration(new MesMap());
            builder.ApplyConfiguration(new PagamentoMap());
            builder.ApplyConfiguration(new ServicoMap());
            builder.ApplyConfiguration(new ServicoPredioMap());
            builder.ApplyConfiguration(new UsuarioMap());
            builder.ApplyConfiguration(new VeiculoMap());
        }

        public DbSet<Aluguel> Alugueis { get; set; }
        public DbSet<Apartamento> Apartamentos { get; set; }
        public DbSet<Evento> Eventos { get; set; }
        public DbSet<Funcao> Funcoes { get; set; }
        public DbSet<HistoricoRecursos> HistoricosRecursos { get; set; }
        public DbSet<Mes> Meses { get; set; }
        public DbSet<Pagamento> Pagamentos { get; set; }
        public DbSet<Servico> Servicos { get; set; }
        public DbSet<ServicoPredio> ServicosPredio { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }

    }
}
