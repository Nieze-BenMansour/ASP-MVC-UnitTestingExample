﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProductsWebsite.Data;

#nullable disable

namespace ProductsWebsite.Migrations;

[DbContext(typeof(ProductContext))]
[Migration("20240514145800_InitialCreate")]
partial class InitialCreate
{
    /// <inheritdoc />
    protected override void BuildTargetModel(ModelBuilder modelBuilder)
    {
#pragma warning disable 612, 618
        modelBuilder.HasAnnotation("ProductVersion", "8.0.4");

        modelBuilder.Entity("ProductsWebsite.Models.Product", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<float>("BasePrice")
                    .HasColumnType("REAL");

                b.Property<string>("Description")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<string>("ImageName")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasColumnType("TEXT");

                b.HasKey("Id");

                b.ToTable("Products");

                b.HasData(
                    new
                    {
                        Id = 1,
                        BasePrice = 5.5f,
                        Description = "A spherical ball used in basketball games.",
                        ImageName = "basketball",
                        Name = "Basketball"
                    },
                    new
                    {
                        Id = 2,
                        BasePrice = 2.5f,
                        Description = "Cupcake topped with Blue mysterious and delicous cream.",
                        ImageName = "blue-cupcake",
                        Name = "Blue Cupcake"
                    },
                    new
                    {
                        Id = 3,
                        BasePrice = 4f,
                        Description = "Chocolate cupcakes topped with chocolate frosting.",
                        ImageName = "chocolate-cupcake",
                        Name = "Chocolate Cupcake"
                    },
                    new
                    {
                        Id = 4,
                        BasePrice = 3f,
                        Description = "An orange cone that is used to be placed on roads or footpaths to temporarily redirect traffic in a safe manner.",
                        ImageName = "traffic-cone",
                        Name = "Traffic Cone"
                    },
                    new
                    {
                        Id = 5,
                        BasePrice = 2f,
                        Description = "A ball inflated with air that is being played by using your feet.",
                        ImageName = "football",
                        Name = "Football"
                    });
            });
#pragma warning restore 612, 618
    }
}
