using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest
{
    public class WorkDayCalculator : IWorkDayCalculator
    {
        public DateTime Calculate(DateTime startDate, int dayCount, WeekEnd[] weekEnds)
        {
            WeekEndsCalculator weekendsCalculator = new WeekEndsCalculator();
            int duration = 0;           
            int[] weekendsDuration = null;
            var tempDate = startDate;
            int i = 0;

            if (weekEnds != null)
            {
                weekendsDuration = weekendsCalculator.WeekendsDurationCalculate(weekEnds);
            }

            while (duration < dayCount)
            {
                if (weekEnds != null && i < weekEnds.Length && tempDate == weekEnds[i].StartDate)
                {
                    tempDate = tempDate.AddDays(weekendsDuration[i]);
                    i++;
                }
                else
                {
                    duration++;
                    tempDate = tempDate.AddDays(1);
                }               
            }
            DateTime endDate = tempDate.AddDays(-1);
            return endDate;
        }
    }
}
