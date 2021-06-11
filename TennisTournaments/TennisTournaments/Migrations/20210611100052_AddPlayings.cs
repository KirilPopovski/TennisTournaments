using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TennisTournaments.Migrations
{
    public partial class AddPlayings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Registrations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Registrations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlayingsIn",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistrationId = table.Column<int>(type: "int", nullable: false),
                    Seed = table.Column<int>(type: "int", nullable: false),
                    TournamentPlayingCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayingsIn", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayingsIn_Registrations_RegistrationId",
                        column: x => x.RegistrationId,
                        principalTable: "Registrations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayingsIn_TournamentPlayingCategories_TournamentPlayingCategoryId",
                        column: x => x.TournamentPlayingCategoryId,
                        principalTable: "TournamentPlayingCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RegistrationPlayers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistrationId = table.Column<int>(type: "int", nullable: false),
                    PlayerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistrationPlayers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RegistrationPlayers_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RegistrationPlayers_Registrations_RegistrationId",
                        column: x => x.RegistrationId,
                        principalTable: "Registrations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PlayingsIn_RegistrationId",
                table: "PlayingsIn",
                column: "RegistrationId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayingsIn_TournamentPlayingCategoryId",
                table: "PlayingsIn",
                column: "TournamentPlayingCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_RegistrationPlayers_PlayerId",
                table: "RegistrationPlayers",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_RegistrationPlayers_RegistrationId",
                table: "RegistrationPlayers",
                column: "RegistrationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlayingsIn");

            migrationBuilder.DropTable(
                name: "RegistrationPlayers");

            migrationBuilder.DropTable(
                name: "Registrations");
        }
    }
}
