// <auto-generated />
using System;
using Marian_Cristina_lab02.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Marian_Cristina_lab02.Migrations
{
    [DbContext(typeof(Marian_Cristina_lab02Context))]
    [Migration("20221030182205_Author")]
    partial class Author
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Marian_Cristina_lab02.Models.Author", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("FirstName")
                        .HasColumnType("int");

                    b.Property<int>("LastName")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Author");
                });

            modelBuilder.Entity("Marian_Cristina_lab02.Models.Book", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int?>("AuthorID")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(6,2)");

                    b.Property<int?>("PublisherID")
                        .HasColumnType("int");

                    b.Property<DateTime>("PublishingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("AuthorID");

                    b.HasIndex("PublisherID");

                    b.ToTable("Book");
                });

            modelBuilder.Entity("Marian_Cristina_lab02.Models.Publisher", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("PublisherName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Publisher");
                });

            modelBuilder.Entity("Marian_Cristina_lab02.Models.Book", b =>
                {
                    b.HasOne("Marian_Cristina_lab02.Models.Author", "Author")
                        .WithMany("Books")
                        .HasForeignKey("AuthorID");

                    b.HasOne("Marian_Cristina_lab02.Models.Publisher", "Publisher")
                        .WithMany("Books")
                        .HasForeignKey("PublisherID");

                    b.Navigation("Author");

                    b.Navigation("Publisher");
                });

            modelBuilder.Entity("Marian_Cristina_lab02.Models.Author", b =>
                {
                    b.Navigation("Books");
                });

            modelBuilder.Entity("Marian_Cristina_lab02.Models.Publisher", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
