using TechSpire.Application.Abstraction;
using TechSpire.Application.Contracts.Users;
using TechSpire.Domain.Entities;

namespace TechSpire.Application.Services.User;

public interface IUserService
{
    Task<Result<UserProfileResponse>> GetUserProfile(string id);
    Task<Result> UpdateUserProfile(string id, UpdateUserProfileRequest request);
    Task<Result> ChangePassword(string id, ChangePasswordRequest request);

    public Task<ApplicataionUser> GetCurrentUser();
    public Task<Quiz> GetQuizByLevelId(int? levelId);
    public Task<List<Question>> GetQuestionsByQuizId(int quizId);

}
