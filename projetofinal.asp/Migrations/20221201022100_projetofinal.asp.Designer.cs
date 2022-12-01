﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using projetofinal.asp.Models;

#nullable disable

namespace projetofinal.asp.Migrations
{
    [DbContext(typeof(BancoDeDados))]
    [Migration("20221201022100_projetofinal.asp")]
    partial class projetofinalasp
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("projetofinal.asp.Models.Consumidor", b =>
                {
                    b.Property<string>("ConsumidorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.ToTable("Consumidors");
                });

            modelBuilder.Entity("projetofinal.asp.Models.Pagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Valor")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Pagamentos");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Pagamento");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("projetofinal.asp.Models.Pedido", b =>
                {
                    b.Property<int>("PedidoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PedidoId"));

                    b.HasKey("PedidoId");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("projetofinal.asp.Models.Produto", b =>
                {
                    b.Property<int>("ProdutoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProdutoID"));

                    b.Property<string>("Descrição")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PedidoId")
                        .HasColumnType("int");

                    b.HasKey("ProdutoID");

                    b.HasIndex("PedidoId");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("projetofinal.asp.Models.Boleto", b =>
                {
                    b.HasBaseType("projetofinal.asp.Models.Pagamento");

                    b.Property<int>("CodigoBoleto")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Boleto");
                });

            modelBuilder.Entity("projetofinal.asp.Models.CartãoCredito", b =>
                {
                    b.HasBaseType("projetofinal.asp.Models.Pagamento");

                    b.Property<int>("NumeroCartao")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("CartãoCredito");
                });

            modelBuilder.Entity("projetofinal.asp.Models.Produto", b =>
                {
                    b.HasOne("projetofinal.asp.Models.Pedido", null)
                        .WithMany("Itens")
                        .HasForeignKey("PedidoId");
                });

            modelBuilder.Entity("projetofinal.asp.Models.Pedido", b =>
                {
                    b.Navigation("Itens");
                });
#pragma warning restore 612, 618
        }
    }
}
