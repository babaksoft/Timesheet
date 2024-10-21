using System;

namespace Timesheet.Model
{
    public class TimesheetEntry
    {
        public TimesheetEntry()
        {
            Title = String.Empty;
            Description = String.Empty;
            Date = DateOnly.FromDateTime(DateTime.Now);
        }

        public int Id { get; set; }

        public DateOnly Date { get; set; }

        public TimeSpan StartTime { get; set; }

        public TimeSpan EndTime { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }
    }
}
