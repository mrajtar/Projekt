using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projekt.Migrations
{
    /// <inheritdoc />
    public partial class AddRowNumberAndSeatNumberToCinemaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seats_Cinema_CinemaId",
                table: "Seats");

            migrationBuilder.DropIndex(
                name: "IX_Seats_CinemaId",
                table: "Seats");

            migrationBuilder.DropColumn(
                name: "CinemaId",
                table: "Seats");

            migrationBuilder.AddColumn<int>(
                name: "RowNumber",
                table: "Cinema",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RowSeatNumber",
                table: "Cinema",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RowNumber",
                table: "Cinema");

            migrationBuilder.DropColumn(
                name: "RowSeatNumber",
                table: "Cinema");

            migrationBuilder.AddColumn<int>(
                name: "CinemaId",
                table: "Seats",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Seats_CinemaId",
                table: "Seats",
                column: "CinemaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Seats_Cinema_CinemaId",
                table: "Seats",
                column: "CinemaId",
                principalTable: "Cinema",
                principalColumn: "Id");
        }
    }
}
