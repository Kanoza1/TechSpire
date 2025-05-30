using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSpire.Application.Services;
using static TechSpire.infra.Services.TimeService;

namespace TechSpire.infra.Services;
public class TimeService : ITimeService
{
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
