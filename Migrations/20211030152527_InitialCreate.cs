using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace rps.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GameData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    GameMode = table.Column<int>(type: "int", nullable: false),
                    PlayerOneName = table.Column<string>(type: "text", nullable: true),
                    PlayerTwoName = table.Column<string>(type: "text", nullable: true),
                    PlayerOneSelection = table.Column<string>(type: "text", nullable: true),
                    PlayerTwoSelection = table.Column<string>(type: "text", nullable: true),
                    Winner = table.Column<string>(type: "text", nullable: true),
                    date = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameData", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GameData");
        }
    }
}
