using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Timesheet.Model;
using Timesheet.Persistence;

namespace Timesheet
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            cmbTimesheet.DataSource = _repository.LoadTimesheets();
            cmbView.DataSource = TimesheetView.AllViews;
        }

        private void Timesheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCurrentTimesheet();
        }

        private void View_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCurrentEntries();
        }

        private void NewEntry_Click(object sender, EventArgs e)
        {
            var editor = new EntryEditorForm();
            if (editor.ShowDialog(this) == DialogResult.OK)
            {
                AddEntry(editor.Entry);
                SaveTimesheet();
                LoadEntries(cmbView.SelectedItem as TimesheetView);
            }
        }

        private void EditEntry_Click(object sender, EventArgs e)
        {
            if (grdEntries.SelectedRows.Count == 0)
            {
                return;
            }

            var editor = new EntryEditorForm()
            {
                Entry = grdEntries.SelectedRows[0].DataBoundItem as TimesheetEntry
            };
            if (editor.ShowDialog(this) == DialogResult.OK)
            {
                EditEntry(editor.Entry);
                SaveTimesheet();
                LoadEntries(cmbView.SelectedItem as TimesheetView);
            }
        }

        private void DeleteEntry_Click(object sender, EventArgs e)
        {
            if (grdEntries.SelectedRows.Count == 0)
            {
                return;
            }

            var response = MessageBox.Show(this, "Are you sure you want to remove this entry?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
            if (response == DialogResult.Yes)
            {
                var entry = grdEntries.SelectedRows[0].DataBoundItem as TimesheetEntry;
                DeleteEntry(entry);
                SaveTimesheet();
                LoadEntries(cmbView.SelectedItem as TimesheetView);
            }
        }

        private void Details_Click(object sender, EventArgs e)
        {
            var detailsForm = new TimesheetDetailsForm() { Timesheet = _timesheet };
            detailsForm.ShowDialog(this);
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoadEntries(TimesheetView view)
        {
            var timesheets = _timesheet.Sheets
                .Where(sheet => sheet.Date >= view.FromDate
                    && sheet.Date <= view.ToDate)
                .ToList();
            var entries = new List<TimesheetEntry>();
            int totalHours = 0;
            int totalMinutes = 0;
            foreach (var timesheet in timesheets)
            {
                entries.AddRange(timesheet.Entries);
                totalHours += timesheet.WorkTime.Hours;
                totalMinutes += timesheet.WorkTime.Minutes;
            }

            totalHours += totalMinutes / 60;
            totalMinutes %= 60;
            grdEntries.DataSource = entries
                .OrderByDescending(entry => entry.Date)
                .ThenByDescending(entry => entry.StartTime)
                .ToList();
            txtWorkDays.Text = $"{timesheets.Count}";
            txtWorkHours.Text = $"{totalHours}:{totalMinutes}";
        }

        private void AddEntry(TimesheetEntry entry)
        {
            int nextId = GetNextEntryId();
            var timesheet = _timesheet.Sheets
                .FirstOrDefault(sheet => sheet.Date == entry.Date);
            if (timesheet == null)
            {
                timesheet = new DailyTimesheet()
                {
                    Date = entry.Date
                };
                entry.Id = nextId;
                timesheet.Entries.Add(entry);
                _timesheet.Sheets.Add(timesheet);
            }
            else
            {
                entry.Id = nextId;
                timesheet.Entries.Add(entry);
            }
        }

        private void EditEntry(TimesheetEntry entry)
        {
            var timesheet = _timesheet.Sheets
                .SingleOrDefault(sheet => sheet.Date == entry.Date);
            var edited = timesheet.Entries.SingleOrDefault(ent => ent.Id == entry.Id);
            var editedIndex = timesheet.Entries.IndexOf(edited);
            timesheet.Entries.RemoveAt(editedIndex);
            timesheet.Entries.Insert(editedIndex, entry);
        }

        private void DeleteEntry(TimesheetEntry entry)
        {
            var timesheet = _timesheet.Sheets
                .SingleOrDefault(sheet => sheet.Date == entry.Date);
            var deleted = timesheet.Entries.SingleOrDefault(ent => ent.Id == entry.Id);
            timesheet.Entries.Remove(deleted);
            if (timesheet.Entries.Count == 0)
            {
                _timesheet.Sheets.Remove(timesheet);
            }
        }

        private void LoadCurrentTimesheet()
        {
            if (cmbTimesheet.SelectedIndex != -1)
            {
                var currentTimesheet = cmbTimesheet.SelectedItem as TimesheetInfo;
                _timesheet = _repository.LoadTimesheet(currentTimesheet.DataFile);
                LoadCurrentEntries();
            }
        }

        private void LoadCurrentEntries()
        {
            if (cmbView.SelectedIndex != -1)
            {
                var currentView = cmbView.SelectedItem as TimesheetView;
                LoadEntries(currentView);
            }
        }

        private void SaveTimesheet()
        {
            _repository.SaveTimesheet(_timesheet);
        }

        private int GetNextEntryId()
        {
            int maxId = 0;
            foreach (var timesheet in _timesheet.Sheets)
            {
                int maxEntryId = timesheet.Entries.Count > 0
                    ? timesheet.Entries.Max(entry => entry.Id)
                    : 0;
                maxId = Math.Max(maxId, maxEntryId);
            }

            return maxId + 1;
        }

        private readonly TimesheetRepository _repository = new();
        private TimesheetInfo _timesheet;
    }
}
