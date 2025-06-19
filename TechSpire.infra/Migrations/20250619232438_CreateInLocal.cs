using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechSpire.infra.Migrations
{
    /// <inheritdoc />
    public partial class CreateInLocal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Articles_Topics_TopicId",
                table: "Articles");

            migrationBuilder.DropForeignKey(
                name: "FK_Books_Topics_TopicId",
                table: "Books");

            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_Topics_TopicId",
                table: "Lessons");

            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Topics_TopicId",
                table: "Posts");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Topics_TopicId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Quizzes_Topics_TopicId",
                table: "Quizzes");

            migrationBuilder.DropIndex(
                name: "IX_Quizzes_TopicId",
                table: "Quizzes");

            migrationBuilder.DropIndex(
                name: "IX_Questions_TopicId",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Posts_TopicId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Books_TopicId",
                table: "Books");

            migrationBuilder.DropIndex(
                name: "IX_Articles_TopicId",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "TopicId",
                table: "Quizzes");

            migrationBuilder.DropColumn(
                name: "MaterialType",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "TopicId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "TopicId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "TopicId",
                table: "Articles");

            migrationBuilder.RenameColumn(
                name: "MaterialId",
                table: "Questions",
                newName: "TopicId1");

            migrationBuilder.AddColumn<int>(
                name: "ArticleId",
                table: "Topics",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "Topics",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PostId",
                table: "Topics",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QuestionId",
                table: "Topics",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "QuizId",
                table: "Topics",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Topics_ArticleId",
                table: "Topics",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_Topics_BookId",
                table: "Topics",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Topics_PostId",
                table: "Topics",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_Topics_QuizId",
                table: "Topics",
                column: "QuizId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_TopicId1",
                table: "Questions",
                column: "TopicId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_Topics_TopicId",
                table: "Lessons",
                column: "TopicId",
                principalTable: "Topics",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Topics_TopicId1",
                table: "Questions",
                column: "TopicId1",
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Lessons_Topics_TopicId",
                table: "Lessons");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Topics_TopicId1",
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

            migrationBuilder.DropIndex(
                name: "IX_Topics_ArticleId",
                table: "Topics");

            migrationBuilder.DropIndex(
                name: "IX_Topics_BookId",
                table: "Topics");

            migrationBuilder.DropIndex(
                name: "IX_Topics_PostId",
                table: "Topics");

            migrationBuilder.DropIndex(
                name: "IX_Topics_QuizId",
                table: "Topics");

            migrationBuilder.DropIndex(
                name: "IX_Questions_TopicId1",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "ArticleId",
                table: "Topics");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "Topics");

            migrationBuilder.DropColumn(
                name: "PostId",
                table: "Topics");

            migrationBuilder.DropColumn(
                name: "QuestionId",
                table: "Topics");

            migrationBuilder.DropColumn(
                name: "QuizId",
                table: "Topics");

            migrationBuilder.RenameColumn(
                name: "TopicId1",
                table: "Questions",
                newName: "MaterialId");

            migrationBuilder.AddColumn<int>(
                name: "TopicId",
                table: "Quizzes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "MaterialType",
                table: "Questions",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TopicId",
                table: "Posts",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TopicId",
                table: "Books",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TopicId",
                table: "Articles",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "TopicId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "TopicId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "TopicId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "TopicId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "TopicId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "TopicId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                column: "TopicId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                column: "TopicId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                column: "TopicId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "TopicId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "TopicId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "TopicId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "TopicId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "TopicId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                column: "TopicId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                column: "TopicId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                column: "TopicId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                column: "TopicId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                column: "TopicId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                column: "TopicId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                column: "TopicId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "TopicId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                column: "TopicId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                column: "TopicId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                column: "TopicId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                column: "TopicId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                column: "TopicId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                column: "TopicId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                column: "TopicId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                column: "TopicId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Quizzes_TopicId",
                table: "Quizzes",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_TopicId",
                table: "Questions",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_TopicId",
                table: "Posts",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_TopicId",
                table: "Books",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_TopicId",
                table: "Articles",
                column: "TopicId");

            migrationBuilder.AddForeignKey(
                name: "FK_Articles_Topics_TopicId",
                table: "Articles",
                column: "TopicId",
                principalTable: "Topics",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Topics_TopicId",
                table: "Books",
                column: "TopicId",
                principalTable: "Topics",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Lessons_Topics_TopicId",
                table: "Lessons",
                column: "TopicId",
                principalTable: "Topics",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Topics_TopicId",
                table: "Posts",
                column: "TopicId",
                principalTable: "Topics",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Topics_TopicId",
                table: "Questions",
                column: "TopicId",
                principalTable: "Topics",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Quizzes_Topics_TopicId",
                table: "Quizzes",
                column: "TopicId",
                principalTable: "Topics",
                principalColumn: "Id");
        }
    }
}
