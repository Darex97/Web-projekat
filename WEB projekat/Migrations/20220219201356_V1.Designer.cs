﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Models;

namespace WEB_projekat.Migrations
{
    [DbContext(typeof(BorbaContext))]
    [Migration("20220219201356_V1")]
    partial class V1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BorbaPlaneta", b =>
                {
                    b.Property<int>("BorbaPlaneteID")
                        .HasColumnType("int");

                    b.Property<int>("PlanetineBorbeID")
                        .HasColumnType("int");

                    b.HasKey("BorbaPlaneteID", "PlanetineBorbeID");

                    b.HasIndex("PlanetineBorbeID");

                    b.ToTable("BorbaPlaneta");
                });

            modelBuilder.Entity("Models.Borba", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PlanetaPobedink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Vreme")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Borba");
                });

            modelBuilder.Entity("Models.Galaksija", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrojPlaneta")
                        .HasColumnType("int");

                    b.Property<string>("ImeGalaksije")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Galaksija");
                });

            modelBuilder.Entity("Models.Klasa", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImeKlase")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Klasa");
                });

            modelBuilder.Entity("Models.Planeta", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BrojRatnika")
                        .HasColumnType("int");

                    b.Property<string>("ImePlanete")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("PlanetaUGalaksijiID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("PlanetaUGalaksijiID");

                    b.ToTable("Planeta");
                });

            modelBuilder.Entity("Models.Ratnik", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ime")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Klasa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RatnikPlanetaID")
                        .HasColumnType("int");

                    b.Property<int?>("RatnikovaKlasaID")
                        .HasColumnType("int");

                    b.Property<int>("Snaga")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("RatnikPlanetaID");

                    b.HasIndex("RatnikovaKlasaID");

                    b.ToTable("Ratnik");
                });

            modelBuilder.Entity("BorbaPlaneta", b =>
                {
                    b.HasOne("Models.Planeta", null)
                        .WithMany()
                        .HasForeignKey("BorbaPlaneteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Borba", null)
                        .WithMany()
                        .HasForeignKey("PlanetineBorbeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Models.Planeta", b =>
                {
                    b.HasOne("Models.Galaksija", "PlanetaUGalaksiji")
                        .WithMany("GalaksijaPlanete")
                        .HasForeignKey("PlanetaUGalaksijiID");

                    b.Navigation("PlanetaUGalaksiji");
                });

            modelBuilder.Entity("Models.Ratnik", b =>
                {
                    b.HasOne("Models.Planeta", "RatnikPlaneta")
                        .WithMany("PlanetaRatnici")
                        .HasForeignKey("RatnikPlanetaID");

                    b.HasOne("Models.Klasa", "RatnikovaKlasa")
                        .WithMany("KlasaRatnici")
                        .HasForeignKey("RatnikovaKlasaID");

                    b.Navigation("RatnikovaKlasa");

                    b.Navigation("RatnikPlaneta");
                });

            modelBuilder.Entity("Models.Galaksija", b =>
                {
                    b.Navigation("GalaksijaPlanete");
                });

            modelBuilder.Entity("Models.Klasa", b =>
                {
                    b.Navigation("KlasaRatnici");
                });

            modelBuilder.Entity("Models.Planeta", b =>
                {
                    b.Navigation("PlanetaRatnici");
                });
#pragma warning restore 612, 618
        }
    }
}
