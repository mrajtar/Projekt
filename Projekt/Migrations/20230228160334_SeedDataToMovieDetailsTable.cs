using Microsoft.EntityFrameworkCore.Migrations;

namespace Projekt.Migrations
{
    public partial class SeedDataToMovieDetailsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"INSERT INTO [dbo].[MovieDetails]
                   ([Title]
                   ,[Description]
                   ,[ImageURL]
                   ,[MovieCategory]
                   ,[ReleaseYear])
                VALUES
                   ('Diune', 'A noble family becomes embroiled in a war for control over the galaxys most valuable asset while its heir becomes troubled by visions of a dark future.', 'https://fwcdn.pl/fpo/94/76/469476/7972251.3.jpg', 2, 2021)");
            migrationBuilder.Sql(@"INSERT INTO [dbo].[MovieDetails]
                   ([Title]
                   ,[Description]
                   ,[ImageURL]
                   ,[MovieCategory]
                   ,[ReleaseYear])
                VALUES
                   ('All quiet on the western front', 'A young German soldiers terrifying experiences and distress on the western front during World War I.', 'https://resizing.flixster.com/sR9EKvvVni5UmJp4N67v91S_QYM=/300x300/v2/https://resizing.flixster.com/Tv-nj_XzcvU5GZthFm-0xrSvvjo=/ems.cHJkLWVtcy1hc3NldHMvbW92aWVzLzljM2U3Mjk3LWExNzgtNGE2NS05OTMxLWVlZmU1NzNlZWM5MS5qcGc=', 3, 2022)");
            migrationBuilder.Sql(@"INSERT INTO [dbo].[MovieDetails]
                   ([Title]
                   ,[Description]
                   ,[ImageURL]
                   ,[MovieCategory]
                   ,[ReleaseYear])
                VALUES
                   ('Everything Everywhere All at Once', 'A middle-aged Chinese immigrant is swept up into an insane adventure in which she alone can save existence by exploring other universes and connecting with the lives she could have led.', 'https://upload.wikimedia.org/wikipedia/en/1/1e/Everything_Everywhere_All_at_Once.jpg', 4, 2022)");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }

    }
}
