﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using SalesApi.DataContext.Contexts;
using System;

namespace SalesApi.DataContext.Migrations
{
    [DbContext(typeof(SalesContext))]
    partial class SalesContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SalesApi.Models.Settings.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("CreateUser")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<bool>("Deleted");

                    b.Property<string>("LastAction")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<int>("Order");

                    b.Property<string>("Owner")
                        .HasMaxLength(50);

                    b.Property<DateTime>("UpdateTime");

                    b.Property<string>("UpdateUser")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Vehicles");
                });
#pragma warning restore 612, 618
        }
    }
}
