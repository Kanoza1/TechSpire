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
                Title = "C# Programming",
                Description = "Learn the fundamentals of C# programming.",
                ImageUrl = "https://example.com/csharp.jpg",
                BookUrl = "https://example.com/csharp-book.pdf",
                StageId = 1
            },
            new Book
            {
                Id = 2,
                Title = "ASP.NET Core Development",
                Description = "Build modern web applications using ASP.NET Core.",
                ImageUrl = "https://example.com/aspnetcore.jpg",
                BookUrl = "https://example.com/aspnetcore-book.pdf",
                StageId = 1
            }
        );
    }
}
