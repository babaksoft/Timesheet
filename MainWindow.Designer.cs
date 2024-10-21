using System.Drawing;
using System.Windows.Forms;

namespace Timesheet
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnNewEntry = new Button();
            btnEditEntry = new Button();
            btnDeleteEntry = new Button();
            btnExit = new Button();
            btnDetails = new Button();
            grdEntries = new DataGridView();
            label2 = new Label();
            cmbView = new ComboBox();
            label3 = new Label();
            txtWorkDays = new TextBox();
            txtWorkHours = new TextBox();
            label4 = new Label();
            cmbTimesheet = new ComboBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)grdEntries).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(132, 20);
            label1.TabIndex = 0;
            label1.Text = "Timesheet Entries :";
            // 
            // btnNewEntry
            // 
            btnNewEntry.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnNewEntry.Location = new Point(12, 626);
            btnNewEntry.Name = "btnNewEntry";
            btnNewEntry.Size = new Size(94, 35);
            btnNewEntry.TabIndex = 8;
            btnNewEntry.Text = "&New Entry";
            btnNewEntry.UseVisualStyleBackColor = true;
            btnNewEntry.Click += NewEntry_Click;
            // 
            // btnEditEntry
            // 
            btnEditEntry.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEditEntry.Location = new Point(112, 626);
            btnEditEntry.Name = "btnEditEntry";
            btnEditEntry.Size = new Size(94, 35);
            btnEditEntry.TabIndex = 9;
            btnEditEntry.Text = "&Edit Entry";
            btnEditEntry.UseVisualStyleBackColor = true;
            btnEditEntry.Click += EditEntry_Click;
            // 
            // btnDeleteEntry
            // 
            btnDeleteEntry.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDeleteEntry.Location = new Point(212, 626);
            btnDeleteEntry.Name = "btnDeleteEntry";
            btnDeleteEntry.Size = new Size(94, 35);
            btnDeleteEntry.TabIndex = 10;
            btnDeleteEntry.Text = "&Delete";
            btnDeleteEntry.UseVisualStyleBackColor = true;
            btnDeleteEntry.Click += DeleteEntry_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnExit.Location = new Point(726, 626);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 35);
            btnExit.TabIndex = 12;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += Exit_Click;
            // 
            // btnDetails
            // 
            btnDetails.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDetails.Location = new Point(312, 626);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(164, 35);
            btnDetails.TabIndex = 11;
            btnDetails.Text = "&Timesheet Details...";
            btnDetails.UseVisualStyleBackColor = true;
            btnDetails.Click += Details_Click;
            // 
            // grdEntries
            // 
            grdEntries.AllowUserToAddRows = false;
            grdEntries.AllowUserToDeleteRows = false;
            grdEntries.AllowUserToResizeRows = false;
            grdEntries.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            grdEntries.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            grdEntries.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdEntries.Location = new Point(12, 41);
            grdEntries.MultiSelect = false;
            grdEntries.Name = "grdEntries";
            grdEntries.ReadOnly = true;
            grdEntries.RowHeadersVisible = false;
            grdEntries.RowHeadersWidth = 51;
            grdEntries.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdEntries.Size = new Size(808, 534);
            grdEntries.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(547, 9);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 1;
            label2.Text = "Current View :";
            // 
            // cmbView
            // 
            cmbView.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbView.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbView.FormattingEnabled = true;
            cmbView.Location = new Point(653, 6);
            cmbView.Name = "cmbView";
            cmbView.Size = new Size(167, 28);
            cmbView.TabIndex = 2;
            cmbView.SelectedIndexChanged += View_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(383, 588);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 4;
            label3.Text = "Days (total) :";
            // 
            // txtWorkDays
            // 
            txtWorkDays.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtWorkDays.Location = new Point(483, 585);
            txtWorkDays.Name = "txtWorkDays";
            txtWorkDays.ReadOnly = true;
            txtWorkDays.Size = new Size(94, 27);
            txtWorkDays.TabIndex = 5;
            // 
            // txtWorkHours
            // 
            txtWorkHours.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtWorkHours.Location = new Point(726, 585);
            txtWorkHours.Name = "txtWorkHours";
            txtWorkHours.ReadOnly = true;
            txtWorkHours.Size = new Size(94, 27);
            txtWorkHours.TabIndex = 7;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Location = new Point(616, 588);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 6;
            label4.Text = "Hours (total) :";
            // 
            // cmbTimesheet
            // 
            cmbTimesheet.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cmbTimesheet.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTimesheet.FormattingEnabled = true;
            cmbTimesheet.Location = new Point(354, 6);
            cmbTimesheet.Name = "cmbTimesheet";
            cmbTimesheet.Size = new Size(167, 28);
            cmbTimesheet.TabIndex = 14;
            cmbTimesheet.SelectedIndexChanged += Timesheet_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Location = new Point(212, 9);
            label5.Name = "label5";
            label5.Size = new Size(136, 20);
            label5.TabIndex = 13;
            label5.Text = "Current Timesheet :";
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 673);
            Controls.Add(cmbTimesheet);
            Controls.Add(label5);
            Controls.Add(txtWorkHours);
            Controls.Add(label4);
            Controls.Add(txtWorkDays);
            Controls.Add(label3);
            Controls.Add(cmbView);
            Controls.Add(label2);
            Controls.Add(grdEntries);
            Controls.Add(btnDetails);
            Controls.Add(btnExit);
            Controls.Add(btnDeleteEntry);
            Controls.Add(btnEditEntry);
            Controls.Add(btnNewEntry);
            Controls.Add(label1);
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Simple Timesheet Application";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)grdEntries).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnNewEntry;
        private Button btnEditEntry;
        private Button btnDeleteEntry;
        private Button btnExit;
        private Button btnDetails;
        private DataGridView grdEntries;
        private Label label2;
        private ComboBox cmbView;
        private Label label3;
        private TextBox txtWorkDays;
        private TextBox txtWorkHours;
        private Label label4;
        private ComboBox cmbTimesheet;
        private Label label5;
    }
}
