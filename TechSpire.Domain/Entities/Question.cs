namespace TechSpire.Domain.Entities;
public class Question
{
    public int Id { get; set; }
    public string Text { get; set; } = string.Empty;
    public int QuizId { get; set; }
    public Quiz Quiz { get; set; } = default!;
    public List<Answer> Answers { get; set; } = [];
    public string? MaterialType { get; set; } // e.g., "Lesson", "Article", "Book", "Post"
    public int? MaterialId { get; set; } // The ID of the referenced material
    public int? TopicId { get; set; } // Foreign key to Topic
    public Topic? Topic { get; set; } // Navigation property
    public int StageId { get; set; } // Foreign key to Stage
    // property for correct answer 
}
