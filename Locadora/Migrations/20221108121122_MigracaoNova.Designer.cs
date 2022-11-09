﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using locadora;

#nullable disable

namespace ProjetoLocadora.Migrations
{
    [DbContext(typeof(BaseDados))]
    [Migration("20221108121122_MigracaoNova")]
    partial class MigracaoNova
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.0");

            modelBuilder.Entity("locadora.Alocar", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("dataAlocacao")
                        .HasColumnType("TEXT");

                    b.Property<string>("dataDevolucao")
                        .HasColumnType("TEXT");

                    b.Property<int>("idFilme")
                        .HasColumnType("INTEGER");

                    b.Property<int>("idUsuario")
                        .HasColumnType("INTEGER");

                    b.Property<string>("nomeFilme")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("nomeUsuario")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("statusAloc")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Alocacoes");
                });

            modelBuilder.Entity("locadora.Filme", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("classIndicativa")
                        .HasColumnType("INTEGER");

                    b.Property<string>("dataLancamento")
                        .HasColumnType("TEXT");

                    b.Property<string>("diretor")
                        .HasColumnType("TEXT");

                    b.Property<string>("genero")
                        .HasColumnType("TEXT");

                    b.Property<string>("nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("statusFilme")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Filmes");
                });

            modelBuilder.Entity("locadora.Usuario", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("dataCadastro")
                        .HasColumnType("TEXT");

                    b.Property<string>("endereco")
                        .HasColumnType("TEXT");

                    b.Property<int>("idade")
                        .HasColumnType("INTEGER");

                    b.Property<string>("nome")
                        .HasColumnType("TEXT");

                    b.Property<string>("telefone")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
