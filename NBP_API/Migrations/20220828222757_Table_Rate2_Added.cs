using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NBP_API.Migrations
{
    public partial class Table_Rate2_Added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rates2",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    THB = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    USD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AUD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HKD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CAD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NZD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SGD = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EUR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HUF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CHF = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GBP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UAH = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JPY = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CZK = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DKK = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ISK = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NOK = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SEK = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HRK = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RON = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BGN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TRY = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ILS = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CLP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PHP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MXN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZAR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BRL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MYR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IDR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    INR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KRW = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CNY = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    XDR = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExchangeRatesId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rates2", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rates2_ExchangeRates_ExchangeRatesId",
                        column: x => x.ExchangeRatesId,
                        principalTable: "ExchangeRates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Rates2_ExchangeRatesId",
                table: "Rates2",
                column: "ExchangeRatesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rates2");
        }
    }
}
