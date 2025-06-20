using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechSpire.infra.Migrations
{
    /// <inheritdoc />
    public partial class TopicTry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TopicId",
                table: "Questions",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Topic",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: true),
                    StageId = table.Column<int>(type: "int", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: true),
                    PostId = table.Column<int>(type: "int", nullable: true),
                    ArticleId = table.Column<int>(type: "int", nullable: true),
                    QuizId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topic", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Topic_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Topic_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Topic_Posts_PostId",
                        column: x => x.PostId,
                        principalTable: "Posts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Topic_Quizzes_QuizId",
                        column: x => x.QuizId,
                        principalTable: "Quizzes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Topic_Stages_StageId",
                        column: x => x.StageId,
                        principalTable: "Stages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Questions_TopicId",
                table: "Questions",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_Topic_ArticleId",
                table: "Topic",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_Topic_BookId",
                table: "Topic",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Topic_PostId",
                table: "Topic",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Topic_QuizId",
                table: "Topic",
                column: "QuizId");

            migrationBuilder.CreateIndex(
                name: "IX_Topic_StageId",
                table: "Topic",
                column: "StageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Topic_TopicId",
                table: "Questions",
                column: "TopicId",
                principalTable: "Topic",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Topic_TopicId",
                table: "Questions");

            migrationBuilder.DropTable(
                name: "Topic");

            migrationBuilder.DropIndex(
                name: "IX_Questions_TopicId",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "TopicId",
                table: "Questions");
        }
    }
}
