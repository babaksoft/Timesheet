using System;
using System.Collections.Generic;
using System.Globalization;
using BabakSoft.Platform.Common;
using BabakSoft.Platform.Extensions;

namespace Timesheet.Model
{
    internal class TimesheetView
    {
        static TimesheetView()
        {
            AllViews = GetAllViews();
        }

        internal TimesheetView()
        {
            Title = String.Empty;
        }

        internal string Title { get; private set; }

        internal DateOnly FromDate { get; private set; }

        internal DateOnly ToDate { get; private set; }

        internal static List<TimesheetView> AllViews { get; private set; }

        public override string ToString()
        {
            return Title;
        }

        private static List<TimesheetView> GetAllViews()
        {
            var allViews = new List<TimesheetView>();
            allViews.Add(new TimesheetView()
            {
                Title = "All Entries",
                FromDate = DateOnly.MinValue,
                ToDate = DateOnly.MaxValue
            });
            allViews.Add(new TimesheetView()
            {
                Title = "Today",
                FromDate = DateOnly.FromDateTime(DateTime.Now),
                ToDate = DateOnly.FromDateTime(DateTime.Now)
            });
            allViews.Add(GetThisWeek());
            allViews.Add(GetLastWeek());
            allViews.Add(GetThisMonth());
            allViews.Add(GetLastMonth());
            allViews.Add(GetLastMonths(3));
            allViews.Add(GetLastMonths(6));
            allViews.Add(GetLastMonths(9));

            return allViews;
        }

        private static TimesheetView GetThisWeek()
        {
            var persianCalendar = new PersianCalendar();
            var dayOfWeek = DateTime.Now.DayOfWeek;
            return new TimesheetView()
            {
                Title = "This Week",
                FromDate = DateOnly.FromDateTime(
                    DateTime.Now - TimeSpan.FromDays(GetStartOfWeekOffset(persianCalendar, dayOfWeek))),
                ToDate = DateOnly.FromDateTime(
                    DateTime.Now + TimeSpan.FromDays(GetEndOfWeekOffset(persianCalendar, dayOfWeek)))
            };
        }

        private static TimesheetView GetLastWeek()
        {
            var persianCalendar = new PersianCalendar();
            var dayOfWeek = DateTime.Now.DayOfWeek;
            var startOfWeekOffset = GetStartOfWeekOffset(persianCalendar, dayOfWeek);
            return new TimesheetView()
            {
                Title = "Last Week",
                FromDate = DateOnly.FromDateTime(
                    DateTime.Now - TimeSpan.FromDays(7 + startOfWeekOffset)),
                ToDate = DateOnly.FromDateTime(
                    DateTime.Now - TimeSpan.FromDays(1 + startOfWeekOffset))
            };
        }

        private static TimesheetView GetThisMonth()
        {
            var persianCalendar = new PersianCalendar();
            var jalaliNow = JalaliDateTime.Now;
            return new TimesheetView()
            {
                Title = "This Month",
                FromDate = DateOnly.FromDateTime(persianCalendar.GetStartOfMonth(jalaliNow.Month)),
                ToDate = DateOnly.FromDateTime(persianCalendar.GetEndOfMonth(jalaliNow.Month))
            };
        }

        private static TimesheetView GetLastMonth()
        {
            var persianCalendar = new PersianCalendar();
            var jalaliNow = JalaliDateTime.Now;
            var lastMonthNo = jalaliNow.Month > 1
                ? jalaliNow.Month - 1
                : 12;
            return new TimesheetView()
            {
                Title = "Last Month",
                FromDate = DateOnly.FromDateTime(persianCalendar.GetStartOfMonth(lastMonthNo)),
                ToDate = DateOnly.FromDateTime(persianCalendar.GetEndOfMonth(lastMonthNo))
            };
        }

        private static TimesheetView GetLastMonths(int count)
        {
            int day = JalaliDateTime.Now.Day;
            int month = JalaliDateTime.Now.Month > count
                ? JalaliDateTime.Now.Month - count
                : 12 + JalaliDateTime.Now.Month - count;
            int year = JalaliDateTime.Now.Month > count
                ? JalaliDateTime.Now.Year
                : JalaliDateTime.Now.Year - 1;
            if (month <= 6)
            {
                day = Math.Min(day, 31);
            }
            else if (month > 6 && month < 12)
            {
                day = Math.Min(day, 30);
            }
            else
            {
                day = JalaliDateTime.Now.IsLeapDay()
                    ? Math.Min(day, 30)
                    : Math.Min(day, 29);
            }

            return new TimesheetView()
            {
                Title = $"Last {count} Months",
                FromDate = DateOnly.FromDateTime(
                    new JalaliDateTime(year, month, day).ToGregorian()),
                ToDate = DateOnly.FromDateTime(DateTime.Now)
            };
        }

        private static int GetStartOfWeekOffset(Calendar calendar, DayOfWeek dayOfWeek)
        {
            int offset;
            if (calendar is PersianCalendar)
            {
                offset = dayOfWeek == DayOfWeek.Saturday
                    ? 0
                    : (int)dayOfWeek + 1;
            }
            else    // Currently, this means Gregorian calendar (only two calendars currently supported)
            {
                offset = dayOfWeek == DayOfWeek.Sunday
                    ? 6
                    : (int)dayOfWeek - 1;
            }

            return offset;
        }

        private static int GetEndOfWeekOffset(Calendar calendar, DayOfWeek dayOfWeek)
        {
            return 6 - GetStartOfWeekOffset(calendar, dayOfWeek);
        }
    }
}
