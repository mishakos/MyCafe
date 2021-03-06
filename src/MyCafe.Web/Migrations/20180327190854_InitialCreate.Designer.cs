﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using MyCafe.Db.Context;
using System;

namespace MyCafe.Web.Migrations
{
    [DbContext(typeof(MyCafeContext))]
    [Migration("20180327190854_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("MyCafe.DB.Enities.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FirstName");

                    b.Property<bool>("IsLegal");

                    b.Property<bool>("IsResident");

                    b.Property<string>("LastName");

                    b.Property<string>("MiddleName");

                    b.Property<string>("Name");

                    b.Property<string>("TaxNumber");

                    b.HasKey("Id");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("MyCafe.DB.Enities.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("FirmId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("FirmId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("MyCafe.DB.Enities.Firm", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Firms");
                });

            modelBuilder.Entity("MyCafe.DB.Enities.Invoice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClientId");

                    b.Property<DateTime>("Date");

                    b.Property<int>("DepartmentId");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("MyCafe.DB.Enities.InvoiceDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Amount");

                    b.Property<int>("InvoiceId");

                    b.Property<decimal>("Price");

                    b.Property<int>("ProductId");

                    b.Property<int>("ProductUnitId");

                    b.Property<decimal>("Quantity");

                    b.HasKey("Id");

                    b.HasIndex("InvoiceId");

                    b.HasIndex("ProductId");

                    b.HasIndex("ProductUnitId");

                    b.ToTable("InvoiceDetails");
                });

            modelBuilder.Entity("MyCafe.DB.Enities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ClientId");

                    b.Property<DateTime>("Date");

                    b.Property<int>("TableId");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("TableId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("MyCafe.DB.Enities.OrderDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Amount");

                    b.Property<int>("OrderId");

                    b.Property<decimal>("Price");

                    b.Property<int>("ProductId");

                    b.Property<int>("ProductUnitId");

                    b.Property<decimal>("Quantity");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.HasIndex("ProductUnitId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("MyCafe.DB.Enities.Price", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Amount");

                    b.Property<DateTime>("Date");

                    b.Property<int>("PriceTypeId");

                    b.Property<int>("ProductId");

                    b.Property<int>("ProductUnitId");

                    b.HasKey("Id");

                    b.HasIndex("PriceTypeId");

                    b.HasIndex("ProductId");

                    b.HasIndex("ProductUnitId");

                    b.ToTable("Prices");
                });

            modelBuilder.Entity("MyCafe.DB.Enities.PriceType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("PriceTypes");
                });

            modelBuilder.Entity("MyCafe.DB.Enities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("MyCafe.DB.Enities.ProductUnit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("Koef");

                    b.Property<int>("ProductId");

                    b.Property<int>("UnitId");

                    b.Property<decimal>("Weight");

                    b.Property<int>("WeightUnitId");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("UnitId");

                    b.HasIndex("WeightUnitId");

                    b.ToTable("ProductUnits");
                });

            modelBuilder.Entity("MyCafe.DB.Enities.Recipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("BruttoWeight");

                    b.Property<string>("Comments");

                    b.Property<DateTime>("Date");

                    b.Property<decimal>("NetWeight");

                    b.Property<int>("ProductId");

                    b.Property<decimal>("Quantity");

                    b.HasKey("Id");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("MyCafe.DB.Enities.RecipeDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("BruttoWeight");

                    b.Property<decimal>("NetWeight");

                    b.Property<int>("ProductId");

                    b.Property<int>("ProductUnitId");

                    b.Property<decimal>("Quantity");

                    b.Property<int>("RecipeId");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("ProductUnitId");

                    b.HasIndex("RecipeId");

                    b.ToTable("RecipeDetails");
                });

            modelBuilder.Entity("MyCafe.DB.Enities.Table", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DepartmentId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Tables");
                });

            modelBuilder.Entity("MyCafe.DB.Enities.Unit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("ShortCode");

                    b.HasKey("Id");

                    b.ToTable("Units");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MyCafe.DB.Enities.Department", b =>
                {
                    b.HasOne("MyCafe.DB.Enities.Firm", "Firm")
                        .WithMany()
                        .HasForeignKey("FirmId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MyCafe.DB.Enities.Invoice", b =>
                {
                    b.HasOne("MyCafe.DB.Enities.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MyCafe.DB.Enities.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MyCafe.DB.Enities.InvoiceDetail", b =>
                {
                    b.HasOne("MyCafe.DB.Enities.Invoice", "Invoice")
                        .WithMany("InvoiceDetails")
                        .HasForeignKey("InvoiceId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MyCafe.DB.Enities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MyCafe.DB.Enities.ProductUnit", "ProductUnit")
                        .WithMany()
                        .HasForeignKey("ProductUnitId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("MyCafe.DB.Enities.Order", b =>
                {
                    b.HasOne("MyCafe.DB.Enities.Client", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MyCafe.DB.Enities.Table", "Table")
                        .WithMany()
                        .HasForeignKey("TableId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MyCafe.DB.Enities.OrderDetail", b =>
                {
                    b.HasOne("MyCafe.DB.Enities.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MyCafe.DB.Enities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MyCafe.DB.Enities.ProductUnit", "ProductUnit")
                        .WithMany()
                        .HasForeignKey("ProductUnitId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("MyCafe.DB.Enities.Price", b =>
                {
                    b.HasOne("MyCafe.DB.Enities.PriceType", "PriceType")
                        .WithMany()
                        .HasForeignKey("PriceTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MyCafe.DB.Enities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MyCafe.DB.Enities.ProductUnit", "ProductUnit")
                        .WithMany()
                        .HasForeignKey("ProductUnitId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("MyCafe.DB.Enities.ProductUnit", b =>
                {
                    b.HasOne("MyCafe.DB.Enities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MyCafe.DB.Enities.Unit", "Unit")
                        .WithMany()
                        .HasForeignKey("UnitId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MyCafe.DB.Enities.Unit", "WeightUnit")
                        .WithMany()
                        .HasForeignKey("WeightUnitId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("MyCafe.DB.Enities.RecipeDetail", b =>
                {
                    b.HasOne("MyCafe.DB.Enities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MyCafe.DB.Enities.ProductUnit", "ProductUnit")
                        .WithMany()
                        .HasForeignKey("ProductUnitId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("MyCafe.DB.Enities.Recipe", "Recipe")
                        .WithMany("RecipeDetails")
                        .HasForeignKey("RecipeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MyCafe.DB.Enities.Table", b =>
                {
                    b.HasOne("MyCafe.DB.Enities.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
