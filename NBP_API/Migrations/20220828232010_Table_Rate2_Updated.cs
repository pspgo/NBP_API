using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NBP_API.Migrations
{
    public partial class Table_Rate2_Updated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Rates2_ExchangeRatesId",
                table: "Rates2");

            migrationBuilder.CreateIndex(
                name: "IX_Rates2_ExchangeRatesId",
                table: "Rates2",
                column: "ExchangeRatesId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Rates2_ExchangeRatesId",
                table: "Rates2");

            migrationBuilder.CreateIndex(
                name: "IX_Rates2_ExchangeRatesId",
                table: "Rates2",
                column: "ExchangeRatesId");
        }
    }
}
