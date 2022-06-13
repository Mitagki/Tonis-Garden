﻿using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.tonisgarden.Services.Ordering.API.Infrastructure;

namespace Microsoft.tonisgarden.Services.Ordering.API.Infrastructure.Migrations
{
    [DbContext(typeof(OrderingDbContext))]
    partial class OrderingDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.HasSequence("orderitemseq")
                .IncrementsBy(10);

            modelBuilder.HasSequence("orderseq")
                .IncrementsBy(10);

            modelBuilder.Entity("Microsoft.tonisgarden.Services.Ordering.API.Model.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BuyerEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BuyerId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("OrderNumber")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:HiLoSequenceName", "orderseq")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.SequenceHiLo);

                    b.Property<string>("OrderStatus")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasAlternateKey("OrderNumber");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Microsoft.tonisgarden.Services.Ordering.API.Model.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:HiLoSequenceName", "orderitemseq")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.SequenceHiLo);

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PictureFileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("UnitPrice")
                        .HasPrecision(4, 2)
                        .HasColumnType("decimal(4,2)");

                    b.Property<int>("Units")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("Microsoft.tonisgarden.Services.Ordering.API.Model.Order", b =>
                {
                    b.OwnsOne("Microsoft.tonisgarden.Services.Ordering.API.Model.Address", "Address", b1 =>
                        {
                            b1.Property<Guid>("OrderId")
                                .HasColumnType("uniqueidentifier");

                            b1.Property<string>("City")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Country")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("State")
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Street")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("OrderId");

                            b1.ToTable("Orders");

                            b1.WithOwner()
                                .HasForeignKey("OrderId");
                        });

                    b.Navigation("Address");
                });

            modelBuilder.Entity("Microsoft.tonisgarden.Services.Ordering.API.Model.OrderItem", b =>
                {
                    b.HasOne("Microsoft.tonisgarden.Services.Ordering.API.Model.Order", null)
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.tonisgarden.Services.Ordering.API.Model.Order", b =>
                {
                    b.Navigation("OrderItems");
                });
#pragma warning restore 612, 618
        }
    }
}
