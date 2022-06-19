using Microsoft.EntityFrameworkCore.Migrations;

namespace APBDProject.Server.Data.Migrations
{
    public partial class addedtime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Time",
                table: "Ohlcs",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Time",
                table: "Ohlcs");
        }
    }
}
