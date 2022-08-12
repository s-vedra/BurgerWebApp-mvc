﻿// <auto-generated />
using System;
using BurgerWebApp.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BurgerWebApp.DataAccess.Migrations
{
    [DbContext(typeof(BurgerAppDbContext))]
    [Migration("20220809100926_new-pic")]
    partial class newpic
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BurgerWebApp.DomainModels.Burger", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("HasFries")
                        .HasColumnType("bit");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsVegan")
                        .HasColumnType("bit");

                    b.Property<bool>("IsVegetarian")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Burger", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            HasFries = true,
                            Image = "https://tastesbetterfromscratch.com/wp-content/uploads/2020/06/Classic-Juicy-Hamburger-Recipe-Square.jpg",
                            IsVegan = false,
                            IsVegetarian = false,
                            Name = "Hamburger",
                            Price = 100m
                        },
                        new
                        {
                            Id = 2,
                            HasFries = true,
                            Image = "https://www.kitchensanctuary.com/wp-content/uploads/2021/05/Double-Cheeseburger-square-FS-42.jpg",
                            IsVegan = false,
                            IsVegetarian = false,
                            Name = "Cheeseburger",
                            Price = 120m
                        },
                        new
                        {
                            Id = 3,
                            HasFries = true,
                            Image = "https://images.unsplash.com/photo-1590498403794-fd0ebd0db70c?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=687&q=80",
                            IsVegan = false,
                            IsVegetarian = false,
                            Name = "Chickenburger",
                            Price = 120m
                        },
                        new
                        {
                            Id = 4,
                            HasFries = true,
                            Image = "https://images.immediate.co.uk/production/volatile/sites/30/2020/08/halloumi-burger-4fdad97.jpg",
                            IsVegan = false,
                            IsVegetarian = true,
                            Name = "Vegeterian Dish",
                            Price = 220m
                        },
                        new
                        {
                            Id = 5,
                            HasFries = true,
                            Image = "https://images.unsplash.com/photo-1585238341267-1cfec2046a55?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=574&q=80",
                            IsVegan = true,
                            IsVegetarian = true,
                            Name = "Veggie Burger",
                            Price = 250m
                        });
                });

            modelBuilder.Entity("BurgerWebApp.DomainModels.BurgerOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BurgerId")
                        .HasColumnType("int");

                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Selected")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("BurgerId");

                    b.HasIndex("CartId");

                    b.ToTable("BurgerOrder", (string)null);
                });

            modelBuilder.Entity("BurgerWebApp.DomainModels.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("FullPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Cart", (string)null);
                });

            modelBuilder.Entity("BurgerWebApp.DomainModels.Extra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SizeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SizeId");

                    b.ToTable("Extra", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Image = "https://images.immediate.co.uk/production/volatile/sites/30/2021/03/French-fries-b9e3e0c.jpg",
                            Name = "Small Fries",
                            SizeId = 1
                        },
                        new
                        {
                            Id = 2,
                            Image = "https://images.immediate.co.uk/production/volatile/sites/30/2021/03/French-fries-b9e3e0c.jpg",
                            Name = "Medium Fries",
                            SizeId = 2
                        },
                        new
                        {
                            Id = 3,
                            Image = "https://images.immediate.co.uk/production/volatile/sites/30/2021/03/French-fries-b9e3e0c.jpg",
                            Name = "Large Fries",
                            SizeId = 3
                        },
                        new
                        {
                            Id = 4,
                            Image = "https://www.kwiberry.com/pohojar/2022/02/000145352.jpeg",
                            Name = "Small Coke",
                            SizeId = 1
                        },
                        new
                        {
                            Id = 5,
                            Image = "https://www.kwiberry.com/pohojar/2022/02/000145352.jpeg",
                            Name = "Medium Coke",
                            SizeId = 2
                        },
                        new
                        {
                            Id = 6,
                            Image = "https://www.kwiberry.com/pohojar/2022/02/000145352.jpeg",
                            Name = "Large Coke",
                            SizeId = 3
                        });
                });

            modelBuilder.Entity("BurgerWebApp.DomainModels.ExtrasOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<int>("ExtraId")
                        .HasColumnType("int");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("Selected")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.HasIndex("ExtraId");

                    b.ToTable("ExtraOrder", (string)null);
                });

            modelBuilder.Entity("BurgerWebApp.DomainModels.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ClosesAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OpensAt")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Location", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "BurgerStreet1",
                            ClosesAt = new DateTime(2022, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified),
                            Image = "https://images.unsplash.com/photo-1530554764233-e79e16c91d08?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=687&q=80",
                            Name = "Hamm Burger",
                            OpensAt = new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            Address = "BurgerStreet2",
                            ClosesAt = new DateTime(2022, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified),
                            Image = "https://images.unsplash.com/photo-1530554764233-e79e16c91d08?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=687&q=80",
                            Name = "Burger Place",
                            OpensAt = new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            Address = "BurgerStreet3",
                            ClosesAt = new DateTime(2022, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified),
                            Image = "https://images.unsplash.com/photo-1530554764233-e79e16c91d08?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=687&q=80",
                            Name = "Burger Palace",
                            OpensAt = new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            Address = "BurgerStreet4",
                            ClosesAt = new DateTime(2022, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified),
                            Image = "https://images.unsplash.com/photo-1530554764233-e79e16c91d08?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=687&q=80",
                            Name = "Burger World",
                            OpensAt = new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            Address = "BurgerStreet5",
                            ClosesAt = new DateTime(2022, 1, 1, 23, 0, 0, 0, DateTimeKind.Unspecified),
                            Image = "https://images.unsplash.com/photo-1530554764233-e79e16c91d08?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=687&q=80",
                            Name = "Burger Place Two",
                            OpensAt = new DateTime(2022, 1, 1, 8, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("BurgerWebApp.DomainModels.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CartId")
                        .HasColumnType("int");

                    b.Property<bool>("IsDelivered")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LocationId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CartId");

                    b.HasIndex("LocationId");

                    b.ToTable("Order", (string)null);
                });

            modelBuilder.Entity("BurgerWebApp.DomainModels.Size", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Size", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Small",
                            Price = 50m
                        },
                        new
                        {
                            Id = 2,
                            Description = "Medium",
                            Price = 70m
                        },
                        new
                        {
                            Id = 3,
                            Description = "Large",
                            Price = 100m
                        });
                });

            modelBuilder.Entity("BurgerWebApp.DomainModels.BurgerOrder", b =>
                {
                    b.HasOne("BurgerWebApp.DomainModels.Burger", "Burger")
                        .WithMany()
                        .HasForeignKey("BurgerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BurgerWebApp.DomainModels.Cart", "Cart")
                        .WithMany("BurgerOrders")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Burger");

                    b.Navigation("Cart");
                });

            modelBuilder.Entity("BurgerWebApp.DomainModels.Extra", b =>
                {
                    b.HasOne("BurgerWebApp.DomainModels.Size", "Size")
                        .WithMany()
                        .HasForeignKey("SizeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Size");
                });

            modelBuilder.Entity("BurgerWebApp.DomainModels.ExtrasOrder", b =>
                {
                    b.HasOne("BurgerWebApp.DomainModels.Cart", "Cart")
                        .WithMany("Extras")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BurgerWebApp.DomainModels.Extra", "Extra")
                        .WithMany()
                        .HasForeignKey("ExtraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("Extra");
                });

            modelBuilder.Entity("BurgerWebApp.DomainModels.Order", b =>
                {
                    b.HasOne("BurgerWebApp.DomainModels.Cart", "Cart")
                        .WithMany()
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BurgerWebApp.DomainModels.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("BurgerWebApp.DomainModels.Cart", b =>
                {
                    b.Navigation("BurgerOrders");

                    b.Navigation("Extras");
                });
#pragma warning restore 612, 618
        }
    }
}
