using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechSpire.infra.Migrations
{
    /// <inheritdoc />
    public partial class TopicNames : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Topic_TopicId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Topic_Articles_ArticleId",
                table: "Topic");

            migrationBuilder.DropForeignKey(
                name: "FK_Topic_Books_BookId",
                table: "Topic");

            migrationBuilder.DropForeignKey(
                name: "FK_Topic_Posts_PostId",
                table: "Topic");

            migrationBuilder.DropForeignKey(
                name: "FK_Topic_Quizzes_QuizId",
                table: "Topic");

            migrationBuilder.DropForeignKey(
                name: "FK_Topic_Stages_StageId",
                table: "Topic");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Topic",
                table: "Topic");

            migrationBuilder.RenameTable(
                name: "Topic",
                newName: "Topics");

            migrationBuilder.RenameIndex(
                name: "IX_Topic_StageId",
                table: "Topics",
                newName: "IX_Topics_StageId");

            migrationBuilder.RenameIndex(
                name: "IX_Topic_QuizId",
                table: "Topics",
                newName: "IX_Topics_QuizId");

            migrationBuilder.RenameIndex(
                name: "IX_Topic_PostId",
                table: "Topics",
                newName: "IX_Topics_PostId");

            migrationBuilder.RenameIndex(
                name: "IX_Topic_BookId",
                table: "Topics",
                newName: "IX_Topics_BookId");

            migrationBuilder.RenameIndex(
                name: "IX_Topic_ArticleId",
                table: "Topics",
                newName: "IX_Topics_ArticleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Topics",
                table: "Topics",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Topics_TopicId",
                table: "Questions",
                column: "TopicId",
                principalTable: "Topics",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Topics_Articles_ArticleId",
                table: "Topics",
                column: "ArticleId",
                principalTable: "Articles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Topics_Books_BookId",
                table: "Topics",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Topics_Posts_PostId",
                table: "Topics",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Topics_Quizzes_QuizId",
                table: "Topics",
                column: "QuizId",
                principalTable: "Quizzes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Topics_Stages_StageId",
                table: "Topics",
                column: "StageId",
                principalTable: "Stages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Topics_TopicId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Topics_Articles_ArticleId",
                table: "Topics");

            migrationBuilder.DropForeignKey(
                name: "FK_Topics_Books_BookId",
                table: "Topics");

            migrationBuilder.DropForeignKey(
                name: "FK_Topics_Posts_PostId",
                table: "Topics");

            migrationBuilder.DropForeignKey(
                name: "FK_Topics_Quizzes_QuizId",
                table: "Topics");

            migrationBuilder.DropForeignKey(
                name: "FK_Topics_Stages_StageId",
                table: "Topics");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Topics",
                table: "Topics");

            migrationBuilder.RenameTable(
                name: "Topics",
                newName: "Topic");

            migrationBuilder.RenameIndex(
                name: "IX_Topics_StageId",
                table: "Topic",
                newName: "IX_Topic_StageId");

            migrationBuilder.RenameIndex(
                name: "IX_Topics_QuizId",
                table: "Topic",
                newName: "IX_Topic_QuizId");

            migrationBuilder.RenameIndex(
                name: "IX_Topics_PostId",
                table: "Topic",
                newName: "IX_Topic_PostId");

            migrationBuilder.RenameIndex(
                name: "IX_Topics_BookId",
                table: "Topic",
                newName: "IX_Topic_BookId");

            migrationBuilder.RenameIndex(
                name: "IX_Topics_ArticleId",
                table: "Topic",
                newName: "IX_Topic_ArticleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Topic",
                table: "Topic",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Topic_TopicId",
                table: "Questions",
                column: "TopicId",
                principalTable: "Topic",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Topic_Articles_ArticleId",
                table: "Topic",
                column: "ArticleId",
                principalTable: "Articles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Topic_Books_BookId",
                table: "Topic",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Topic_Posts_PostId",
                table: "Topic",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Topic_Quizzes_QuizId",
                table: "Topic",
                column: "QuizId",
                principalTable: "Quizzes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Topic_Stages_StageId",
                table: "Topic",
                column: "StageId",
                principalTable: "Stages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
