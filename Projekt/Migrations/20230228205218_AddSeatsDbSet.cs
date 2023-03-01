using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projekt.Migrations
{
    /// <inheritdoc />
    public partial class AddSeatsDbSet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieDetails_Cinema_CinemaId",
                table: "MovieDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Seat_Cinema_CinemaId",
                table: "Seat");

            migrationBuilder.DropIndex(
                name: "IX_MovieDetails_CinemaId",
                table: "MovieDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Seat",
                table: "Seat");

            migrationBuilder.DropColumn(
                name: "CinemaId",
                table: "MovieDetails");

            migrationBuilder.RenameTable(
                name: "Seat",
                newName: "Seats");

            migrationBuilder.RenameIndex(
                name: "IX_Seat_CinemaId",
                table: "Seats",
                newName: "IX_Seats_CinemaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Seats",
                table: "Seats",
                column: "SeatId");

            migrationBuilder.AddForeignKey(
                name: "FK_Seats_Cinema_CinemaId",
                table: "Seats",
                column: "CinemaId",
                principalTable: "Cinema",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seats_Cinema_CinemaId",
                table: "Seats");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Seats",
                table: "Seats");

            migrationBuilder.RenameTable(
                name: "Seats",
                newName: "Seat");

            migrationBuilder.RenameIndex(
                name: "IX_Seats_CinemaId",
                table: "Seat",
                newName: "IX_Seat_CinemaId");

            migrationBuilder.AddColumn<int>(
                name: "CinemaId",
                table: "MovieDetails",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Seat",
                table: "Seat",
                column: "SeatId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieDetails_CinemaId",
                table: "MovieDetails",
                column: "CinemaId");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieDetails_Cinema_CinemaId",
                table: "MovieDetails",
                column: "CinemaId",
                principalTable: "Cinema",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Seat_Cinema_CinemaId",
                table: "Seat",
                column: "CinemaId",
                principalTable: "Cinema",
                principalColumn: "Id");
        }
    }
}
