using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Konyvtar_Api.Migrations
{
    /// <inheritdoc />
    public partial class Konyvtar_Api : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Book List",
                columns: table => new
                {
                    identity = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Author = table.Column<string>(type: "TEXT", nullable: false),
                    Creators = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book List", x => x.identity);
                });

            migrationBuilder.CreateTable(
                name: "Out List",
                columns: table => new
                {
                    identity = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    B_ID = table.Column<int>(type: "INTEGER", nullable: false),
                    P_ID = table.Column<int>(type: "INTEGER", nullable: false),
                    outcast = table.Column<DateTime>(type: "TEXT", nullable: false),
                    recast = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Out List", x => x.identity);
                });

            migrationBuilder.CreateTable(
                name: "People List",
                columns: table => new
                {
                    identity = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Adress = table.Column<string>(type: "TEXT", nullable: false),
                    BYear = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People List", x => x.identity);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Book List");

            migrationBuilder.DropTable(
                name: "Out List");

            migrationBuilder.DropTable(
                name: "People List");
        }
    }
}
