namespace TechSpire.Domain.Entities;

public class Topic
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public ICollection<Book> Books { get; set; } = new List<Book>();
    public ICollection<Article> Articles { get; set; } = new List<Article>();
    public ICollection<Post> Posts { get; set; } = new List<Post>();
    public ICollection<Lesson> Lessons { get; set; } = new List<Lesson>();
    public ICollection<Quiz> Quizzes { get; set; } = new List<Quiz>();
    public ICollection<Question> Questions { get; set; } = new List<Question>();
    public int StageId { get; set; }
    public Stage Stage { get; set; } = default!;
    // Optionally, you can add navigation properties if needed later
} 