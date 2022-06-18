using Microsoft.EntityFrameworkCore.Migrations;

namespace APBDProject.Server.Data.Migrations
{
    public partial class newkey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Observations_AspNetUsers_UserId",
                table: "Observations");

            migrationBuilder.DropForeignKey(
                name: "FK_Observations_Tickers_TickerName",
                table: "Observations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Observations",
                table: "Observations");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Observations",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "TickerName",
                table: "Observations",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "ObservationId",
                table: "Observations",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Observations",
                table: "Observations",
                column: "ObservationId");

            migrationBuilder.CreateIndex(
                name: "IX_Observations_TickerName",
                table: "Observations",
                column: "TickerName");

            migrationBuilder.AddForeignKey(
                name: "FK_Observations_AspNetUsers_UserId",
                table: "Observations",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Observations_Tickers_TickerName",
                table: "Observations",
                column: "TickerName",
                principalTable: "Tickers",
                principalColumn: "ticker",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Observations_AspNetUsers_UserId",
                table: "Observations");

            migrationBuilder.DropForeignKey(
                name: "FK_Observations_Tickers_TickerName",
                table: "Observations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Observations",
                table: "Observations");

            migrationBuilder.DropIndex(
                name: "IX_Observations_TickerName",
                table: "Observations");

            migrationBuilder.DropColumn(
                name: "ObservationId",
                table: "Observations");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Observations",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TickerName",
                table: "Observations",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Observations",
                table: "Observations",
                columns: new[] { "TickerName", "UserId" });

            migrationBuilder.AddForeignKey(
                name: "FK_Observations_AspNetUsers_UserId",
                table: "Observations",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Observations_Tickers_TickerName",
                table: "Observations",
                column: "TickerName",
                principalTable: "Tickers",
                principalColumn: "ticker",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
