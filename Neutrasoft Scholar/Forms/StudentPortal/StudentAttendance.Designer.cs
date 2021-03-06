﻿namespace Neutrasoft_Scholar.Forms.StudentPortal
{
    partial class StudentAttendance
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.pnlMyAccount = new System.Windows.Forms.Panel();
            this.llbMyAccount = new System.Windows.Forms.LinkLabel();
            this.pnlLoginHistory = new System.Windows.Forms.Panel();
            this.llbLoginHistory = new System.Windows.Forms.LinkLabel();
            this.pnlExit = new System.Windows.Forms.Panel();
            this.llbExit = new System.Windows.Forms.LinkLabel();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.lblStudentAccess = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlNavigationBarHolder = new System.Windows.Forms.Panel();
            this.pnlNavigationBar = new System.Windows.Forms.Panel();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.btnAttendance = new System.Windows.Forms.Button();
            this.btnGradebook = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.dgvStudentAttendance = new System.Windows.Forms.DataGridView();
            this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PeriodColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExcusedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTop.SuspendLayout();
            this.pnlMyAccount.SuspendLayout();
            this.pnlLoginHistory.SuspendLayout();
            this.pnlExit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlNavigationBarHolder.SuspendLayout();
            this.pnlNavigationBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.pnlMyAccount);
            this.pnlTop.Controls.Add(this.pnlLoginHistory);
            this.pnlTop.Controls.Add(this.pnlExit);
            this.pnlTop.Controls.Add(this.lblStudentName);
            this.pnlTop.Controls.Add(this.lblStudentAccess);
            this.pnlTop.Controls.Add(this.pictureBox1);
            this.pnlTop.Location = new System.Drawing.Point(-2, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1166, 151);
            this.pnlTop.TabIndex = 0;
            // 
            // pnlMyAccount
            // 
            this.pnlMyAccount.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlMyAccount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMyAccount.Controls.Add(this.llbMyAccount);
            this.pnlMyAccount.Location = new System.Drawing.Point(945, 0);
            this.pnlMyAccount.Name = "pnlMyAccount";
            this.pnlMyAccount.Size = new System.Drawing.Size(160, 29);
            this.pnlMyAccount.TabIndex = 5;
            // 
            // llbMyAccount
            // 
            this.llbMyAccount.AutoSize = true;
            this.llbMyAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbMyAccount.Location = new System.Drawing.Point(23, 7);
            this.llbMyAccount.Name = "llbMyAccount";
            this.llbMyAccount.Size = new System.Drawing.Size(114, 20);
            this.llbMyAccount.TabIndex = 1;
            this.llbMyAccount.TabStop = true;
            this.llbMyAccount.Text = "MY ACCOUNT";
            this.llbMyAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbMyAccount_LinkClicked);
            // 
            // pnlLoginHistory
            // 
            this.pnlLoginHistory.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlLoginHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLoginHistory.Controls.Add(this.llbLoginHistory);
            this.pnlLoginHistory.Location = new System.Drawing.Point(798, 0);
            this.pnlLoginHistory.Name = "pnlLoginHistory";
            this.pnlLoginHistory.Size = new System.Drawing.Size(150, 29);
            this.pnlLoginHistory.TabIndex = 4;
            // 
            // llbLoginHistory
            // 
            this.llbLoginHistory.AutoSize = true;
            this.llbLoginHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbLoginHistory.Location = new System.Drawing.Point(5, 7);
            this.llbLoginHistory.Name = "llbLoginHistory";
            this.llbLoginHistory.Size = new System.Drawing.Size(135, 20);
            this.llbLoginHistory.TabIndex = 1;
            this.llbLoginHistory.TabStop = true;
            this.llbLoginHistory.Text = "LOGIN HISTORY";
            this.llbLoginHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbLoginHistory_LinkClicked);
            // 
            // pnlExit
            // 
            this.pnlExit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlExit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlExit.Controls.Add(this.llbExit);
            this.pnlExit.Location = new System.Drawing.Point(1102, 0);
            this.pnlExit.Name = "pnlExit";
            this.pnlExit.Size = new System.Drawing.Size(63, 29);
            this.pnlExit.TabIndex = 4;
            // 
            // llbExit
            // 
            this.llbExit.AutoSize = true;
            this.llbExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbExit.Location = new System.Drawing.Point(8, 7);
            this.llbExit.Name = "llbExit";
            this.llbExit.Size = new System.Drawing.Size(45, 20);
            this.llbExit.TabIndex = 2;
            this.llbExit.TabStop = true;
            this.llbExit.Text = "EXIT";
            this.llbExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbExit_LinkClicked);
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentName.Location = new System.Drawing.Point(189, 95);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(310, 24);
            this.lblStudentName.TabIndex = 2;
            this.lblStudentName.Text = "{FirstName MiddleName LastName}";
            // 
            // lblStudentAccess
            // 
            this.lblStudentAccess.AutoSize = true;
            this.lblStudentAccess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentAccess.Location = new System.Drawing.Point(189, 24);
            this.lblStudentAccess.Name = "lblStudentAccess";
            this.lblStudentAccess.Size = new System.Drawing.Size(141, 24);
            this.lblStudentAccess.TabIndex = 1;
            this.lblStudentAccess.Text = "Student Access";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Neutrasoft_Scholar.Properties.Resources.Neutrasoft_Scholar_Image_Smaller;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 151);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlNavigationBarHolder
            // 
            this.pnlNavigationBarHolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNavigationBarHolder.Controls.Add(this.pnlNavigationBar);
            this.pnlNavigationBarHolder.Location = new System.Drawing.Point(-1, 150);
            this.pnlNavigationBarHolder.Name = "pnlNavigationBarHolder";
            this.pnlNavigationBarHolder.Size = new System.Drawing.Size(212, 655);
            this.pnlNavigationBarHolder.TabIndex = 1;
            // 
            // pnlNavigationBar
            // 
            this.pnlNavigationBar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlNavigationBar.Controls.Add(this.btnSchedule);
            this.pnlNavigationBar.Controls.Add(this.btnAttendance);
            this.pnlNavigationBar.Controls.Add(this.btnGradebook);
            this.pnlNavigationBar.Controls.Add(this.btnHome);
            this.pnlNavigationBar.Location = new System.Drawing.Point(35, 7);
            this.pnlNavigationBar.Name = "pnlNavigationBar";
            this.pnlNavigationBar.Size = new System.Drawing.Size(137, 212);
            this.pnlNavigationBar.TabIndex = 0;
            // 
            // btnSchedule
            // 
            this.btnSchedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchedule.Location = new System.Drawing.Point(-1, 155);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(137, 55);
            this.btnSchedule.TabIndex = 5;
            this.btnSchedule.Text = "Schedule";
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // btnAttendance
            // 
            this.btnAttendance.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAttendance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttendance.Location = new System.Drawing.Point(-1, 103);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Size = new System.Drawing.Size(137, 55);
            this.btnAttendance.TabIndex = 4;
            this.btnAttendance.Text = "Attendance";
            this.btnAttendance.UseVisualStyleBackColor = false;
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            // 
            // btnGradebook
            // 
            this.btnGradebook.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGradebook.Location = new System.Drawing.Point(-1, 51);
            this.btnGradebook.Name = "btnGradebook";
            this.btnGradebook.Size = new System.Drawing.Size(137, 55);
            this.btnGradebook.TabIndex = 3;
            this.btnGradebook.Text = "Gradebook";
            this.btnGradebook.UseVisualStyleBackColor = true;
            this.btnGradebook.Click += new System.EventHandler(this.btnGradebook_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.Control;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(-1, -1);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(137, 55);
            this.btnHome.TabIndex = 2;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // dgvStudentAttendance
            // 
            this.dgvStudentAttendance.AllowUserToAddRows = false;
            this.dgvStudentAttendance.AllowUserToDeleteRows = false;
            this.dgvStudentAttendance.AllowUserToResizeColumns = false;
            this.dgvStudentAttendance.AllowUserToResizeRows = false;
            this.dgvStudentAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudentAttendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateColumn,
            this.PeriodColumn,
            this.StateColumn,
            this.ExcusedColumn});
            this.dgvStudentAttendance.Location = new System.Drawing.Point(209, 150);
            this.dgvStudentAttendance.Name = "dgvStudentAttendance";
            this.dgvStudentAttendance.ReadOnly = true;
            this.dgvStudentAttendance.RowHeadersVisible = false;
            this.dgvStudentAttendance.Size = new System.Drawing.Size(955, 655);
            this.dgvStudentAttendance.TabIndex = 2;
            // 
            // DateColumn
            // 
            this.DateColumn.HeaderText = "Date";
            this.DateColumn.Name = "DateColumn";
            this.DateColumn.ReadOnly = true;
            this.DateColumn.Width = 250;
            // 
            // PeriodColumn
            // 
            this.PeriodColumn.HeaderText = "Period";
            this.PeriodColumn.Name = "PeriodColumn";
            this.PeriodColumn.ReadOnly = true;
            // 
            // StateColumn
            // 
            this.StateColumn.HeaderText = "Absent/Tardy";
            this.StateColumn.Name = "StateColumn";
            this.StateColumn.ReadOnly = true;
            // 
            // ExcusedColumn
            // 
            this.ExcusedColumn.HeaderText = "Excused";
            this.ExcusedColumn.Name = "ExcusedColumn";
            this.ExcusedColumn.ReadOnly = true;
            // 
            // StudentAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 802);
            this.Controls.Add(this.dgvStudentAttendance);
            this.Controls.Add(this.pnlNavigationBarHolder);
            this.Controls.Add(this.pnlTop);
            this.Name = "StudentAttendance";
            this.Text = "Neutrasoft Scholar: Student Attendance";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlMyAccount.ResumeLayout(false);
            this.pnlMyAccount.PerformLayout();
            this.pnlLoginHistory.ResumeLayout(false);
            this.pnlLoginHistory.PerformLayout();
            this.pnlExit.ResumeLayout(false);
            this.pnlExit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlNavigationBarHolder.ResumeLayout(false);
            this.pnlNavigationBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudentAttendance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label lblStudentAccess;
        private System.Windows.Forms.Panel pnlExit;
        private System.Windows.Forms.LinkLabel llbExit;
        private System.Windows.Forms.Panel pnlNavigationBarHolder;
        private System.Windows.Forms.Panel pnlNavigationBar;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnlMyAccount;
        private System.Windows.Forms.LinkLabel llbMyAccount;
        private System.Windows.Forms.Panel pnlLoginHistory;
        private System.Windows.Forms.LinkLabel llbLoginHistory;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.Button btnGradebook;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.DataGridView dgvStudentAttendance;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeriodColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExcusedColumn;
    }
}