using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TechSpire.infra.Migrations
{
    /// <inheritdoc />
    public partial class fuckenlearning : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserArticleInProgress",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ArticleId = table.Column<int>(type: "int", nullable: false),
                    CurrentPage = table.Column<int>(type: "int", nullable: false),
                    CompletedPercentage = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserArticleInProgress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserArticleInProgress_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserArticleInProgress_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserBookInProgress",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    CurrentPage = table.Column<int>(type: "int", nullable: false),
                    CompletedPercentage = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserBookInProgress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserBookInProgress_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserBookInProgress_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UsersProgress",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StudiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DailyBooks = table.Column<int>(type: "int", nullable: false),
                    DailyPosts = table.Column<int>(type: "int", nullable: false),
                    DailyArticles = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersProgress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsersProgress_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Stages",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Beginner Stage" },
                    { 2, "Intermediate stage" },
                    { 3, "Advanced stage" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "BookUrl", "Description", "ImageUrl", "StageId", "Title" },
                values: new object[,]
                {
                    { 1, "https://example.com/csharp-book.pdf", "Learn the fundamentals of C# programming.", "https://example.com/csharp.jpg", 1, "C# Programming" },
                    { 2, "https://example.com/aspnetcore-book.pdf", "Build modern web applications using ASP.NET Core.", "https://example.com/aspnetcore.jpg", 1, "ASP.NET Core Development" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserArticleInProgress_AppUserId",
                table: "UserArticleInProgress",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserArticleInProgress_ArticleId",
                table: "UserArticleInProgress",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserBookInProgress_AppUserId",
                table: "UserBookInProgress",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserBookInProgress_BookId",
                table: "UserBookInProgress",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersProgress_UserId",
                table: "UsersProgress",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserArticleInProgress");

            migrationBuilder.DropTable(
                name: "UserBookInProgress");

            migrationBuilder.DropTable(
                name: "UsersProgress");

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Stages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Stages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Stages",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
