using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class V1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AktiviteSeviyeleri",
                columns: table => new
                {
                    AktiviteSeviyesiID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeviyeBilgisi = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    SeviyeDegeri = table.Column<double>(type: "float", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AktiviteSeviyeleri", x => x.AktiviteSeviyesiID);
                });

            migrationBuilder.CreateTable(
                name: "Kategoriler",
                columns: table => new
                {
                    KategoriID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriAd = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoriler", x => x.KategoriID);
                });

            migrationBuilder.CreateTable(
                name: "Ogunler",
                columns: table => new
                {
                    OgunID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgunAd = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ogunler", x => x.OgunID);
                });

            migrationBuilder.CreateTable(
                name: "Kullanicilar",
                columns: table => new
                {
                    KullaniciID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AktiviteSeviyesiID = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ad = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Soyad = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Cinsiyet = table.Column<int>(type: "int", nullable: false),
                    KullaniciAdi = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Boy = table.Column<double>(type: "float", nullable: false),
                    Kilo = table.Column<double>(type: "float", nullable: false),
                    KaloriIhtiyacı = table.Column<double>(type: "float", nullable: false),
                    ResimYolu = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kullanicilar", x => x.KullaniciID);
                    table.ForeignKey(
                        name: "FK_Kullanicilar_AktiviteSeviyeleri_AktiviteSeviyesiID",
                        column: x => x.AktiviteSeviyesiID,
                        principalTable: "AktiviteSeviyeleri",
                        principalColumn: "AktiviteSeviyesiID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Yiyecekler",
                columns: table => new
                {
                    YiyecekID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    YiyecekAd = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    KategoriID = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yiyecekler", x => x.YiyecekID);
                    table.ForeignKey(
                        name: "FK_Yiyecekler_Kategoriler_KategoriID",
                        column: x => x.KategoriID,
                        principalTable: "Kategoriler",
                        principalColumn: "KategoriID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OgunDetaylari",
                columns: table => new
                {
                    OgunDetayID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgunID = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgunDetaylari", x => x.OgunDetayID);
                    table.ForeignKey(
                        name: "FK_OgunDetaylari_Ogunler_OgunID",
                        column: x => x.OgunID,
                        principalTable: "Ogunler",
                        principalColumn: "OgunID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GunlukRaporlar",
                columns: table => new
                {
                    GunlukRaporID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KaloriIhtiyaci = table.Column<double>(type: "float", nullable: false),
                    TuketilenKalori = table.Column<double>(type: "float", nullable: false),
                    Protein = table.Column<double>(type: "float", nullable: false),
                    Karbonhidrat = table.Column<double>(type: "float", nullable: false),
                    Yag = table.Column<double>(type: "float", nullable: false),
                    KullaniciID = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GunlukRaporlar", x => x.GunlukRaporID);
                    table.ForeignKey(
                        name: "FK_GunlukRaporlar_Kullanicilar_KullaniciID",
                        column: x => x.KullaniciID,
                        principalTable: "Kullanicilar",
                        principalColumn: "KullaniciID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KullaniciGecmisleri",
                columns: table => new
                {
                    KullaniciGecmisiID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KisininAktiviteGecmisi = table.Column<string>(type: "varchar", nullable: false),
                    KullaniciID = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ad = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Soyad = table.Column<string>(type: "varchar(20)", maxLength: 20, nullable: false),
                    Cinsiyet = table.Column<int>(type: "int", nullable: false),
                    KullaniciAdi = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Sifre = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    DogumTarihi = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Boy = table.Column<double>(type: "float", nullable: false),
                    Kilo = table.Column<double>(type: "float", nullable: false),
                    KaloriIhtiyacı = table.Column<double>(type: "float", nullable: false),
                    ResimYolu = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KullaniciGecmisleri", x => x.KullaniciGecmisiID);
                    table.ForeignKey(
                        name: "FK_KullaniciGecmisleri_Kullanicilar_KullaniciID",
                        column: x => x.KullaniciID,
                        principalTable: "Kullanicilar",
                        principalColumn: "KullaniciID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KullaniciOgunleri",
                columns: table => new
                {
                    KullaniciOgunID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KullaniciID = table.Column<int>(type: "int", nullable: false),
                    OgunID = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KullaniciOgunleri", x => x.KullaniciOgunID);
                    table.ForeignKey(
                        name: "FK_KullaniciOgunleri_Kullanicilar_KullaniciID",
                        column: x => x.KullaniciID,
                        principalTable: "Kullanicilar",
                        principalColumn: "KullaniciID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KullaniciOgunleri_Ogunler_OgunID",
                        column: x => x.OgunID,
                        principalTable: "Ogunler",
                        principalColumn: "OgunID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TuketimGecmisleri",
                columns: table => new
                {
                    TuketimGecmisiID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgunID = table.Column<int>(type: "int", nullable: false),
                    KategoriID = table.Column<int>(type: "int", nullable: false),
                    YiyecekID = table.Column<int>(type: "int", nullable: false),
                    BesinDegeriID = table.Column<int>(type: "int", nullable: false),
                    KullaniciID = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TuketimGecmisleri", x => x.TuketimGecmisiID);
                    table.ForeignKey(
                        name: "FK_TuketimGecmisleri_Kullanicilar_KullaniciID",
                        column: x => x.KullaniciID,
                        principalTable: "Kullanicilar",
                        principalColumn: "KullaniciID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "YiyecekDetaylari",
                columns: table => new
                {
                    YiyecekDetayID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Icerik = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    ResimYolu = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Kalori100gr = table.Column<double>(type: "float", nullable: false),
                    Protein100gr = table.Column<double>(type: "float", nullable: false),
                    Karbonhidrat100gr = table.Column<double>(type: "float", nullable: false),
                    Yag100gr = table.Column<double>(type: "float", nullable: false),
                    YiyecekID = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YiyecekDetaylari", x => x.YiyecekDetayID);
                    table.ForeignKey(
                        name: "FK_YiyecekDetaylari_Yiyecekler_YiyecekID",
                        column: x => x.YiyecekID,
                        principalTable: "Yiyecekler",
                        principalColumn: "YiyecekID");
                });

            migrationBuilder.CreateTable(
                name: "YiyecekOgunler",
                columns: table => new
                {
                    YiyecekOgunID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OgunID = table.Column<int>(type: "int", nullable: false),
                    YiyecekID = table.Column<int>(type: "int", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YiyecekOgunler", x => x.YiyecekOgunID);
                    table.ForeignKey(
                        name: "FK_YiyecekOgunler_Ogunler_OgunID",
                        column: x => x.OgunID,
                        principalTable: "Ogunler",
                        principalColumn: "OgunID");
                    table.ForeignKey(
                        name: "FK_YiyecekOgunler_Yiyecekler_YiyecekID",
                        column: x => x.YiyecekID,
                        principalTable: "Yiyecekler",
                        principalColumn: "YiyecekID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BesinDegerleri",
                columns: table => new
                {
                    BesinDegeriID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PorsiyonGramaji = table.Column<double>(type: "float", nullable: false),
                    Kalori = table.Column<double>(type: "float", nullable: false),
                    Protein = table.Column<double>(type: "float", nullable: false),
                    Karbonhidrat = table.Column<double>(type: "float", nullable: false),
                    Yag = table.Column<double>(type: "float", nullable: false),
                    YiyecekOgunID = table.Column<int>(type: "int", nullable: false),
                    YiyecekDetayID = table.Column<int>(type: "int", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BesinDegerleri", x => x.BesinDegeriID);
                    table.ForeignKey(
                        name: "FK_BesinDegerleri_YiyecekDetaylari_YiyecekDetayID",
                        column: x => x.YiyecekDetayID,
                        principalTable: "YiyecekDetaylari",
                        principalColumn: "YiyecekDetayID");
                    table.ForeignKey(
                        name: "FK_BesinDegerleri_YiyecekOgunler_YiyecekOgunID",
                        column: x => x.YiyecekOgunID,
                        principalTable: "YiyecekOgunler",
                        principalColumn: "YiyecekOgunID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AktiviteSeviyeleri",
                columns: new[] { "AktiviteSeviyesiID", "CreationDate", "SeviyeBilgisi", "SeviyeDegeri" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 16, 13, 57, 33, 447, DateTimeKind.Local).AddTicks(4752), "Hareketsiz", 1.2 },
                    { 2, new DateTime(2023, 5, 16, 13, 57, 33, 447, DateTimeKind.Local).AddTicks(4763), "Dusuk Duzey", 1.375 },
                    { 3, new DateTime(2023, 5, 16, 13, 57, 33, 447, DateTimeKind.Local).AddTicks(4764), "Orta Duzey", 1.55 },
                    { 4, new DateTime(2023, 5, 16, 13, 57, 33, 447, DateTimeKind.Local).AddTicks(4764), "Yuksek Duzey", 1.7250000000000001 },
                    { 5, new DateTime(2023, 5, 16, 13, 57, 33, 447, DateTimeKind.Local).AddTicks(4765), "Cok Yuksek Duzey", 1.8999999999999999 }
                });

            migrationBuilder.InsertData(
                table: "Kategoriler",
                columns: new[] { "KategoriID", "CreationDate", "KategoriAd" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 16, 13, 57, 33, 447, DateTimeKind.Local).AddTicks(6287), "Kirmizi Et" },
                    { 2, new DateTime(2023, 5, 16, 13, 57, 33, 447, DateTimeKind.Local).AddTicks(6293), "Beyaz Et" },
                    { 3, new DateTime(2023, 5, 16, 13, 57, 33, 447, DateTimeKind.Local).AddTicks(6294), "Deniz Urunleri" },
                    { 4, new DateTime(2023, 5, 16, 13, 57, 33, 447, DateTimeKind.Local).AddTicks(6296), "Sut ve Sut Urunleri" },
                    { 5, new DateTime(2023, 5, 16, 13, 57, 33, 447, DateTimeKind.Local).AddTicks(6296), "Atistirmalik" },
                    { 6, new DateTime(2023, 5, 16, 13, 57, 33, 447, DateTimeKind.Local).AddTicks(6298), "Meyve/Sebze" },
                    { 7, new DateTime(2023, 5, 16, 13, 57, 33, 447, DateTimeKind.Local).AddTicks(6298), "Temel Gida" }
                });

            migrationBuilder.InsertData(
                table: "Ogunler",
                columns: new[] { "OgunID", "CreationDate", "OgunAd" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 16, 13, 57, 33, 448, DateTimeKind.Local).AddTicks(2908), "Sabah" },
                    { 2, new DateTime(2023, 5, 16, 13, 57, 33, 448, DateTimeKind.Local).AddTicks(2919), "Ogle" },
                    { 3, new DateTime(2023, 5, 16, 13, 57, 33, 448, DateTimeKind.Local).AddTicks(2927), "Aksam" },
                    { 4, new DateTime(2023, 5, 16, 13, 57, 33, 448, DateTimeKind.Local).AddTicks(2928), "Ara" }
                });

            migrationBuilder.InsertData(
                table: "Yiyecekler",
                columns: new[] { "YiyecekID", "CreationDate", "KategoriID", "YiyecekAd" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 16, 13, 57, 33, 448, DateTimeKind.Local).AddTicks(5897), 1, "Bonfile" },
                    { 2, new DateTime(2023, 5, 16, 13, 57, 33, 448, DateTimeKind.Local).AddTicks(5905), 2, "Firinda Tavuk" },
                    { 3, new DateTime(2023, 5, 16, 13, 57, 33, 448, DateTimeKind.Local).AddTicks(5906), 3, "Hamsi Tava" },
                    { 4, new DateTime(2023, 5, 16, 13, 57, 33, 448, DateTimeKind.Local).AddTicks(5907), 4, "Peynir" },
                    { 5, new DateTime(2023, 5, 16, 13, 57, 33, 448, DateTimeKind.Local).AddTicks(5908), 5, "Cips" },
                    { 6, new DateTime(2023, 5, 16, 13, 57, 33, 448, DateTimeKind.Local).AddTicks(5909), 6, "Elma" }
                });

            migrationBuilder.InsertData(
                table: "YiyecekDetaylari",
                columns: new[] { "YiyecekDetayID", "CreationDate", "Icerik", "Kalori100gr", "Karbonhidrat100gr", "Protein100gr", "ResimYolu", "Yag100gr", "YiyecekID" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 16, 13, 57, 33, 448, DateTimeKind.Local).AddTicks(6962), "dana Eti", 250.0, 0.0, 26.0, null, 17.0, 1 },
                    { 2, new DateTime(2023, 5, 16, 13, 57, 33, 448, DateTimeKind.Local).AddTicks(6968), "Tavuk Eti", 165.0, 0.0, 31.0, null, 3.6000000000000001, 2 },
                    { 3, new DateTime(2023, 5, 16, 13, 57, 33, 448, DateTimeKind.Local).AddTicks(6969), "Balık Eti", 208.0, 0.0, 16.0, null, 15.0, 3 },
                    { 4, new DateTime(2023, 5, 16, 13, 57, 33, 448, DateTimeKind.Local).AddTicks(6970), "%70 inek sütü", 300.0, 5.0, 20.0, null, 30.0, 4 },
                    { 5, new DateTime(2023, 5, 16, 13, 57, 33, 448, DateTimeKind.Local).AddTicks(6972), "Anne eli değimiş gibi", 536.0, 51.0, 6.5999999999999996, null, 34.0, 5 },
                    { 6, new DateTime(2023, 5, 16, 13, 57, 33, 448, DateTimeKind.Local).AddTicks(6973), "newton hatrına", 52.0, 14.0, 0.29999999999999999, null, 0.20000000000000001, 6 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BesinDegerleri_YiyecekDetayID",
                table: "BesinDegerleri",
                column: "YiyecekDetayID");

            migrationBuilder.CreateIndex(
                name: "IX_BesinDegerleri_YiyecekOgunID",
                table: "BesinDegerleri",
                column: "YiyecekOgunID");

            migrationBuilder.CreateIndex(
                name: "IX_GunlukRaporlar_KullaniciID",
                table: "GunlukRaporlar",
                column: "KullaniciID");

            migrationBuilder.CreateIndex(
                name: "IX_KullaniciGecmisleri_KullaniciID",
                table: "KullaniciGecmisleri",
                column: "KullaniciID");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicilar_AktiviteSeviyesiID",
                table: "Kullanicilar",
                column: "AktiviteSeviyesiID");

            migrationBuilder.CreateIndex(
                name: "IX_Kullanicilar_KullaniciAdi",
                table: "Kullanicilar",
                column: "KullaniciAdi",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_KullaniciOgunleri_KullaniciID",
                table: "KullaniciOgunleri",
                column: "KullaniciID");

            migrationBuilder.CreateIndex(
                name: "IX_KullaniciOgunleri_OgunID",
                table: "KullaniciOgunleri",
                column: "OgunID");

            migrationBuilder.CreateIndex(
                name: "IX_OgunDetaylari_OgunID",
                table: "OgunDetaylari",
                column: "OgunID");

            migrationBuilder.CreateIndex(
                name: "IX_TuketimGecmisleri_KullaniciID",
                table: "TuketimGecmisleri",
                column: "KullaniciID");

            migrationBuilder.CreateIndex(
                name: "IX_YiyecekDetaylari_YiyecekID",
                table: "YiyecekDetaylari",
                column: "YiyecekID");

            migrationBuilder.CreateIndex(
                name: "IX_Yiyecekler_KategoriID",
                table: "Yiyecekler",
                column: "KategoriID");

            migrationBuilder.CreateIndex(
                name: "IX_YiyecekOgunler_OgunID",
                table: "YiyecekOgunler",
                column: "OgunID");

            migrationBuilder.CreateIndex(
                name: "IX_YiyecekOgunler_YiyecekID",
                table: "YiyecekOgunler",
                column: "YiyecekID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BesinDegerleri");

            migrationBuilder.DropTable(
                name: "GunlukRaporlar");

            migrationBuilder.DropTable(
                name: "KullaniciGecmisleri");

            migrationBuilder.DropTable(
                name: "KullaniciOgunleri");

            migrationBuilder.DropTable(
                name: "OgunDetaylari");

            migrationBuilder.DropTable(
                name: "TuketimGecmisleri");

            migrationBuilder.DropTable(
                name: "YiyecekDetaylari");

            migrationBuilder.DropTable(
                name: "YiyecekOgunler");

            migrationBuilder.DropTable(
                name: "Kullanicilar");

            migrationBuilder.DropTable(
                name: "Ogunler");

            migrationBuilder.DropTable(
                name: "Yiyecekler");

            migrationBuilder.DropTable(
                name: "AktiviteSeviyeleri");

            migrationBuilder.DropTable(
                name: "Kategoriler");
        }
    }
}
