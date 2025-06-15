using MapsterMapper;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TechSpire.Application.Dto;
using TechSpire.Application.Services;
using TechSpire.Domain.Entities;
using TechSpire.infra;
using TechSpire.infra.Dbcontext;
using TechSpire.infra.Extensions;
using TechSpire.infra.Services.Fucckinglearning;

namespace TechSpire.APi.Controllers;
[Route("[controller]")]
[ApiController]
[Authorize]
public class LearningsController(ITimeService service, AppDbcontext dbcontext) : ControllerBase
{
    private readonly ITimeService service = service;
    private readonly AppDbcontext dbcontext = dbcontext;

    // Endpoint to get user progress
    [HttpPost("AddDailyProgress")]
    public async Task<ActionResult> AddDailyProgress(UserProgressDto userProgressDto)
    {
        var userid = User.GetUserId();
        var result = await service.lol(userid, userProgressDto);
        if (result)
        {
            return Ok(new { Message = "Your progress has been added successfully." });
        }
        else
        {
            return BadRequest(new { Message = "Failed to add your progress. Please try again." });
        }

    }

    [HttpPost("AddUserInProgressBook")]
    public async Task<ActionResult> AddUserInProgressBook(InProgressBookDto inProgressBook)
    {

        var userid = User.GetUserId();
        var result = await service.loll2(inProgressBook, userid);
        if (result)
        {
            return Ok(new { Message = "Your in-progress book has been added successfully." });
        }
        else
        {
            return BadRequest(new { Message = "Failed to add your in-progress book. Please try again." });
        }

    }

    [HttpGet("GetWeeklyUserProgress")]
    public async Task<ActionResult> GetWeeklyUserProgress()
    {
        var userId = User.GetUserId();
        try
        {
            var (result, result2) = await service.lol3(User.GetUserId());
            List<ProgressDto> currentWeekProgresses = await ComputeCurrentWeekProgress(userId, result2);
            List<ProgressDto> lastWeekProgresses = await ComputeLastWeekProgress(userId, result, result2);
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
        var userId = User.GetUserId();
        try
        {
            var (inProgressBook, nextBook) = await service.lol4(userId);
            if (inProgressBook == null)
            {
                return NotFound(new { Message = "No in-progress book found." });
            }
            return Ok(new
            {
                InProgressBook = inProgressBook,
                NextBook = nextBook
            });
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }

    }

    // =====================================================
    private async Task<List<ProgressDto>> ComputeLastWeekProgress(string currentUser, DateTime lastWeekStart, DateTime lastWeekEnd)
    {
        List<UsersProgress> lastWeekUserprogress = await dbcontext.UsersProgress
            .Where(x => x.UserId == currentUser && x.StudiedAt >= lastWeekStart && x.StudiedAt < lastWeekEnd)
            .ToListAsync(); // Use the DbContext directly for simplicity
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
    private async Task<List<ProgressDto>> ComputeCurrentWeekProgress(string currentUser, DateTime currentWeekStart)
    {

        List<UsersProgress> currentWeekUserprogress = await dbcontext.UsersProgress
            .Where(x => x.UserId == currentUser && x.StudiedAt >= currentWeekStart)
            .ToListAsync();




        // Use the DbContext directly for simplicity
        //int bookCount = await unitOfWork.Repository<Book>().Count();
        // int articleCount = await unitOfWork.Repository<Article>().Count();
        // int postCount = await unitOfWork.Repository<Post>().Count();
        // meeting 
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
