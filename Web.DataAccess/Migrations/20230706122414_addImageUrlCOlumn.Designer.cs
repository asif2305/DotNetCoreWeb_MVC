﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Web.DataAccess.Data;

#nullable disable

namespace Web.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230706122414_addImageUrlCOlumn")]
    partial class addImageUrlCOlumn
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Web.Models.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DisplayOrder = 1,
                            Name = "Action"
                        },
                        new
                        {
                            Id = 2,
                            DisplayOrder = 2,
                            Name = "SciFi"
                        },
                        new
                        {
                            Id = 3,
                            DisplayOrder = 3,
                            Name = "History"
                        });
                });

            modelBuilder.Entity("Web.Models.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("ListPrice")
                        .HasColumnType("float");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<double>("Price100")
                        .HasColumnType("float");

                    b.Property<double>("Price50")
                        .HasColumnType("float");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Author = "Abby Muscles",
                            CategoryId = 1,
                            Description = "This is first description",
                            ISBN = "WS102212555",
                            ImageUrl = "",
                            ListPrice = 70.0,
                            Price = 65.0,
                            Price100 = 40.0,
                            Price50 = 60.0,
                            Title = "Cotton Candy"
                        },
                        new
                        {
                            Id = 2,
                            Author = "Abby Muscles_2",
                            CategoryId = 2,
                            Description = "This is first description_2",
                            ISBN = "WS102212598",
                            ImageUrl = "",
                            ListPrice = 50.0,
                            Price = 60.0,
                            Price100 = 30.0,
                            Price50 = 55.0,
                            Title = "Cotton Candy_2"
                        },
                        new
                        {
                            Id = 3,
                            Author = "Abby Muscles",
                            CategoryId = 3,
                            Description = "This is first description_3",
                            ISBN = "WS102212563",
                            ImageUrl = "",
                            ListPrice = 70.0,
                            Price = 65.0,
                            Price100 = 40.0,
                            Price50 = 60.0,
                            Title = "Cotton Candy_3"
                        },
                        new
                        {
                            Id = 4,
                            Author = "Abby Muscles_4",
                            CategoryId = 2,
                            Description = "This is first description_4",
                            ISBN = "WS102212750",
                            ImageUrl = "",
                            ListPrice = 60.0,
                            Price = 63.0,
                            Price100 = 46.0,
                            Price50 = 52.0,
                            Title = "Cotton Candy_4"
                        },
                        new
                        {
                            Id = 5,
                            Author = "Abby Muscles_5",
                            CategoryId = 3,
                            Description = "This is first description_5",
                            ISBN = "WS102212555",
                            ImageUrl = "",
                            ListPrice = 70.0,
                            Price = 65.0,
                            Price100 = 40.0,
                            Price50 = 60.0,
                            Title = "Cotton Candy_5"
                        },
                        new
                        {
                            Id = 6,
                            Author = "Abby Muscles",
                            CategoryId = 2,
                            Description = "This is first description_6",
                            ISBN = "WS1022125023",
                            ImageUrl = "",
                            ListPrice = 85.0,
                            Price = 65.0,
                            Price100 = 20.0,
                            Price50 = 80.0,
                            Title = "Cotton Candy_6"
                        });
                });

            modelBuilder.Entity("Web.Models.Models.Product", b =>
                {
                    b.HasOne("Web.Models.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
