using System;
using System.Collections.Generic;

namespace Timesheet.Model
{
    public class DailyTimesheet
    {
        public DailyTimesheet()
        {
            Entries = new List<TimesheetEntry>();
        }

        public DateOnly Date { get; set; }

        public TimeSpan WorkTime
        {
            get
            {
                TimeSpan total = TimeSpan.Zero;
                Array.ForEach(Entries.ToArray(), entry =>
                {
                    total += entry.EndTime - entry.StartTime;
                });

                return total;
            }
        }

        public List<TimesheetEntry> Entries { get; }
    }
}
