﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Models;

namespace WEB_projekat.Migrations
{
    [DbContext(typeof(BorbaContext))]
    partial class BorbaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<int>("PlanetaId1")
                        .HasColumnType("int");

                    b.Property<int>("PlanetaId2")
                        .HasColumnType("int");

                    b.Property<int>("PlanetaPobedink")
                        .HasColumnType("int");

                    b.Property<string>("Vreme")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Borba");
                });

            modelBuilder.Entity("Models.Galaksija", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImeGalaksije")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Galaksija");
                });

            modelBuilder.Entity("Models.Planeta", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GalaksijaID")
                        .HasColumnType("int");

                    b.Property<string>("ImePlanete")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.HasIndex("GalaksijaID");

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

                    b.Property<int>("PlanetaId")
                        .HasColumnType("int");

                    b.Property<int>("Snaga")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("PlanetaId");

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
                        .HasForeignKey("GalaksijaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PlanetaUGalaksiji");
                });

            modelBuilder.Entity("Models.Ratnik", b =>
                {
                    b.HasOne("Models.Planeta", "RatnikPlaneta")
                        .WithMany("PlanetaRatnici")
                        .HasForeignKey("PlanetaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RatnikPlaneta");
                });

            modelBuilder.Entity("Models.Galaksija", b =>
                {
                    b.Navigation("GalaksijaPlanete");
                });

            modelBuilder.Entity("Models.Planeta", b =>
                {
                    b.Navigation("PlanetaRatnici");
                });
#pragma warning restore 612, 618
        }
    }
}
