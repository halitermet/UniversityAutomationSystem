﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UniversityCodeFirst.ANK15OkulDbContextt;

#nullable disable

namespace UniversityCodeFirst.Migrations
{
    [DbContext(typeof(ANK15OkulDbContext))]
    [Migration("20240104064143_m4")]
    partial class m4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("UniversityCodeFirst.Concrete.Diploma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("No")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("diplomalar");
                });

            modelBuilder.Entity("UniversityCodeFirst.Concrete.Ogrenci", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Adı")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DiplomaId")
                        .HasColumnType("int");

                    b.Property<string>("Numara")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyadı")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DiplomaId")
                        .IsUnique();

                    b.ToTable("ogrenci");
                });

            modelBuilder.Entity("UniversityCodeFirst.Concrete.Ogrenci", b =>
                {
                    b.HasOne("UniversityCodeFirst.Concrete.Diploma", "Diploma")
                        .WithOne("Ogrenci")
                        .HasForeignKey("UniversityCodeFirst.Concrete.Ogrenci", "DiplomaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Diploma");
                });

            modelBuilder.Entity("UniversityCodeFirst.Concrete.Diploma", b =>
                {
                    b.Navigation("Ogrenci")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
