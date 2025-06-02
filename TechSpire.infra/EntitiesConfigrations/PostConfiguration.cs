using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSpire.infra.EntitiesConfigrations;
public class PostConfiguration : IEntityTypeConfiguration<Post>
{
    public void Configure(EntityTypeBuilder<Post> builder)
    {
        builder
            .HasData(new Post
            {
                Id = 1,
                StageId = 1,
                Title = "Introduction to Python",
                Description = "A beginner's guide to Python programming language.",
                PostUrl = "https://harmash.com/tutorials/python/overview",

            },
            new Post
            {
                Id = 2,
                StageId = 1,
                Title = "Getting Started with Pyhton",
                Description = "Learn the basics of Pyhton, the language of the web.",
                PostUrl = "https://academy.hsoub.com/files/15-%D8%A7%D9%84%D8%A8%D8%B1%D9%85%D8%AC%D8%A9-%D8%A8%D9%84%D8%BA%D8%A9-%D8%A8%D8%A7%D9%8A%D8%AB%D9%88%D9%86/",
            },
            new Post
            {
                Id = 3,
                StageId = 1,
                Title = "Basics For Python",
                Description = "Go From Basic to Intermediate Python Knowledge",
                PostUrl = "https://colab.research.google.com/drive/1LSSOITVzLrLvVN91kppSh1OHm3CU1Esy?authuser=0#scrollTo=hU-QtmhQo2AN",
            },
            new Post
            {
                Id = 4,
                StageId = 2,
                Title = "Python Data Structures",
                Description = "Learn about lists, tuples, sets, and dictionaries in Python.",
                PostUrl = "https://elzero.org/everything-about-data-structure/",
            },
            new Post
            {
                Id = 5,
                StageId = 2,
                Title = "Python OOP ",
                Description = "Understanding functions and modules in Python.",
                PostUrl = "https://www.kholoodtechnotes.net/2024/07/Python-OOP-ClassObject.html?m=1",
            },
            new Post
            {
                Id = 6,
                StageId = 2,
                Title = "Python Object-Oriented Programming",
                Description = "An introduction to OOP concepts in Python.",
                PostUrl = "https://academy.hsoub.com/programming/python/%D9%85%D8%AE%D8%AA%D8%B5%D8%B1-%D8%A7%D9%84%D8%A8%D8%B1%D9%85%D8%AC%D8%A9-%D9%83%D8%A7%D8%A6%D9%86%D9%8A%D8%A9-%D8%A7%D9%84%D8%AA%D9%88%D8%AC%D9%87-oop-%D9%88%D8%AA%D8%B7%D8%A8%D9%8A%D9%82%D9%87%D8%A7-%D9%81%D9%8A-%D8%A8%D8%A7%D9%8A%D8%AB%D9%88%D9%86-r1926/",
            },
            new Post
            {
                Id = 7,
                StageId = 3,
                Title = "Python in Machine Learning",
                Description = " An introduction about Machine Learning ",
                PostUrl = "https://uomus.edu.iq/NewDep.aspx?depid=7&newid=14046",
            },
            new Post
            {
                Id = 8,
                StageId = 3,
                Title = "Machine Learning",
                Description = "A guide to using Machine Learning in Python.",
                PostUrl = "https://academy.hsoub.com/programming/artificial-intelligence/%D8%AA%D8%B9%D9%84%D9%85-%D8%A7%D9%84%D8%A2%D9%84%D8%A9/",
            },
            new Post
            {
                Id = 9,
                StageId = 3,
                Title = "Python With Data Science ",
                Description = "Learn how to use python with data science.",
                PostUrl = "https://www.tomasbeuzen.com/python-programming-for-data-science/README.html",
            }
            );
    }
}
