using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TechSpire.infra.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsDisabled = table.Column<bool>(type: "bit", nullable: false),
                    CompletedLessonIds = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Favs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemId = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Favs_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RefreshTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpiresOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RevokedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshTokens", x => new { x.UserId, x.Id });
                    table.ForeignKey(
                        name: "FK_RefreshTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.CreateTable(
                name: "Topics",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Topics_Stages_StageId",
                        column: x => x.StageId,
                        principalTable: "Stages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArticleUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StageId = table.Column<int>(type: "int", nullable: false),
                    TopicId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Articles_Stages_StageId",
                        column: x => x.StageId,
                        principalTable: "Stages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Articles_Topics_TopicId",
                        column: x => x.TopicId,
                        principalTable: "Topics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StageId = table.Column<int>(type: "int", nullable: false),
                    TopicId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Stages_StageId",
                        column: x => x.StageId,
                        principalTable: "Stages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Books_Topics_TopicId",
                        column: x => x.TopicId,
                        principalTable: "Topics",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Lessons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StageId = table.Column<int>(type: "int", nullable: false),
                    TopicId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Lessons_Stages_StageId",
                        column: x => x.StageId,
                        principalTable: "Stages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Lessons_Topics_TopicId",
                        column: x => x.TopicId,
                        principalTable: "Topics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StageId = table.Column<int>(type: "int", nullable: false),
                    TopicId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_Stages_StageId",
                        column: x => x.StageId,
                        principalTable: "Stages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Posts_Topics_TopicId",
                        column: x => x.TopicId,
                        principalTable: "Topics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Quizzes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StangeId = table.Column<int>(type: "int", nullable: false),
                    TopicId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quizzes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Quizzes_Stages_StangeId",
                        column: x => x.StangeId,
                        principalTable: "Stages",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Quizzes_Topics_TopicId",
                        column: x => x.TopicId,
                        principalTable: "Topics",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

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
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuizId = table.Column<int>(type: "int", nullable: false),
                    MaterialType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaterialId = table.Column<int>(type: "int", nullable: true),
                    TopicId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questions_Quizzes_QuizId",
                        column: x => x.QuizId,
                        principalTable: "Quizzes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Questions_Topics_TopicId",
                        column: x => x.TopicId,
                        principalTable: "Topics",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserQuizResults",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    QuizId = table.Column<int>(type: "int", nullable: false),
                    SubmittedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CorrectPercentage = table.Column<double>(type: "float", nullable: false),
                    WrongPercentage = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserQuizResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserQuizResults_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserQuizResults_Quizzes_QuizId",
                        column: x => x.QuizId,
                        principalTable: "Quizzes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Answers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCorrect = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Answers_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserAnswers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    AnswerId = table.Column<int>(type: "int", nullable: false),
                    TimeTakenInSeconds = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAnswers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserAnswers_Answers_AnswerId",
                        column: x => x.AnswerId,
                        principalTable: "Answers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserAnswers_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserAnswers_Questions_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Questions",
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
                table: "Articles",
                columns: new[] { "Id", "ArticleUrl", "Description", "ImageUrl", "StageId", "Title", "TopicId" },
                values: new object[,]
                {
                    { 1, "https://www.w3schools.com/python/", "A beginner's guide to Python programming language.", "", 1, "Introduction to Python", null },
                    { 2, "https://docs.python.org/3/tutorial/index.html", "Learn the basics of Pyhton, the language of the web.", "", 1, "Getting Started with Pyhton", null },
                    { 3, "https://realpython.com/python-basics/", "Go From Basic to Intermediate Python Knowledge", "", 1, "Basics For Python", null },
                    { 4, "https://www.geeksforgeeks.org/python-data-structures-and-algorithms/", "Learn about lists, tuples, sets, and dictionaries in Python.", "", 2, "Python Data Structures", null },
                    { 5, "https://www.geeksforgeeks.org/python-oops-concepts/", "Understanding functions and modules in Python.", "", 2, "Python Functions and Modules", null },
                    { 6, "https://realpython.com/python3-object-oriented-programming/", "An introduction to OOP concepts in Python.", "", 2, "Python Object-Oriented Programming", null },
                    { 7, "https://docs.python.org/3/tutorial/inputoutput.html#reading-and-writing-files", "Learn how to read and write files in Python.", "", 3, "Python File Handling", null },
                    { 8, "https://www.geeksforgeeks.org/advanced-python-tutorials/", "Python language is a very versatile language and it is used in many technical fields.", "", 3, "Python such as Data Science, Artificial Intelligence and Robotics", null },
                    { 9, "https://www.w3schools.com/python/python_ml_getting_started.asp", "In this tutorial we will go back to mathematics and study statistics.", "", 3, "Python in Machine Learning", null }
                });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "Content", "StageId", "Title", "TopicId" },
                values: new object[,]
                {
                    { 1, "In this lesson, we will cover the basics of Python programming, including syntax, variables, and data types. You will learn how to write your first Python program and understand the structure of Python code.  What can Python do?  Python can be used on a server to create web applications.\r\nPython can be used alongside software to create workflows.\r\nPython can connect to database systems. It can also read and modify files.\r\nPython can be used to handle big data and perform complex mathematics.\r\nPython can be used for rapid prototyping, or for production-ready software development.\r\n", 1, "Lesson 1 : Introduction to Python", null },
                    { 2, "This lesson will guide you through setting up your Python environment, installing necessary tools, and writing your first Python script. You will also learn about basic input and output operations.\n Many PCs and Macs will have python already installed.\r\n\r\nTo check if you have python installed on a Windows PC, search in the start bar for Python", 1, "Lesson 2 : Getting Started with Python", null },
                    { 3, "In this lesson, we will explore basic Python concepts such as control flow, loops, and functions. You will learn how to create reusable code blocks and understand the importance of functions in programming.\n Python Quickstart\r\nPython is an interpreted programming language, this means that as a developer you write Python (.py) files in a text editor and then put those files into the python interpreter to be executed.", 1, "Lesson 3 : Basics of Python", null },
                    { 4, "This lesson will focus on Python syntax, including indentation, comments, and the use of operators. You will learn how to write clean and readable code, which is essential for effective programming.\n Python Indentation\r\nIndentation refers to the spaces at the beginning of a code line.\r\n\r\nWhere in other programming languages the indentation in code is for readability only, the indentation in Python is very important.\r\n\r\nPython uses indentation to indicate a block of code.", 1, "Lesson 4 : Python Syntax", null },
                    { 5, "In this lesson, we will dive deeper into Python variables and data types. You will learn about different data types such as strings, integers, and lists, and how to manipulate them effectively. \n Variables\r\nVariables are containers for storing data values.\r\n\r\nCreating Variables\r\nPython has no command for declaring a variable.\r\n\r\nA variable is created the moment you first assign a value to it.", 1, "Lesson 5 : Python Variables and Data Types", null },
                    { 6, "This lesson will introduce you to Python data structures, including lists, tuples, and dictionaries. You will learn how to choose the right data structure for your needs and how to manipulate them effectively.\n Python Data Structures\r\nPython has a set of built-in data structures, such as lists, tuples, sets, and dictionaries.\r\n\r\nThese data structures allow you to store and manipulate collections of data efficiently.", 2, "Lesson 6 : Python Data Strcture Intro", null },
                    { 7, "In this lesson, we will explore the first data structure in Python: lists. You will learn how to create, access, and manipulate lists, which are essential for storing collections of data.\n Python Lists\r\nLists are used to store multiple items in a single variable.\r\n\r\nA list is created by placing all the items (elements) inside square brackets [], separated by commas.\r\n\r\nList items are ordered, changeable, and allow duplicate values.", 2, "Lesson 7 : First Data Strcture ", null },
                    { 8, "This lesson will introduce you to stacks in Python, which are a type of data structure that follows the Last In First Out (LIFO) principle. You will learn how to implement stacks using lists and understand their applications.\n Python Stacks\r\nA stack is a collection of elements that supports two main operations: push and pop.\r\n\r\nPush adds an element to the top of the stack, while pop removes the top element from the stack.\r\n\r\nStacks are often used in algorithms and data processing tasks.", 2, "Lesson 8 : Python Stacks ", null },
                    { 9, "In this lesson, we will explore queues in Python, which are a type of data structure that follows the First In First Out (FIFO) principle. You will learn how to implement queues using lists and understand their applications.\n Python Queues\r\nA queue is a collection of elements that supports two main operations: enqueue and dequeue.\r\n\r\nEnqueue adds an element to the end of the queue, while dequeue removes the front element from the queue.\r\n\r\nQueues are often used in scheduling and task management scenarios.", 2, "Lesson 9 : Python Queues", null },
                    { 10, "This lesson will introduce you to linked lists in Python, which are a type of data structure that consists of nodes. You will learn how to create and manipulate linked lists, and understand their advantages over other data structures.\n Python Linked Lists\r\nA linked list is a linear data structure where each element is a separate object, called a node.\r\n\r\nEach node contains a value and a reference (or link) to the next node in the sequence.\r\n\r\nLinked lists are often used in scenarios where dynamic memory allocation is required.", 2, "Lesson 10 : Python Linked Lists", null },
                    { 11, "In this lesson, we will explore statistical concepts in Python, including mean, median, and mode. You will learn how to calculate these statistics using Python and understand their significance in data analysis.\n Python Mean Median Mode\r\nMean is the average of a set of numbers, calculated by dividing the sum of all numbers by the count of numbers.\r\n\r\nMedian is the middle value in a sorted list of numbers.\r\n\r\nMode is the value that appears most frequently in a dataset.", 3, "Lesson 11 : Python Mean Median Mode", null },
                    { 12, "This lesson will cover advanced Python topics such as list comprehensions, lambda functions, and error handling. You will learn how to write more efficient and robust Python code.\n Python List Comprehension\r\nList comprehension offers a shorter syntax when you want to create a new list based on the values of an existing list.\r\n\r\nWith list comprehension you can do all this with only one line of code:\r\n\r\nnewlist = [expression for item in iterable if condition == True]\r\n\r\nWhere the expression is the current item in the iteration, but it is also the outcome, which you can manipulate before it ends up like a list item in the new list.", 3, "Lesson 12 : Python Advanced Topics", null },
                    { 13, "In this lesson, we will introduce you to the basics of machine learning in Python. You will learn about popular libraries such as Scikit-learn and TensorFlow, and how to build simple machine learning models.\n Python Machine Learning Libraries\r\nPython has a rich ecosystem of libraries for machine learning, including Scikit-learn, TensorFlow, and Keras.\r\n\r\nThese libraries provide powerful tools for building and training machine learning models.", 3, "Lesson 13 : Python Machine Learning Intro", null },
                    { 14, "This lesson will introduce you to the basics of data science in Python. You will learn about libraries such as NumPy and Pandas, which are essential for data manipulation and analysis.\n Python Data Science Libraries\r\nPython has a rich ecosystem of libraries for data science, including NumPy, Pandas, Matplotlib, and Scikit-learn.\r\n\r\nThese libraries provide powerful tools for data manipulation, analysis, and visualization.", 3, "Lesson 14 : Python Data Science Intro", null },
                    { 15, "In this lesson, we will introduce you to web development in Python. You will learn about popular web frameworks such as Flask and Django, and how to build simple web applications.\n Python Web Development Frameworks\r\nPython has several popular web frameworks, including Flask and Django.\r\n\r\nThese frameworks provide tools and libraries for building web applications quickly and efficiently.", 3, "Lesson 15 : Python Web Development Intro", null }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ImageUrl", "PostUrl", "StageId", "Title", "TopicId" },
                values: new object[,]
                {
                    { 1, "A beginner's guide to Python programming language.", "", "https://harmash.com/tutorials/python/overview", 1, "Introduction to Python", null },
                    { 2, "Learn the basics of Pyhton, the language of the web.", "", "https://academy.hsoub.com/files/15-%D8%A7%D9%84%D8%A8%D8%B1%D9%85%D8%AC%D8%A9-%D8%A8%D9%84%D8%BA%D8%A9-%D8%A8%D8%A7%D9%8A%D8%AB%D9%88%D9%86/", 1, "Getting Started with Pyhton", null },
                    { 3, "Go From Basic to Intermediate Python Knowledge", "", "https://colab.research.google.com/drive/1LSSOITVzLrLvVN91kppSh1OHm3CU1Esy?authuser=0#scrollTo=hU-QtmhQo2AN", 1, "Basics For Python", null },
                    { 4, "Learn about lists, tuples, sets, and dictionaries in Python.", "", "https://elzero.org/everything-about-data-structure/", 2, "Python Data Structures", null },
                    { 5, "Understanding functions and modules in Python.", "", "https://www.kholoodtechnotes.net/2024/07/Python-OOP-ClassObject.html?m=1", 2, "Python OOP ", null },
                    { 6, "An introduction to OOP concepts in Python.", "", "https://academy.hsoub.com/programming/python/%D9%85%D8%AE%D8%AA%D8%B5%D8%B1-%D8%A7%D9%84%D8%A8%D8%B1%D9%85%D8%AC%D8%A9-%D9%83%D8%A7%D8%A6%D9%86%D9%8A%D8%A9-%D8%A7%D9%84%D8%AA%D9%88%D8%AC%D9%87-oop-%D9%88%D8%AA%D8%B7%D8%A8%D9%8A%D9%82%D9%87%D8%A7-%D9%81%D9%8A-%D8%A8%D8%A7%D9%8A%D8%AB%D9%88%D9%86-r1926/", 2, "Python Object-Oriented Programming", null },
                    { 7, " An introduction about Machine Learning ", "", "https://uomus.edu.iq/NewDep.aspx?depid=7&newid=14046", 3, "Python in Machine Learning", null },
                    { 8, "A guide to using Machine Learning in Python.", "", "https://academy.hsoub.com/programming/artificial-intelligence/%D8%AA%D8%B9%D9%84%D9%85-%D8%A7%D9%84%D8%A2%D9%84%D8%A9/", 3, "Machine Learning", null },
                    { 9, "Learn how to use python with data science.", "", "https://www.tomasbeuzen.com/python-programming-for-data-science/README.html", 3, "Python With Data Science ", null }
                });

            migrationBuilder.InsertData(
                table: "Quizzes",
                columns: new[] { "Id", "Description", "StangeId", "Title", "TopicId" },
                values: new object[] { 1, "Test your knowledge of C# basics.", 1, "C# Basics", null });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "MaterialId", "MaterialType", "QuizId", "Text", "TopicId" },
                values: new object[,]
                {
                    { 1, null, null, 1, "What is a variable in C#?", 1 },
                    { 2, null, null, 1, "What is a class in OOP?", 2 },
                    { 3, null, null, 1, "What is a list in C#?", 3 },
                    { 4, null, null, 1, "What is machine learning?", 4 },
                    { 5, null, null, 1, "What is data analysis?", 5 },
                    { 6, null, null, 1, "What is data science?", 6 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answers_QuestionId",
                table: "Answers",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_StageId",
                table: "Articles",
                column: "StageId");

            migrationBuilder.CreateIndex(
                name: "IX_Articles_TopicId",
                table: "Articles",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Books_StageId",
                table: "Books",
                column: "StageId");

            migrationBuilder.CreateIndex(
                name: "IX_Books_TopicId",
                table: "Books",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_Favs_UserId",
                table: "Favs",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_StageId",
                table: "Lessons",
                column: "StageId");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_TopicId",
                table: "Lessons",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_StageId",
                table: "Posts",
                column: "StageId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_TopicId",
                table: "Posts",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_QuizId",
                table: "Questions",
                column: "QuizId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_TopicId",
                table: "Questions",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_Quizzes_StangeId",
                table: "Quizzes",
                column: "StangeId");

            migrationBuilder.CreateIndex(
                name: "IX_Quizzes_TopicId",
                table: "Quizzes",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_Topics_StageId",
                table: "Topics",
                column: "StageId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAnswers_AnswerId",
                table: "UserAnswers",
                column: "AnswerId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAnswers_QuestionId",
                table: "UserAnswers",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAnswers_UserId",
                table: "UserAnswers",
                column: "UserId");

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
                name: "IX_UserQuizResults_QuizId",
                table: "UserQuizResults",
                column: "QuizId");

            migrationBuilder.CreateIndex(
                name: "IX_UserQuizResults_UserId",
                table: "UserQuizResults",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersProgress_UserId",
                table: "UsersProgress",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Favs");

            migrationBuilder.DropTable(
                name: "Lessons");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "RefreshTokens");

            migrationBuilder.DropTable(
                name: "UserAnswers");

            migrationBuilder.DropTable(
                name: "UserArticleInProgress");

            migrationBuilder.DropTable(
                name: "UserBookInProgress");

            migrationBuilder.DropTable(
                name: "UserQuizResults");

            migrationBuilder.DropTable(
                name: "UsersProgress");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Answers");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Quizzes");

            migrationBuilder.DropTable(
                name: "Topics");

            migrationBuilder.DropTable(
                name: "Stages");
        }
    }
}
