namespace TechSpire.Application.Dto;

public class WrongAnswerTopicMaterialDto
{
    public int QuestionId { get; set; }
    public string QuestionText { get; set; } = string.Empty;
    public int? TopicId { get; set; }
    public string? TopicName { get; set; }
    public string? MaterialType { get; set; }
    public int? MaterialId { get; set; }
    public string? MaterialTitle { get; set; }
} 