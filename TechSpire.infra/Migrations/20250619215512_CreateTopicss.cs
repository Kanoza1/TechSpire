using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TechSpire.infra.Migrations
{
    /// <inheritdoc />
    public partial class CreateTopicss : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Topics_TopicId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Quizzes_Topics_TopicId",
                table: "Quizzes");

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
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Questions",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Topics_TopicId",
                table: "Questions");

            migrationBuilder.DropForeignKey(
                name: "FK_Quizzes_Topics_TopicId",
                table: "Quizzes");

            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "IsCorrect", "QuestionId", "Text" },
                values: new object[,]
                {
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
                table: "Questions",
                columns: new[] { "Id", "MaterialId", "MaterialType", "QuizId", "StageId", "Text", "TopicId" },
                values: new object[,]
                {
                    { 1, null, null, 1, 1, "1- What is the What is the correct way to create a variable in Python? ", 1 },
                    { 2, null, null, 1, 1, "2-Which of the following is a valid variable name in Python?", 1 },
                    { 3, null, null, 1, 1, "3-What will be the output of the following code? x = \"5\" y = 2 print(x + str(y))", 1 },
                    { 4, null, null, 1, 1, "4-Which of these is not allowed when assigning variables in Python?", 1 },
                    { 5, null, null, 1, 1, "5-What is the data type of the variable x in this code? x = 3.14", 1 },
                    { 6, null, null, 1, 1, "6-Which of the following is a valid way to assign a value to a variable?", 1 },
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
                name: "FK_Questions_Topics_TopicId",
                table: "Questions",
                column: "TopicId",
                principalTable: "Topics",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Quizzes_Topics_TopicId",
                table: "Quizzes",
                column: "TopicId",
                principalTable: "Topics",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
