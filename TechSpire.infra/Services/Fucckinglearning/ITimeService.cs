using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSpire.Application.Dto;

namespace TechSpire.infra.Services.Fucckinglearning;
public interface ITimeService
{
     Task<(UserBookInProgress, Book)> lol4(string userid);
    Task<(DateTime, DateTime)> lol3(string userid);
    Task<bool> loll2(InProgressBookDto inProgressBook, string userid);
    Task<bool> lol(string usserid, UserProgressDto userProgressDto);
    DateTime GetCurrentWeekStartDate();
    DateTime[] GetLastWeekDates(DateTime currentWeekStart);
}
