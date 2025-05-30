using TechSpire.Application.Abstraction;
using TechSpire.Application.Contracts.Users;
using TechSpire.Application.Services;
using TechSpire.Application.Services.User;

namespace TechSpire.infra.Services.User;

public class UserServices(UserManager<ApplicataionUser> manager) : IUserService
{
    private readonly UserManager<ApplicataionUser> manager = manager;

    public async Task<Result> ChangePassword(string id, ChangePasswordRequest request)
    {
        var user = await manager.FindByIdAsync(id);

        var result = await manager.ChangePasswordAsync(user!, request.CurrentPassword, request.NewPassord);

        if (result.Succeeded)
            return Result.Success();

        var error = result.Errors.First();

        return Result.Failure(new Error(error.Code, error.Description, StatusCodes.Status400BadRequest));
    }

    public async Task<Result<UserProfileResponse>> GetUserProfile(string id)
    {
        var user = await manager.Users
            .Where(i => i.Id == id)
            .ProjectToType<UserProfileResponse>()
            .SingleAsync();
        ;

        return Result.Success(user);
    }

    public async Task<Result> UpdateUserProfile(string id, UpdateUserProfileRequest request)
    {
        //var user = await manager.FindByIdAsync(id);

        //user = request.Adapt(user);

        //await manager.UpdateAsync(user!);
        await manager.Users
            .Where(i => i.Id == id)
            .ExecuteUpdateAsync(set =>
            set.SetProperty(x => x.FirstName, request.FirstName)
               .SetProperty(x => x.LastName, request.LastName));

        return Result.Success();
    }

    //======================================================================================

        private readonly IUnitOfWork unitOfWork;
        private readonly IHttpContextAccessor httpContextAccessor;


    public UserService(
            IGenericRepository<ApplicataionUser> userRepository,
            IGenericRepository<Quiz> quizRepository,
            IGenericRepository<Domain.Entities.Question> questionRepository,
            IHttpContextAccessor httpContextAccessor,
            IUnitOfWork unitOfWork
        )
        {

            this.httpContextAccessor = httpContextAccessor;
            this.unitOfWork = unitOfWork;
        }
        public async Task<ApplicataionUser> GetCurrentUser()
        {
            string userId = httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);
            CurrentUser currentUserSpec = new CurrentUser(userId);
            return await unitOfWork.Repository<ApplicataionUser>().GetByUserIdAsync(userId);
        }



        public async Task<Quiz> GetQuizByLevelId(int? levelId)
        {
            QuizByLevelSpec quizByLevelSpec = new QuizByLevelSpec(levelId);
            return await unitOfWork.Repository<Quiz>().GetEntityWithSpecification(quizByLevelSpec);
        }

        public async Task<List<Question>> GetQuestionsByQuizId(int quizId)
        {
            QuestionWithChoicesByQuizId questionWithChoicesSpec = new QuestionWithChoicesByQuizId(quizId);
            return await unitOfWork.Repository<Question>().ListAsync(questionWithChoicesSpec);
        }
}
