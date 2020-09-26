﻿// <auto-generated />
using System;
using GerenciadorDeCondominio.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GerenciadorDeCondominio.Infrastructure.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20200926014619_criacaoDB")]
    partial class criacaoDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GerenciadorDeCondominios.Domain.Entidades.Aluguel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Ano")
                        .HasColumnType("int");

                    b.Property<int>("MesId")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("NUMERIC(10,2)");

                    b.HasKey("Id");

                    b.HasIndex("MesId");

                    b.ToTable("Alugueis");
                });

            modelBuilder.Entity("GerenciadorDeCondominios.Domain.Entidades.Apartamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Andar")
                        .HasColumnType("int");

                    b.Property<string>("Foto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MoradorId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("ProprietarioId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("MoradorId");

                    b.HasIndex("ProprietarioId");

                    b.ToTable("Apartamentos");
                });

            modelBuilder.Entity("GerenciadorDeCondominios.Domain.Entidades.Evento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("UsuarioId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Eventos");
                });

            modelBuilder.Entity("GerenciadorDeCondominios.Domain.Entidades.Funcao", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("Funcoes");

                    b.HasData(
                        new
                        {
                            Id = "056fa343-de42-4a20-8fa4-c9425d58486d",
                            ConcurrencyStamp = "3696fd33-ff1f-4b64-9d39-be4ed2daf0f5",
                            Descricao = "Morador do Prédio",
                            Name = "Morador",
                            NormalizedName = "MORADOR"
                        },
                        new
                        {
                            Id = "15dc607d-485a-4703-84d5-27f83c5f9144",
                            ConcurrencyStamp = "428c8c86-f6a1-45fd-bf3d-1818802ae9b1",
                            Descricao = "Síndico do Prédio",
                            Name = "Síndico",
                            NormalizedName = "SINDICO"
                        },
                        new
                        {
                            Id = "33d94ed5-aadc-474b-a578-c3e5d3018e58",
                            ConcurrencyStamp = "ff2eb531-0f9f-4bd1-90d2-b085452d8461",
                            Descricao = "Administrador do Prédio",
                            Name = "Administrador",
                            NormalizedName = "ADMINISTRADOR"
                        });
                });

            modelBuilder.Entity("GerenciadorDeCondominios.Domain.Entidades.HistoricoRecursos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Ano")
                        .HasColumnType("int");

                    b.Property<int>("Dia")
                        .HasColumnType("int");

                    b.Property<int>("MesId")
                        .HasColumnType("int");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("NUMERIC(10,2)");

                    b.HasKey("Id");

                    b.HasIndex("MesId")
                        .IsUnique();

                    b.ToTable("HistoricosRecursos");
                });

            modelBuilder.Entity("GerenciadorDeCondominios.Domain.Entidades.Mes", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.HasIndex("Nome")
                        .IsUnique();

                    b.ToTable("Meses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nome = "janeiro"
                        },
                        new
                        {
                            Id = 2,
                            Nome = "fevereiro"
                        },
                        new
                        {
                            Id = 3,
                            Nome = "março"
                        },
                        new
                        {
                            Id = 4,
                            Nome = "abril"
                        },
                        new
                        {
                            Id = 5,
                            Nome = "maio"
                        },
                        new
                        {
                            Id = 6,
                            Nome = "junho"
                        },
                        new
                        {
                            Id = 7,
                            Nome = "julho"
                        },
                        new
                        {
                            Id = 8,
                            Nome = "agosto"
                        },
                        new
                        {
                            Id = 9,
                            Nome = "setembro"
                        },
                        new
                        {
                            Id = 10,
                            Nome = "outubro"
                        },
                        new
                        {
                            Id = 11,
                            Nome = "novembro"
                        },
                        new
                        {
                            Id = 12,
                            Nome = "dezembro"
                        });
                });

            modelBuilder.Entity("GerenciadorDeCondominios.Domain.Entidades.Pagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AluguelId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Data")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("UsuarioId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("AluguelId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Pagamentos");
                });

            modelBuilder.Entity("GerenciadorDeCondominios.Domain.Entidades.Servico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("UsuarioId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("Valor")
                        .HasColumnType("NUMERIC(10,2)");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Servicos");
                });

            modelBuilder.Entity("GerenciadorDeCondominios.Domain.Entidades.ServicoPredio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataExecucao")
                        .HasColumnType("datetime2");

                    b.Property<int>("ServicoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ServicoId");

                    b.ToTable("ServicosPredio");
                });

            modelBuilder.Entity("GerenciadorDeCondominios.Domain.Entidades.Usuario", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("Foto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("PrimeiroAcesso")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("CPF")
                        .IsUnique();

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("GerenciadorDeCondominios.Domain.Entidades.Veiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cor")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("UsuarioId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("Placa")
                        .IsUnique();

                    b.HasIndex("UsuarioId");

                    b.ToTable("Veiculos");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("GerenciadorDeCondominios.Domain.Entidades.Aluguel", b =>
                {
                    b.HasOne("GerenciadorDeCondominios.Domain.Entidades.Mes", "Mes")
                        .WithMany("Alugueis")
                        .HasForeignKey("MesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GerenciadorDeCondominios.Domain.Entidades.Apartamento", b =>
                {
                    b.HasOne("GerenciadorDeCondominios.Domain.Entidades.Usuario", "Morador")
                        .WithMany("MoradorApartamentos")
                        .HasForeignKey("MoradorId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("GerenciadorDeCondominios.Domain.Entidades.Usuario", "Proprietario")
                        .WithMany("ProprietarioApartamentos")
                        .HasForeignKey("ProprietarioId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("GerenciadorDeCondominios.Domain.Entidades.Evento", b =>
                {
                    b.HasOne("GerenciadorDeCondominios.Domain.Entidades.Usuario", "Usuario")
                        .WithMany("Eventos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GerenciadorDeCondominios.Domain.Entidades.HistoricoRecursos", b =>
                {
                    b.HasOne("GerenciadorDeCondominios.Domain.Entidades.Mes", "Mes")
                        .WithMany("HistoricoRecurso")
                        .HasForeignKey("MesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GerenciadorDeCondominios.Domain.Entidades.Pagamento", b =>
                {
                    b.HasOne("GerenciadorDeCondominios.Domain.Entidades.Aluguel", "Aluguel")
                        .WithMany("Pagamentos")
                        .HasForeignKey("AluguelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GerenciadorDeCondominios.Domain.Entidades.Usuario", "Usuario")
                        .WithMany("Pagamentos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GerenciadorDeCondominios.Domain.Entidades.Servico", b =>
                {
                    b.HasOne("GerenciadorDeCondominios.Domain.Entidades.Usuario", "Usuario")
                        .WithMany("Servicos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GerenciadorDeCondominios.Domain.Entidades.ServicoPredio", b =>
                {
                    b.HasOne("GerenciadorDeCondominios.Domain.Entidades.Servico", "Servico")
                        .WithMany("ServicosPredio")
                        .HasForeignKey("ServicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GerenciadorDeCondominios.Domain.Entidades.Veiculo", b =>
                {
                    b.HasOne("GerenciadorDeCondominios.Domain.Entidades.Usuario", "Usuario")
                        .WithMany("Veiculos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("GerenciadorDeCondominios.Domain.Entidades.Funcao", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("GerenciadorDeCondominios.Domain.Entidades.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("GerenciadorDeCondominios.Domain.Entidades.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("GerenciadorDeCondominios.Domain.Entidades.Funcao", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GerenciadorDeCondominios.Domain.Entidades.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("GerenciadorDeCondominios.Domain.Entidades.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
