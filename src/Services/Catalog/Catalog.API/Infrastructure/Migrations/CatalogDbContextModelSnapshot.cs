﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.tonisgarden.Services.Catalog.API.Infrastructure;

namespace Microsoft.tonisgarden.Services.Catalog.API.Infrastructure.Migrations
{
    [DbContext(typeof(CatalogDbContext))]
    partial class CatalogDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.HasSequence("catalog_size_hilo")
                .IncrementsBy(10);

            modelBuilder.HasSequence("catalog_hilo")
                .IncrementsBy(10);

            modelBuilder.HasSequence("catalog_type_hilo")
                .IncrementsBy(10);

            modelBuilder.Entity("Microsoft.tonisgarden.Services.Catalog.API.Model.CatalogSize", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:HiLoSequenceName", "catalog_size_hilo")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.SequenceHiLo);

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("nvarchar(100)");

                b.HasKey("Id");

                b.ToTable("CatalogSize");

                b.HasData(
                    new
                    {
                        Id = 1,
                        Name = "Small"
                    },
                    new
                    {
                        Id = 2,
                        Name = "Medium"
                    },
                    new
                    {
                        Id = 3,
                        Name = "Large"
                    });
            });

            modelBuilder.Entity("Microsoft.tonisgarden.Services.Catalog.API.Model.CatalogItem", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:HiLoSequenceName", "catalog_hilo")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.SequenceHiLo);

                b.Property<int>("AvailableStock")
                    .HasColumnType("int");

                b.Property<int>("CatalogSizeId")
                    .HasColumnType("int");

                b.Property<int>("CatalogTypeId")
                    .HasColumnType("int");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnType("nvarchar(50)");

                b.Property<string>("PictureFileName")
                    .IsRequired()
                    .HasColumnType("nvarchar(max)");

                b.Property<decimal>("Price")
                    .HasPrecision(4, 2)
                    .HasColumnType("decimal(4,2)");

                b.HasKey("Id");

                b.HasIndex("CatalogSizeId");

                b.HasIndex("CatalogTypeId");

                b.ToTable("CatalogItem");

                b.HasData(
                    new
                    {
                        Id = 18,
                        AvailableStock = 100,
                        CatalogSizeId = 1,
                        CatalogTypeId = 1,
                        Name = "Peperomia Watermelon",
                        PictureFileName = "21.png",
                        Price = 49m
                    },
                    new
                    {
                        Id = 19,
                        AvailableStock = 100,
                        CatalogSizeId = 1,
                        CatalogTypeId = 1,
                        Name = "Ficus Altissima",
                        PictureFileName = "22.png",
                        Price = 99m
                    },
                    new
                    {
                        Id = 20,
                        AvailableStock = 100,
                        CatalogSizeId = 1,
                        CatalogTypeId = 1,
                        Name = "Ponytail Palm",
                        PictureFileName = "23.png",
                        Price = 29m
                    },
                    new
                    {
                        Id = 21,
                        AvailableStock = 100,
                        CatalogSizeId = 1,
                        CatalogTypeId = 1,
                        Name = "Hoya Macrophylla",
                        PictureFileName = "24.png",
                        Price = 49m
                    },
                    new
                    {
                        Id = 22,
                        AvailableStock = 100,
                        CatalogSizeId = 1,
                        CatalogTypeId = 1,
                        Name = "Peace Lily",
                        PictureFileName = "25.png",
                        Price = 99m
                    },
                    new
                    {
                        Id = 23,
                        AvailableStock = 100,
                        CatalogSizeId = 1,
                        CatalogTypeId = 1,
                        Name = "Bamboo Palm",
                        PictureFileName = "26.png",
                        Price = 99m
                    },
                    new
                    {
                        Id = 24,
                        AvailableStock = 100,
                        CatalogSizeId = 1,
                        CatalogTypeId = 1,
                        Name = "Money Tree",
                        PictureFileName = "27.png",
                        Price = 99m
                    },
                    new
                    {
                        Id = 25,
                        AvailableStock = 100,
                        CatalogSizeId = 3,
                        CatalogTypeId = 1,
                        Name = "Red Prayer Plant",
                        PictureFileName = "28.png",
                        Price = 39m
                    },
                    new
                    {
                        Id = 26,
                        AvailableStock = 100,
                        CatalogSizeId = 3,
                        CatalogTypeId = 1,
                        Name = "Dracaena Rikki Cane",
                        PictureFileName = "29.png",
                        Price = 99m
                    },
                    new
                    {
                        Id = 27,
                        AvailableStock = 100,
                        CatalogSizeId = 2,
                        CatalogTypeId = 1,
                        Name = "Silver Pothos",
                        PictureFileName = "30.png",
                        Price = 49m
                    },
                    new
                    {
                        Id = 28,
                        AvailableStock = 100,
                        CatalogSizeId = 2,
                        CatalogTypeId = 1,
                        Name = "Calathea Collection",
                        PictureFileName = "31.png",
                        Price = 79m
                    },
                    new
                    {
                        Id = 29,
                        AvailableStock = 100,
                        CatalogSizeId = 1,
                        CatalogTypeId = 2,
                        Name = "Purple African Violet",
                        PictureFileName = "32.png",
                        Price = 49m
                    },
                    new
                    {
                        Id = 30,
                        AvailableStock = 100,
                        CatalogSizeId = 1,
                        CatalogTypeId = 2,
                        Name = "Dieffenbachia",
                        PictureFileName = "33.png",
                        Price = 99m
                    });
            });

            modelBuilder.Entity("Microsoft.tonisgarden.Services.Catalog.API.Model.CatalogType", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int")
                    .HasAnnotation("SqlServer:HiLoSequenceName", "catalog_type_hilo")
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.SequenceHiLo);

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("nvarchar(100)");

                b.HasKey("Id");

                b.ToTable("CatalogType");

                b.HasData(
                    new
                    {
                        Id = 1,
                        Name = "Indoor Plants"
                    },
                    new
                    {
                        Id = 2,
                        Name = "Outdoor Plants"
                    });
            });

            modelBuilder.Entity("Microsoft.tonisgarden.Services.Catalog.API.Model.CatalogItem", b =>
            {
                b.HasOne("Microsoft.tonisgarden.Services.Catalog.API.Model.CatalogSize", "CatalogSize")
                    .WithMany()
                    .HasForeignKey("CatalogSizeId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.HasOne("Microsoft.tonisgarden.Services.Catalog.API.Model.CatalogType", "CatalogType")
                    .WithMany()
                    .HasForeignKey("CatalogTypeId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("CatalogSize");

                b.Navigation("CatalogType");
            });
#pragma warning restore 612, 618
        }
    }
}
