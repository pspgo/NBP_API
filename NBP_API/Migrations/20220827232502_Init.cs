using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NBP_API.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ExchangeRatesTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TableType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    No = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TradingDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EffectiveDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RatesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExchangeRatesTable", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExchangeRatesTableId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rates_ExchangeRatesTable_ExchangeRatesTableId",
                        column: x => x.ExchangeRatesTableId,
                        principalTable: "ExchangeRatesTable",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rates_ExchangeRatesTableId",
                table: "Rates",
                column: "ExchangeRatesTableId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rates");

            migrationBuilder.DropTable(
                name: "ExchangeRatesTable");
        }
    }
}
