﻿// <auto-generated />
using System;
using DAL.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(HubDbContext))]
    partial class HubDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Entities.Models.AktiviteSeviyesi", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("AktiviteSeviyesiID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SeviyeBilgisi")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<double>("SeviyeDegeri")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.ToTable("AktiviteSeviyeleri");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CreationDate = new DateTime(2023, 5, 16, 13, 57, 33, 447, DateTimeKind.Local).AddTicks(4752),
                            SeviyeBilgisi = "Hareketsiz",
                            SeviyeDegeri = 1.2
                        },
                        new
                        {
                            ID = 2,
                            CreationDate = new DateTime(2023, 5, 16, 13, 57, 33, 447, DateTimeKind.Local).AddTicks(4763),
                            SeviyeBilgisi = "Dusuk Duzey",
                            SeviyeDegeri = 1.375
                        },
                        new
                        {
                            ID = 3,
                            CreationDate = new DateTime(2023, 5, 16, 13, 57, 33, 447, DateTimeKind.Local).AddTicks(4764),
                            SeviyeBilgisi = "Orta Duzey",
                            SeviyeDegeri = 1.55
                        },
                        new
                        {
                            ID = 4,
                            CreationDate = new DateTime(2023, 5, 16, 13, 57, 33, 447, DateTimeKind.Local).AddTicks(4764),
                            SeviyeBilgisi = "Yuksek Duzey",
                            SeviyeDegeri = 1.7250000000000001
                        },
                        new
                        {
                            ID = 5,
                            CreationDate = new DateTime(2023, 5, 16, 13, 57, 33, 447, DateTimeKind.Local).AddTicks(4765),
                            SeviyeBilgisi = "Cok Yuksek Duzey",
                            SeviyeDegeri = 1.8999999999999999
                        });
                });

            modelBuilder.Entity("Entities.Models.BesinDegeri", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("BesinDegeriID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("Kalori")
                        .HasColumnType("float");

                    b.Property<double>("Karbonhidrat")
                        .HasColumnType("float");

                    b.Property<double>("PorsiyonGramaji")
                        .HasColumnType("float");

                    b.Property<double>("Protein")
                        .HasColumnType("float");

                    b.Property<double>("Yag")
                        .HasColumnType("float");

                    b.Property<int?>("YiyecekDetayID")
                        .HasColumnType("int");

                    b.Property<int>("YiyecekOgunID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("YiyecekDetayID");

                    b.HasIndex("YiyecekOgunID");

                    b.ToTable("BesinDegerleri");
                });

            modelBuilder.Entity("Entities.Models.GunlukRapor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("GunlukRaporID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("KaloriIhtiyaci")
                        .HasColumnType("float");

                    b.Property<double>("Karbonhidrat")
                        .HasColumnType("float");

                    b.Property<int>("KullaniciID")
                        .HasColumnType("int");

                    b.Property<double>("Protein")
                        .HasColumnType("float");

                    b.Property<double>("TuketilenKalori")
                        .HasColumnType("float");

                    b.Property<double>("Yag")
                        .HasColumnType("float");

                    b.HasKey("ID");

                    b.HasIndex("KullaniciID");

                    b.ToTable("GunlukRaporlar");
                });

            modelBuilder.Entity("Entities.Models.Kategori", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("KategoriID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("KategoriAd")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Kategoriler");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CreationDate = new DateTime(2023, 5, 16, 13, 57, 33, 447, DateTimeKind.Local).AddTicks(6287),
                            KategoriAd = "Kirmizi Et"
                        },
                        new
                        {
                            ID = 2,
                            CreationDate = new DateTime(2023, 5, 16, 13, 57, 33, 447, DateTimeKind.Local).AddTicks(6293),
                            KategoriAd = "Beyaz Et"
                        },
                        new
                        {
                            ID = 3,
                            CreationDate = new DateTime(2023, 5, 16, 13, 57, 33, 447, DateTimeKind.Local).AddTicks(6294),
                            KategoriAd = "Deniz Urunleri"
                        },
                        new
                        {
                            ID = 4,
                            CreationDate = new DateTime(2023, 5, 16, 13, 57, 33, 447, DateTimeKind.Local).AddTicks(6296),
                            KategoriAd = "Sut ve Sut Urunleri"
                        },
                        new
                        {
                            ID = 5,
                            CreationDate = new DateTime(2023, 5, 16, 13, 57, 33, 447, DateTimeKind.Local).AddTicks(6296),
                            KategoriAd = "Atistirmalik"
                        },
                        new
                        {
                            ID = 6,
                            CreationDate = new DateTime(2023, 5, 16, 13, 57, 33, 447, DateTimeKind.Local).AddTicks(6298),
                            KategoriAd = "Meyve/Sebze"
                        },
                        new
                        {
                            ID = 7,
                            CreationDate = new DateTime(2023, 5, 16, 13, 57, 33, 447, DateTimeKind.Local).AddTicks(6298),
                            KategoriAd = "Temel Gida"
                        });
                });

            modelBuilder.Entity("Entities.Models.Kullanici", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("KullaniciID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("AktiviteSeviyesiID")
                        .HasColumnType("int");

                    b.Property<double>("Boy")
                        .HasColumnType("float");

                    b.Property<int>("Cinsiyet")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DogumTarihi")
                        .HasColumnType("datetime2");

                    b.Property<double>("KaloriIhtiyacı")
                        .HasColumnType("float");

                    b.Property<double>("Kilo")
                        .HasColumnType("float");

                    b.Property<string>("KullaniciAdi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("ResimYolu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("ID");

                    b.HasIndex("AktiviteSeviyesiID");

                    b.HasIndex("KullaniciAdi")
                        .IsUnique();

                    b.ToTable("Kullanicilar");
                });

            modelBuilder.Entity("Entities.Models.KullaniciGecmisi", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("KullaniciGecmisiID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<double>("Boy")
                        .HasColumnType("float");

                    b.Property<int>("Cinsiyet")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DogumTarihi")
                        .HasColumnType("datetime2");

                    b.Property<double>("KaloriIhtiyacı")
                        .HasColumnType("float");

                    b.Property<double>("Kilo")
                        .HasColumnType("float");

                    b.Property<string>("KisininAktiviteGecmisi")
                        .IsRequired()
                        .HasColumnType("varchar");

                    b.Property<string>("KullaniciAdi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<int>("KullaniciID")
                        .HasColumnType("int");

                    b.Property<string>("ResimYolu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sifre")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.HasKey("ID");

                    b.HasIndex("KullaniciID");

                    b.ToTable("KullaniciGecmisleri");
                });

            modelBuilder.Entity("Entities.Models.KullaniciOgun", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("KullaniciOgunID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("KullaniciID")
                        .HasColumnType("int");

                    b.Property<int>("OgunID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("KullaniciID");

                    b.HasIndex("OgunID");

                    b.ToTable("KullaniciOgunleri");
                });

            modelBuilder.Entity("Entities.Models.Ogun", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("OgunID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("OgunAd")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("ID");

                    b.ToTable("Ogunler");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CreationDate = new DateTime(2023, 5, 16, 13, 57, 33, 448, DateTimeKind.Local).AddTicks(2908),
                            OgunAd = "Sabah"
                        },
                        new
                        {
                            ID = 2,
                            CreationDate = new DateTime(2023, 5, 16, 13, 57, 33, 448, DateTimeKind.Local).AddTicks(2919),
                            OgunAd = "Ogle"
                        },
                        new
                        {
                            ID = 3,
                            CreationDate = new DateTime(2023, 5, 16, 13, 57, 33, 448, DateTimeKind.Local).AddTicks(2927),
                            OgunAd = "Aksam"
                        },
                        new
                        {
                            ID = 4,
                            CreationDate = new DateTime(2023, 5, 16, 13, 57, 33, 448, DateTimeKind.Local).AddTicks(2928),
                            OgunAd = "Ara"
                        });
                });

            modelBuilder.Entity("Entities.Models.OgunDetay", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("OgunDetayID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("OgunID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("OgunID");

                    b.ToTable("OgunDetaylari");
                });

            modelBuilder.Entity("Entities.Models.TuketimGecmisi", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("TuketimGecmisiID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("BesinDegeriID")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("KategoriID")
                        .HasColumnType("int");

                    b.Property<int>("KullaniciID")
                        .HasColumnType("int");

                    b.Property<int>("OgunID")
                        .HasColumnType("int");

                    b.Property<int>("YiyecekID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("KullaniciID");

                    b.ToTable("TuketimGecmisleri");
                });

            modelBuilder.Entity("Entities.Models.Yiyecek", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("YiyecekID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("KategoriID")
                        .HasColumnType("int");

                    b.Property<string>("YiyecekAd")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.HasKey("ID");

                    b.HasIndex("KategoriID");

                    b.ToTable("Yiyecekler");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CreationDate = new DateTime(2023, 5, 16, 13, 57, 33, 448, DateTimeKind.Local).AddTicks(5897),
                            KategoriID = 1,
                            YiyecekAd = "Bonfile"
                        },
                        new
                        {
                            ID = 2,
                            CreationDate = new DateTime(2023, 5, 16, 13, 57, 33, 448, DateTimeKind.Local).AddTicks(5905),
                            KategoriID = 2,
                            YiyecekAd = "Firinda Tavuk"
                        },
                        new
                        {
                            ID = 3,
                            CreationDate = new DateTime(2023, 5, 16, 13, 57, 33, 448, DateTimeKind.Local).AddTicks(5906),
                            KategoriID = 3,
                            YiyecekAd = "Hamsi Tava"
                        },
                        new
                        {
                            ID = 4,
                            CreationDate = new DateTime(2023, 5, 16, 13, 57, 33, 448, DateTimeKind.Local).AddTicks(5907),
                            KategoriID = 4,
                            YiyecekAd = "Peynir"
                        },
                        new
                        {
                            ID = 5,
                            CreationDate = new DateTime(2023, 5, 16, 13, 57, 33, 448, DateTimeKind.Local).AddTicks(5908),
                            KategoriID = 5,
                            YiyecekAd = "Cips"
                        },
                        new
                        {
                            ID = 6,
                            CreationDate = new DateTime(2023, 5, 16, 13, 57, 33, 448, DateTimeKind.Local).AddTicks(5909),
                            KategoriID = 6,
                            YiyecekAd = "Elma"
                        });
                });

            modelBuilder.Entity("Entities.Models.YiyecekDetay", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("YiyecekDetayID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Icerik")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<double>("Kalori100gr")
                        .HasColumnType("float");

                    b.Property<double>("Karbonhidrat100gr")
                        .HasColumnType("float");

                    b.Property<double>("Protein100gr")
                        .HasColumnType("float");

                    b.Property<string>("ResimYolu")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<double>("Yag100gr")
                        .HasColumnType("float");

                    b.Property<int>("YiyecekID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("YiyecekID");

                    b.ToTable("YiyecekDetaylari");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CreationDate = new DateTime(2023, 5, 16, 13, 57, 33, 448, DateTimeKind.Local).AddTicks(6962),
                            Icerik = "dana Eti",
                            Kalori100gr = 250.0,
                            Karbonhidrat100gr = 0.0,
                            Protein100gr = 26.0,
                            Yag100gr = 17.0,
                            YiyecekID = 1
                        },
                        new
                        {
                            ID = 2,
                            CreationDate = new DateTime(2023, 5, 16, 13, 57, 33, 448, DateTimeKind.Local).AddTicks(6968),
                            Icerik = "Tavuk Eti",
                            Kalori100gr = 165.0,
                            Karbonhidrat100gr = 0.0,
                            Protein100gr = 31.0,
                            Yag100gr = 3.6000000000000001,
                            YiyecekID = 2
                        },
                        new
                        {
                            ID = 3,
                            CreationDate = new DateTime(2023, 5, 16, 13, 57, 33, 448, DateTimeKind.Local).AddTicks(6969),
                            Icerik = "Balık Eti",
                            Kalori100gr = 208.0,
                            Karbonhidrat100gr = 0.0,
                            Protein100gr = 16.0,
                            Yag100gr = 15.0,
                            YiyecekID = 3
                        },
                        new
                        {
                            ID = 4,
                            CreationDate = new DateTime(2023, 5, 16, 13, 57, 33, 448, DateTimeKind.Local).AddTicks(6970),
                            Icerik = "%70 inek sütü",
                            Kalori100gr = 300.0,
                            Karbonhidrat100gr = 5.0,
                            Protein100gr = 20.0,
                            Yag100gr = 30.0,
                            YiyecekID = 4
                        },
                        new
                        {
                            ID = 5,
                            CreationDate = new DateTime(2023, 5, 16, 13, 57, 33, 448, DateTimeKind.Local).AddTicks(6972),
                            Icerik = "Anne eli değimiş gibi",
                            Kalori100gr = 536.0,
                            Karbonhidrat100gr = 51.0,
                            Protein100gr = 6.5999999999999996,
                            Yag100gr = 34.0,
                            YiyecekID = 5
                        },
                        new
                        {
                            ID = 6,
                            CreationDate = new DateTime(2023, 5, 16, 13, 57, 33, 448, DateTimeKind.Local).AddTicks(6973),
                            Icerik = "newton hatrına",
                            Kalori100gr = 52.0,
                            Karbonhidrat100gr = 14.0,
                            Protein100gr = 0.29999999999999999,
                            Yag100gr = 0.20000000000000001,
                            YiyecekID = 6
                        });
                });

            modelBuilder.Entity("Entities.Models.YiyecekOgun", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("YiyecekOgunID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("OgunID")
                        .HasColumnType("int");

                    b.Property<int>("YiyecekID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("OgunID");

                    b.HasIndex("YiyecekID");

                    b.ToTable("YiyecekOgunler");
                });

            modelBuilder.Entity("Entities.Models.BesinDegeri", b =>
                {
                    b.HasOne("Entities.Models.YiyecekDetay", null)
                        .WithMany("BesinDegerleri")
                        .HasForeignKey("YiyecekDetayID");

                    b.HasOne("Entities.Models.YiyecekOgun", "YiyecekOgun")
                        .WithMany("BesinDegerleri")
                        .HasForeignKey("YiyecekOgunID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("YiyecekOgun");
                });

            modelBuilder.Entity("Entities.Models.GunlukRapor", b =>
                {
                    b.HasOne("Entities.Models.Kullanici", "Kullanici")
                        .WithMany("GunlukRaporlar")
                        .HasForeignKey("KullaniciID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kullanici");
                });

            modelBuilder.Entity("Entities.Models.Kullanici", b =>
                {
                    b.HasOne("Entities.Models.AktiviteSeviyesi", "AktiviteSeviyesi")
                        .WithMany("Kullanicilar")
                        .HasForeignKey("AktiviteSeviyesiID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AktiviteSeviyesi");
                });

            modelBuilder.Entity("Entities.Models.KullaniciGecmisi", b =>
                {
                    b.HasOne("Entities.Models.Kullanici", "Kullanici")
                        .WithMany("KullaniciGecmisleri")
                        .HasForeignKey("KullaniciID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kullanici");
                });

            modelBuilder.Entity("Entities.Models.KullaniciOgun", b =>
                {
                    b.HasOne("Entities.Models.Kullanici", "Kullanici")
                        .WithMany("KullaniciOgunleri")
                        .HasForeignKey("KullaniciID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Models.Ogun", "Ogun")
                        .WithMany("KullaniciOgunleri")
                        .HasForeignKey("OgunID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kullanici");

                    b.Navigation("Ogun");
                });

            modelBuilder.Entity("Entities.Models.OgunDetay", b =>
                {
                    b.HasOne("Entities.Models.Ogun", "Ogun")
                        .WithMany("OgunDetaylari")
                        .HasForeignKey("OgunID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ogun");
                });

            modelBuilder.Entity("Entities.Models.TuketimGecmisi", b =>
                {
                    b.HasOne("Entities.Models.Kullanici", "Kullanici")
                        .WithMany("TuketimGecmisleri")
                        .HasForeignKey("KullaniciID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kullanici");
                });

            modelBuilder.Entity("Entities.Models.Yiyecek", b =>
                {
                    b.HasOne("Entities.Models.Kategori", "Kategori")
                        .WithMany("Yiyecekler")
                        .HasForeignKey("KategoriID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");
                });

            modelBuilder.Entity("Entities.Models.YiyecekDetay", b =>
                {
                    b.HasOne("Entities.Models.Yiyecek", "Yiyecek")
                        .WithMany("YiyecekDetaylari")
                        .HasForeignKey("YiyecekID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Yiyecek");
                });

            modelBuilder.Entity("Entities.Models.YiyecekOgun", b =>
                {
                    b.HasOne("Entities.Models.Ogun", "Ogun")
                        .WithMany("YiyecekOgunleri")
                        .HasForeignKey("OgunID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Entities.Models.Yiyecek", "Yiyecek")
                        .WithMany()
                        .HasForeignKey("YiyecekID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ogun");

                    b.Navigation("Yiyecek");
                });

            modelBuilder.Entity("Entities.Models.AktiviteSeviyesi", b =>
                {
                    b.Navigation("Kullanicilar");
                });

            modelBuilder.Entity("Entities.Models.Kategori", b =>
                {
                    b.Navigation("Yiyecekler");
                });

            modelBuilder.Entity("Entities.Models.Kullanici", b =>
                {
                    b.Navigation("GunlukRaporlar");

                    b.Navigation("KullaniciGecmisleri");

                    b.Navigation("KullaniciOgunleri");

                    b.Navigation("TuketimGecmisleri");
                });

            modelBuilder.Entity("Entities.Models.Ogun", b =>
                {
                    b.Navigation("KullaniciOgunleri");

                    b.Navigation("OgunDetaylari");

                    b.Navigation("YiyecekOgunleri");
                });

            modelBuilder.Entity("Entities.Models.Yiyecek", b =>
                {
                    b.Navigation("YiyecekDetaylari");
                });

            modelBuilder.Entity("Entities.Models.YiyecekDetay", b =>
                {
                    b.Navigation("BesinDegerleri");
                });

            modelBuilder.Entity("Entities.Models.YiyecekOgun", b =>
                {
                    b.Navigation("BesinDegerleri");
                });
#pragma warning restore 612, 618
        }
    }
}
