using System.Collections.Generic;

namespace TechSpire.Application.Contracts.Quiz
{
    public class BookSuggestion
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string BookUrl { get; set; } = string.Empty;
    }

    public class WrongAnswerResponse
    {
        public int QuestionId { get; set; }
        public string QuestionText { get; set; } = string.Empty;
        public string SelectedAnswer { get; set; } = string.Empty;
        public string CorrectAnswer { get; set; } = string.Empty;
        public string? Topic { get; set; }
        public List<BookSuggestion> BookSuggestions { get; set; } = new();
    }
} 