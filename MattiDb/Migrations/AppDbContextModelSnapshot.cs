﻿// <auto-generated />
using System;
using MattiDb;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MattiDb.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MattiDb.Entities.Mittaustulos", b =>
                {
                    b.Property<int>("MittaustulosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MittaustulosId"));

                    b.Property<int?>("Arvo")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("InsertDate")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Nimi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("MittaustulosId");

                    b.ToTable("mittaustulos");
                });
#pragma warning restore 612, 618
        }
    }
}
