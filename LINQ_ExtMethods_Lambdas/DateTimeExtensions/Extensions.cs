using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeExtensions
{
   public static class AdvancedDateTime
    {
        public static int WorkDaysToPayment(this DateTime date)
        {
            int daysToPayment = 0, currentMonth = date.Month;
            DateTime iteratingDate = date;

            if (date.IsPastWorkHours())
            {
                daysToPayment--;
            }
            
            while (iteratingDate.Month == currentMonth)
            {
                iteratingDate = iteratingDate.AddDays(1);
                if (!iteratingDate.IsWeekend())
                {
                    daysToPayment++;
                }
            }

            return daysToPayment;
        }

        public static bool IsPastWorkHours(this DateTime date)
        {
            if (date.Hour > 17)
            {
                return true;
            }
            else
                return false;
        }

        public static bool IsWeekend(this DateTime date)
        {
            if (date.DayOfWeek == DayOfWeek.Sunday || date.DayOfWeek == DayOfWeek.Saturday)
            {
                return true;
            }
            else
                return false;
        }
    }
    
}


