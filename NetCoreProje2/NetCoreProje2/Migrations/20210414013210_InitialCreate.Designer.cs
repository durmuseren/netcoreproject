﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetCoreProje2.Models;

namespace NetCoreProje2.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20210414013210_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NetCoreProje2.Models.Birim", b =>
                {
                    b.Property<int>("BirimID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BirimAd")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BirimID");

                    b.ToTable("Birims");
                });

            modelBuilder.Entity("NetCoreProje2.Models.Personel", b =>
                {
                    b.Property<int>("PersonelID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BirimID")
                        .HasColumnType("int");

                    b.Property<string>("Sehir")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyad")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonelID");

                    b.HasIndex("BirimID");

                    b.ToTable("Personels");
                });

            modelBuilder.Entity("NetCoreProje2.Models.Personel", b =>
                {
                    b.HasOne("NetCoreProje2.Models.Birim", "Birim")
                        .WithMany("Personels")
                        .HasForeignKey("BirimID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Birim");
                });

            modelBuilder.Entity("NetCoreProje2.Models.Birim", b =>
                {
                    b.Navigation("Personels");
                });
#pragma warning restore 612, 618
        }
    }
}
