using MapsterMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TechSpire.Application.Dto;
using TechSpire.Application.Services;
using TechSpire.Domain.Entities;
using TechSpire.infra;

namespace TechSpire.APi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class LearningsController : ControllerBase
{
    // Endpoint to get user progress
    [HttpPost("AddDailyProgress")]
    public async Task<ActionResult> AddDailyProgress(UserProgressDto userProgressDto)
    {
        try
        {
            AspNetUser currentUser = await userService.GetCurrentUser();
            DateTime today = DateTime.Now;
            UsersProgress userProgress = mapper.Map<UsersProgress>(userProgressDto);
            userProgress.StudiedAt = today;
            userProgress.UserId = currentUser.Id;
            unitOfWork.Repository<UsersProgress>().Add(userProgress);
            await unitOfWork.Complete();
            return Ok("You Recorded the user's progress Successfully");
        }
        catch (Exception ex)
        {
            return BadRequest(new { Message = ex.Message.ToString() });
        }

    }

    [HttpPost("AddUserInProgressBook")]
    public async Task<ActionResult> AddUserInProgressBook(InProgressBookDto inProgressBook)
    {
        try
        {
            if (ModelState.IsValid)
            {
                ApplicataionUser currentUser = await userService.GetCurrentUser();
                // Book book = await unitOfWork.Repository<Book>().GetByIdAsync(inProgressBook.BookId);
                UserBookInProgress InProgressBook = mapper.Map<UserBookInProgress>(inProgressBook);
                InProgressBook.AspNetUserId = currentUser.Id;
                //  InProgressBook.CompletedPercentage = (inProgressBook.CurrentPage / book.PageCount) * 100;
                unitOfWork.Repository<UserBookInProgress>().Add(InProgressBook);
                await unitOfWork.Complete();
                return Ok(new { Message = "You Added Your Inprogress Book data Successfully" });
            }
            return BadRequest("You entered wrong data, please try again");

        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }

    }

    [HttpGet("GetWeeklyUserProgress")]
    public async Task<ActionResult> GetWeeklyUserProgress()
    {
        try
        {
            ApplicataionUser currentUser = await userService.GetCurrentUser();
            DateTime currentWeekStart = timeService.GetCurrentWeekStartDate();
            DateTime lastWeekStart = timeService.GetLastWeekDates(currentWeekStart)[0];
            DateTime lastWeekEnd = timeService.GetLastWeekDates(currentWeekStart)[1];
            List<ProgressDto> currentWeekProgresses = await ComputeCurrentWeekProgress(currentUser, currentWeekStart);
            List<ProgressDto> lastWeekProgresses = await ComputeLastWeekProgress(currentUser, lastWeekStart, lastWeekEnd);
            return Ok(new
            {
                CurrentWeek = currentWeekProgresses,
                LastWeek = lastWeekProgresses
            });
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }

    }

    // =======================================================================
    [HttpGet("GetStudyBooks")]
    public async Task<ActionResult> GetStudyBooks()
    {
        try
        {
            ApplicataionUser currentUser = await userService.GetCurrentUser();
            UserBookInProgressByUserId userBookInProgressSpec = new UserBookInProgressByUserId(currentUser.Id);
            UserBookInProgress inProgressBook = await unitOfWork.Repository<UserBookInProgress>().GetEntityWithSpecification(userBookInProgressSpec);
            Book nextBook = await unitOfWork.Repository<Book>().GetByIdAsync(inProgressBook.BookId + 1);
            return Ok(new { InProgressBook = inProgressBook, NextBook = nextBook });
        }
        catch (Exception ex)
        {
            return BadRequest(new { Message = ex.Message });
        }

    }

    // =====================================================
    private async Task<List<ProgressDto>> ComputeLastWeekProgress(ApplicataionUser currentUser, DateTime lastWeekStart, DateTime lastWeekEnd)
    {
        LastWeekUserProgress lastWeekUserProgressSpec = new
            LastWeekUserProgress(currentUser.Id, lastWeekStart, lastWeekEnd);
        List<UsersProgress> lastWeekUserprogress = await unitOfWork.Repository<UsersProgress>().ListAsync(lastWeekUserProgressSpec);
        // int bookCount = await unitOfWork.Repository<Book>().Count();
        // int articleCount = await unitOfWork.Repository<Article>().Count();
        // int postCount = await unitOfWork.Repository<Post>().Count();
        List<ProgressDto> dailyProgress = new List<ProgressDto>();
        foreach (var item in lastWeekUserprogress)
        {
            //decimal dailyBookAverage = (item.DailyBooks / bookCount) * 100;
            //decimal dailyArticleAverage = (item.DailyArticles / articleCount) * 100;
            // decimal dailyPostAverage = (item.DailyPosts / postCount) * 100;
            // decimal dailyAverage = dailyBookAverage + dailyArticleAverage + dailyPostAverage;
            dailyProgress.Add(new ProgressDto
            {
                StudiedAt = item.StudiedAt,
                //    Progress = dailyAverage
            });
        }
        return dailyProgress;
    }
    // =====================================================
    private async Task<List<ProgressDto>> ComputeCurrentWeekProgress(ApplicataionUser currentUser, DateTime currentWeekStart)
    {
        CurrentWeekUserProgress currentWeekUserProgressSpec = new
            CurrentWeekUserProgress(currentUser.Id, currentWeekStart);
        List<UsersProgress> currentWeekUserprogress = await unitOfWork.Repository<UsersProgress>().ListAsync(currentWeekUserProgressSpec);
        //int bookCount = await unitOfWork.Repository<Book>().Count();
        // int articleCount = await unitOfWork.Repository<Article>().Count();
        // int postCount = await unitOfWork.Repository<Post>().Count();
        List<ProgressDto> dailyProgress = new List<ProgressDto>();
        foreach (var item in currentWeekUserprogress)
        {
            //  decimal dailyBookAverage = (item.DailyBooks / bookCount) * 100;
            //decimal dailyArticleAverage = (item.DailyArticles / articleCount) * 100;
            //decimal dailyPostAverage = (item.DailyPosts / postCount) * 100;
            //decimal dailyAverage = dailyBookAverage + dailyArticleAverage + dailyPostAverage;
            dailyProgress.Add(new ProgressDto
            {
                StudiedAt = item.StudiedAt,
                // Progress = dailyAverage
            });
        }
        return dailyProgress;
    }
    // =======================================================================

}
