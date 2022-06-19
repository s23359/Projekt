using Microsoft.EntityFrameworkCore.Migrations;

namespace APBDProject.Server.Data.Migrations
{
    public partial class Needohlc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ohlcs",
                columns: table => new
                {
                    OhlcId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ticker = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    O = table.Column<double>(type: "float", nullable: false),
                    C = table.Column<double>(type: "float", nullable: false),
                    H = table.Column<double>(type: "float", nullable: false),
                    L = table.Column<double>(type: "float", nullable: false),
                    V = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ohlcs", x => x.OhlcId);
                    table.ForeignKey(
                        name: "FK_Ohlcs_Tickers_Ticker",
                        column: x => x.Ticker,
                        principalTable: "Tickers",
                        principalColumn: "ticker",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ohlcs_Ticker",
                table: "Ohlcs",
                column: "Ticker");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ohlcs");
        }
    }
}
