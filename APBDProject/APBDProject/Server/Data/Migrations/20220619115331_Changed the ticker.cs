using Microsoft.EntityFrameworkCore.Migrations;

namespace APBDProject.Server.Data.Migrations
{
    public partial class Changedtheticker : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "description",
                table: "Tickers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "homepage_url",
                table: "Tickers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "description",
                table: "Tickers");

            migrationBuilder.DropColumn(
                name: "homepage_url",
                table: "Tickers");
        }
    }
}
