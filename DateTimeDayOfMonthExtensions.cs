using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public static class DateTimeDayOfMonthExtensions
    {
        public static DateTime FirstDayOfMonth(this DateTime value)
        {
            return new DateTime(value.Year, value.Month, 1);
        }

        public static int DaysInMonth(this DateTime value)
        {
            return DateTime.DaysInMonth(value.Year, value.Month);
        }

        public static DateTime LastDayOfMonth(this DateTime value)
        {
            return new DateTime(value.Year, value.Month, value.DaysInMonth());
        }
        public static DateTime startWeekDateExtMethod(this DateTime value)
        {
            DateTime wkStDt = DateTime.MinValue;


            DateTime wkEndDt = DateTime.MinValue;

            wkStDt = value.AddDays(1 - Convert.ToDouble(value.DayOfWeek));


             return wkStDt;
        }
        public static DateTime endWeekDateExtMethod(this DateTime value)
        {
             


            DateTime wkEndDt = DateTime.MinValue;
            wkEndDt = value.AddDays(7 - Convert.ToDouble(value.DayOfWeek));

            return wkEndDt;
        }
        public static DateTime  firstDateTrimestereExtMethod(this DateTime value)
        {
            int currQuarter = (value.Month - 1) / 3 + 1;


            DateTime dtFirstDay = new DateTime(value.Year, 3 * currQuarter - 2, 1);
            return dtFirstDay;
        }
        public static DateTime lastDateTrimestereExtMethod(this DateTime value)
        {
            int currQuarter = (value.Month - 1) / 3 + 1;

            DateTime dtLastDay = new DateTime(value.Year, 3 * currQuarter + 1, 1).AddDays(-1);


            return dtLastDay;
        }

    }

}
