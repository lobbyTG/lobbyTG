﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using DataBaseAPI.Db;

#nullable disable

namespace backend.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    [Migration("20231003174914_MigracaoQuadra")]
    //[Migration("20231003174914_Quadra")]
    partial class Quadra
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("QuadraAPI.Models.Quadra", b =>
                {
                    b.Property<int>("QuadraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QuadraId"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)");

                    b.Property<int>("avaliacaoQuadra")
                        .HasColumnType("int");

                    b.Property<string>("endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("horarioFuncionamento")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("horarioLobby")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("imagem")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("latitude")
                        .IsRequired()
                        .HasColumnType("nvarchar(350)");

                    b.Property<string>("longitude")
                        .IsRequired()
                        .HasColumnType("nvarchar(350)");

                    b.Property<string>("modalidades")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("QuadraId");

                    b.ToTable("Quadras");
                });
#pragma warning restore 612, 618
        }
    }
}
