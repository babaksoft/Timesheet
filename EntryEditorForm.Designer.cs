using System.Drawing;
using System.Windows.Forms;

namespace Timesheet
{
    partial class EntryEditorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtTitle = new TextBox();
            txtDescription = new TextBox();
            label2 = new Label();
            label3 = new Label();
            dtpDate = new DateTimePicker();
            dtpStartTime = new DateTimePicker();
            label4 = new Label();
            dtpEndTime = new DateTimePicker();
            label5 = new Label();
            txtJalaliDate = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 172);
            label1.Name = "label1";
            label1.Size = new Size(45, 20);
            label1.TabIndex = 7;
            label1.Text = "Title :";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(12, 199);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(433, 27);
            txtTitle.TabIndex = 8;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(12, 275);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ScrollBars = ScrollBars.Vertical;
            txtDescription.Size = new Size(433, 119);
            txtDescription.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 248);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 9;
            label2.Text = "Description :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 22);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 0;
            label3.Text = "Date :";
            // 
            // dtpDate
            // 
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(12, 49);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(206, 27);
            dtpDate.TabIndex = 1;
            dtpDate.ValueChanged += Date_ValueChanged;
            // 
            // dtpStartTime
            // 
            dtpStartTime.Format = DateTimePickerFormat.Time;
            dtpStartTime.Location = new Point(12, 122);
            dtpStartTime.Name = "dtpStartTime";
            dtpStartTime.Size = new Size(206, 27);
            dtpStartTime.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 95);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 3;
            label4.Text = "Start Time :";
            // 
            // dtpEndTime
            // 
            dtpEndTime.Format = DateTimePickerFormat.Time;
            dtpEndTime.Location = new Point(234, 122);
            dtpEndTime.Name = "dtpEndTime";
            dtpEndTime.Size = new Size(211, 27);
            dtpEndTime.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(234, 95);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 5;
            label5.Text = "End Time :";
            // 
            // txtJalaliDate
            // 
            txtJalaliDate.Location = new Point(234, 49);
            txtJalaliDate.Name = "txtJalaliDate";
            txtJalaliDate.ReadOnly = true;
            txtJalaliDate.Size = new Size(211, 27);
            txtJalaliDate.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 410);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 36);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += Save_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(114, 410);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 36);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += Cancel_Click;
            // 
            // EntryEditorForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(464, 453);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtJalaliDate);
            Controls.Add(dtpEndTime);
            Controls.Add(label5);
            Controls.Add(dtpStartTime);
            Controls.Add(label4);
            Controls.Add(dtpDate);
            Controls.Add(label3);
            Controls.Add(txtDescription);
            Controls.Add(label2);
            Controls.Add(txtTitle);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "EntryEditorForm";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Timesheet Entry Editor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTitle;
        private TextBox txtDescription;
        private Label label2;
        private Label label3;
        private DateTimePicker dtpDate;
        private DateTimePicker dtpStartTime;
        private Label label4;
        private DateTimePicker dtpEndTime;
        private Label label5;
        private TextBox txtJalaliDate;
        private Button btnSave;
        private Button btnCancel;
    }
}