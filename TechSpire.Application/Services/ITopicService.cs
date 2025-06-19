using System.Collections.Generic;
using System.Threading.Tasks;
using TechSpire.Application.Abstraction;
using TechSpire.Domain.Entities;

namespace TechSpire.Application.Services;
public interface ITopicService
{
    Task<Result<List<Topic>>> GetAllTopicsAsync();
    Task<Result<Topic>> GetTopicByIdAsync(int topicId);
    //Task<Result> SeedTopicsAsync();
    Task<Result> AssignTopicsToQuestionsAsync();
    Task<Result<Topic>> CreateTopicAsync(string name);
    Task<Result<Topic>> UpdateTopicAsync(int id, string name);
    Task<Result> DeleteTopicAsync(int id);
} 