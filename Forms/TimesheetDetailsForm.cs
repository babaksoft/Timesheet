﻿using System;
using System.Configuration;
using System.IO;
using System.Windows.Forms;
using BabakSoft.Platform.Helpers;
using Timesheet.Model;

namespace Timesheet.Forms
{
    public partial class TimesheetDetailsForm : Form
    {
        public TimesheetDetailsForm()
        {
            InitializeComponent();
        }

        public TimesheetInfo Timesheet { get; set; }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            SetupBindings();
        }

        private void SetupBindings()
        {
            txtName.DataBindings.Add("Text", Timesheet, "Name");
            txtDescription.DataBindings.Add("Text", Timesheet, "Description");

            var path = Path.Combine(ConfigurationManager.AppSettings["DataRoot"], Timesheet.DataFile);
            txtLocation.Text = FileUtility.GetAbsolutePath(path);
        }
    }
}
