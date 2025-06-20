using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSpire.Application.Abstraction;
using TechSpire.Application.Contracts;
using TechSpire.Application.Contracts.Stage;
using TechSpire.Application.Services;
using TechSpire.infra.Dbcontext;

namespace TechSpire.infra.Services;
public class TopicService(AppDbcontext appDbcontext) : ITopicService
{
    private readonly AppDbcontext appDbcontext = appDbcontext;

    public async Task<Result<DbT>> GetTopic(int Id)
    {
        var topic = await appDbcontext.Topics.FirstOrDefaultAsync(x => x.Id == Id);
        if (topic == null)
        {
            return Result.Failure<DbT>(new Error("Not Found", "This topic not found",404));
        }

        var book = await appDbcontext.Books.FirstOrDefaultAsync(x => x.Id == topic.BookId);
        var article = await appDbcontext.Articles.FirstOrDefaultAsync(x => x.Id == topic.ArticleId);
        var post = await appDbcontext.Posts.FirstOrDefaultAsync(x => x.Id == topic.PostId);

        var book1 = book.Adapt<BookResponse>();
        var article1 = article.Adapt<ArticleResponse>();
        var post1 = post.Adapt<PostResponse>();

        var response = new DbT(book1, article1 , post1);

        return Result.Success(response);

    }

    public async Task<Result<DbT>> GetTopicByName(string Name)
    {
        var topic = await appDbcontext.Topics.FirstOrDefaultAsync(x => x.Name.StartsWith(Name));
        if (topic == null)
        {
            return Result.Failure<DbT>(new Error("Not Found", "This topic not found", 404));
        }

        var book = await appDbcontext.Books.FirstOrDefaultAsync(x => x.Id == topic.BookId);
        var article = await appDbcontext.Articles.FirstOrDefaultAsync(x => x.Id == topic.ArticleId);
        var post = await appDbcontext.Posts.FirstOrDefaultAsync(x => x.Id == topic.PostId);

        var book1 = book.Adapt<BookResponse>();
        var article1 = article.Adapt<ArticleResponse>();
        var post1 = post.Adapt<PostResponse>();

        var response = new DbT(book1, article1, post1);

        return Result.Success(response);
    }
}
