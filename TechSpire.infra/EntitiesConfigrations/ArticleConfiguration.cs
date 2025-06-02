using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSpire.infra.EntitiesConfigrations;
public class ArticleConfiguration : IEntityTypeConfiguration<Article>
{
    public void Configure(EntityTypeBuilder<Article> builder)
    {
        builder
            .HasData(new Article
            {
                Id = 1,
                StageId = 1,
                Title = "Introduction to Python",
                Description = "A beginner's guide to Python programming language.",
                ArticleUrl = "https://www.w3schools.com/python/",

            },
            new Article
            {
                Id = 2,
                StageId = 1,
                Title = "Getting Started with Pyhton",
                Description = "Learn the basics of Pyhton, the language of the web.",
                ArticleUrl = "https://docs.python.org/3/tutorial/index.html",
            },
            new Article
            {
                Id = 3,
                StageId = 1,
                Title = "Basics For Python",
                Description = "Go From Basic to Intermediate Python Knowledge",
                ArticleUrl = "https://realpython.com/python-basics/",
            },
            new Article
            {
                Id = 4,
                StageId = 2,
                Title = "Python Data Structures",
                Description = "Learn about lists, tuples, sets, and dictionaries in Python.",
                ArticleUrl = "https://www.geeksforgeeks.org/python-data-structures-and-algorithms/",
            },
            new Article
            {
                Id = 5,
                StageId = 2,
                Title = "Python Functions and Modules",
                Description = "Understanding functions and modules in Python.",
                ArticleUrl = "https://www.geeksforgeeks.org/python-oops-concepts/",
            },
            new Article
            {
                Id = 6,
                StageId = 2,
                Title = "Python Object-Oriented Programming",
                Description = "An introduction to OOP concepts in Python.",
                ArticleUrl = "https://realpython.com/python3-object-oriented-programming/",
            },
            new Article
            {
                Id = 7,
                StageId = 3,
                Title = "Python File Handling",
                Description = "Learn how to read and write files in Python.",
                ArticleUrl = "https://docs.python.org/3/tutorial/inputoutput.html#reading-and-writing-files",
            },
            new Article
            {
                Id = 8,
                StageId = 3,
                Title = "Python such as Data Science, Artificial Intelligence and Robotics",
                Description = "Python language is a very versatile language and it is used in many technical fields.",
                ArticleUrl = "https://www.geeksforgeeks.org/advanced-python-tutorials/",
            },
            new Article
            {
                Id = 9,
                StageId = 3,
                Title = "Python in Machine Learning",
                Description = "In this tutorial we will go back to mathematics and study statistics.",
                ArticleUrl = "https://www.w3schools.com/python/python_ml_getting_started.asp",
            }
            );
    }
}

