using Microsoft.EntityFrameworkCore.Migrations;

namespace KnifeWebApi.Migrations
{
    public partial class readdedmodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    OriginCountry = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Knives",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    PatternNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    YearEra = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    HandleMaterial = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Color = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Length = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    NumberOfBlades = table.Column<int>(type: "int", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Knives", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Knives_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CostAndSales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KnifeId = table.Column<int>(type: "int", nullable: false),
                    BlueBookPrice = table.Column<decimal>(type: "decimal(11,2)", nullable: false),
                    PaidPrice = table.Column<decimal>(type: "decimal(11,2)", nullable: false),
                    AskingPrice = table.Column<decimal>(type: "decimal(11,2)", nullable: false),
                    SellPrice = table.Column<decimal>(type: "decimal(11,2)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(11,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CostAndSales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CostAndSales_Knives_KnifeId",
                        column: x => x.KnifeId,
                        principalTable: "Knives",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CostAndSales_KnifeId",
                table: "CostAndSales",
                column: "KnifeId");

            migrationBuilder.CreateIndex(
                name: "IX_Knives_BrandId",
                table: "Knives",
                column: "BrandId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CostAndSales");

            migrationBuilder.DropTable(
                name: "Knives");

            migrationBuilder.DropTable(
                name: "Brands");
        }
    }
}
