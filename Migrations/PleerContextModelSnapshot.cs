﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PLEER;

#nullable disable

namespace PLEER.Migrations
{
    [DbContext(typeof(PleerContext))]
    partial class PleerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("PLEER.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Apartment")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)")
                        .HasColumnName("apartment");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("city");

                    b.Property<string>("Floor")
                        .HasMaxLength(8)
                        .HasColumnType("character varying(8)")
                        .HasColumnName("floor");

                    b.Property<string>("House")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("house");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("street");

                    b.HasKey("Id")
                        .HasName("address_pkey");

                    b.ToTable("address", (string)null);
                });

            modelBuilder.Entity("PLEER.Cart", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("integer")
                        .HasColumnName("customer_id");

                    b.HasKey("Id")
                        .HasName("cart_pkey");

                    b.HasIndex("CustomerId")
                        .IsUnique();

                    b.ToTable("cart", (string)null);
                });

            modelBuilder.Entity("PLEER.CartProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CartId")
                        .HasColumnType("integer")
                        .HasColumnName("cart_id");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer")
                        .HasColumnName("product_id");

                    b.HasKey("Id")
                        .HasName("cart_product_pkey");

                    b.HasIndex("CartId");

                    b.HasIndex("ProductId");

                    b.ToTable("cart_product", (string)null);
                });

            modelBuilder.Entity("PLEER.Courier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)")
                        .HasColumnName("last_name");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("character varying(16)")
                        .HasColumnName("phone");

                    b.HasKey("Id")
                        .HasName("courier_pkey");

                    b.ToTable("courier", (string)null);
                });

            modelBuilder.Entity("PLEER.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)")
                        .HasColumnName("first_name");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)")
                        .HasColumnName("last_name");

                    b.Property<string>("MiddleName")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)")
                        .HasColumnName("middle_name");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)")
                        .HasColumnName("phone");

                    b.HasKey("Id")
                        .HasName("customer_pkey");

                    b.HasIndex(new[] { "Email" }, "customer_email_key")
                        .IsUnique();

                    b.ToTable("customer", (string)null);
                });

            modelBuilder.Entity("PLEER.CustomerAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AddressId")
                        .HasColumnType("integer")
                        .HasColumnName("address_id");

                    b.Property<int>("CustomerId")
                        .HasColumnType("integer")
                        .HasColumnName("customer_id");

                    b.HasKey("Id")
                        .HasName("customer_address_pkey");

                    b.HasIndex("AddressId");

                    b.HasIndex("CustomerId");

                    b.ToTable("customer_address", (string)null);
                });

            modelBuilder.Entity("PLEER.Customerorder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("AddressId")
                        .HasColumnType("integer")
                        .HasColumnName("address_id");

                    b.Property<int?>("CourierId")
                        .HasColumnType("integer")
                        .HasColumnName("courier_id");

                    b.Property<int>("CustomerId")
                        .HasColumnType("integer")
                        .HasColumnName("customer_id");

                    b.Property<DateTime?>("OrderDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("order_date")
                        .HasDefaultValueSql("now()");

                    b.Property<int>("StatusId")
                        .HasColumnType("integer")
                        .HasColumnName("status_id");

                    b.Property<int?>("TransactionId")
                        .HasColumnType("integer")
                        .HasColumnName("transaction_id");

                    b.HasKey("Id")
                        .HasName("customerorder_pkey");

                    b.HasIndex("AddressId");

                    b.HasIndex("CourierId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("StatusId");

                    b.HasIndex("TransactionId")
                        .IsUnique();

                    b.ToTable("customerorder", (string)null);
                });

            modelBuilder.Entity("PLEER.OrderProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("OrderId")
                        .HasColumnType("integer")
                        .HasColumnName("order_id");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer")
                        .HasColumnName("product_id");

                    b.HasKey("Id")
                        .HasName("order_product_pkey");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("order_product", (string)null);
                });

            modelBuilder.Entity("PLEER.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Image")
                        .HasColumnType("text")
                        .HasColumnName("image");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("name");

                    b.Property<decimal>("Price")
                        .HasPrecision(10, 2)
                        .HasColumnType("numeric(10,2)")
                        .HasColumnName("price");

                    b.HasKey("Id")
                        .HasName("product_pkey");

                    b.ToTable("product", (string)null);
                });

            modelBuilder.Entity("PLEER.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CustomerId")
                        .HasColumnType("integer")
                        .HasColumnName("customer_id");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer")
                        .HasColumnName("product_id");

                    b.Property<int>("Rating")
                        .HasColumnType("integer")
                        .HasColumnName("rating");

                    b.Property<DateTime?>("ReviewDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("review_date")
                        .HasDefaultValueSql("now()");

                    b.HasKey("Id")
                        .HasName("review_pkey");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ProductId");

                    b.ToTable("review", (string)null);
                });

            modelBuilder.Entity("PLEER.Status", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("StatusName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("status_name");

                    b.HasKey("Id")
                        .HasName("status_pkey");

                    b.ToTable("status", (string)null);
                });

            modelBuilder.Entity("PLEER.Transaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Amount")
                        .HasPrecision(10, 2)
                        .HasColumnType("numeric(10,2)")
                        .HasColumnName("amount");

                    b.Property<DateTime?>("TransactionDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("transaction_date")
                        .HasDefaultValueSql("now()");

                    b.HasKey("Id")
                        .HasName("transaction_pkey");

                    b.ToTable("transaction", (string)null);
                });

            modelBuilder.Entity("PLEER.Cart", b =>
                {
                    b.HasOne("PLEER.Customer", "Customer")
                        .WithOne("Cart")
                        .HasForeignKey("PLEER.Cart", "CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_cart_customer");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("PLEER.CartProduct", b =>
                {
                    b.HasOne("PLEER.Cart", "Cart")
                        .WithMany("CartProducts")
                        .HasForeignKey("CartId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_cart_product_cart");

                    b.HasOne("PLEER.Product", "Product")
                        .WithMany("CartProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_cart_product_product");

                    b.Navigation("Cart");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("PLEER.CustomerAddress", b =>
                {
                    b.HasOne("PLEER.Address", "Address")
                        .WithMany("CustomerAddresses")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_customer_address_address");

                    b.HasOne("PLEER.Customer", "Customer")
                        .WithMany("CustomerAddresses")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_customer_address_customer");

                    b.Navigation("Address");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("PLEER.Customerorder", b =>
                {
                    b.HasOne("PLEER.Address", "Address")
                        .WithMany("Customerorders")
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired()
                        .HasConstraintName("fk_customerorder_address");

                    b.HasOne("PLEER.Courier", "Courier")
                        .WithMany("Customerorders")
                        .HasForeignKey("CourierId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .HasConstraintName("fk_customerorder_courier");

                    b.HasOne("PLEER.Customer", "Customer")
                        .WithMany("Customerorders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_customerorder_customer");

                    b.HasOne("PLEER.Status", "Status")
                        .WithMany("Customerorders")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.SetNull)
                        .IsRequired()
                        .HasConstraintName("fk_customerorder_status");

                    b.HasOne("PLEER.Transaction", "Transaction")
                        .WithOne("Customerorder")
                        .HasForeignKey("PLEER.Customerorder", "TransactionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .HasConstraintName("fk_transaction_customerorder");

                    b.Navigation("Address");

                    b.Navigation("Courier");

                    b.Navigation("Customer");

                    b.Navigation("Status");

                    b.Navigation("Transaction");
                });

            modelBuilder.Entity("PLEER.OrderProduct", b =>
                {
                    b.HasOne("PLEER.Customerorder", "Order")
                        .WithMany("OrderProducts")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_order_product_order");

                    b.HasOne("PLEER.Product", "Product")
                        .WithMany("OrderProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_order_product_product");

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("PLEER.Review", b =>
                {
                    b.HasOne("PLEER.Customer", "Customer")
                        .WithMany("Reviews")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_review_customer");

                    b.HasOne("PLEER.Product", "Product")
                        .WithMany("Reviews")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_review_product");

                    b.Navigation("Customer");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("PLEER.Address", b =>
                {
                    b.Navigation("CustomerAddresses");

                    b.Navigation("Customerorders");
                });

            modelBuilder.Entity("PLEER.Cart", b =>
                {
                    b.Navigation("CartProducts");
                });

            modelBuilder.Entity("PLEER.Courier", b =>
                {
                    b.Navigation("Customerorders");
                });

            modelBuilder.Entity("PLEER.Customer", b =>
                {
                    b.Navigation("Cart")
                        .IsRequired();

                    b.Navigation("CustomerAddresses");

                    b.Navigation("Customerorders");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("PLEER.Customerorder", b =>
                {
                    b.Navigation("OrderProducts");
                });

            modelBuilder.Entity("PLEER.Product", b =>
                {
                    b.Navigation("CartProducts");

                    b.Navigation("OrderProducts");

                    b.Navigation("Reviews");
                });

            modelBuilder.Entity("PLEER.Status", b =>
                {
                    b.Navigation("Customerorders");
                });

            modelBuilder.Entity("PLEER.Transaction", b =>
                {
                    b.Navigation("Customerorder");
                });
#pragma warning restore 612, 618
        }
    }
}
