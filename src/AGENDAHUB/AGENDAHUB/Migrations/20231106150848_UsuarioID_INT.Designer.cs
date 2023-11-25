﻿// <auto-generated />
using System;
using AGENDAHUB.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AGENDAHUB.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231106150848_UsuarioID_INT")]
    partial class UsuarioID_INT
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.23")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AGENDAHUB.Models.Agendamentos", b =>
                {
                    b.Property<int>("ID_Agendamentos")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_Agendamentos"), 1L, 1);

                    b.Property<DateTime>("Data")
                        .HasColumnType("date");

                    b.Property<TimeSpan>("Hora")
                        .HasColumnType("time");

                    b.Property<int>("ID_Cliente")
                        .HasColumnType("int");

                    b.Property<int>("ID_Profissional")
                        .HasColumnType("int");

                    b.Property<int>("ID_Servico")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioID")
                        .HasColumnType("int");

                    b.HasKey("ID_Agendamentos");

                    b.HasIndex("ID_Cliente");

                    b.HasIndex("ID_Profissional");

                    b.HasIndex("ID_Servico");

                    b.HasIndex("UsuarioID");

                    b.ToTable("Agendamentos");
                });

            modelBuilder.Entity("AGENDAHUB.Models.Clientes", b =>
                {
                    b.Property<int>("ID_Cliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_Cliente"), 1L, 1);

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contato")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsuarioID")
                        .HasColumnType("int");

                    b.HasKey("ID_Cliente");

                    b.HasIndex("UsuarioID");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("AGENDAHUB.Models.Configuracao", b =>
                {
                    b.Property<int>("ID_Configuracao")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_Configuracao"), 1L, 1);

                    b.Property<string>("Cnpj")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DiaDaSemana")
                        .HasColumnType("int");

                    b.Property<string>("Endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("HoraFim")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("HoraInicio")
                        .HasColumnType("time");

                    b.Property<string>("NomeEmpresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UsuarioID")
                        .HasColumnType("int");

                    b.Property<string>("_Email")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID_Configuracao");

                    b.HasIndex("UsuarioID")
                        .IsUnique();

                    b.ToTable("Configuracao");
                });

            modelBuilder.Entity("AGENDAHUB.Models.Profissionais", b =>
                {
                    b.Property<int>("ID_Profissional")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_Profissional"), 1L, 1);

                    b.Property<string>("CPF")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("Cargo")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Senha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<int>("UsuarioID")
                        .HasColumnType("int");

                    b.HasKey("ID_Profissional");

                    b.HasIndex("UsuarioID");

                    b.ToTable("Profissionais");
                });

            modelBuilder.Entity("AGENDAHUB.Models.Servicos", b =>
                {
                    b.Property<int>("ID_Servico")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID_Servico"), 1L, 1);

                    b.Property<int>("ID_Profissional")
                        .HasColumnType("int");

                    b.Property<byte[]>("Imagem")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18,2)");

                    b.Property<TimeSpan>("TempoDeExecucao")
                        .HasColumnType("time");

                    b.Property<int>("UsuarioID")
                        .HasColumnType("int");

                    b.HasKey("ID_Servico");

                    b.HasIndex("ID_Profissional");

                    b.HasIndex("UsuarioID");

                    b.ToTable("Servicos");
                });

            modelBuilder.Entity("AGENDAHUB.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Cnpj")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DiaDaSemana")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("HoraFim")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("HoraInicio")
                        .HasColumnType("time");

                    b.Property<string>("NomeEmpresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeUsuario")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Perfil")
                        .HasColumnType("int");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("_Email")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("NomeUsuario")
                        .IsUnique();

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("AGENDAHUB.Models.Agendamentos", b =>
                {
                    b.HasOne("AGENDAHUB.Models.Clientes", "Cliente")
                        .WithMany()
                        .HasForeignKey("ID_Cliente")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AGENDAHUB.Models.Profissionais", "Profissionais")
                        .WithMany()
                        .HasForeignKey("ID_Profissional")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AGENDAHUB.Models.Servicos", "Servicos")
                        .WithMany()
                        .HasForeignKey("ID_Servico")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AGENDAHUB.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Profissionais");

                    b.Navigation("Servicos");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("AGENDAHUB.Models.Clientes", b =>
                {
                    b.HasOne("AGENDAHUB.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("AGENDAHUB.Models.Configuracao", b =>
                {
                    b.HasOne("AGENDAHUB.Models.Usuario", "Usuario")
                        .WithOne("Configuracao")
                        .HasForeignKey("AGENDAHUB.Models.Configuracao", "UsuarioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("AGENDAHUB.Models.Profissionais", b =>
                {
                    b.HasOne("AGENDAHUB.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("AGENDAHUB.Models.Servicos", b =>
                {
                    b.HasOne("AGENDAHUB.Models.Profissionais", "Profissional")
                        .WithMany()
                        .HasForeignKey("ID_Profissional")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AGENDAHUB.Models.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("UsuarioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Profissional");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("AGENDAHUB.Models.Usuario", b =>
                {
                    b.Navigation("Configuracao");
                });
#pragma warning restore 612, 618
        }
    }
}