using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "plates",
                columns: table => new
                {
                    plateID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    plateNo = table.Column<string>(type: "CHAR(25)", nullable: true),
                    plateComment = table.Column<string>(type: "CHAR(25)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_plates", x => x.plateID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProductName = table.Column<string>(nullable: true),
                    CategoryID = table.Column<int>(nullable: false),
                    UnitPrice = table.Column<decimal>(nullable: false),
                    QuantityPerUnit = table.Column<string>(nullable: true),
                    UnitİnStock = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                });

            migrationBuilder.CreateTable(
                name: "proje",
                columns: table => new
                {
                    pid = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    pkod = table.Column<string>(type: "CHAR(20)", nullable: true),
                    pisim = table.Column<string>(type: "CHAR(50)", nullable: true),
                    paciklama = table.Column<string>(type: "CHAR(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_proje", x => x.pid);
                });

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    userID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(type: "VARCHAR(25)", nullable: true),
                    UserPass = table.Column<string>(type: "VARCHAR(25)", nullable: true),
                    UserLevel = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.userID);
                });

            migrationBuilder.CreateTable(
                name: "cutting",
                columns: table => new
                {
                    cutid = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    cutdate = table.Column<DateTime>(nullable: false),
                    ProjeID = table.Column<int>(nullable: false),
                    profile = table.Column<string>(type: "CHAR(15)", nullable: true),
                    comment = table.Column<string>(type: "CHAR(20)", nullable: true),
                    assemkod = table.Column<string>(type: "CHAR(15)", nullable: true),
                    single = table.Column<string>(type: "CHAR(15)", nullable: true),
                    cutqty = table.Column<int>(nullable: false),
                    cutno = table.Column<int>(nullable: false),
                    skilo = table.Column<string>(type: "CHAR(25)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cutting", x => x.cutid);
                    table.ForeignKey(
                        name: "FK_cutting_proje_ProjeID",
                        column: x => x.ProjeID,
                        principalTable: "proje",
                        principalColumn: "pid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sevkiyat",
                columns: table => new
                {
                    sevkid = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    pid = table.Column<int>(nullable: false),
                    sevkno = table.Column<int>(nullable: false),
                    sevktarihi = table.Column<DateTime>(nullable: false),
                    pozno = table.Column<string>(type: "CHAR(25)", nullable: true),
                    sevkadet = table.Column<int>(nullable: false),
                    sevkkilo = table.Column<string>(type: "CHAR(25)", nullable: true),
                    sevktopkilo = table.Column<string>(type: "CHAR(20)", nullable: true),
                    paketno = table.Column<string>(type: "CHAR(20)", nullable: true),
                    eskisevkmi = table.Column<string>(type: "CHAR(1)", nullable: true),
                    konteynerno = table.Column<string>(type: "VARCHAR(25)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sevkiyat", x => x.sevkid);
                    table.ForeignKey(
                        name: "FK_sevkiyat_proje_pid",
                        column: x => x.pid,
                        principalTable: "proje",
                        principalColumn: "pid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sofor",
                columns: table => new
                {
                    kayıtid = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    pid = table.Column<int>(nullable: false),
                    sevkno = table.Column<int>(nullable: false),
                    sevksorumlu = table.Column<string>(type: "VARCHAR(30)", nullable: true),
                    imalatsorumlu = table.Column<string>(type: "VARCHAR(30)", nullable: true),
                    kalitesorumlu = table.Column<string>(type: "VARCHAR(30)", nullable: true),
                    soforadi = table.Column<string>(type: "VARCHAR(30)", nullable: true),
                    sofortel = table.Column<string>(type: "VARCHAR(30)", nullable: true),
                    aracplaka = table.Column<string>(type: "VARCHAR(20)", nullable: true),
                    dorseplaka = table.Column<string>(type: "VARCHAR(20)", nullable: true),
                    kantarkilo = table.Column<double>(nullable: false),
                    konteynerno = table.Column<string>(type: "VARCHAR(25)", nullable: true),
                    resim = table.Column<byte[]>(type: "VARBINARY(32767)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sofor", x => x.kayıtid);
                    table.ForeignKey(
                        name: "FK_sofor_proje_pid",
                        column: x => x.pid,
                        principalTable: "proje",
                        principalColumn: "pid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "assembly",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    assemkod = table.Column<string>(type: "CHAR(15)", nullable: true),
                    assemadet = table.Column<int>(nullable: false),
                    assemkilo = table.Column<double>(nullable: false),
                    pid = table.Column<int>(nullable: false),
                    P00 = table.Column<string>(type: "VARCHAR(10)", nullable: true),
                    P05 = table.Column<string>(type: "VARCHAR(10)", nullable: true),
                    P06 = table.Column<string>(type: "VARCHAR(10)", nullable: true),
                    P08 = table.Column<string>(type: "VARCHAR(10)", nullable: true),
                    P10 = table.Column<string>(type: "VARCHAR(10)", nullable: true),
                    P12 = table.Column<string>(type: "VARCHAR(10)", nullable: true),
                    P15 = table.Column<string>(type: "VARCHAR(10)", nullable: true),
                    P20 = table.Column<string>(type: "VARCHAR(10)", nullable: true),
                    P25 = table.Column<string>(type: "VARCHAR(10)", nullable: true),
                    P30 = table.Column<string>(type: "VARCHAR(10)", nullable: true),
                    P35 = table.Column<string>(type: "VARCHAR(10)", nullable: true),
                    P40 = table.Column<string>(type: "VARCHAR(10)", nullable: true),
                    P45 = table.Column<string>(type: "VARCHAR(10)", nullable: true),
                    P50 = table.Column<string>(type: "VARCHAR(10)", nullable: true),
                    P55 = table.Column<string>(type: "VARCHAR(10)", nullable: true),
                    P60 = table.Column<string>(type: "VARCHAR(10)", nullable: true),
                    cutno = table.Column<int>(nullable: false),
                    cutdate = table.Column<DateTime>(nullable: false),
                    comment = table.Column<string>(type: "CHAR(20)", nullable: true),
                    meterialtype = table.Column<string>(type: "CHAR(20)", nullable: true),
                    sevkadet = table.Column<int>(nullable: false),
                    sevkkilo = table.Column<string>(type: "CHAR(20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_assembly", x => x.ID);
                    table.ForeignKey(
                        name: "FK_assembly_cutting_cutno",
                        column: x => x.cutno,
                        principalTable: "cutting",
                        principalColumn: "cutid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_assembly_proje_pid",
                        column: x => x.pid,
                        principalTable: "proje",
                        principalColumn: "pid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "single",
                columns: table => new
                {
                    sid = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    pid = table.Column<int>(nullable: false),
                    assemid = table.Column<int>(nullable: false),
                    sisim = table.Column<string>(type: "VARCHAR(15)", nullable: true),
                    sprofile = table.Column<string>(type: "VARCHAR(15)", nullable: true),
                    sadet = table.Column<int>(nullable: false),
                    assemxsing = table.Column<int>(nullable: false),
                    suzunluk = table.Column<int>(nullable: false),
                    skilo = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_single", x => x.sid);
                    table.ForeignKey(
                        name: "FK_single_assembly_assemid",
                        column: x => x.assemid,
                        principalTable: "assembly",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_single_proje_pid",
                        column: x => x.pid,
                        principalTable: "proje",
                        principalColumn: "pid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_assembly_cutno",
                table: "assembly",
                column: "cutno");

            migrationBuilder.CreateIndex(
                name: "IX_assembly_pid",
                table: "assembly",
                column: "pid");

            migrationBuilder.CreateIndex(
                name: "IX_cutting_ProjeID",
                table: "cutting",
                column: "ProjeID");

            migrationBuilder.CreateIndex(
                name: "IX_sevkiyat_pid",
                table: "sevkiyat",
                column: "pid");

            migrationBuilder.CreateIndex(
                name: "IX_single_assemid",
                table: "single",
                column: "assemid");

            migrationBuilder.CreateIndex(
                name: "IX_single_pid",
                table: "single",
                column: "pid");

            migrationBuilder.CreateIndex(
                name: "IX_sofor_pid",
                table: "sofor",
                column: "pid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "plates");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "sevkiyat");

            migrationBuilder.DropTable(
                name: "single");

            migrationBuilder.DropTable(
                name: "sofor");

            migrationBuilder.DropTable(
                name: "user");

            migrationBuilder.DropTable(
                name: "assembly");

            migrationBuilder.DropTable(
                name: "cutting");

            migrationBuilder.DropTable(
                name: "proje");
        }
    }
}
