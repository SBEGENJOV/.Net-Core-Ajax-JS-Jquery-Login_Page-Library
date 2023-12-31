﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using odev_coreAjaxProject.Data;

#nullable disable

namespace odev_coreAjaxProject.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231116111552_mig1")]
    partial class mig1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("odev_coreAjaxProject.Models.Account.User", b =>
                {
                    b.Property<int>("kID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("kID"), 1L, 1);

                    b.Property<int>("kAd")
                        .HasColumnType("int");

                    b.Property<int>("kSifre")
                        .HasColumnType("int");

                    b.HasKey("kID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("odev_coreAjaxProject.Models.Kitap", b =>
                {
                    b.Property<int>("KitapID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KitapID"), 1L, 1);

                    b.Property<string>("KitapAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KitapSayfa")
                        .HasColumnType("int");

                    b.Property<string>("KitapYazar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KitapYil")
                        .HasColumnType("int");

                    b.HasKey("KitapID");

                    b.ToTable("Kitaps");
                });

            modelBuilder.Entity("odev_coreAjaxProject.Models.Kutuphane", b =>
                {
                    b.Property<int>("KutuphaneID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("KutuphaneID"), 1L, 1);

                    b.Property<string>("KutuphaneAd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KutuphaneKonum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KutuphaneMasaSay")
                        .HasColumnType("int");

                    b.Property<string>("KutuphaneYonetici")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KutuphaneID");

                    b.ToTable("Kutuphanes");
                });

            modelBuilder.Entity("odev_coreAjaxProject.Models.Yazar", b =>
                {
                    b.Property<int>("YazarID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("YazarID"), 1L, 1);

                    b.Property<string>("YazarAdSoyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YazarKitapYaz")
                        .HasColumnType("int");

                    b.Property<string>("YazarMemleket")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YazarYas")
                        .HasColumnType("int");

                    b.HasKey("YazarID");

                    b.ToTable("Yazars");
                });
#pragma warning restore 612, 618
        }
    }
}
