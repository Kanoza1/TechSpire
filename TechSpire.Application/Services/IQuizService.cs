using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSpire.Application.Abstraction;
using TechSpire.Application.Contracts.Quiz;
using TechSpire.Application.Contracts.Stage;
using TechSpire.Application.Dto;
using QuizWrongAnswerResponse = TechSpire.Application.Contracts.Quiz.WrongAnswerResponse;

namespace TechSpire.Application.Services;
public interface IQuizService
{
    Task<Result<List<QuizWrongAnswerResponse>>> SubmitUserAnswersAsync(string userId, List<UserAnswerRequest> answers);
    Task<Result<List<QuizResponse>>> GetAllQuizsForStage(int stageId);
    Task<Result<QuizResponse>> GetQuizWithId(int Id);
    Task<Result<UserQuizSummaryResponse>> GetUserQuizSummaryAsync(string userId);
    Task<Result<List<WrongAnswerTopicMaterialDto>>> GetWrongAnswerTopicsAndMaterialsAsync(string userId, int quizId);
}
