﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TEOAG.API.Data;

namespace TEOAG.API.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230327001255_Eigth")]
    partial class Eigth
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.10");

            modelBuilder.Entity("TEOAG.API.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CNPJSupplier")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("ManufacturingDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductDescription")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProductName")
                        .HasColumnType("TEXT");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SupplierDescription")
                        .HasColumnType("TEXT");

                    b.Property<int>("SupplierId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
