using System.Collections.Generic;

namespace Timesheet.Model
{
    public class TimesheetInfo
    {
        public TimesheetInfo()
        {
            Name = "<Not Specified>";
            Description = "<Not Specified>";
            Sheets = new List<DailyTimesheet>();
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public string DataFile { get; set; }

        public List<DailyTimesheet> Sheets { get; }

        public override string ToString()
        {
            return Name;
        }
    }
}
