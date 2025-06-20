namespace TechSpire.Domain.Entities;

public class Topic
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    //public ICollection<Book> Books { get; set; } = new List<Book>();
    //public ICollection<Question> Questions { get; set; } = new List<Question>();
    public int? QuestionId { get; set; }
    //public Question Question { get; set; } = default!;
    public int StageId { get; set; }
    public Stage Stage { get; set; } = default!;
    public int? BookId { get; set; }
    public Book Book { get; set; } = default!;
    public int? PostId { get; set; }
    public Post Post { get; set; } = default!;
    public int? ArticleId { get; set; }
    public Article Article { get; set; } = default!;

    public int? QuizId { get; set; }
    public Quiz Quiz { get; set; } = default!;
}