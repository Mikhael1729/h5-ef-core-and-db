﻿// <auto-generated />
using System;
using BdEntityFramework.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BdEntityFramework.Migrations
{
    [DbContext(typeof(SchoolDbContext))]
    partial class SchoolDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BdEntityFramework.Models.Classroom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("Id");

                    b.ToTable("Classrooms");
                });

            modelBuilder.Entity("BdEntityFramework.Models.Instrument", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(500);

                    b.Property<double>("Price");

                    b.Property<int>("StudentId");

                    b.HasKey("Id");

                    b.HasIndex("StudentId")
                        .IsUnique();

                    b.ToTable("Instruments");
                });

            modelBuilder.Entity("BdEntityFramework.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Firstname")
                        .HasMaxLength(500);

                    b.Property<string>("Lastname")
                        .HasMaxLength(800);

                    b.HasKey("Id");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("BdEntityFramework.Models.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClassroomId");

                    b.Property<DateTime>("EndTime");

                    b.Property<string>("Name")
                        .HasMaxLength(500);

                    b.Property<DateTime>("StartTime");

                    b.Property<int>("TeacherId");

                    b.HasKey("Id");

                    b.HasIndex("ClassroomId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("BdEntityFramework.Models.SubjectClassroom", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClassroomId");

                    b.Property<int>("SubjectId");

                    b.HasKey("Id");

                    b.HasIndex("ClassroomId");

                    b.HasIndex("SubjectId");

                    b.ToTable("SubjectClassrooms");
                });

            modelBuilder.Entity("BdEntityFramework.Models.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Firstname")
                        .HasMaxLength(500);

                    b.Property<string>("Lastname")
                        .HasMaxLength(800);

                    b.HasKey("Id");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("BdEntityFramework.Models.Instrument", b =>
                {
                    b.HasOne("BdEntityFramework.Models.Student", "Student")
                        .WithOne("Instrument")
                        .HasForeignKey("BdEntityFramework.Models.Instrument", "StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BdEntityFramework.Models.Subject", b =>
                {
                    b.HasOne("BdEntityFramework.Models.Classroom")
                        .WithMany("Subjects")
                        .HasForeignKey("ClassroomId");

                    b.HasOne("BdEntityFramework.Models.Teacher", "Teacher")
                        .WithMany("Subjects")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BdEntityFramework.Models.SubjectClassroom", b =>
                {
                    b.HasOne("BdEntityFramework.Models.Classroom", "Classroom")
                        .WithMany()
                        .HasForeignKey("ClassroomId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("BdEntityFramework.Models.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
