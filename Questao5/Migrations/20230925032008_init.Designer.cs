﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Questao5.Data;

#nullable disable

namespace Questao5.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230925032008_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("ContaCorrente", b =>
                {
                    b.Property<string>("IdContaCorrente")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Ativo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Numero")
                        .HasColumnType("INTEGER");

                    b.HasKey("IdContaCorrente");

                    b.ToTable("ContasCorrentes");
                });

            modelBuilder.Entity("Movimento", b =>
                {
                    b.Property<string>("IdMovimento")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("DataMovimento")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("datamovimento");

                    b.Property<string>("IdContaCorrente")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<char>("TipoMovimento")
                        .HasColumnType("TEXT")
                        .HasColumnName("tipomovimento");

                    b.Property<decimal>("Valor")
                        .HasColumnType("TEXT");

                    b.HasKey("IdMovimento");

                    b.ToTable("Movimentos");
                });
#pragma warning restore 612, 618
        }
    }
}
