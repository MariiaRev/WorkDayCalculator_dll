using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTest
{
    interface IWeekEndsCalculator
    {
        int[] WeekendsDurationCalculate(WeekEnd[] weekEnds);
    }
}
