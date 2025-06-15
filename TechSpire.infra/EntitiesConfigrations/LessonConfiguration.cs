using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSpire.infra.EntitiesConfigrations;
public class LessonConfiguration : IEntityTypeConfiguration<Lesson>
{
    public void Configure(EntityTypeBuilder<Lesson> builder)
    {
        builder
            .HasData(
            new Lesson
            {
                Id = 1,
                StageId = 1,
                Title = "Lesson 1 : Introduction to Python",
                Content = "In this lesson, we will cover the basics of Python programming, including syntax, variables, and data types. You will learn how to write your first Python program and understand the structure of Python code." +
                "  What can Python do?  Python can be used on a server to create web applications.\r\nPython can be used alongside software to create workflows.\r\nPython can connect to database systems. It can also read and modify files.\r\nPython can be used to handle big data and perform complex mathematics.\r\nPython can be used for rapid prototyping, or for production-ready software development.\r\n",
            },
            new Lesson
            {
                Id = 2,
                StageId = 1,
                Title = "Lesson 2 : Getting Started with Python",
                Content = "This lesson will guide you through setting up your Python environment, installing necessary tools, and writing your first Python script. You will also learn about basic input and output operations.\n Many PCs and Macs will have python already installed.\r\n\r\nTo check if you have python installed on a Windows PC, search in the start bar for Python",
            },
            new Lesson
            {
                Id = 3,
                StageId = 1,
                Title = "Lesson 3 : Basics of Python",
                Content = "In this lesson, we will explore basic Python concepts such as control flow, loops, and functions. You will learn how to create reusable code blocks and understand the importance of functions in programming.\n Python Quickstart\r\nPython is an interpreted programming language, this means that as a developer you write Python (.py) files in a text editor and then put those files into the python interpreter to be executed.",
            },
            new Lesson
            {
                Id = 4,
                StageId = 1,
                Title = "Lesson 4 : Python Syntax",
                Content = "This lesson will focus on Python syntax, including indentation, comments, and the use of operators. You will learn how to write clean and readable code, which is essential for effective programming.\n Python Indentation\r\nIndentation refers to the spaces at the beginning of a code line.\r\n\r\nWhere in other programming languages the indentation in code is for readability only, the indentation in Python is very important.\r\n\r\nPython uses indentation to indicate a block of code.",
            },
            new Lesson
            {
                Id = 5,
                StageId = 1,
                Title = "Lesson 5 : Python Variables and Data Types",
                Content = "In this lesson, we will dive deeper into Python variables and data types. You will learn about different data types such as strings, integers, and lists, and how to manipulate them effectively. \n Variables\r\nVariables are containers for storing data values.\r\n\r\nCreating Variables\r\nPython has no command for declaring a variable.\r\n\r\nA variable is created the moment you first assign a value to it.",
            },
            new Lesson
            {
                Id = 6,
                StageId = 2,
                Title = "Lesson 6 : Python Data Strcture Intro",
                Content = "This lesson will introduce you to Python data structures, including lists, tuples, and dictionaries. You will learn how to choose the right data structure for your needs and how to manipulate them effectively.\n Python Data Structures\r\nPython has a set of built-in data structures, such as lists, tuples, sets, and dictionaries.\r\n\r\nThese data structures allow you to store and manipulate collections of data efficiently.",
            },
            new Lesson
            {
                Id = 7,
                StageId = 2,
                Title = "Lesson 7 : First Data Strcture ",
                Content = "In this lesson, we will explore the first data structure in Python: lists. You will learn how to create, access, and manipulate lists, which are essential for storing collections of data.\n Python Lists\r\nLists are used to store multiple items in a single variable.\r\n\r\nA list is created by placing all the items (elements) inside square brackets [], separated by commas.\r\n\r\nList items are ordered, changeable, and allow duplicate values.",
            },
            new Lesson
            {
                Id = 8,
                StageId = 2,
                Title = "Lesson 8 : Python Stacks ",
                Content = "This lesson will introduce you to stacks in Python, which are a type of data structure that follows the Last In First Out (LIFO) principle. You will learn how to implement stacks using lists and understand their applications.\n Python Stacks\r\nA stack is a collection of elements that supports two main operations: push and pop.\r\n\r\nPush adds an element to the top of the stack, while pop removes the top element from the stack.\r\n\r\nStacks are often used in algorithms and data processing tasks.",
            },
            new Lesson
            {
                Id = 9,
                StageId = 2,
                Title = "Lesson 9 : Python Queues",
                Content = "In this lesson, we will explore queues in Python, which are a type of data structure that follows the First In First Out (FIFO) principle. You will learn how to implement queues using lists and understand their applications.\n Python Queues\r\nA queue is a collection of elements that supports two main operations: enqueue and dequeue.\r\n\r\nEnqueue adds an element to the end of the queue, while dequeue removes the front element from the queue.\r\n\r\nQueues are often used in scheduling and task management scenarios.",
            },
            new Lesson
            {
                Id = 10,
                StageId = 2,
                Title = "Lesson 10 : Python Linked Lists",
                Content = "This lesson will introduce you to linked lists in Python, which are a type of data structure that consists of nodes. You will learn how to create and manipulate linked lists, and understand their advantages over other data structures.\n Python Linked Lists\r\nA linked list is a linear data structure where each element is a separate object, called a node.\r\n\r\nEach node contains a value and a reference (or link) to the next node in the sequence.\r\n\r\nLinked lists are often used in scenarios where dynamic memory allocation is required.",
            },
            new Lesson
            {
                Id = 11,
                StageId = 3,
                Title = "Lesson 11 : Python Mean Median Mode",
                Content = "In this lesson, we will explore statistical concepts in Python, including mean, median, and mode. You will learn how to calculate these statistics using Python and understand their significance in data analysis.\n Python Mean Median Mode\r\nMean is the average of a set of numbers, calculated by dividing the sum of all numbers by the count of numbers.\r\n\r\nMedian is the middle value in a sorted list of numbers.\r\n\r\nMode is the value that appears most frequently in a dataset.",
            },
            new Lesson
            {
                Id = 12,
                StageId = 3,
                Title = "Lesson 12 : Python Advanced Topics",
                Content = "This lesson will cover advanced Python topics such as list comprehensions, lambda functions, and error handling. You will learn how to write more efficient and robust Python code.\n Python List Comprehension\r\nList comprehension offers a shorter syntax when you want to create a new list based on the values of an existing list.\r\n\r\nWith list comprehension you can do all this with only one line of code:\r\n\r\nnewlist = [expression for item in iterable if condition == True]\r\n\r\nWhere the expression is the current item in the iteration, but it is also the outcome, which you can manipulate before it ends up like a list item in the new list.",
            },
            new Lesson
            {
                Id = 13,
                StageId = 3,
                Title = "Lesson 13 : Python Machine Learning Intro",
                Content = "In this lesson, we will introduce you to the basics of machine learning in Python. You will learn about popular libraries such as Scikit-learn and TensorFlow, and how to build simple machine learning models.\n Python Machine Learning Libraries\r\nPython has a rich ecosystem of libraries for machine learning, including Scikit-learn, TensorFlow, and Keras.\r\n\r\nThese libraries provide powerful tools for building and training machine learning models.",
            },
            new Lesson
            {
                Id = 14,
                StageId = 3,
                Title = "Lesson 14 : Python Data Science Intro",
                Content = "This lesson will introduce you to the basics of data science in Python. You will learn about libraries such as NumPy and Pandas, which are essential for data manipulation and analysis.\n Python Data Science Libraries\r\nPython has a rich ecosystem of libraries for data science, including NumPy, Pandas, Matplotlib, and Scikit-learn.\r\n\r\nThese libraries provide powerful tools for data manipulation, analysis, and visualization.",
            },
            new Lesson
            {
                Id = 15,
                StageId = 3,
                Title = "Lesson 15 : Python Web Development Intro",
                Content = "In this lesson, we will introduce you to web development in Python. You will learn about popular web frameworks such as Flask and Django, and how to build simple web applications.\n Python Web Development Frameworks\r\nPython has several popular web frameworks, including Flask and Django.\r\n\r\nThese frameworks provide tools and libraries for building web applications quickly and efficiently.",
            }
            );
    }
}