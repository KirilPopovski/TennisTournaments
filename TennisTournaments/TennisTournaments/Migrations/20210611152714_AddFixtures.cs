using Microsoft.EntityFrameworkCore.Migrations;

namespace TennisTournaments.Migrations
{
    public partial class AddFixtures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fixtures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TournamentPlayingCategoryId = table.Column<int>(type: "int", nullable: false),
                    FirstRegistrationId = table.Column<int>(type: "int", nullable: false),
                    SecondRegistrationId = table.Column<int>(type: "int", nullable: false),
                    Round = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fixtures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fixtures_Registrations_FirstRegistrationId",
                        column: x => x.FirstRegistrationId,
                        principalTable: "Registrations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Fixtures_Registrations_SecondRegistrationId",
                        column: x => x.SecondRegistrationId,
                        principalTable: "Registrations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Fixtures_TournamentPlayingCategories_TournamentPlayingCategoryId",
                        column: x => x.TournamentPlayingCategoryId,
                        principalTable: "TournamentPlayingCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FixtureResults",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FixtureId = table.Column<int>(type: "int", nullable: false),
                    WinnerRegistrationId = table.Column<int>(type: "int", nullable: false),
                    NumberOfSetsPlayed = table.Column<int>(type: "int", nullable: false),
                    IsOpponentRetired = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FixtureResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FixtureResults_Fixtures_FixtureId",
                        column: x => x.FixtureId,
                        principalTable: "Fixtures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FixtureResults_Registrations_WinnerRegistrationId",
                        column: x => x.WinnerRegistrationId,
                        principalTable: "Registrations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GameScores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FixtureId = table.Column<int>(type: "int", nullable: false),
                    SetNumber = table.Column<int>(type: "int", nullable: false),
                    GameNumber = table.Column<int>(type: "int", nullable: false),
                    FirstRegistrationPoints = table.Column<int>(type: "int", nullable: false),
                    SecondRegistrationPoints = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameScores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GameScores_Fixtures_FixtureId",
                        column: x => x.FixtureId,
                        principalTable: "Fixtures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SetScores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FixtureId = table.Column<int>(type: "int", nullable: false),
                    SetNumber = table.Column<int>(type: "int", nullable: false),
                    FirstRegistrationGames = table.Column<int>(type: "int", nullable: false),
                    SecondRegistrationGames = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SetScores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SetScores_Fixtures_FixtureId",
                        column: x => x.FixtureId,
                        principalTable: "Fixtures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TieBreakers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FixtureId = table.Column<int>(type: "int", nullable: false),
                    SetNumber = table.Column<int>(type: "int", nullable: false),
                    FirstRegistrationPoints = table.Column<int>(type: "int", nullable: false),
                    SecondRegistrationPoints = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TieBreakers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TieBreakers_Fixtures_FixtureId",
                        column: x => x.FixtureId,
                        principalTable: "Fixtures",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FixtureResults_FixtureId",
                table: "FixtureResults",
                column: "FixtureId");

            migrationBuilder.CreateIndex(
                name: "IX_FixtureResults_WinnerRegistrationId",
                table: "FixtureResults",
                column: "WinnerRegistrationId");

            migrationBuilder.CreateIndex(
                name: "IX_Fixtures_FirstRegistrationId",
                table: "Fixtures",
                column: "FirstRegistrationId");

            migrationBuilder.CreateIndex(
                name: "IX_Fixtures_SecondRegistrationId",
                table: "Fixtures",
                column: "SecondRegistrationId");

            migrationBuilder.CreateIndex(
                name: "IX_Fixtures_TournamentPlayingCategoryId",
                table: "Fixtures",
                column: "TournamentPlayingCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_GameScores_FixtureId",
                table: "GameScores",
                column: "FixtureId");

            migrationBuilder.CreateIndex(
                name: "IX_SetScores_FixtureId",
                table: "SetScores",
                column: "FixtureId");

            migrationBuilder.CreateIndex(
                name: "IX_TieBreakers_FixtureId",
                table: "TieBreakers",
                column: "FixtureId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FixtureResults");

            migrationBuilder.DropTable(
                name: "GameScores");

            migrationBuilder.DropTable(
                name: "SetScores");

            migrationBuilder.DropTable(
                name: "TieBreakers");

            migrationBuilder.DropTable(
                name: "Fixtures");
        }
    }
}
