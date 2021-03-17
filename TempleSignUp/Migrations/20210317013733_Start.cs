using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TempleSignUp.Migrations
{
    public partial class Start : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    GroupID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GroupName = table.Column<string>(type: "TEXT", nullable: false),
                    GroupSize = table.Column<int>(type: "INTEGER", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    TourTime = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.GroupID);
                });

            migrationBuilder.CreateTable(
                name: "Times",
                columns: table => new
                {
                    SlottedTimeID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Schedule = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Availbility = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Times", x => x.SlottedTimeID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Times");
        }
    }
}
