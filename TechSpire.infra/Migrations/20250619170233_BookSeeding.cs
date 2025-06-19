using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TechSpire.infra.Migrations
{
    /// <inheritdoc />
    public partial class BookSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "BookUrl", "Description", "ImageUrl", "StageId", "Title" },
                values: new object[,]
                {
                    { 1, "https://drive.google.com/file/d/16KohWjujqh1nRMb1YmJyeoVbIlIDmqB2/view?usp=drive_link", "A beginner's guide to Python programming language.", "https://drive.google.com/file/d/1tvk6zU8SpXOUu-y9oBOAgQJFXFLB8Nby/view?usp=drive_link", 1, "How-to-code-in-python" },
                    { 2, "https://drive.google.com/file/d/14yl0K2kNvLcMmyupgvdBEhMw9T5ETH7c/view?usp=drive_link", "Learn the basics of Python, the language of the web.", "https://drive.google.com/file/d/1zrkNTZzqGSrYXP-_sifUYcvSHxXeJbAM/view?usp=drive_link", 1, "Learning Python" },
                    { 3, "https://drive.google.com/file/d/16coGOcEz60f91XuCN6vOzCV_9W3uGlmZ/view?usp=drive_link", "A comprehensive guide to Python for beginners.", "https://drive.google.com/file/d/1T7p9YWal6ymugkyCGzT-5_iRJEsC51Yj/view?usp=sharing", 1, "Hasou with python" },
                    { 4, "https://drive.google.com/file/d/14yl0K2kNvLcMmyupgvdBEhMw9T5ETH7c/view?usp=drive_link", "Dive deeper into Python with basic concepts.", "https://drive.google.com/file/d/19d4fGntUOyCN0sT07PSsxOHgIZ9FaKQ1/view?usp=drive_link", 1, "Python in arabic" },
                    { 5, "https://drive.google.com/file/d/12Y3rlr03JKKbkeLG5vjocabDEjx2X4Os/view?usp=drive_link", "A guide to using Python for thinking with python.", "https://drive.google.com/file/d/1QVFWHnhT2jD6n2FO4FEIUCjKSKBMt6XP/view?usp=drive_link", 1, "Think Python" },
                    { 6, "https://drive.google.com/file/d/1WQf24NQIWmVTqitoYMdmknol_rn0LNos/view?usp=drive_link", "A guide to using Python for data structure.", "https://drive.google.com/file/d/1axJQq-cLL2UWxbcDuPZMKQxRWWWj40my/view?usp=drive_link", 2, "Python for data structure" },
                    { 7, "https://drive.google.com/file/d/1U8oLuQ5RY5qllPFmesuvx9FJkl0AP70u/view?usp=drive_link", "A comprehensive guide to data structure in Python.", "https://drive.google.com/file/d/1yDjHGglBm68bfzyMJyT91km_pv4rROd7/view?usp=drive_link", 2, "Data structure in python" },
                    { 8, "https://drive.google.com/file/d/1cNMyAO7xoAyXEmUv0zY32KfFyx5VBo2y/view?usp=drive_link", "A guide to using Python for algorithms.", "https://drive.google.com/file/d/1MX8qDUNCa0H4fWexqUz7vBb91Grz2EYs/view?usp=drive_link", 2, "Python for algorithms" },
                    { 9, "https://drive.google.com/file/d/1SuldYbX8KduRaGqoG0qVROfiuPmh-wXU/view?usp=drive_link", "A comprehensive guide to algorithms in Python.", "https://drive.google.com/file/d/1alwZjhLNEu6VOZaoAUDpbi6Vt1cl2ha2/view?usp=drive_link", 2, "Algorithms in python" },
                    { 10, "https://drive.google.com/file/d/1cVUoQAnrDdxQGLQaN6bkIm7wyNdvRvD2/view?usp=drive_link", "A guide to using Python for machine learning.", "https://drive.google.com/file/d/1UhspnmqNSEcg6LRixxvBcsNDeP4OhkiD/view?usp=drive_link", 3, "Machine learning with python" },
                    { 11, "https://drive.google.com/file/d/1vsOjmLBeT-T7UAWenlHpgRFql_NwHZGA/view?usp=drive_link", "A comprehensive guide to data analysis in Python.", "https://drive.google.com/file/d/1IF5jryx8-ogxGJXUNKfrEnsBLGSJ1fiL/view?usp=drive_link", 3, "Data analysis with python" },
                    { 12, "https://drive.google.com/file/d/1hj_1Us9UZMw4lbsVI9ux3Xv0AEzyLiBC/view?usp=drive_link", "A guide to using Python for data science.", "https://drive.google.com/file/d/1RPHVouW2ypLQtgUvqu6gupf_tvPk-M-C/view?usp=drive_link", 3, "Data science with python" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12);
        }
    }
}
