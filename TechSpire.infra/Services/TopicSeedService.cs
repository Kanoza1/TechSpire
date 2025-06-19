using TechSpire.Application.Abstraction;
using TechSpire.Application.Services;
using TechSpire.Domain.Entities;
using TechSpire.infra.Dbcontext;
using Microsoft.EntityFrameworkCore;

namespace TechSpire.infra.Services;

public class TopicSeedService : ITopicService
{
    private readonly AppDbcontext _dbContext;

    public TopicSeedService(AppDbcontext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Result<List<Topic>>> GetAllTopicsAsync()
    {
        var topics = await _dbContext.Topics.ToListAsync();
        return Result.Success(topics);
    }

    public async Task<Result<Topic>> GetTopicByIdAsync(int topicId)
    {
        var topic = await _dbContext.Topics.FindAsync(topicId);
        if (topic == null)
            return Result.Failure<Topic>(new Error("Topic.NotFound", "No topic found with the given ID.", 404));
        return Result.Success(topic);
    }

    //public async Task<Result> SeedTopicsAsync()
    //{
    //    if (_dbContext.Topics.Any())
    //        return Result.Failure(new Error("Topic.Exists", "Topics already exist in database.", 409));

    //var topics = new List<Topic>
    //{
    //    new Topic { Name = "Syntax", StageId = 1 },
    //    new Topic { Name = "OOP", StageId = 1 },
    //    new Topic { Name = "Data Structure", StageId = 2 },
    //    new Topic { Name = "Algorithms", StageId = 2 },
    //    new Topic { Name = "ML", StageId = 3 },
    //    new Topic { Name = "Data Analysis", StageId = 3 },
    //    new Topic { Name = "Data Science", StageId = 3 }
    //};

    //    _dbContext.Topics.AddRange(topics);
    //    await _dbContext.SaveChangesAsync();
    //    return Result.Success();
    //}

    public async Task<Result> AssignTopicsToQuestionsAsync()
    {
        var questions = await _dbContext.Questions.ToListAsync();
        var syntaxTopic = await _dbContext.Topics.FirstOrDefaultAsync(t => t.Name == "Syntax");
        var oopTopic = await _dbContext.Topics.FirstOrDefaultAsync(t => t.Name == "OOP");
        var dataStructureTopic = await _dbContext.Topics.FirstOrDefaultAsync(t => t.Name == "Data Structure");
        var mlTopic = await _dbContext.Topics.FirstOrDefaultAsync(t => t.Name == "ML");
        var dataAnalysisTopic = await _dbContext.Topics.FirstOrDefaultAsync(t => t.Name == "Data Analysis");
        var dataScienceTopic = await _dbContext.Topics.FirstOrDefaultAsync(t => t.Name == "Data Science");

        foreach (var question in questions)
        {
            var questionText = question.Text.ToLower();
            if (questionText.Contains("variable") || questionText.Contains("syntax") || questionText.Contains("print"))
                question.TopicId = syntaxTopic?.Id;
            else if (questionText.Contains("class") || questionText.Contains("object") || questionText.Contains("method"))
                question.TopicId = oopTopic?.Id;
            else if (questionText.Contains("list") || questionText.Contains("array") || questionText.Contains("dictionary"))
                question.TopicId = dataStructureTopic?.Id;
            else if (questionText.Contains("machine") || questionText.Contains("learning") || questionText.Contains("model"))
                question.TopicId = mlTopic?.Id;
            else if (questionText.Contains("analysis") || questionText.Contains("statistics") || questionText.Contains("chart"))
                question.TopicId = dataAnalysisTopic?.Id;
            else if (questionText.Contains("data") && (questionText.Contains("science") || questionText.Contains("pipeline")))
                question.TopicId = dataScienceTopic?.Id;
            else
                question.TopicId = syntaxTopic?.Id;
        }
        await _dbContext.SaveChangesAsync();
        return Result.Success();
    }

    public async Task<Result<Topic>> CreateTopicAsync(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
            return Result.Failure<Topic>(new Error("Topic.InvalidName", "Topic name cannot be empty.", 400));
        if (await _dbContext.Topics.AnyAsync(t => t.Name == name))
            return Result.Failure<Topic>(new Error("Topic.Exists", "A topic with this name already exists.", 409));
        var topic = new Topic { Name = name };
        _dbContext.Topics.Add(topic);
        await _dbContext.SaveChangesAsync();
        return Result.Success(topic);
    }

    public async Task<Result<Topic>> UpdateTopicAsync(int id, string name)
    {
        var topic = await _dbContext.Topics.FindAsync(id);
        if (topic == null)
            return Result.Failure<Topic>(new Error("Topic.NotFound", "No topic found with the given ID.", 404));
        if (string.IsNullOrWhiteSpace(name))
            return Result.Failure<Topic>(new Error("Topic.InvalidName", "Topic name cannot be empty.", 400));
        topic.Name = name;
        await _dbContext.SaveChangesAsync();
        return Result.Success(topic);
    }

    public async Task<Result> DeleteTopicAsync(int id)
    {
        var topic = await _dbContext.Topics.FindAsync(id);
        if (topic == null)
            return Result.Failure(new Error("Topic.NotFound", "No topic found with the given ID.", 404));
        _dbContext.Topics.Remove(topic);
        await _dbContext.SaveChangesAsync();
        return Result.Success();
    }
} 