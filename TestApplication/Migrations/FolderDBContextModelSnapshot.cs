// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TestApplication.Models.Data;

namespace TestApplication.Migrations
{
    [DbContext(typeof(FolderDBContext))]
    partial class FolderDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("TestApplication.Models.Folder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CatalogId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int?>("RootFolderId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Folders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CatalogId = 1,
                            Name = "Creating Digital Images"
                        },
                        new
                        {
                            Id = 2,
                            CatalogId = 1,
                            Name = "Resources",
                            RootFolderId = 1
                        },
                        new
                        {
                            Id = 3,
                            CatalogId = 1,
                            Name = "Evidence",
                            RootFolderId = 1
                        },
                        new
                        {
                            Id = 4,
                            CatalogId = 1,
                            Name = "Graphic Products",
                            RootFolderId = 1
                        },
                        new
                        {
                            Id = 5,
                            CatalogId = 1,
                            Name = "Primary Sources",
                            RootFolderId = 2
                        },
                        new
                        {
                            Id = 6,
                            CatalogId = 1,
                            Name = "Secondary Sources",
                            RootFolderId = 2
                        },
                        new
                        {
                            Id = 7,
                            CatalogId = 1,
                            Name = "Process",
                            RootFolderId = 4
                        },
                        new
                        {
                            Id = 8,
                            CatalogId = 1,
                            Name = "Final Product",
                            RootFolderId = 4
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
