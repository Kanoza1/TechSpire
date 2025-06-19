using System.ComponentModel.DataAnnotations.Schema;

namespace TechSpire.Domain.Entities;
public class Question
{
    public int Id { get; set; }
    public string Text { get; set; } = string.Empty;
    public int QuizId { get; set; }
    public Quiz Quiz { get; set; } = default!;
    public List<Answer> Answers { get; set; } = [];

    public int? TopicId { get; set; } // Foreign key to Topic
    public int StageId { get; set; } // Foreign key to Stage
    public Stage Stage { get; set; } = default!; // navigation property to stage
    // navigation property to topic

    [ForeignKey(nameof(TopicId))]
    public Topic Topic { get; set; } 
}
