using System;
using System.Windows.Forms;
using BabakSoft.Platform.Common;
using Timesheet.Model;

namespace Timesheet.Forms
{
    public partial class EntryEditorForm : Form
    {
        public EntryEditorForm()
        {
            InitializeComponent();
            Entry = new TimesheetEntry();
        }

        public TimesheetEntry Entry { get; set; }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            SetupBindings();
        }

        private void Date_ValueChanged(object sender, EventArgs e)
        {
            var jalaliDate = JalaliDateTime.FromDateTime(dtpDate.Value);
            txtJalaliDate.Text = jalaliDate.ToShortDateString();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (!ValidateEntry())
            {
                return;
            }

            Entry.Date = DateOnly.FromDateTime(dtpDate.Value);
            Entry.StartTime = dtpStartTime.Value.TimeOfDay;
            Entry.EndTime = dtpEndTime.Value.TimeOfDay;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void SetupBindings()
        {
            txtTitle.DataBindings.Add("Text", Entry, "Title");
            txtDescription.DataBindings.Add("Text", Entry, "Description");
            dtpDate.Value = Entry.Date.ToDateTime(TimeOnly.MinValue);
            dtpStartTime.Value = DateTime.Now.Date + Entry.StartTime;
            dtpEndTime.Value = DateTime.Now.Date + Entry.EndTime;
        }

        private bool ValidateEntry()
        {
            if (String.IsNullOrEmpty(txtTitle.Text))
            {
                MessageBox.Show(this, "Please enter a title that briefly describes a task.");
                txtTitle.Focus();
                return false;
            }

            if (dtpEndTime.Value.TimeOfDay < dtpStartTime.Value.TimeOfDay)
            {
                MessageBox.Show(this, "End time cannot be before start time.");
                return false;
            }

            return true;
        }
    }
}
