using System;

namespace GrouponDesktop.Helpers
{
    public static class DateTimeHelpers
    {
        public static int GetSemester(this DateTime dateTime)
        {
            return (dateTime.Month - 1) / 6 + 1;
        }
    }
}
