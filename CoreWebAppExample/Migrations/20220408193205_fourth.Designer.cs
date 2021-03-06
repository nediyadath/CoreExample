// <auto-generated />
using System;
using CoreWebAppExample.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CoreWebAppExample.Migrations
{
    [DbContext(typeof(HospitalContext))]
    [Migration("20220408193205_fourth")]
    partial class fourth
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CoreWebAppExample.Models.Appointment", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.Property<int>("docID")
                        .HasColumnType("int");

                    b.Property<int>("ptID")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("docID");

                    b.HasIndex("ptID");

                    b.ToTable("appointment");
                });

            modelBuilder.Entity("CoreWebAppExample.Models.Doctor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("speciality")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("doctor");
                });

            modelBuilder.Entity("CoreWebAppExample.Models.Hospital", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("check")
                        .HasColumnType("bit");

                    b.Property<string>("city")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("hospital");
                });

            modelBuilder.Entity("CoreWebAppExample.Models.Patient", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Allergies")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("patient");
                });

            modelBuilder.Entity("CoreWebAppExample.Models.Schedule", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("docID")
                        .HasColumnType("int");

                    b.Property<string>("schedule")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("docID");

                    b.ToTable("schedule");
                });

            modelBuilder.Entity("CoreWebAppExample.Models.Appointment", b =>
                {
                    b.HasOne("CoreWebAppExample.Models.Doctor", "doctor")
                        .WithMany()
                        .HasForeignKey("docID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("CoreWebAppExample.Models.Patient", "patient")
                        .WithMany()
                        .HasForeignKey("ptID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("doctor");

                    b.Navigation("patient");
                });

            modelBuilder.Entity("CoreWebAppExample.Models.Schedule", b =>
                {
                    b.HasOne("CoreWebAppExample.Models.Doctor", "doc")
                        .WithMany()
                        .HasForeignKey("docID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("doc");
                });
#pragma warning restore 612, 618
        }
    }
}
