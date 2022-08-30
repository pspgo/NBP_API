using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NBP_API.Migrations
{
    public partial class EntitiesUpdate8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Mid",
                table: "Rates",
                newName: "mid");

            migrationBuilder.RenameColumn(
                name: "Currency",
                table: "Rates",
                newName: "currency");

            migrationBuilder.RenameColumn(
                name: "Code",
                table: "Rates",
                newName: "code");

            migrationBuilder.RenameColumn(
                name: "TradingDate",
                table: "ExchangeRates",
                newName: "tradingDate");

            migrationBuilder.RenameColumn(
                name: "No",
                table: "ExchangeRates",
                newName: "no");

            migrationBuilder.RenameColumn(
                name: "EffectiveDate",
                table: "ExchangeRates",
                newName: "effectiveDate");

            migrationBuilder.RenameColumn(
                name: "TableType",
                table: "ExchangeRates",
                newName: "table");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "mid",
                table: "Rates",
                newName: "Mid");

            migrationBuilder.RenameColumn(
                name: "currency",
                table: "Rates",
                newName: "Currency");

            migrationBuilder.RenameColumn(
                name: "code",
                table: "Rates",
                newName: "Code");

            migrationBuilder.RenameColumn(
                name: "tradingDate",
                table: "ExchangeRates",
                newName: "TradingDate");

            migrationBuilder.RenameColumn(
                name: "no",
                table: "ExchangeRates",
                newName: "No");

            migrationBuilder.RenameColumn(
                name: "effectiveDate",
                table: "ExchangeRates",
                newName: "EffectiveDate");

            migrationBuilder.RenameColumn(
                name: "table",
                table: "ExchangeRates",
                newName: "TableType");
        }
    }
}
