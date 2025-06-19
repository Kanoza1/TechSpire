using TechSpire.Domain.Entities;
using TechSpire.infra.Dbcontext;

namespace TechSpire.infra.Services;

public class TopicExtractionService
{
    private readonly AppDbcontext _dbContext;

    public TopicExtractionService(AppDbcontext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task ExtractAndAssignTopicsFromQuestionNamesAsync()
    {
        // Get all questions
        var questions = await _dbContext.Questions.ToListAsync();
        
        // Get or create topics based on what we find in question names
        var topics = new Dictionary<string, Topic>();
        
        foreach (var question in questions)
        {
            var topicName = ExtractTopicFromQuestionName(question.Text);
            
            if (!string.IsNullOrEmpty(topicName))
            {
                // Get or create the topic
                if (!topics.ContainsKey(topicName))
                {
                    var existingTopic = await _dbContext.Topics.FirstOrDefaultAsync(t => t.Name == topicName);
                    if (existingTopic == null)
                    {
                        existingTopic = new Topic { Name = topicName };
                        _dbContext.Topics.Add(existingTopic);
                        await _dbContext.SaveChangesAsync();
                    }
                    topics[topicName] = existingTopic;
                }
                
                // Assign topic to question
                question.TopicId = topics[topicName].Id;
            }
        }

        await _dbContext.SaveChangesAsync();
        Console.WriteLine($"Extracted and assigned topics to {questions.Count} questions.");
        Console.WriteLine($"Topics found: {string.Join(", ", topics.Keys)}");
    }

    private string ExtractTopicFromQuestionName(string questionText)
    {
        // Convert to lowercase for easier matching
        var text = questionText.ToLower();
        
        // Define topic keywords and their corresponding topic names
        var topicKeywords = new Dictionary<string, string>
        {
            { "variable", "Syntax" },
            { "syntax", "Syntax" },
            { "print", "Syntax" },
            { "string", "Syntax" },
            { "integer", "Syntax" },
            { "float", "Syntax" },
            { "boolean", "Syntax" },
            { "class", "OOP" },
            { "object", "OOP" },
            { "method", "OOP" },
            { "inheritance", "OOP" },
            { "encapsulation", "OOP" },
            { "polymorphism", "OOP" },
            { "list", "Data Structure" },
            { "array", "Data Structure" },
            { "dictionary", "Data Structure" },
            { "tuple", "Data Structure" },
            { "set", "Data Structure" },
            { "stack", "Data Structure" },
            { "queue", "Data Structure" },
            { "machine learning", "ML" },
            { "ml", "ML" },
            { "model", "ML" },
            { "algorithm", "ML" },
            { "neural", "ML" },
            { "analysis", "Data Analysis" },
            { "statistics", "Data Analysis" },
            { "chart", "Data Analysis" },
            { "graph", "Data Analysis" },
            { "pandas", "Data Analysis" },
            { "numpy", "Data Analysis" },
            { "data science", "Data Science" },
            { "pipeline", "Data Science" },
            { "preprocessing", "Data Science" },
            { "feature", "Data Science" }
        };

        // Find the first matching topic
        foreach (var keyword in topicKeywords)
        {
            if (text.Contains(keyword.Key))
            {
                return keyword.Value;
            }
        }

        // Default to Syntax for Python basics if no specific topic found
        return "Syntax";
    }
} 