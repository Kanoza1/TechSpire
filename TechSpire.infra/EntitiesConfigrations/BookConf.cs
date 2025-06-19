using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSpire.infra.EntitiesConfigrations;
public class BookCnfigration : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.HasData
        (
            new Book
            {
                Id = 1,
                StageId = 1,
                Title = "How-to-code-in-python",
                Description = "A beginner's guide to Python programming language.",
                ImageUrl = "https://drive.google.com/file/d/1tvk6zU8SpXOUu-y9oBOAgQJFXFLB8Nby/view?usp=drive_link",
                BookUrl = "https://drive.google.com/file/d/16KohWjujqh1nRMb1YmJyeoVbIlIDmqB2/view?usp=drive_link",
                TopicId = 1 
            },
            new Book
            {
                Id = 2,
                StageId = 1,
                Title = "Learning Python",
                Description = "Learn the basics of Python, the language of the web.",
                ImageUrl = "https://drive.google.com/file/d/1zrkNTZzqGSrYXP-_sifUYcvSHxXeJbAM/view?usp=drive_link",
                BookUrl = "https://drive.google.com/file/d/14yl0K2kNvLcMmyupgvdBEhMw9T5ETH7c/view?usp=drive_link",
                TopicId = 1 
            },
            new Book
            {
                Id = 3,
                StageId = 1,
                Title = "Hasou with python",
                Description = "A comprehensive guide to Python for beginners.",
                ImageUrl = "https://drive.google.com/file/d/1T7p9YWal6ymugkyCGzT-5_iRJEsC51Yj/view?usp=sharing",
                BookUrl = "https://drive.google.com/file/d/16coGOcEz60f91XuCN6vOzCV_9W3uGlmZ/view?usp=drive_link",
                TopicId = 1 
            },
            new Book
            {
                Id = 4,
                StageId = 1,
                Title = "Python in arabic",
                Description = "Dive deeper into Python with basic concepts.",
                ImageUrl = "https://drive.google.com/file/d/19d4fGntUOyCN0sT07PSsxOHgIZ9FaKQ1/view?usp=drive_link",
                BookUrl = "https://drive.google.com/file/d/14yl0K2kNvLcMmyupgvdBEhMw9T5ETH7c/view?usp=drive_link",
                TopicId = 2 
            },
            new Book
            {
                Id = 5,
                StageId = 1,
                Title = "Think Python",
                Description = "A guide to using Python for thinking with python.",
                ImageUrl = "https://drive.google.com/file/d/1QVFWHnhT2jD6n2FO4FEIUCjKSKBMt6XP/view?usp=drive_link",
                BookUrl = "https://drive.google.com/file/d/12Y3rlr03JKKbkeLG5vjocabDEjx2X4Os/view?usp=drive_link",
                TopicId = 2
            },
            new Book
            {
                Id = 6,
                StageId = 2,
                Title = "Python for data structure",
                Description = "A guide to using Python for data structure.",
                ImageUrl = "https://drive.google.com/file/d/1axJQq-cLL2UWxbcDuPZMKQxRWWWj40my/view?usp=drive_link",
                BookUrl = "https://drive.google.com/file/d/1WQf24NQIWmVTqitoYMdmknol_rn0LNos/view?usp=drive_link",
                TopicId = 3
            },
            new Book
            {
                Id = 7,
                StageId = 2,
                Title = "Data structure in python",
                Description = "A comprehensive guide to data structure in Python.",
                ImageUrl = "https://drive.google.com/file/d/1yDjHGglBm68bfzyMJyT91km_pv4rROd7/view?usp=drive_link",
                BookUrl = "https://drive.google.com/file/d/1U8oLuQ5RY5qllPFmesuvx9FJkl0AP70u/view?usp=drive_link",
                TopicId = 3
            },
            new Book
            {
                Id = 8,
                StageId = 2,
                Title = "Python for algorithms",
                Description = "A guide to using Python for algorithms.",
                ImageUrl = "https://drive.google.com/file/d/1MX8qDUNCa0H4fWexqUz7vBb91Grz2EYs/view?usp=drive_link",
                BookUrl = "https://drive.google.com/file/d/1cNMyAO7xoAyXEmUv0zY32KfFyx5VBo2y/view?usp=drive_link",
                TopicId = 4
            },
            new Book
            {
                Id = 9,
                StageId = 2,
                Title = "Algorithms in python",
                Description = "A comprehensive guide to algorithms in Python.",
                ImageUrl = "https://drive.google.com/file/d/1alwZjhLNEu6VOZaoAUDpbi6Vt1cl2ha2/view?usp=drive_link",
                BookUrl = "https://drive.google.com/file/d/1SuldYbX8KduRaGqoG0qVROfiuPmh-wXU/view?usp=drive_link",
                TopicId = 4
            },
            new Book
            {
                Id = 10,
                StageId = 3,
                Title = "Machine learning with python",
                Description = "A guide to using Python for machine learning.",
                ImageUrl = "https://drive.google.com/file/d/1UhspnmqNSEcg6LRixxvBcsNDeP4OhkiD/view?usp=drive_link",
                BookUrl = "https://drive.google.com/file/d/1cVUoQAnrDdxQGLQaN6bkIm7wyNdvRvD2/view?usp=drive_link",
                TopicId = 5
            },
            new Book
            {
                Id = 11,
                StageId = 3,
                Title = "Data analysis with python",
                Description = "A comprehensive guide to data analysis in Python.",
                ImageUrl = "https://drive.google.com/file/d/1IF5jryx8-ogxGJXUNKfrEnsBLGSJ1fiL/view?usp=drive_link",
                BookUrl = "https://drive.google.com/file/d/1vsOjmLBeT-T7UAWenlHpgRFql_NwHZGA/view?usp=drive_link",
                TopicId = 6
            },
            new Book
            {
                Id = 12,
                StageId = 3,
                Title = "Data science with python",
                Description = "A guide to using Python for data science.",
                ImageUrl = "https://drive.google.com/file/d/1RPHVouW2ypLQtgUvqu6gupf_tvPk-M-C/view?usp=drive_link",
                BookUrl = "https://drive.google.com/file/d/1hj_1Us9UZMw4lbsVI9ux3Xv0AEzyLiBC/view?usp=drive_link",
                TopicId = 7
            }
        );

        //Add this inside the Configure method if you uncomment it:

        builder.HasOne(b => b.Topic)
                .WithMany(t => t.Books)
                .HasForeignKey(b => b.TopicId)
                .OnDelete(DeleteBehavior.SetNull);
    }
}
