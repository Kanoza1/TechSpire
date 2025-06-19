using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TechSpire.infra.Migrations
{
    /// <inheritdoc />
    public partial class CreateTopic : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Topics_TopicId",
                table: "Books");

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AddColumn<int>(
                name: "StageId",
                table: "Questions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "IsCorrect", "QuestionId", "Text" },
                values: new object[,]
                {
                    { 1, true, 1, "Python is a programming language." },
                    { 2, false, 1, "Python is a snake species." },
                    { 3, true, 2, "Python supports multiple programming paradigms." },
                    { 4, false, 2, "Python only supports procedural programming." },
                    { 5, true, 3, "Python is dynamically typed." },
                    { 6, false, 3, "Python is statically typed." },
                    { 7, true, 4, "Python has a large standard library." },
                    { 8, false, 4, "Python has a small standard library." },
                    { 9, true, 5, "Python supports object-oriented programming." },
                    { 10, false, 5, "Python does not support object-oriented programming." },
                    { 11, true, 6, "Python supports functional programming." },
                    { 12, false, 6, "Python does not support functional programming." },
                    { 31, true, 16, "Python supports class variables." },
                    { 32, false, 16, "Python does not support class variables." },
                    { 33, true, 17, "Python supports instance variables." },
                    { 34, false, 17, "Python does not support instance variables." },
                    { 35, true, 18, "Python supports static variables." },
                    { 36, false, 18, "Python does not support static variables." },
                    { 37, true, 19, "Python supports class methods." },
                    { 38, false, 19, "Python does not support class methods." },
                    { 39, true, 20, "Python supports instance methods." },
                    { 40, false, 20, "Python does not support instance methods." }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "BookUrl", "Description", "ImageUrl", "StageId", "Title", "TopicId" },
                values: new object[,]
                {
                    { 1, "https://drive.google.com/file/d/16KohWjujqh1nRMb1YmJyeoVbIlIDmqB2/view?usp=drive_link", "A beginner's guide to Python programming language.", "https://drive.google.com/file/d/1tvk6zU8SpXOUu-y9oBOAgQJFXFLB8Nby/view?usp=drive_link", 1, "How-to-code-in-python", 1 },
                    { 2, "https://drive.google.com/file/d/14yl0K2kNvLcMmyupgvdBEhMw9T5ETH7c/view?usp=drive_link", "Learn the basics of Python, the language of the web.", "https://drive.google.com/file/d/1zrkNTZzqGSrYXP-_sifUYcvSHxXeJbAM/view?usp=drive_link", 1, "Learning Python", 1 },
                    { 3, "https://drive.google.com/file/d/16coGOcEz60f91XuCN6vOzCV_9W3uGlmZ/view?usp=drive_link", "A comprehensive guide to Python for beginners.", "https://drive.google.com/file/d/1T7p9YWal6ymugkyCGzT-5_iRJEsC51Yj/view?usp=sharing", 1, "Hasou with python", 1 },
                    { 4, "https://drive.google.com/file/d/14yl0K2kNvLcMmyupgvdBEhMw9T5ETH7c/view?usp=drive_link", "Dive deeper into Python with basic concepts.", "https://drive.google.com/file/d/19d4fGntUOyCN0sT07PSsxOHgIZ9FaKQ1/view?usp=drive_link", 1, "Python in arabic", 2 },
                    { 5, "https://drive.google.com/file/d/12Y3rlr03JKKbkeLG5vjocabDEjx2X4Os/view?usp=drive_link", "A guide to using Python for thinking with python.", "https://drive.google.com/file/d/1QVFWHnhT2jD6n2FO4FEIUCjKSKBMt6XP/view?usp=drive_link", 1, "Think Python", 2 },
                    { 6, "https://drive.google.com/file/d/1WQf24NQIWmVTqitoYMdmknol_rn0LNos/view?usp=drive_link", "A guide to using Python for data structure.", "https://drive.google.com/file/d/1axJQq-cLL2UWxbcDuPZMKQxRWWWj40my/view?usp=drive_link", 2, "Python for data structure", 3 },
                    { 7, "https://drive.google.com/file/d/1U8oLuQ5RY5qllPFmesuvx9FJkl0AP70u/view?usp=drive_link", "A comprehensive guide to data structure in Python.", "https://drive.google.com/file/d/1yDjHGglBm68bfzyMJyT91km_pv4rROd7/view?usp=drive_link", 2, "Data structure in python", 3 },
                    { 8, "https://drive.google.com/file/d/1cNMyAO7xoAyXEmUv0zY32KfFyx5VBo2y/view?usp=drive_link", "A guide to using Python for algorithms.", "https://drive.google.com/file/d/1MX8qDUNCa0H4fWexqUz7vBb91Grz2EYs/view?usp=drive_link", 2, "Python for algorithms", 4 },
                    { 9, "https://drive.google.com/file/d/1SuldYbX8KduRaGqoG0qVROfiuPmh-wXU/view?usp=drive_link", "A comprehensive guide to algorithms in Python.", "https://drive.google.com/file/d/1alwZjhLNEu6VOZaoAUDpbi6Vt1cl2ha2/view?usp=drive_link", 2, "Algorithms in python", 4 },
                    { 10, "https://drive.google.com/file/d/1cVUoQAnrDdxQGLQaN6bkIm7wyNdvRvD2/view?usp=drive_link", "A guide to using Python for machine learning.", "https://drive.google.com/file/d/1UhspnmqNSEcg6LRixxvBcsNDeP4OhkiD/view?usp=drive_link", 3, "Machine learning with python", 5 },
                    { 11, "https://drive.google.com/file/d/1vsOjmLBeT-T7UAWenlHpgRFql_NwHZGA/view?usp=drive_link", "A comprehensive guide to data analysis in Python.", "https://drive.google.com/file/d/1IF5jryx8-ogxGJXUNKfrEnsBLGSJ1fiL/view?usp=drive_link", 3, "Data analysis with python", 6 },
                    { 12, "https://drive.google.com/file/d/1hj_1Us9UZMw4lbsVI9ux3Xv0AEzyLiBC/view?usp=drive_link", "A guide to using Python for data science.", "https://drive.google.com/file/d/1RPHVouW2ypLQtgUvqu6gupf_tvPk-M-C/view?usp=drive_link", 3, "Data science with python", 7 }
                });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "StageId", "Text" },
                values: new object[] { 1, "1- What is the What is the correct way to create a variable in Python? " });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "StageId", "Text", "TopicId" },
                values: new object[] { 1, "2-Which of the following is a valid variable name in Python?", 1 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "StageId", "Text", "TopicId" },
                values: new object[] { 1, "3-What will be the output of the following code? x = \"5\" y = 2 print(x + str(y))", 1 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "StageId", "Text", "TopicId" },
                values: new object[] { 1, "4-Which of these is not allowed when assigning variables in Python?", 1 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "StageId", "Text", "TopicId" },
                values: new object[] { 1, "5-What is the data type of the variable x in this code? x = 3.14", 1 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "StageId", "Text", "TopicId" },
                values: new object[] { 1, "6-Which of the following is a valid way to assign a value to a variable?", 1 });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "MaterialId", "MaterialType", "QuizId", "StageId", "Text", "TopicId" },
                values: new object[,]
                {
                    { 7, null, null, 1, 1, "7-What will be the value of x after this code runs? x = 10 x = x + 5", 1 },
                    { 8, null, null, 1, 1, "8-Which of the following variable names is written in snake_case?", 1 },
                    { 9, null, null, 1, 1, "9-What is the value of result after running this code? a = 4 b = 3 result = a * b", 1 },
                    { 10, null, null, 1, 1, "10-Which statement is true about variables in Python?", 1 },
                    { 11, null, null, 2, 2, "What keyword is used to define a class in Python?", 2 },
                    { 12, null, null, 2, 2, "What is the first parameter of a method inside a class?", 2 },
                    { 13, null, null, 2, 2, "Which method is automatically called when an object is created?", 2 },
                    { 14, null, null, 2, 2, "What is it called when a class inherits from another class?", 2 },
                    { 15, null, null, 2, 2, "What is the purpose of the __str__() method in a class?", 2 },
                    { 21, null, null, 3, 3, "What is the main purpose of machine learning?", 3 },
                    { 22, null, null, 3, 3, "Which of the following is a common type of machine learning?", 3 },
                    { 23, null, null, 3, 3, "What is the purpose of a training dataset in machine learning?", 3 },
                    { 24, null, null, 3, 3, "What is overfitting in machine learning?", 3 },
                    { 25, null, null, 3, 3, "What is the purpose of a validation dataset in machine learning?", 3 }
                });

            migrationBuilder.InsertData(
                table: "Quizzes",
                columns: new[] { "Id", "Description", "StangeId", "Title", "TopicId" },
                values: new object[,]
                {
                    { 4, "A comprehensive quiz for Python beginners covering variables, data types, conditionals, and loops.", 1, "Beginner Python Quiz", 1 },
                    { 5, "A comprehensive quiz for Python intermediate learners covering OOP, data structures, algorithms, and functions.", 2, "Intermediate Python Quiz", 2 },
                    { 6, "A comprehensive quiz for advanced Python learners covering machine learning, deep learning, and big data.", 3, "Advanced Python Quiz", 3 }
                });

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "IsCorrect", "QuestionId", "Text" },
                values: new object[,]
                {
                    { 13, true, 7, "Python supports concurrent programming." },
                    { 14, false, 7, "Python does not support concurrent programming." },
                    { 15, true, 8, "Python supports metaprogramming." },
                    { 16, false, 8, "Python does not support metaprogramming." },
                    { 17, true, 9, "Python supports introspection." },
                    { 18, false, 9, "Python does not support introspection." },
                    { 19, true, 10, "Python supports reflection." },
                    { 20, false, 10, "Python does not support reflection." },
                    { 21, true, 11, "Python supports duck typing." },
                    { 22, false, 11, "Python does not support duck typing." },
                    { 23, true, 12, "Python supports multiple inheritance." },
                    { 24, false, 12, "Python does not support multiple inheritance." },
                    { 25, true, 13, "Python supports operator overloading." },
                    { 26, false, 13, "Python does not support operator overloading." },
                    { 27, true, 14, "Python supports method overloading." },
                    { 28, false, 14, "Python does not support method overloading." },
                    { 29, true, 15, "Python supports method overriding." },
                    { 30, false, 15, "Python does not support method overriding." },
                    { 41, true, 21, "Python supports static methods." },
                    { 42, false, 21, "Python does not support static methods." },
                    { 43, true, 22, "Python supports abstract classes." },
                    { 44, false, 22, "Python does not support abstract classes." },
                    { 45, true, 23, "Python supports interfaces." },
                    { 46, false, 23, "Python does not support interfaces." },
                    { 47, true, 24, "Python supports mixins." },
                    { 48, false, 24, "Python does not support mixins." },
                    { 49, true, 25, "Python supports decorators." },
                    { 50, false, 25, "Python does not support decorators." }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Topics_TopicId",
                table: "Books",
                column: "TopicId",
                principalTable: "Topics",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Topics_TopicId",
                table: "Books");

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 50);

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

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Quizzes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DropColumn(
                name: "StageId",
                table: "Questions");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Text",
                value: "What is a variable in C#?");

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Text", "TopicId" },
                values: new object[] { "What is a class in OOP?", 2 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Text", "TopicId" },
                values: new object[] { "What is a list in C#?", 3 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Text", "TopicId" },
                values: new object[] { "What is machine learning?", 4 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Text", "TopicId" },
                values: new object[] { "What is data analysis?", 5 });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Text", "TopicId" },
                values: new object[] { "What is data science?", 6 });

            migrationBuilder.InsertData(
                table: "Quizzes",
                columns: new[] { "Id", "Description", "StangeId", "Title", "TopicId" },
                values: new object[] { 1, "Test your knowledge of C# basics.", 1, "C# Basics", null });

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Topics_TopicId",
                table: "Books",
                column: "TopicId",
                principalTable: "Topics",
                principalColumn: "Id");
        }
    }
}
