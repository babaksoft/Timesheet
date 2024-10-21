namespace Timesheet.Forms
{
    partial class TimesheetDetailsForm
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            txtName = new System.Windows.Forms.TextBox();
            txtDescription = new System.Windows.Forms.TextBox();
            txtLocation = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            btnOK = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(22, 30);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(56, 20);
            label1.TabIndex = 0;
            label1.Text = "Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(22, 105);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(92, 20);
            label2.TabIndex = 2;
            label2.Text = "Description :";
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(22, 59);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new System.Drawing.Size(470, 27);
            txtName.TabIndex = 1;
            // 
            // txtDescription
            // 
            txtDescription.Location = new System.Drawing.Point(22, 134);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new System.Drawing.Size(470, 120);
            txtDescription.TabIndex = 3;
            // 
            // txtLocation
            // 
            txtLocation.Location = new System.Drawing.Point(22, 304);
            txtLocation.Name = "txtLocation";
            txtLocation.ReadOnly = true;
            txtLocation.Size = new System.Drawing.Size(470, 27);
            txtLocation.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(22, 275);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(73, 20);
            label3.TabIndex = 4;
            label3.Text = "Location :";
            // 
            // btnOK
            // 
            btnOK.Location = new System.Drawing.Point(22, 368);
            btnOK.Name = "btnOK";
            btnOK.Size = new System.Drawing.Size(94, 36);
            btnOK.TabIndex = 6;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            // 
            // TimesheetDetailsForm
            // 
            AcceptButton = btnOK;
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            CancelButton = btnOK;
            ClientSize = new System.Drawing.Size(515, 412);
            Controls.Add(btnOK);
            Controls.Add(txtLocation);
            Controls.Add(label3);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TimesheetDetailsForm";
            ShowInTaskbar = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Timesheet Details";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOK;
    }
}