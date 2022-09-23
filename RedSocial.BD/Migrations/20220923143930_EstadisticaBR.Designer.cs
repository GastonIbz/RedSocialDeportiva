﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RedSocial.BD.Data;

#nullable disable

namespace RedSocial.BD.Migrations
{
    [DbContext(typeof(BDContext))]
    [Migration("20220923143930_EstadisticaBR")]
    partial class EstadisticaBR
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("RedSocial.BD.Data.Entidades.EstadisticaBR", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("accounType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("timeWindow")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Id" }, "IdUsuario_UQ")
                        .IsUnique();

                    b.ToTable("TablaEstadistica");
                });

            modelBuilder.Entity("RedSocial.BD.Data.Entidades.Publicacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ContenidoPublicacion")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("EsPrivada")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaPublicacion")
                        .HasColumnType("datetime2");

                    b.Property<int>("MeGusta")
                        .HasColumnType("int");

                    b.Property<string>("Usuario")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("VecesCompartido")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Id" }, "IdUsuario_UQ")
                        .IsUnique()
                        .HasDatabaseName("IdUsuario_UQ1");

                    b.ToTable("TablaPublicacion");
                });

            modelBuilder.Entity("RedSocial.BD.Data.Entidades.Ranking", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Id" }, "IdUsuario_UQ")
                        .IsUnique()
                        .HasDatabaseName("IdUsuario_UQ2");

                    b.ToTable("TablaRanking");
                });

            modelBuilder.Entity("RedSocial.BD.Data.Entidades.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Descripcion")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgPerfil")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgPortada")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex(new[] { "Id" }, "IdUsuario_UQ")
                        .IsUnique()
                        .HasDatabaseName("IdUsuario_UQ3");

                    b.ToTable("TablaUsuario");
                });
#pragma warning restore 612, 618
        }
    }
}
