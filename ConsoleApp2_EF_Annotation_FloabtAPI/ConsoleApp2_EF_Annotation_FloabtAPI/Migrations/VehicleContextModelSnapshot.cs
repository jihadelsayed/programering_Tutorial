﻿// <auto-generated />
using System;
using ConsoleApp2_EF_Annotation_FloabtAPI;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ConsoleApp2_EF_Annotation_FloabtAPI.Migrations
{
    [DbContext(typeof(VehicleContext))]
    partial class VehicleContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ConsoleApp2_EF_Annotation_FloabtAPI.Car", b =>
                {
                    b.Property<int>("MySpecialId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("ModelFluent");

                    b.Property<int>("Speed")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("MySpecialId");

                    b.HasIndex("CompanyId");

                    b.ToTable("CarTable");
                });

            modelBuilder.Entity("ConsoleApp2_EF_Annotation_FloabtAPI.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("ConsoleApp2_EF_Annotation_FloabtAPI.Motorcycle", b =>
                {
                    b.HasBaseType("ConsoleApp2_EF_Annotation_FloabtAPI.Car");

                    b.Property<int?>("CompanyId1")
                        .HasColumnType("int");

                    b.HasIndex("CompanyId1");

                    b.ToTable("CarsDA");
                });

            modelBuilder.Entity("ConsoleApp2_EF_Annotation_FloabtAPI.Car", b =>
                {
                    b.HasOne("ConsoleApp2_EF_Annotation_FloabtAPI.Company", "Company")
                        .WithMany("Cars")
                        .HasForeignKey("CompanyId");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("ConsoleApp2_EF_Annotation_FloabtAPI.Motorcycle", b =>
                {
                    b.HasOne("ConsoleApp2_EF_Annotation_FloabtAPI.Company", null)
                        .WithMany("Motorcycles")
                        .HasForeignKey("CompanyId1");

                    b.HasOne("ConsoleApp2_EF_Annotation_FloabtAPI.Car", null)
                        .WithOne()
                        .HasForeignKey("ConsoleApp2_EF_Annotation_FloabtAPI.Motorcycle", "MySpecialId")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ConsoleApp2_EF_Annotation_FloabtAPI.Company", b =>
                {
                    b.Navigation("Cars");

                    b.Navigation("Motorcycles");
                });
#pragma warning restore 612, 618
        }
    }
}