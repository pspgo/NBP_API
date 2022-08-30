using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NBP_API.Migrations
{
    public partial class EntitiesUpdate1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RatesId",
                table: "ExchangeRatesTable");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RatesId",
                table: "ExchangeRatesTable",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
