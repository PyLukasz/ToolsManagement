﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ToolsManagement.Data.Context;

namespace ToolsManagement.Migrations
{
    [DbContext(typeof(ToolsManagementDbContext))]
    [Migration("20220726103126_AddLengthToDrillEntity")]
    partial class AddLengthToDrillEntity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<int>("Length")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Drills");
                });

            modelBuilder.Entity("ToolsManagement.Entities.DrillParameters", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DrillId")
                        .HasColumnType("int");

                    b.Property<double>("Fz")
                        .HasColumnType("float");

                    b.Property<int>("Vc")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DrillId");

                    b.ToTable("DrillParameters");
                });

            modelBuilder.Entity("ToolsManagement.Entities.EndMillCutter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Diameter")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("EndMillCutters");
                });

            modelBuilder.Entity("ToolsManagement.Entities.EndMillCutterParameters", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EndMillCutterId")
                        .HasColumnType("int");

                    b.Property<double>("Fz")
                        .HasColumnType("float");

                    b.Property<int>("NumberOfTeeth")
                        .HasColumnType("int");

                    b.Property<int>("Vc")
                        .HasColumnType("int");

                    b.Property<int>("WorkingLength")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EndMillCutterId");

                    b.ToTable("EndMillCutterParameters");
                });

            modelBuilder.Entity("ToolsManagement.Entities.DrillParameters", b =>
                {
                    b.HasOne("ToolsManagement.Entities.Drill", "Drill")
                        .WithMany("DrillParameters")
                        .HasForeignKey("DrillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Drill");
                });

            modelBuilder.Entity("ToolsManagement.Entities.EndMillCutterParameters", b =>
                {
                    b.HasOne("ToolsManagement.Entities.EndMillCutter", "EndMillCutter")
                        .WithMany("EndMillCutterParameters")
                        .HasForeignKey("EndMillCutterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EndMillCutter");
                });

            modelBuilder.Entity("ToolsManagement.Entities.Drill", b =>
                {
                    b.Navigation("DrillParameters");
                });

            modelBuilder.Entity("ToolsManagement.Entities.EndMillCutter", b =>
                {
                    b.Navigation("EndMillCutterParameters");
                });
#pragma warning restore 612, 618
        }
    }
}
