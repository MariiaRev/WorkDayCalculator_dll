using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest
{
    class WeekEndsCalculator : IWeekEndsCalculator
    {
        public int[] WeekendsDurationCalculate(WeekEnd[] weekEnds)
        {
            int[] duration = new int[weekEnds.Length];
            for (int i = 0; i < weekEnds.Length; i++)
            {
                duration[i] = Convert.ToInt32(weekEnds[i].EndDate.Subtract(weekEnds[i].StartDate).TotalDays) + 1;
            }
            return duration;
        }
    }
}
