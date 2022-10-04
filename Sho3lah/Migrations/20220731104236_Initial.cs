using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sho3lah.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Administrative_Boards",
                columns: table => new
                {
                    Administrative_BoardID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Boards = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administrative_Boards", x => x.Administrative_BoardID);
                });

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    AuthorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProFilePictureURL = table.Column<string>(nullable: true),
                    FullName = table.Column<string>(nullable: true),
                    Bio = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Education = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.AuthorID);
                });

            migrationBuilder.CreateTable(
                name: "Libraries",
                columns: table => new
                {
                    LibraryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logo = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Bio = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libraries", x => x.LibraryID);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    MemberID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProFilePictureURL = table.Column<string>(nullable: true),
                    FullName = table.Column<string>(nullable: true),
                    Bio = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Education = table.Column<string>(nullable: true),
                    Boards = table.Column<int>(nullable: false),
                    Administrative_BoardID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.MemberID);
                    table.ForeignKey(
                        name: "FK_Members_Administrative_Boards_Administrative_BoardID",
                        column: x => x.Administrative_BoardID,
                        principalTable: "Administrative_Boards",
                        principalColumn: "Administrative_BoardID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true),
                    ImageURL = table.Column<string>(nullable: true),
                    PublishDate = table.Column<DateTime>(nullable: false),
                    BOOKCategory = table.Column<int>(nullable: false),
                    LibraryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookID);
                    table.ForeignKey(
                        name: "FK_Books_Libraries_LibraryID",
                        column: x => x.LibraryID,
                        principalTable: "Libraries",
                        principalColumn: "LibraryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Authors_Books",
                columns: table => new
                {
                    BookID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookID1 = table.Column<int>(nullable: false),
                    AuthorID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors_Books", x => x.BookID);
                    table.ForeignKey(
                        name: "FK_Authors_Books_Authors_AuthorID",
                        column: x => x.AuthorID,
                        principalTable: "Authors",
                        principalColumn: "AuthorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Authors_Books_Books_BookID1",
                        column: x => x.BookID1,
                        principalTable: "Books",
                        principalColumn: "BookID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Authors_Books_AuthorID",
                table: "Authors_Books",
                column: "AuthorID");

            migrationBuilder.CreateIndex(
                name: "IX_Authors_Books_BookID1",
                table: "Authors_Books",
                column: "BookID1");

            migrationBuilder.CreateIndex(
                name: "IX_Books_LibraryID",
                table: "Books",
                column: "LibraryID");

            migrationBuilder.CreateIndex(
                name: "IX_Members_Administrative_BoardID",
                table: "Members",
                column: "Administrative_BoardID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Authors_Books");

            migrationBuilder.DropTable(
                name: "Members");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Administrative_Boards");

            migrationBuilder.DropTable(
                name: "Libraries");
        }
    }
}
