using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MovieBooking.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"));

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"));

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-1111-aaaa-aaaa-aaaaaaaaaaaa"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-1111-bbbb-bbbb-bbbbbbbbbbbb"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-2222-aaaa-aaaa-aaaaaaaaaaaa"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-2222-bbbb-bbbb-bbbbbbbbbbbb"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-3333-aaaa-aaaa-aaaaaaaaaaaa"));

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-3333-bbbb-bbbb-bbbbbbbbbbbb"));

            migrationBuilder.DeleteData(
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("33333333-cccc-cccc-cccc-cccccccccccc"));

            migrationBuilder.DeleteData(
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("55555555-eeee-eeee-eeee-eeeeeeeeeeee"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"));

            migrationBuilder.DeleteData(
                table: "Directors",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"));

            migrationBuilder.DeleteData(
                table: "Theatre",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-1111-1111-1111-111111111111"));

            migrationBuilder.DeleteData(
                table: "Theatre",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-2222-2222-2222-222222222222"));

            migrationBuilder.DeleteData(
                table: "Theatre",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-3333-3333-3333-333333333333"));

            migrationBuilder.DeleteData(
                table: "Cinema",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-1111-1111-1111-111111111111"));

            migrationBuilder.DeleteData(
                table: "Cinema",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-2222-2222-2222-222222222222"));

            migrationBuilder.DeleteData(
                table: "Cinema",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-3333-3333-3333-333333333333"));

            migrationBuilder.DeleteData(
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("11111111-aaaa-aaaa-aaaa-aaaaaaaaaaaa"));

            migrationBuilder.DeleteData(
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("22222222-bbbb-bbbb-bbbb-bbbbbbbbbbbb"));

            migrationBuilder.DeleteData(
                table: "State",
                keyColumn: "Id",
                keyValue: new Guid("44444444-dddd-dddd-dddd-dddddddddddd"));

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("cccccccc-3333-aaaa-aaaa-aaaaaaaaaaaa"), "User" },
                    { new Guid("cccccccc-3333-bbbb-bbbb-bbbbbbbbbbbb"), "Admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-3333-aaaa-aaaa-aaaaaaaaaaaa"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-3333-bbbb-bbbb-bbbbbbbbbbbb"));

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), "Chris Hemsworth" },
                    { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), "Tom Hiddleston" },
                    { new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"), "Natalie Portman" },
                    { new Guid("dddddddd-dddd-dddd-dddd-dddddddddddd"), "Robert Downey Jr." },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), "Scarlett Johansson" }
                });

            migrationBuilder.InsertData(
                table: "Directors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), "Christopher Nolan" },
                    { new Guid("22222222-2222-2222-2222-222222222222"), "Steven Spielberg" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), "Drama" },
                    { new Guid("22222222-2222-2222-2222-222222222222"), "Action" },
                    { new Guid("33333333-3333-3333-3333-333333333333"), "Horror" },
                    { new Guid("44444444-4444-4444-4444-444444444444"), "Love Story" },
                    { new Guid("55555555-5555-5555-5555-555555555555"), "Sci-Fi" },
                    { new Guid("66666666-6666-6666-6666-666666666666"), "Thriller" }
                });

            migrationBuilder.InsertData(
                table: "State",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("11111111-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), "SA" },
                    { new Guid("22222222-bbbb-bbbb-bbbb-bbbbbbbbbbbb"), "VIC" },
                    { new Guid("33333333-cccc-cccc-cccc-cccccccccccc"), "NSW" },
                    { new Guid("44444444-dddd-dddd-dddd-dddddddddddd"), "WA" },
                    { new Guid("55555555-eeee-eeee-eeee-eeeeeeeeeeee"), "QLD" }
                });

            migrationBuilder.InsertData(
                table: "Cinema",
                columns: new[] { "Id", "Name", "StateId" },
                values: new object[,]
                {
                    { new Guid("aaaaaaaa-1111-1111-1111-111111111111"), "Event Cinema Adelaide SA", new Guid("11111111-aaaa-aaaa-aaaa-aaaaaaaaaaaa") },
                    { new Guid("aaaaaaaa-2222-2222-2222-222222222222"), "Hoyts Melbourne Central VIC", new Guid("22222222-bbbb-bbbb-bbbb-bbbbbbbbbbbb") },
                    { new Guid("aaaaaaaa-3333-3333-3333-333333333333"), "Luna Cinemas Perth WA", new Guid("44444444-dddd-dddd-dddd-dddddddddddd") }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "DirectorId", "ReleaseDate", "RuntimeMinutes", "Status", "Title" },
                values: new object[,]
                {
                    { new Guid("33333333-3333-3333-3333-333333333333"), "Mind-bending sci-fi thriller", new Guid("11111111-1111-1111-1111-111111111111"), new DateTime(2010, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 148, 20, "Inception" },
                    { new Guid("44444444-4444-4444-4444-444444444444"), "Shark attack thriller", new Guid("22222222-2222-2222-2222-222222222222"), new DateTime(1975, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 124, 20, "Jaws" }
                });

            migrationBuilder.InsertData(
                table: "Theatre",
                columns: new[] { "Id", "CinemaId", "Name", "SeatCapacity" },
                values: new object[,]
                {
                    { new Guid("bbbbbbbb-1111-1111-1111-111111111111"), new Guid("aaaaaaaa-1111-1111-1111-111111111111"), "Event Theatre 1a", 100 },
                    { new Guid("bbbbbbbb-2222-2222-2222-222222222222"), new Guid("aaaaaaaa-2222-2222-2222-222222222222"), "Hoyts Theatre 1a", 120 },
                    { new Guid("bbbbbbbb-3333-3333-3333-333333333333"), new Guid("aaaaaaaa-3333-3333-3333-333333333333"), "Luna Theatre 1a", 80 }
                });

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "Id", "SeatNo", "TheatreId" },
                values: new object[,]
                {
                    { new Guid("cccccccc-1111-aaaa-aaaa-aaaaaaaaaaaa"), "A1a", new Guid("bbbbbbbb-1111-1111-1111-111111111111") },
                    { new Guid("cccccccc-1111-bbbb-bbbb-bbbbbbbbbbbb"), "A2a", new Guid("bbbbbbbb-1111-1111-1111-111111111111") },
                    { new Guid("cccccccc-2222-aaaa-aaaa-aaaaaaaaaaaa"), "B1b", new Guid("bbbbbbbb-2222-2222-2222-222222222222") },
                    { new Guid("cccccccc-2222-bbbb-bbbb-bbbbbbbbbbbb"), "B2b", new Guid("bbbbbbbb-2222-2222-2222-222222222222") },
                    { new Guid("cccccccc-3333-aaaa-aaaa-aaaaaaaaaaaa"), "C1c", new Guid("bbbbbbbb-3333-3333-3333-333333333333") },
                    { new Guid("cccccccc-3333-bbbb-bbbb-bbbbbbbbbbbb"), "C2c", new Guid("bbbbbbbb-3333-3333-3333-333333333333") }
                });
        }
    }
}
