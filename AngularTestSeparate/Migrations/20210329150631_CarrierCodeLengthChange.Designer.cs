﻿// <auto-generated />
using System;
using AngularTestSeparate.Models.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AngularTestSeparate.Migrations
{
    [DbContext(typeof(OrderContext))]
    [Migration("20210329150631_CarrierCodeLengthChange")]
    partial class CarrierCodeLengthChange
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AngularTestSeparate.Models.Carrier.Carrier", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CarrierCode")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("CarrierName")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("CarrierPhone")
                        .HasColumnType("varchar(20)");

                    b.Property<string>("DispatcherName")
                        .HasColumnType("varchar(100)");

                    b.Property<string>("McNumber")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Carrier");
                });

            modelBuilder.Entity("AngularTestSeparate.Models.Location.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("CountryCode")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.HasKey("Id");

                    b.ToTable("City");
                });

            modelBuilder.Entity("AngularTestSeparate.Models.Location.Location", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CityId")
                        .HasColumnType("int");

                    b.Property<string>("LocationName")
                        .IsRequired()
                        .HasColumnType("varchar(200)");

                    b.HasKey("Id");

                    b.HasIndex("CityId");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("AngularTestSeparate.Models.Order.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CarrierId")
                        .HasColumnType("int");

                    b.Property<int>("LegNumber")
                        .HasColumnType("int");

                    b.Property<int>("OrderNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CarrierId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("AngularTestSeparate.Models.Stop.Stop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ArrivalTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DepartureTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("EarliestAppointment")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("LatestAppointment")
                        .HasColumnType("datetime2");

                    b.Property<int?>("LocationId")
                        .HasColumnType("int");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("StopSequence")
                        .HasColumnType("int");

                    b.Property<int>("StopType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.HasIndex("OrderId");

                    b.ToTable("Stop");
                });

            modelBuilder.Entity("AngularTestSeparate.Models.Location.Location", b =>
                {
                    b.HasOne("AngularTestSeparate.Models.Location.City", "City")
                        .WithMany()
                        .HasForeignKey("CityId");

                    b.Navigation("City");
                });

            modelBuilder.Entity("AngularTestSeparate.Models.Order.Order", b =>
                {
                    b.HasOne("AngularTestSeparate.Models.Carrier.Carrier", "Carrier")
                        .WithMany()
                        .HasForeignKey("CarrierId");

                    b.Navigation("Carrier");
                });

            modelBuilder.Entity("AngularTestSeparate.Models.Stop.Stop", b =>
                {
                    b.HasOne("AngularTestSeparate.Models.Location.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId");

                    b.HasOne("AngularTestSeparate.Models.Order.Order", null)
                        .WithMany("Stops")
                        .HasForeignKey("OrderId");

                    b.Navigation("Location");
                });

            modelBuilder.Entity("AngularTestSeparate.Models.Order.Order", b =>
                {
                    b.Navigation("Stops");
                });
#pragma warning restore 612, 618
        }
    }
}
