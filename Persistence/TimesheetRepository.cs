using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text;
using BabakSoft.Platform.Common;
using Timesheet.Model;

namespace Timesheet.Persistence
{
    public class TimesheetRepository
    {
        public List<TimesheetInfo> LoadTimesheets()
        {
            var timesheets = new List<TimesheetInfo>();
            var directoryInfo = new DirectoryInfo(GetDataDirectory());
            foreach (var fileInfo in directoryInfo.GetFiles("*.json"))
            {
                var timesheet = LoadTimesheet(Path.GetFileName(fileInfo.FullName));
                timesheet.Sheets.Clear();
                timesheets.Add(timesheet);
            }

            return timesheets;
        }

        public TimesheetInfo LoadTimesheet(string dataFileName)
        {
            var path = Path.Combine(GetDataDirectory(), dataFileName);
            if (!File.Exists(path))
            {
                var timesheet = new TimesheetInfo();
                SaveTimesheet(timesheet);
                return timesheet;
            }

            return JsonHelper.To<TimesheetInfo>(File.ReadAllText(path, Encoding.UTF8));
        }

        public void SaveTimesheet(TimesheetInfo timesheet)
        {
            var path = Path.Combine(GetDataDirectory(), timesheet.DataFile);
            File.WriteAllText(path, JsonHelper.From(timesheet), Encoding.UTF8);
        }

        private static string GetDataDirectory()
        {
            // Save yourself some boring manual backup and use your dropbox folder...
            var path = ConfigurationManager.AppSettings["DataRoot"];
            if (!Directory.Exists(path))
            {
                // NOTE: The following approach is a very bad idea!
                //path = Path.Combine("..", "..", "..", "Data");

                // TODO: Either create the dropbox folder structure or initialize timesheets
                // in default Data folder...
            }

            return path;
        }
    }
}
