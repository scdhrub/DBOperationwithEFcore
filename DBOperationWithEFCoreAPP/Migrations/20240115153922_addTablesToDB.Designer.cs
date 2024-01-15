﻿// <auto-generated />
using System;
using DBOperationWithEFCoreAPP.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DBOperationWithEFCoreAPP.Migrations
{
    [DbContext(typeof(AddDbContext))]
    [Migration("20240115153922_addTablesToDB")]
    partial class addTablesToDB
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DBOperationWithEFCoreAPP.Data.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int");

                    b.Property<int>("NoOfPages")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("LanguageId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("DBOperationWithEFCoreAPP.Data.BookPrice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.Property<int>("CurrencyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BookId");

                    b.HasIndex("CurrencyId");

                    b.ToTable("BookPrices");
                });

            modelBuilder.Entity("DBOperationWithEFCoreAPP.Data.Currency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Currencies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Indian Rupees",
                            Title = "INR"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Dollar",
                            Title = "Dollar"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Euro",
                            Title = "Euro"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Dinar",
                            Title = "Dinar"
                        });
                });

            modelBuilder.Entity("DBOperationWithEFCoreAPP.Data.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Languages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Hindi",
                            Title = "Hindi"
                        },
                        new
                        {
                            Id = 2,
                            Description = "English",
                            Title = "English"
                        },
                        new
                        {
                            Id = 3,
                            Description = "French",
                            Title = "French"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Arabic",
                            Title = "Arabic"
                        });
                });

            modelBuilder.Entity("DBOperationWithEFCoreAPP.Data.Book", b =>
                {
                    b.HasOne("DBOperationWithEFCoreAPP.Data.Language", "Language")
                        .WithMany("Books")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Language");
                });

            modelBuilder.Entity("DBOperationWithEFCoreAPP.Data.BookPrice", b =>
                {
                    b.HasOne("DBOperationWithEFCoreAPP.Data.Book", "Book")
                        .WithMany()
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DBOperationWithEFCoreAPP.Data.Currency", "Currency")
                        .WithMany("BookPrices")
                        .HasForeignKey("CurrencyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Currency");
                });

            modelBuilder.Entity("DBOperationWithEFCoreAPP.Data.Currency", b =>
                {
                    b.Navigation("BookPrices");
                });

            modelBuilder.Entity("DBOperationWithEFCoreAPP.Data.Language", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
