using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechSpire.infra.Migrations
{
    /// <inheritdoc />
    public partial class CreateInLocalll : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Topics_TopicId1",
                table: "Questions");

            migrationBuilder.AlterColumn<int>(
                name: "TopicId1",
                table: "Questions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Questions_StageId",
                table: "Questions",
                column: "StageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Stages_StageId",
                table: "Questions",
                column: "StageId",
                principalTable: "Stages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Topics_TopicId1",
                table: "Questions",
                column: "TopicId1",
                principalTable: "Topics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Stages_StageId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Topics_TopicId1",
                table: "Questions");

            migrationBuilder.DropIndex(
                name: "IX_Questions_StageId",
                table: "Questions");

            migrationBuilder.AlterColumn<int>(
                name: "TopicId1",
                table: "Questions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Topics_TopicId1",
                table: "Questions",
                column: "TopicId1",
                principalTable: "Topics",
                principalColumn: "Id");
        }
    }
}
