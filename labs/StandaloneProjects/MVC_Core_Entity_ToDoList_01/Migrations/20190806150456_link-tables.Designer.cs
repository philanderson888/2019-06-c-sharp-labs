﻿// <auto-generated />
using System;
using MVC_Core_Entity_ToDoList_01.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MVC_Core_Entity_ToDoList_01.Migrations
{
    [DbContext(typeof(TaskDbContext))]
    [Migration("20190806150456_link-tables")]
    partial class linktables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MVC_Core_Entity_ToDoList_01.Models.Category", b =>
                {
                    b.Property<int>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName");

                    b.HasKey("CategoryID");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("MVC_Core_Entity_ToDoList_01.Models.Task", b =>
                {
                    b.Property<int>("TaskID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryID");

                    b.Property<DateTime>("DueDate");

                    b.Property<string>("TaskName");

                    b.HasKey("TaskID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Task");
                });

            modelBuilder.Entity("MVC_Core_Entity_ToDoList_01.Models.Task", b =>
                {
                    b.HasOne("MVC_Core_Entity_ToDoList_01.Models.Category", "Category")
                        .WithMany("Tasks")
                        .HasForeignKey("CategoryID");
                });
#pragma warning restore 612, 618
        }
    }
}
