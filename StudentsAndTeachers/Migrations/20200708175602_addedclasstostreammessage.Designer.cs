﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentsAndTeachers;

namespace StudentsAndTeachers.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200708175602_addedclasstostreammessage")]
    partial class addedclasstostreammessage
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StudentsAndTeachers.Models.ClassCourse", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("StudentsAndTeachers.Models.Comment", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Homeworkid")
                        .HasColumnType("int");

                    b.Property<int?>("StreamMessageid")
                        .HasColumnType("int");

                    b.Property<string>("comment")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("Homeworkid");

                    b.HasIndex("StreamMessageid");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("StudentsAndTeachers.Models.Homework", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("classCourseid")
                        .HasColumnType("int");

                    b.Property<DateTime>("deadline")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("grade")
                        .HasColumnType("int");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("classCourseid");

                    b.ToTable("Homeworks");
                });

            modelBuilder.Entity("StudentsAndTeachers.Models.StreamMessage", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("classCourseid")
                        .HasColumnType("int");

                    b.Property<DateTime>("dateTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("message")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("classCourseid");

                    b.ToTable("StreamMessages");
                });

            modelBuilder.Entity("StudentsAndTeachers.Models.Comment", b =>
                {
                    b.HasOne("StudentsAndTeachers.Models.Homework", null)
                        .WithMany("Comments")
                        .HasForeignKey("Homeworkid");

                    b.HasOne("StudentsAndTeachers.Models.StreamMessage", null)
                        .WithMany("Comments")
                        .HasForeignKey("StreamMessageid");
                });

            modelBuilder.Entity("StudentsAndTeachers.Models.Homework", b =>
                {
                    b.HasOne("StudentsAndTeachers.Models.ClassCourse", "classCourse")
                        .WithMany("Homeworks")
                        .HasForeignKey("classCourseid");
                });

            modelBuilder.Entity("StudentsAndTeachers.Models.StreamMessage", b =>
                {
                    b.HasOne("StudentsAndTeachers.Models.ClassCourse", "classCourse")
                        .WithMany("Messages")
                        .HasForeignKey("classCourseid");
                });
#pragma warning restore 612, 618
        }
    }
}
