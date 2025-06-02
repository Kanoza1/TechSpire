using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TechSpire.infra.Migrations
{
    /// <inheritdoc />
    public partial class DataAdding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "ArticleUrl", "Description", "ImageUrl", "StageId", "Title" },
                values: new object[,]
                {
                    { 1, "https://www.w3schools.com/python/", "A beginner's guide to Python programming language.", "", 1, "Introduction to Python" },
                    { 2, "https://docs.python.org/3/tutorial/index.html", "Learn the basics of Pyhton, the language of the web.", "", 1, "Getting Started with Pyhton" },
                    { 3, "https://realpython.com/python-basics/", "Go From Basic to Intermediate Python Knowledge", "", 1, "Basics For Python" },
                    { 4, "https://www.geeksforgeeks.org/python-data-structures-and-algorithms/", "Learn about lists, tuples, sets, and dictionaries in Python.", "", 2, "Python Data Structures" },
                    { 5, "https://www.geeksforgeeks.org/python-oops-concepts/", "Understanding functions and modules in Python.", "", 2, "Python Functions and Modules" },
                    { 6, "https://realpython.com/python3-object-oriented-programming/", "An introduction to OOP concepts in Python.", "", 2, "Python Object-Oriented Programming" },
                    { 7, "https://docs.python.org/3/tutorial/inputoutput.html#reading-and-writing-files", "Learn how to read and write files in Python.", "", 3, "Python File Handling" },
                    { 8, "https://www.geeksforgeeks.org/advanced-python-tutorials/", "Python language is a very versatile language and it is used in many technical fields.", "", 3, "Python such as Data Science, Artificial Intelligence and Robotics" },
                    { 9, "https://www.w3schools.com/python/python_ml_getting_started.asp", "In this tutorial we will go back to mathematics and study statistics.", "", 3, "Python in Machine Learning" }
                });

            migrationBuilder.InsertData(
                table: "Lessons",
                columns: new[] { "Id", "Content", "StageId", "Title" },
                values: new object[,]
                {
                    { 1, "In this lesson, we will cover the basics of Python programming, including syntax, variables, and data types. You will learn how to write your first Python program and understand the structure of Python code.  What can Python do?  Python can be used on a server to create web applications.\r\nPython can be used alongside software to create workflows.\r\nPython can connect to database systems. It can also read and modify files.\r\nPython can be used to handle big data and perform complex mathematics.\r\nPython can be used for rapid prototyping, or for production-ready software development.\r\n", 1, "Lesson 1 : Introduction to Python" },
                    { 2, "This lesson will guide you through setting up your Python environment, installing necessary tools, and writing your first Python script. You will also learn about basic input and output operations.\n Many PCs and Macs will have python already installed.\r\n\r\nTo check if you have python installed on a Windows PC, search in the start bar for Python", 1, "Lesson 2 : Getting Started with Python" },
                    { 3, "In this lesson, we will explore basic Python concepts such as control flow, loops, and functions. You will learn how to create reusable code blocks and understand the importance of functions in programming.\n Python Quickstart\r\nPython is an interpreted programming language, this means that as a developer you write Python (.py) files in a text editor and then put those files into the python interpreter to be executed.", 1, "Lesson 3 : Basics of Python" },
                    { 4, "This lesson will focus on Python syntax, including indentation, comments, and the use of operators. You will learn how to write clean and readable code, which is essential for effective programming.\n Python Indentation\r\nIndentation refers to the spaces at the beginning of a code line.\r\n\r\nWhere in other programming languages the indentation in code is for readability only, the indentation in Python is very important.\r\n\r\nPython uses indentation to indicate a block of code.", 1, "Lesson 4 : Python Syntax" },
                    { 5, "In this lesson, we will dive deeper into Python variables and data types. You will learn about different data types such as strings, integers, and lists, and how to manipulate them effectively. \n Variables\r\nVariables are containers for storing data values.\r\n\r\nCreating Variables\r\nPython has no command for declaring a variable.\r\n\r\nA variable is created the moment you first assign a value to it.", 1, "Lesson 5 : Python Variables and Data Types" },
                    { 6, "This lesson will introduce you to Python data structures, including lists, tuples, and dictionaries. You will learn how to choose the right data structure for your needs and how to manipulate them effectively.\n Python Data Structures\r\nPython has a set of built-in data structures, such as lists, tuples, sets, and dictionaries.\r\n\r\nThese data structures allow you to store and manipulate collections of data efficiently.", 2, "Lesson 6 : Python Data Strcture Intro" },
                    { 7, "In this lesson, we will explore the first data structure in Python: lists. You will learn how to create, access, and manipulate lists, which are essential for storing collections of data.\n Python Lists\r\nLists are used to store multiple items in a single variable.\r\n\r\nA list is created by placing all the items (elements) inside square brackets [], separated by commas.\r\n\r\nList items are ordered, changeable, and allow duplicate values.", 2, "Lesson 7 : First Data Strcture " },
                    { 8, "This lesson will introduce you to stacks in Python, which are a type of data structure that follows the Last In First Out (LIFO) principle. You will learn how to implement stacks using lists and understand their applications.\n Python Stacks\r\nA stack is a collection of elements that supports two main operations: push and pop.\r\n\r\nPush adds an element to the top of the stack, while pop removes the top element from the stack.\r\n\r\nStacks are often used in algorithms and data processing tasks.", 2, "Lesson 8 : Python Stacks " },
                    { 9, "In this lesson, we will explore queues in Python, which are a type of data structure that follows the First In First Out (FIFO) principle. You will learn how to implement queues using lists and understand their applications.\n Python Queues\r\nA queue is a collection of elements that supports two main operations: enqueue and dequeue.\r\n\r\nEnqueue adds an element to the end of the queue, while dequeue removes the front element from the queue.\r\n\r\nQueues are often used in scheduling and task management scenarios.", 2, "Lesson 9 : Python Queues" },
                    { 10, "This lesson will introduce you to linked lists in Python, which are a type of data structure that consists of nodes. You will learn how to create and manipulate linked lists, and understand their advantages over other data structures.\n Python Linked Lists\r\nA linked list is a linear data structure where each element is a separate object, called a node.\r\n\r\nEach node contains a value and a reference (or link) to the next node in the sequence.\r\n\r\nLinked lists are often used in scenarios where dynamic memory allocation is required.", 2, "Lesson 10 : Python Linked Lists" },
                    { 11, "In this lesson, we will explore statistical concepts in Python, including mean, median, and mode. You will learn how to calculate these statistics using Python and understand their significance in data analysis.\n Python Mean Median Mode\r\nMean is the average of a set of numbers, calculated by dividing the sum of all numbers by the count of numbers.\r\n\r\nMedian is the middle value in a sorted list of numbers.\r\n\r\nMode is the value that appears most frequently in a dataset.", 3, "Lesson 11 : Python Mean Median Mode" },
                    { 12, "This lesson will cover advanced Python topics such as list comprehensions, lambda functions, and error handling. You will learn how to write more efficient and robust Python code.\n Python List Comprehension\r\nList comprehension offers a shorter syntax when you want to create a new list based on the values of an existing list.\r\n\r\nWith list comprehension you can do all this with only one line of code:\r\n\r\nnewlist = [expression for item in iterable if condition == True]\r\n\r\nWhere the expression is the current item in the iteration, but it is also the outcome, which you can manipulate before it ends up like a list item in the new list.", 3, "Lesson 12 : Python Advanced Topics" },
                    { 13, "In this lesson, we will introduce you to the basics of machine learning in Python. You will learn about popular libraries such as Scikit-learn and TensorFlow, and how to build simple machine learning models.\n Python Machine Learning Libraries\r\nPython has a rich ecosystem of libraries for machine learning, including Scikit-learn, TensorFlow, and Keras.\r\n\r\nThese libraries provide powerful tools for building and training machine learning models.", 3, "Lesson 13 : Python Machine Learning Intro" },
                    { 14, "This lesson will introduce you to the basics of data science in Python. You will learn about libraries such as NumPy and Pandas, which are essential for data manipulation and analysis.\n Python Data Science Libraries\r\nPython has a rich ecosystem of libraries for data science, including NumPy, Pandas, Matplotlib, and Scikit-learn.\r\n\r\nThese libraries provide powerful tools for data manipulation, analysis, and visualization.", 3, "Lesson 14 : Python Data Science Intro" },
                    { 15, "In this lesson, we will introduce you to web development in Python. You will learn about popular web frameworks such as Flask and Django, and how to build simple web applications.\n Python Web Development Frameworks\r\nPython has several popular web frameworks, including Flask and Django.\r\n\r\nThese frameworks provide tools and libraries for building web applications quickly and efficiently.", 3, "Lesson 15 : Python Web Development Intro" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Description", "ImageUrl", "PostUrl", "StageId", "Title" },
                values: new object[,]
                {
                    { 1, "A beginner's guide to Python programming language.", "", "https://harmash.com/tutorials/python/overview", 1, "Introduction to Python" },
                    { 2, "Learn the basics of Pyhton, the language of the web.", "", "https://academy.hsoub.com/files/15-%D8%A7%D9%84%D8%A8%D8%B1%D9%85%D8%AC%D8%A9-%D8%A8%D9%84%D8%BA%D8%A9-%D8%A8%D8%A7%D9%8A%D8%AB%D9%88%D9%86/", 1, "Getting Started with Pyhton" },
                    { 3, "Go From Basic to Intermediate Python Knowledge", "", "https://colab.research.google.com/drive/1LSSOITVzLrLvVN91kppSh1OHm3CU1Esy?authuser=0#scrollTo=hU-QtmhQo2AN", 1, "Basics For Python" },
                    { 4, "Learn about lists, tuples, sets, and dictionaries in Python.", "", "https://elzero.org/everything-about-data-structure/", 2, "Python Data Structures" },
                    { 5, "Understanding functions and modules in Python.", "", "https://www.kholoodtechnotes.net/2024/07/Python-OOP-ClassObject.html?m=1", 2, "Python OOP " },
                    { 6, "An introduction to OOP concepts in Python.", "", "https://academy.hsoub.com/programming/python/%D9%85%D8%AE%D8%AA%D8%B5%D8%B1-%D8%A7%D9%84%D8%A8%D8%B1%D9%85%D8%AC%D8%A9-%D9%83%D8%A7%D8%A6%D9%86%D9%8A%D8%A9-%D8%A7%D9%84%D8%AA%D9%88%D8%AC%D9%87-oop-%D9%88%D8%AA%D8%B7%D8%A8%D9%8A%D9%82%D9%87%D8%A7-%D9%81%D9%8A-%D8%A8%D8%A7%D9%8A%D8%AB%D9%88%D9%86-r1926/", 2, "Python Object-Oriented Programming" },
                    { 7, " An introduction about Machine Learning ", "", "https://uomus.edu.iq/NewDep.aspx?depid=7&newid=14046", 3, "Python in Machine Learning" },
                    { 8, "A guide to using Machine Learning in Python.", "", "https://academy.hsoub.com/programming/artificial-intelligence/%D8%AA%D8%B9%D9%84%D9%85-%D8%A7%D9%84%D8%A2%D9%84%D8%A9/", 3, "Machine Learning" },
                    { 9, "Learn how to use python with data science.", "", "https://www.tomasbeuzen.com/python-programming-for-data-science/README.html", 3, "Python With Data Science " }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Lessons",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "BookUrl", "Description", "ImageUrl", "StageId", "Title" },
                values: new object[,]
                {
                    { 1, "https://example.com/csharp-book.pdf", "Learn the fundamentals of C# programming.", "https://example.com/csharp.jpg", 1, "C# Programming" },
                    { 2, "https://example.com/aspnetcore-book.pdf", "Build modern web applications using ASP.NET Core.", "https://example.com/aspnetcore.jpg", 1, "ASP.NET Core Development" }
                });
        }
    }
}
