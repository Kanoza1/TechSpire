using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechSpire.infra.Migrations
{
    /// <inheritdoc />
    public partial class UpdateFav : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Favs",
                table: "Favs");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Favs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Favs",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Favs",
                table: "Favs",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Favs_UserId",
                table: "Favs",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Favs",
                table: "Favs");

            migrationBuilder.DropIndex(
                name: "IX_Favs_UserId",
                table: "Favs");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Favs");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Favs",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Favs",
                table: "Favs",
                columns: new[] { "UserId", "ItemId", "Type" });
        }
    }
}
