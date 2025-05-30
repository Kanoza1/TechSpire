using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSpire.Application.Abstraction;
using TechSpire.Application.Dto;
using TechSpire.Domain.Entities;
using TechSpire.infra.Dbcontext;
using TechSpire.infra.Migrations;
using static TechSpire.infra.Services.Fucckinglearning.TimeService;

namespace TechSpire.infra.Services.Fucckinglearning;
public class TimeService(UserManager<ApplicataionUser> userManager, AppDbcontext dbcontext) : ITimeService
{
    private readonly UserManager<ApplicataionUser> userManager = userManager;
    private readonly AppDbcontext dbcontext = dbcontext;

    public async Task<(UserBookInProgress?, Book?)> lol4(string userid)
    {
        var inProgressBook = await dbcontext.UserBookInProgress
      .Where(x => x.AppUserId == userid)
      .FirstOrDefaultAsync();

        if (inProgressBook == null)
            return (null, null); // or handle appropriately

        var nextBook = await dbcontext.Books
            .Where(b => b.Id == inProgressBook.BookId + 1)
            .FirstOrDefaultAsync();
        if (nextBook == null)
            return (null, null);
        return (inProgressBook, nextBook);
    }
    public async Task<(DateTime, DateTime)> lol3(string userid)
    {

        var use = await userManager.FindByIdAsync(userid);
        DateTime today = DateTime.Today;
        DateTime currentWeekStart = today.AddDays(-(int)today.DayOfWeek);

        DateTime lastWeekStart = DateTime.UtcNow.AddDays(-7);
        DateTime lastWeekEnd = currentWeekStart;
        DateTime[] lastWeekDates = { lastWeekStart, lastWeekEnd };

        DateTime lastWeekStart2 = DateTime.UtcNow.AddDays(0);
        DateTime lastWeekEnd2 = currentWeekStart;
        DateTime[] lastWeekDates2 = { lastWeekStart2, lastWeekEnd2 };


        return (lastWeekStart, lastWeekStart2);
    }
    public async Task<bool> loll2(InProgressBookDto inProgressBook, string userid)
    {
        
            var user = await userManager.FindByIdAsync(userid);


            var currentUser = await userManager.FindByIdAsync(userid);
            // Book book = await unitOfWork.Repository<Book>().GetByIdAsync(inProgressBook.BookId);
            UserBookInProgress InProgressBook = inProgressBook.Adapt<UserBookInProgress>();
            InProgressBook.AppUserId = currentUser.Id;
        //  InProgressBook.CompletedPercentage = (inProgressBook.CurrentPage / book.PageCount) * 100;
        var result = await dbcontext.UserBookInProgress.AddAsync(InProgressBook);
        await dbcontext.SaveChangesAsync();
        if (result != null)
     
        {
                return true;
            }
            else
            {
                return false;
            }


        }
    
    public async Task<bool> lol (string usserid , UserProgressDto userProgressDto)
    {
        var user = await userManager.FindByIdAsync(usserid);
        try
        {
            
            DateTime today = DateTime.Now;
            UsersProgress userProgress = userProgressDto.Adapt<UsersProgress>();
            userProgress.StudiedAt = today;
            userProgress.UserId = user.Id;
            var result = await dbcontext.UsersProgress.AddAsync(userProgress);
            await dbcontext.SaveChangesAsync();
            return true;
        }
        catch (Exception ex)
        {
            return false;
        }

    } 
        public DateTime GetCurrentWeekStartDate()
    {
        DateTime today = DateTime.Today;
        DateTime currentWeekStart = today.AddDays(-(int)today.DayOfWeek);
        return currentWeekStart;
    }

        public DateTime[] GetLastWeekDates(DateTime currentWeekStart)
        {
            DateTime lastWeekStart = currentWeekStart.AddDays(-7);
            DateTime lastWeekEnd = currentWeekStart;
            DateTime[] lastWeekDates = { lastWeekStart, lastWeekEnd };
            return lastWeekDates;
        }


}
