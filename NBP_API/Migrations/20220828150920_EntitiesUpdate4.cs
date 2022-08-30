using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NBP_API.Migrations
{
    public partial class EntitiesUpdate4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rates_ExchangeRatesTable_ExchangeRatesTableId",
                table: "Rates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExchangeRatesTable",
                table: "ExchangeRatesTable");

            migrationBuilder.RenameTable(
                name: "ExchangeRatesTable",
                newName: "ExchangeRates");

            migrationBuilder.RenameColumn(
                name: "ExchangeRatesTableId",
                table: "Rates",
                newName: "ExchangeRatesId");

            migrationBuilder.RenameIndex(
                name: "IX_Rates_ExchangeRatesTableId",
                table: "Rates",
                newName: "IX_Rates_ExchangeRatesId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExchangeRates",
                table: "ExchangeRates",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rates_ExchangeRates_ExchangeRatesId",
                table: "Rates",
                column: "ExchangeRatesId",
                principalTable: "ExchangeRates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rates_ExchangeRates_ExchangeRatesId",
                table: "Rates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ExchangeRates",
                table: "ExchangeRates");

            migrationBuilder.RenameTable(
                name: "ExchangeRates",
                newName: "ExchangeRatesTable");

            migrationBuilder.RenameColumn(
                name: "ExchangeRatesId",
                table: "Rates",
                newName: "ExchangeRatesTableId");

            migrationBuilder.RenameIndex(
                name: "IX_Rates_ExchangeRatesId",
                table: "Rates",
                newName: "IX_Rates_ExchangeRatesTableId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ExchangeRatesTable",
                table: "ExchangeRatesTable",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Rates_ExchangeRatesTable_ExchangeRatesTableId",
                table: "Rates",
                column: "ExchangeRatesTableId",
                principalTable: "ExchangeRatesTable",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
