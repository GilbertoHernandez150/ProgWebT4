﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ProgWebT4.Migrations
{
    [DbContext(typeof(SerieContext))]
    [Migration("20241112225930_PrimeraMigracion")]
    partial class PrimeraMigracion
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("Personaje", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Apodo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Edad")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FotoUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PoderCaracteristico")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Raza")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("SeriePeliculaLibroId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SignoZodiacal")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("SeriePeliculaLibroId");

                    b.ToTable("Personajes");
                });

            modelBuilder.Entity("SeriePeliculaLibro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FotoUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Idioma")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Resumen")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Tipo")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("SeriePeliculaLibros");
                });

            modelBuilder.Entity("Personaje", b =>
                {
                    b.HasOne("SeriePeliculaLibro", "SeriePeliculaLibro")
                        .WithMany("Personajes")
                        .HasForeignKey("SeriePeliculaLibroId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SeriePeliculaLibro");
                });

            modelBuilder.Entity("SeriePeliculaLibro", b =>
                {
                    b.Navigation("Personajes");
                });
#pragma warning restore 612, 618
        }
    }
}
