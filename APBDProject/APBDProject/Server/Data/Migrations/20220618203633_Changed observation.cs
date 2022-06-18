using Microsoft.EntityFrameworkCore.Migrations;

namespace APBDProject.Server.Data.Migrations
{
    public partial class Changedobservation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Observations_AspNetUsers_UserName",
                table: "Observations");

            migrationBuilder.DropColumn(
                name: "type",
                table: "Tickers");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Observations",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Observations_UserName",
                table: "Observations",
                newName: "IX_Observations_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Observations_AspNetUsers_UserId",
                table: "Observations",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Observations_AspNetUsers_UserId",
                table: "Observations");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Observations",
                newName: "UserName");

            migrationBuilder.RenameIndex(
                name: "IX_Observations_UserId",
                table: "Observations",
                newName: "IX_Observations_UserName");

            migrationBuilder.AddColumn<string>(
                name: "type",
                table: "Tickers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Observations_AspNetUsers_UserName",
                table: "Observations",
                column: "UserName",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
