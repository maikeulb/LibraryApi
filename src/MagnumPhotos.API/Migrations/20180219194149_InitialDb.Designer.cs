﻿// <auto-generated />
using MagnumPhotos.API.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace MagnumPhotos.Migrations
{
    [DbContext(typeof(MagnumPhotosContext))]
    [Migration("20180219194149_InitialDb")]
    partial class InitialDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("MagnumPhotos.API.Entities.Book", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("CopyrightDate")
                        .IsRequired();

                    b.Property<string>("Description")
                        .HasMaxLength(500);

                    b.Property<Guid>("PhotographerId");

                    b.Property<Guid?>("PhotographerId1");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.HasIndex("PhotographerId");

                    b.HasIndex("PhotographerId1");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("MagnumPhotos.API.Entities.Photographer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTimeOffset>("DateOfBirth");

                    b.Property<DateTimeOffset?>("DateOfDeath");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Genre");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Photographers");
                });

            modelBuilder.Entity("MagnumPhotos.API.Entities.Book", b =>
                {
                    b.HasOne("MagnumPhotos.API.Entities.Photographer", "Photographer")
                        .WithMany()
                        .HasForeignKey("PhotographerId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MagnumPhotos.API.Entities.Photographer")
                        .WithMany("Books")
                        .HasForeignKey("PhotographerId1");
                });
#pragma warning restore 612, 618
        }
    }
}
