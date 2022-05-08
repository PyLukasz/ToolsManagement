﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ToolsManagement.Entities;

namespace ToolsManagement.Migrations
{
    [DbContext(typeof(ToolsManagementDbContext))]
    partial class ToolsManagementDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ToolsManagement.Entities.Drill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Diameter")
                        .HasColumnType("float");

                    b.Property<double>("Fz")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Vc")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Drills");
                });

            modelBuilder.Entity("ToolsManagement.Entities.EndMillCutter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Diameter")
                        .HasColumnType("float");

                    b.Property<double>("Fz")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfTeeth")
                        .HasColumnType("int");

                    b.Property<int>("Vc")
                        .HasColumnType("int");

                    b.Property<int>("WorkingLength")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("EndMillCutters");
                });
#pragma warning restore 612, 618
        }
    }
}
