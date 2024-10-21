using System;
using System.Globalization;
using BabakSoft.Platform.Common;

namespace BabakSoft.Platform.Extensions
{
    /// <summary>
    /// Extends <see cref="System.Globalization.PersianCalendar"/> with useful methods
    /// </summary>
    public static class PersianCalendarExtensions
    {
        /// <summary>
        /// Returns a datetime instance that represents the first day of given month in current year
        /// </summary>
        /// <param name="calendar">Current <see cref="System.Globalization.PersianCalendar"/> object</param>
        /// <param name="month">One-based index of given month</param>
        /// <returns>First day of given month as a datetime instance</returns>
        public static DateTime GetStartOfMonth(this PersianCalendar calendar, int month)
        {
            Verify.ArgumentNotNull(calendar, "calendar");
            int currentYear = calendar.GetYear(DateTime.Now);
            return JalaliDateTime.
                Parse(String.Format("{0}/{1:D2}/01", currentYear, month))
                .ToGregorian()
                .Date;
        }

        /// <summary>
        /// Returns a datetime instance that represents the last day of given month in current year
        /// </summary>
        /// <param name="calendar">Current <see cref="System.Globalization.PersianCalendar"/> object</param>
        /// <param name="month">One-based index of given month</param>
        /// <returns>Last day of given month as a datetime instance</returns>
        public static DateTime GetEndOfMonth(this PersianCalendar calendar, int month)
        {
            Verify.ArgumentNotNull(calendar, "calendar");
            int currentYear = calendar.GetYear(DateTime.Now);
            DateTime startOfMonth = calendar.GetStartOfMonth(month);
            return startOfMonth + TimeSpan.FromDays(calendar.GetDaysInMonth(currentYear, month) - 1);
        }

        /// <summary>
        /// Returns a datetime instance that represents the first day of given month in given year
        /// </summary>
        /// <param name="calendar">Current <see cref="System.Globalization.PersianCalendar"/> object</param>
        /// <param name="year">Given year</param>
        /// <param name="month">One-based index of given month</param>
        /// <returns>First day of given month as a datetime instance</returns>
        public static DateTime GetStartOfMonth(this PersianCalendar calendar, int year, int month)
        {
            Verify.ArgumentNotNull(calendar, "calendar");
            if (year < calendar.GetYear(calendar.MinSupportedDateTime)
                || year > calendar.GetYear(calendar.MaxSupportedDateTime))
            {
                throw ExceptionBuilder.NewArgumentOutOfRangeException(nameof(year));
            }

            return JalaliDateTime.
                Parse(String.Format("{0}/{1:D2}/01", year, month))
                .ToGregorian()
                .Date;
        }

        /// <summary>
        /// Returns a datetime instance that represents the last day of given month in given year
        /// </summary>
        /// <param name="calendar">Current <see cref="System.Globalization.PersianCalendar"/> object</param>
        /// <param name="year">Given year</param>
        /// <param name="month">One-based index of given month</param>
        /// <returns>Last day of given month as a datetime instance</returns>
        public static DateTime GetEndOfMonth(this PersianCalendar calendar, int year, int month)
        {
            Verify.ArgumentNotNull(calendar, "calendar");
            if (year < calendar.GetYear(calendar.MinSupportedDateTime)
                || year > calendar.GetYear(calendar.MaxSupportedDateTime))
            {
                throw ExceptionBuilder.NewArgumentOutOfRangeException(nameof(year));
            }

            DateTime startOfMonth = calendar.GetStartOfMonth(year, month);
            return startOfMonth + TimeSpan.FromDays(calendar.GetDaysInMonth(year, month) - 1);
        }
    }
}
