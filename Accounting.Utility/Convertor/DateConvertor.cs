using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Accounting.Utility.Convertor
{
    public static class DateConvertor
    {
        public static string ToShamsi(this DateTime value)
        {
            PersianCalendar persianCalendar = new PersianCalendar();
            return
                $"{persianCalendar.GetYear(value)}/{persianCalendar.GetMonth(value).ToString("00")}/{persianCalendar.GetDayOfMonth(value).ToString("00")}";
        }

        public static DateTime ToMiladi(DateTime dateTime)
        {
            return new DateTime(dateTime.Year,dateTime.Month,dateTime.Day,new PersianCalendar());
        }
    }
}
