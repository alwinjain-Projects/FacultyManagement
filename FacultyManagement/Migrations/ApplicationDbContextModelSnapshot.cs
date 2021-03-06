﻿// <auto-generated />
using FacultyManagement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FacultyManagement.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FacultyManagement.Models.FacultyResponse", b =>
                {
                    b.Property<int>("fId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("fLastName")
                        .IsRequired();

                    b.Property<string>("fName")
                        .IsRequired();

                    b.HasKey("fId");

                    b.ToTable("Faculty");
                });

            modelBuilder.Entity("FacultyManagement.Models.FeedbackResponse", b =>
                {
                    b.Property<int>("fId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Message")
                        .IsRequired();

                    b.Property<string>("cOrF")
                        .IsRequired();

                    b.Property<string>("cOrFName")
                        .IsRequired();

                    b.Property<string>("fName")
                        .IsRequired();

                    b.Property<string>("feedback")
                        .IsRequired();

                    b.Property<string>("gmail")
                        .IsRequired();

                    b.Property<string>("lName")
                        .IsRequired();

                    b.Property<string>("phone")
                        .IsRequired();

                    b.HasKey("fId");

                    b.ToTable("FacultyFeedback");
                });
#pragma warning restore 612, 618
        }
    }
}
