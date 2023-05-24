﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TransactionalAPIMaddiApp.Data;

#nullable disable

namespace TransactionalAPIMaddiApp.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230523204552_InitialDb2")]
    partial class InitialDb2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TransactionalAPIMaddiApp.Data.Entities.AssetsImage", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("StrImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("tblAssetsImage");
                });

            modelBuilder.Entity("TransactionalAPIMaddiApp.Data.Entities.Headquarter", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("BiActive")
                        .HasColumnType("bit");

                    b.Property<bool>("BiBooking")
                        .HasColumnType("bit");

                    b.Property<bool>("BiDelivery")
                        .HasColumnType("bit");

                    b.Property<bool>("BiOrderTable")
                        .HasColumnType("bit");

                    b.Property<TimeSpan>("DtEnd")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("DtStart")
                        .HasColumnType("time");

                    b.Property<Guid>("RestaurantFK")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("StrAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StrName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RestaurantFK");

                    b.ToTable("tblHeadquarter");
                });

            modelBuilder.Entity("TransactionalAPIMaddiApp.Data.Entities.Restaurant", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("BiActive")
                        .HasColumnType("bit");

                    b.Property<int>("IntCantSedes")
                        .HasColumnType("int");

                    b.Property<Guid>("Logo_AssetsFK")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("StrDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StrName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StrNit")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StrWebsite")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("UserFK")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("Logo_AssetsFK")
                        .IsUnique();

                    b.HasIndex("UserFK")
                        .IsUnique();

                    b.ToTable("tblRestaurant");
                });

            modelBuilder.Entity("TransactionalAPIMaddiApp.Data.Entities.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("BiActive")
                        .HasColumnType("bit");

                    b.Property<bool>("BiEmailConfirm")
                        .HasColumnType("bit");

                    b.Property<bool>("BiPhoneConfirm")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("DtExpirationDateOTP")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DtLastFailedLogin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DtLastLogin")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DtLastPasswordChange")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DtUnlookDt")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("HsLastPassword")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("HsPassword")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("IntLoginFailed")
                        .HasColumnType("int");

                    b.Property<string>("StrDocument")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StrEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StrName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StrOTP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StrPhone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StrRemark")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StrUser")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("tblUser");
                });

            modelBuilder.Entity("TransactionalAPIMaddiApp.Data.Entities.Headquarter", b =>
                {
                    b.HasOne("TransactionalAPIMaddiApp.Data.Entities.Restaurant", "Restaurant")
                        .WithMany()
                        .HasForeignKey("RestaurantFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("TransactionalAPIMaddiApp.Data.Entities.Restaurant", b =>
                {
                    b.HasOne("TransactionalAPIMaddiApp.Data.Entities.AssetsImage", "AssetsImage")
                        .WithOne()
                        .HasForeignKey("TransactionalAPIMaddiApp.Data.Entities.Restaurant", "Logo_AssetsFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TransactionalAPIMaddiApp.Data.Entities.User", "User")
                        .WithOne()
                        .HasForeignKey("TransactionalAPIMaddiApp.Data.Entities.Restaurant", "UserFK")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AssetsImage");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}