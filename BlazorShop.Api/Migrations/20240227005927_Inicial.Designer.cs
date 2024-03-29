﻿// <auto-generated />
using BlazorShop.Api.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorShop.Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240227005927_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.27")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BlazorShop.Api.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("IconCss")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IconCss = "fas fa-spa",
                            Name = "Beleza"
                        },
                        new
                        {
                            Id = 2,
                            IconCss = "fas fa-couch",
                            Name = "Moveis"
                        },
                        new
                        {
                            Id = 3,
                            IconCss = "fas fa-headphones",
                            Name = "Eletronicos"
                        },
                        new
                        {
                            Id = 4,
                            IconCss = "fas fa-shoe-prints",
                            Name = "Calcados"
                        });
                });

            modelBuilder.Entity("BlazorShop.Api.Entities.ItemTrolley", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("TrolleyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("TrolleyId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("BlazorShop.Api.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(10,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "Um kit fornecido pela Natura, contendo Products para cuidados com a pele",
                            ImageUrl = "/Imagens/Beleza/Beleza1.png",
                            Name = "Glossier - Beleza Kit",
                            Price = 100m,
                            Quantity = 100
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "Um kit fornecido pela Curology, contendo Products para cuidados com a pele",
                            ImageUrl = "/Imagens/Beleza/Beleza2.png",
                            Name = "Curology - Kit para Pele",
                            Price = 50m,
                            Quantity = 45
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "Um kit fornecido pela Glossier, contendo Products para cuidados com a pele",
                            ImageUrl = "/Imagens/Beleza/Beleza3.png",
                            Name = "Óleo de Coco Orgânico",
                            Price = 20m,
                            Quantity = 30
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Description = "Um kit fornecido pela Curology, contendo Products para cuidados com a pele",
                            ImageUrl = "/Imagens/Beleza/Beleza4.png",
                            Name = "Schwarzkopf - Kit de cuidados com a pele e cabelo",
                            Price = 50m,
                            Quantity = 60
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            Description = "Kit de cuidados com a pele, contendo Products para cuidados com a pele e cabelos",
                            ImageUrl = "/Imagens/Beleza/Beleza5.png",
                            Name = "Kit de cuidados com a pele",
                            Price = 30m,
                            Quantity = 85
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 3,
                            Description = "Air Pods - fones de ouvido sem fio intra-auriculares",
                            ImageUrl = "/Imagens/Eletronicos/eletronico1.png",
                            Name = "Fones de ouvidos",
                            Price = 100m,
                            Quantity = 120
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 3,
                            Description = "Fones de ouvido dourados na orelha - esses fones de ouvido não são sem fio",
                            ImageUrl = "/Imagens/Eletronicos/eletronico2.png",
                            Name = "Fones de ouvido dourados",
                            Price = 40m,
                            Quantity = 200
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 3,
                            Description = "Fones de ouvido pretos na orelha - esses fones de ouvido não são sem fio",
                            ImageUrl = "/Imagens/Eletronicos/eletronico3.png",
                            Name = "Fones de ouvido pretos",
                            Price = 40m,
                            Quantity = 300
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 3,
                            Description = "Câmera Digital Sennheiser - Câmera digital de alta qualidade fornecida pela Sennheiser - inclui tripé",
                            ImageUrl = "/Imagens/Eletronicos/eletronico4.png",
                            Name = "Câmera digital Sennheiser com tripé",
                            Price = 600m,
                            Quantity = 20
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 3,
                            Description = "Canon Digital Camera - Câmera digital de alta qualidade fornecida pela Canon",
                            ImageUrl = "/Imagens/Eletronicos/eletronico5.png",
                            Name = "Câmera Digital Canon",
                            Price = 500m,
                            Quantity = 15
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 3,
                            Description = "Gameboy - Fornecido por Nintendo",
                            ImageUrl = "/Imagens/Eletronicos/tecnologia6.png",
                            Name = "Nintendo Gameboy",
                            Price = 100m,
                            Quantity = 60
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 2,
                            Description = "Cadeira de escritório em couro preto muito confortável",
                            ImageUrl = "/Imagens/Moveis/moveis1.png",
                            Name = "Cadeira de escritório de couro preto",
                            Price = 50m,
                            Quantity = 212
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 2,
                            Description = "Cadeira de escritório em couro rosa muito confortável",
                            ImageUrl = "/Imagens/Moveis/moveis2.png",
                            Name = "Cadeira de escritório de couro rosa",
                            Price = 50m,
                            Quantity = 112
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 2,
                            Description = "Poltrona muito confortável",
                            ImageUrl = "/Imagens/Moveis/moveis3.png",
                            Name = "Espreguiçadeira",
                            Price = 70m,
                            Quantity = 90
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 2,
                            Description = "Poltrona prateada muito confortável",
                            ImageUrl = "/Imagens/Moveis/moveis4.png",
                            Name = "Silver Lounge Chair",
                            Price = 120m,
                            Quantity = 95
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 2,
                            Description = "Abajur de mesa de porcelana branco e azul",
                            ImageUrl = "/Imagens/Moveis/moveis6.png",
                            Name = "Luminária de mesa de porcelana",
                            Price = 15m,
                            Quantity = 100
                        },
                        new
                        {
                            Id = 17,
                            CategoryId = 2,
                            Description = "Abajur de mesa de escritório",
                            ImageUrl = "/Imagens/Moveis/moveis7.png",
                            Name = "Office Table Lamp",
                            Price = 20m,
                            Quantity = 73
                        },
                        new
                        {
                            Id = 18,
                            CategoryId = 4,
                            Description = "Tênis Puma confortáveis na maioria dos tamanhos",
                            ImageUrl = "/Imagens/Calcados/calcado1.png",
                            Name = "Tênis Puma",
                            Price = 100m,
                            Quantity = 50
                        },
                        new
                        {
                            Id = 19,
                            CategoryId = 4,
                            Description = "Tênis coloridos - disponíveis na maioria dos tamanhos",
                            ImageUrl = "/Imagens/Calcados/calcado2.png",
                            Name = "Tênis Colodiros",
                            Price = 150m,
                            Quantity = 60
                        },
                        new
                        {
                            Id = 20,
                            CategoryId = 4,
                            Description = "Tênis Nike azul - disponível na maioria dos tamanhos",
                            ImageUrl = "/Imagens/Calcados/calcado3.png",
                            Name = "Tênis Nike Azul",
                            Price = 200m,
                            Quantity = 70
                        },
                        new
                        {
                            Id = 21,
                            CategoryId = 4,
                            Description = "Treinadores Hummel coloridos - disponíveis na maioria dos tamanhos",
                            ImageUrl = "/Imagens/Calcados/calcado4.png",
                            Name = "Tênis Hummel Coloridos",
                            Price = 120m,
                            Quantity = 120
                        },
                        new
                        {
                            Id = 22,
                            CategoryId = 4,
                            Description = "Tênis Nike vermelho - disponível na maioria dos tamanhos",
                            ImageUrl = "/Imagens/Calcados/calcado5.png",
                            Name = "Tênis Nike Vermelho",
                            Price = 200m,
                            Quantity = 100
                        },
                        new
                        {
                            Id = 23,
                            CategoryId = 4,
                            Description = "Sandálias Birkenstock - disponíveis na maioria dos tamanhos",
                            ImageUrl = "/Imagens/Calcados/calcado6.png",
                            Name = "Sandálidas Birkenstock",
                            Price = 50m,
                            Quantity = 150
                        });
                });

            modelBuilder.Entity("BlazorShop.Api.Entities.Trolley", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Trolleys");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            UserId = 1
                        },
                        new
                        {
                            Id = 2,
                            UserId = 2
                        });
                });

            modelBuilder.Entity("BlazorShop.Api.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("NameUser")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            NameUser = "Macoratti"
                        },
                        new
                        {
                            Id = 2,
                            NameUser = "Janice"
                        });
                });

            modelBuilder.Entity("BlazorShop.Api.Entities.ItemTrolley", b =>
                {
                    b.HasOne("BlazorShop.Api.Entities.Product", "Product")
                        .WithMany("items")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazorShop.Api.Entities.Trolley", "Trolley")
                        .WithMany("Items")
                        .HasForeignKey("TrolleyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("Trolley");
                });

            modelBuilder.Entity("BlazorShop.Api.Entities.Product", b =>
                {
                    b.HasOne("BlazorShop.Api.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BlazorShop.Api.Entities.Trolley", b =>
                {
                    b.HasOne("BlazorShop.Api.Entities.User", "User")
                        .WithOne("Trolley")
                        .HasForeignKey("BlazorShop.Api.Entities.Trolley", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("BlazorShop.Api.Entities.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("BlazorShop.Api.Entities.Product", b =>
                {
                    b.Navigation("items");
                });

            modelBuilder.Entity("BlazorShop.Api.Entities.Trolley", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("BlazorShop.Api.Entities.User", b =>
                {
                    b.Navigation("Trolley");
                });
#pragma warning restore 612, 618
        }
    }
}
