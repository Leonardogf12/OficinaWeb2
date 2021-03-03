﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OficinaWeb2.Data;

namespace OficinaWeb2.Migrations
{
    [DbContext(typeof(OficinaWeb2Context))]
    [Migration("20210303011239_inicio")]
    partial class inicio
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("OficinaWeb2.Models.Departamento", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("NOME")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("ID");

                    b.ToTable("Departamento");
                });
#pragma warning restore 612, 618
        }
    }
}
