using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSpire.Application.Abstraction;
using TechSpire.Application.Contracts.Quiz;
using TechSpire.Application.Contracts.Stage;
using TechSpire.Application.Services;
using TechSpire.Domain.Entities;
using TechSpire.infra.Dbcontext;
using TechSpire.Application.Dto;

namespace TechSpire.infra.Services;
public class QuizService : IQuizService
{
    private readonly AppDbcontext dbcontext;
    private readonly ITopicService topicService;

    public QuizService(AppDbcontext dbcontext, ITopicService topicService)
    {
        this.dbcontext = dbcontext;
        this.topicService = topicService;
    }

    public async Task<Result<List<QuizResponse>>> GetAllQuizsForStage(int stageId)
    {
        var Quizzes = await dbcontext.Quizzes
            .Where(c=>c.StangeId == stageId)
            .ProjectToType<QuizResponse>()
            .AsNoTracking()
            .ToListAsync();

        if (Quizzes == null)
            return Result.Failure<List<QuizResponse>>(new Error("Quiz.Notfound", "No quiz found for the given stage.",StatusCodes.Status404NotFound));

        return Result.Success(Quizzes);
    }

    public async Task<Result<QuizResponse>> GetQuizWithId(int Id)
    {
        var Quizzes = await dbcontext.Quizzes
            .Where(c => c.Id == Id)
            .ProjectToType<QuizResponse>()
            .AsNoTracking()
            .FirstOrDefaultAsync();

        if (Quizzes == null)
            return Result.Failure<QuizResponse>(new Error("Quiz.Notfound", "No quiz found for the given Quiz ID.", StatusCodes.Status404NotFound));

        return Result.Success(Quizzes);
    }

    #region submit
    //public async Task<Result<Allinone>> SubmitUserAnswersAsync(string userId, List<UserAnswerRequest> answers)
    //{
    #region HelloWorld
    //var userAnswerss = await dbcontext.UserAnswers
    //        .Where(e => e.UserId == userId)
    //        .ToListAsync();

    //var exists = userAnswerss
    //    .Any(e => answers.Any(a => a.QuestionId == e.QuestionId && a.AnswerId == e.AnswerId));

    //var repeted = await dbcontext.UserAnswers
    //    .AnyAsync(ua => ua.UserId == userId && answers.Any(a => a.QuestionId == ua.QuestionId && a.AnswerId == ua.AnswerId));

    // 1. Prepare (QuestionId, AnswerId) pairs from the incoming answers
    //var submittedKeys = answers
    //    .Select(a => new ValueTuple<int, int>(a.QuestionId, a.AnswerId))
    //    .ToList(); // Must be materialized

    //// 2. Query EF with tuple-based Contains
    //var duplicateAnswers = await dbcontext.UserAnswers
    //    .Where(x => submittedKeys
    //        .Contains(new ValueTuple<int, int>(x.QuestionId, x.AnswerId)))
    //    .ToListAsync();


    //if (repeted)
    //    return Result.Failure<List<WrongAnswerResponse>>(new Error("Quiz.Repeted", "You have already submitted this answer.", StatusCodes.Status400BadRequest));
    #endregion

    //var questionIds = answers
    //    .Select(a => a.QuestionId).ToList();

    //var questions = await dbcontext.Questions
    //    .Where(q => questionIds.Contains(q.Id))
    //    .Include(q => q.Answers)
    //    .ToListAsync();

    //var userAnswers = new List<UserAnswer>();


    //foreach (var answerDto in answers)
    //{
    //    var question = questions.FirstOrDefault(q => q.Id == answerDto.QuestionId);
    //    var selectedAnswer = question?.Answers.FirstOrDefault(a => a.Id == answerDto.AnswerId);

    //    if (question != null && selectedAnswer != null)
    //    {
    //        userAnswers.Add(new UserAnswer
    //        {
    //            UserId = userId,
    //            QuestionId = answerDto.QuestionId,
    //            AnswerId = answerDto.AnswerId
    //        });
    //    }

    //}

    //// Remove existing answers for this user
    //var existingAnswers = await dbcontext.UserAnswers
    //    .Where(ua => ua.UserId == userId && questionIds.Contains(ua.QuestionId) && !ua.Answer.IsCorrect)
    //    .ToListAsync();

    //dbcontext.UserAnswers.RemoveRange(existingAnswers);
    //await dbcontext.SaveChangesAsync(); // Save deletions first


    //await dbcontext.UserAnswers.AddRangeAsync(userAnswers);
    //await dbcontext.SaveChangesAsync();


    //var wrongAnswers = userAnswers
    //    .Where(ua =>
    //    {
    //        var question = questions.First(q => q.Id == ua.QuestionId);
    //        var selected = question.Answers.First(a => a.Id == ua.AnswerId);
    //        return !selected.IsCorrect;
    //    })
    //    .Select(ua =>
    //    {
    //        var question = questions.First(q => q.Id == ua.QuestionId);
    //        var selected = question.Answers.First(a => a.Id == ua.AnswerId);
    //        var correct = question.Answers.FirstOrDefault(a => a.IsCorrect);

    //        return new WrongAnswerResponse
    //        (
    //            question.Id,
    //            question.Text,
    //            selected.Text,
    //            correct?.Text ?? "N/A"
    //        );
    //    })
    //    .ToList();

    //int totalAnswers = userAnswers.Count;

    //int correctAnswersCount = userAnswers.Count(ua =>
    //{
    //    var question = questions.First(q => q.Id == ua.QuestionId);
    //    var selected = question.Answers.First(a => a.Id == ua.AnswerId);
    //    return selected.IsCorrect;
    //});

    //int wrongAnswersCount = totalAnswers - correctAnswersCount;

    //double correctPercentage = totalAnswers == 0 ? 0 : (correctAnswersCount * 100.0) / totalAnswers;
    //double wrongPercentage = totalAnswers == 0 ? 0 : (wrongAnswersCount * 100.0) / totalAnswers;

    //var ayhaga = new allinone(wrongAnswers, correctPercentage, wrongPercentage);

    //return Result.Success(ayhaga);}

    #endregion
    public async Task<Result<List<TechSpire.Application.Contracts.Quiz.WrongAnswerResponse>>> SubmitUserAnswersAsync(string userId, List<UserAnswerRequest> answers)
    {
        if (answers == null || answers.Count == 0)
            return Result.Failure<List<TechSpire.Application.Contracts.Quiz.WrongAnswerResponse>>(new Error("Quiz.Empty", "No answers submitted.",400));

        int QuestionId = answers.First().QuestionId;

        var quizId = await dbcontext.Questions.Where(c=>c.Id == QuestionId).Select(c => c.QuizId).FirstOrDefaultAsync();

        // Load quiz questions and answers
        var questions = await dbcontext.Questions
            .Where(q => q.QuizId == quizId)
            .Include(q => q.Answers)
            .ToListAsync();

        var validQuestionIds = questions.Select(q => q.Id).ToHashSet();

        // Group answers by question for easier handling of multi-select
        var groupedAnswers = answers
            .Where(a => validQuestionIds.Contains(a.QuestionId))
            .GroupBy(a => a.QuestionId)
            .ToDictionary(g => g.Key, g => g.Select(a => a.AnswerId).ToList());

        var userAnswersToSave = new List<UserAnswer>();
        var questionFeedbackList = new List<TechSpire.Application.Contracts.Quiz.WrongAnswerResponse>();
        var totalQuestions = questions.Count;
        var correctQuestions = 0;

        foreach (var question in questions)
        {
            if (!groupedAnswers.TryGetValue(question.Id, out var submittedAnswerIds))
                continue;

            var correctAnswerIds = question.Answers
                .Where(a => a.IsCorrect)
                .Select(a => a.Id)
                .ToHashSet();

            var selectedAnswers = question.Answers
                .Where(a => submittedAnswerIds.Contains(a.Id))
                .ToList();

            // Determine if the answer is wrong (none of the selected answers are correct OR no answers selected)
            bool isWrong = selectedAnswers.Count == 0 || !selectedAnswers.Any(a => a.IsCorrect);
            
            // Count correct questions for percentage calculation
            if (!isWrong && selectedAnswers.Any())
                correctQuestions++;
            
            // Save user answers (for all questions, not just wrong ones)
            foreach (var ans in selectedAnswers)
            {
                userAnswersToSave.Add(new UserAnswer
                {
                    UserId = userId,
                    QuestionId = question.Id,
                    AnswerId = ans.Id,
                    TimeTakenInSeconds = answers.FirstOrDefault(a => a.QuestionId == question.Id)?.TimeTakenInSeconds ?? 0
                });
            }
            
            // Only add to feedback list if the answer is wrong
            if (!isWrong) continue;

            // Fetch topic info
            string? topicName = null;
            List<BookSuggestion> bookSuggestions = new();
            if (question.TopicId.HasValue)
            {
                var topicResult = await topicService.GetTopicByIdAsync(question.TopicId.Value);
                topicName = topicResult.IsSuccess ? topicResult.Value.Name : null;

                // Fetch all books for this topic
                var books = await dbcontext.Books
                    //.Where(b => b.TopicId == question.TopicId.Value)
                    .ToListAsync();
                bookSuggestions = books.Select(b => new BookSuggestion
                {
                    Title = b.Title,
                    Description = b.Description,
                    BookUrl = b.BookUrl
                }).ToList();
            }

            // Fetch material title and URL
            //string? materialTitle = await GetMaterialTitleAsync(question.MaterialType, question.MaterialId);
            //string? materialUrl = await GetMaterialUrlAsync(question.MaterialType, question.MaterialId);

            var feedback = new TechSpire.Application.Contracts.Quiz.WrongAnswerResponse
            {
                QuestionId = question.Id,
                QuestionText = question.Text,
                SelectedAnswer = string.Join(", ", selectedAnswers.Select(a => a.Text)),
                CorrectAnswer = string.Join(", ", question.Answers.Where(a => a.IsCorrect).Select(a => a.Text)),
                Topic = topicName,
                BookSuggestions = bookSuggestions
            };
            questionFeedbackList.Add(feedback);
        }

        if (userAnswersToSave.Count == 0)
            return Result.Failure<List<TechSpire.Application.Contracts.Quiz.WrongAnswerResponse>>(new Error("Quiz.InvalidAnswers", "No valid answers submitted.",400));

        // Remove existing answers for this user and quiz
        var submittedQuestionIds = groupedAnswers.Keys.ToList();

        var existingAnswers = await dbcontext.UserAnswers
            .Where(ua => ua.UserId == userId && submittedQuestionIds.Contains(ua.QuestionId))
            .ToListAsync();

        dbcontext.UserAnswers.RemoveRange(existingAnswers);
        await dbcontext.SaveChangesAsync();

        // Save new answers
        await dbcontext.UserAnswers.AddRangeAsync(userAnswersToSave);
        await dbcontext.SaveChangesAsync();

        // Calculate correct and wrong percentages
        double correctPercentage = totalQuestions > 0 ? (correctQuestions * 100.0) / totalQuestions : 0;
        double wrongPercentage = 100 - correctPercentage;

        var result = new UserQuizResult
        {
            UserId = userId,
            QuizId = quizId,
            CorrectPercentage = correctPercentage,
            WrongPercentage = wrongPercentage,
            SubmittedAt = DateTime.UtcNow
        };

        dbcontext.UserQuizResults.Add(result);
        await dbcontext.SaveChangesAsync();

        return Result.Success(questionFeedbackList);
    }

    public async Task<Result<UserQuizSummaryResponse>> GetUserQuizSummaryAsync(string userId)
    {
        var quizResults = await dbcontext.UserQuizResults
            .Where(r => r.UserId == userId)
            .Include(r => r.Quiz)
            .OrderByDescending(r => r.SubmittedAt)
            .ToListAsync();

        if (quizResults.Count == 0)
            return Result.Failure<UserQuizSummaryResponse>(new Error("Quiz.NoneFound", "No quiz attempts found.",400));

        var attempts = quizResults.Select(r => new QuizAttemptSummary
        (
            r.QuizId,
            r.Quiz?.Title ?? "Untitled Quiz",
            r.CorrectPercentage,
            r.SubmittedAt
            //await dbcontext.UserAnswers
            //    .Where(ua => ua.UserId == userId && ua.Question.QuizId == r.QuizId)
            //    .ToDictionaryAsync(ua => ua.QuestionId, ua => ua.TimeTakenInSeconds)
        )).ToList();

        double averageScore = quizResults.Average(r => r.CorrectPercentage);
        int passedCount = quizResults.Count(r => r.CorrectPercentage >= 50);
        int failedCount = quizResults.Count - passedCount;

        var response = new UserQuizSummaryResponse
        (
            attempts,
            averageScore,
            quizResults.Count,
            passedCount,
            failedCount
        );

        return Result.Success(response);
    }

    private async Task<string?> GetMaterialTitleAsync(string? materialType, int? materialId)
    {
        if (string.IsNullOrEmpty(materialType) || materialId == null)
            return null;
        switch (materialType)
        {
            case "Lesson":
                return await dbcontext.Lessons.Where(l => l.Id == materialId).Select(l => l.Title).FirstOrDefaultAsync();
            case "Article":
                return await dbcontext.Articles.Where(a => a.Id == materialId).Select(a => a.Title).FirstOrDefaultAsync();
            case "Book":
                return await dbcontext.Books.Where(b => b.Id == materialId).Select(b => b.Title).FirstOrDefaultAsync();
            case "Post":
                return await dbcontext.Posts.Where(p => p.Id == materialId).Select(p => p.Title).FirstOrDefaultAsync();
            default:
                return null;
        }
    }

    private async Task<string?> GetMaterialUrlAsync(string? materialType, int? materialId)
    {
        if (string.IsNullOrEmpty(materialType) || materialId == null)
            return null;
        switch (materialType)
        {
            case "Lesson":
                return null; // Add logic if lessons have URLs
            case "Article":
                return await dbcontext.Articles.Where(a => a.Id == materialId).Select(a => a.ArticleUrl).FirstOrDefaultAsync();
            case "Book":
                return await dbcontext.Books.Where(b => b.Id == materialId).Select(b => b.BookUrl).FirstOrDefaultAsync();
            case "Post":
                return await dbcontext.Posts.Where(p => p.Id == materialId).Select(p => p.PostUrl).FirstOrDefaultAsync();
            default:
                return null;
        }
    }

    public async Task<Result<List<WrongAnswerTopicMaterialDto>>> GetWrongAnswerTopicsAndMaterialsAsync(string userId, int quizId)
    {
        // Get the latest quiz attempt for this user and quiz
        var userQuizResult = await dbcontext.UserQuizResults
            .Where(r => r.UserId == userId && r.QuizId == quizId)
            .OrderByDescending(r => r.SubmittedAt)
            .FirstOrDefaultAsync();
        if (userQuizResult == null)
            return Result.Failure<List<WrongAnswerTopicMaterialDto>>(new Error("Quiz.NotFound", "No quiz attempt found for this user.", 404));

        // Get all user answers for this attempt
        var userAnswers = await dbcontext.UserAnswers
            .Where(ua => ua.UserId == userId)
            .Join(dbcontext.Questions.Where(q => q.QuizId == quizId),
                  ua => ua.QuestionId,
                  q => q.Id,
                  (ua, q) => new { ua, q })
            .ToListAsync();

        var wrongAnswers = userAnswers
            .Where(x => x.q.Answers.Any(a => a.Id == x.ua.AnswerId && !a.IsCorrect))
            .Select(x => x.q)
            .Distinct()
            .ToList();

        var result = new List<WrongAnswerTopicMaterialDto>();
        foreach (var question in wrongAnswers)
        {
            string? topicName = null;
            if (question.TopicId.HasValue)
            {
                var topicResult = await topicService.GetTopicByIdAsync(question.TopicId.Value);
                topicName = topicResult.IsSuccess ? topicResult.Value.Name : null;
            }
            //string? materialTitle = await GetMaterialTitleAsync(question.MaterialType, question.MaterialId);
            result.Add(new WrongAnswerTopicMaterialDto
            {
                QuestionId = question.Id,
                QuestionText = question.Text,
                TopicId = question.TopicId,
                TopicName = topicName,
                //MaterialType = question.MaterialType,
                //MaterialId = question.MaterialId,
                //MaterialTitle = materialTitle
            });
        }
        return Result.Success(result);
    }
}


