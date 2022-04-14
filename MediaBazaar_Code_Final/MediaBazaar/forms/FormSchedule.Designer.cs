namespace MediaBazaar.forms
{
    partial class FormSchedule
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
            this.btnSeeShiftsToday = new System.Windows.Forms.Button();
            this.lblSiftsOn = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.ScheduleTable = new System.Windows.Forms.DataGridView();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbEmployee = new System.Windows.Forms.ComboBox();
            this.btnSeeShiftsOfEmployee = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSeeShifts = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MomentOfTheDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSeeShiftsToday
            // 
            this.btnSeeShiftsToday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(10)))), ((int)(((byte)(103)))));
            this.btnSeeShiftsToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeeShiftsToday.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSeeShiftsToday.ForeColor = System.Drawing.Color.White;
            this.btnSeeShiftsToday.Location = new System.Drawing.Point(470, 185);
            this.btnSeeShiftsToday.Name = "btnSeeShiftsToday";
            this.btnSeeShiftsToday.Size = new System.Drawing.Size(276, 49);
            this.btnSeeShiftsToday.TabIndex = 19;
            this.btnSeeShiftsToday.Text = "See shifts today";
            this.btnSeeShiftsToday.UseVisualStyleBackColor = false;
            this.btnSeeShiftsToday.Click += new System.EventHandler(this.btnSeeShiftsToday_Click);
            // 
            // lblSiftsOn
            // 
            this.lblSiftsOn.AutoSize = true;
            this.lblSiftsOn.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSiftsOn.ForeColor = System.Drawing.Color.White;
            this.lblSiftsOn.Location = new System.Drawing.Point(273, 65);
            this.lblSiftsOn.Name = "lblSiftsOn";
            this.lblSiftsOn.Size = new System.Drawing.Size(125, 33);
            this.lblSiftsOn.TabIndex = 17;
            this.lblSiftsOn.Text = "Shifts on:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(399, 65);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(68, 33);
            this.lblDate.TabIndex = 16;
            this.lblDate.Text = "date";
            // 
            // ScheduleTable
            // 
            this.ScheduleTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(82)))), ((int)(((byte)(97)))));
            this.ScheduleTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScheduleTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cName,
            this.Email,
            this.Date,
            this.MomentOfTheDay,
            this.cDepartment});
            this.ScheduleTable.Location = new System.Drawing.Point(46, 297);
            this.ScheduleTable.Name = "ScheduleTable";
            this.ScheduleTable.RowHeadersWidth = 51;
            this.ScheduleTable.RowTemplate.Height = 24;
            this.ScheduleTable.Size = new System.Drawing.Size(1176, 446);
            this.ScheduleTable.TabIndex = 12;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(10)))), ((int)(((byte)(103)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(572, 57);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(174, 49);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Next  >";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(10)))), ((int)(((byte)(103)))));
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Location = new System.Drawing.Point(46, 58);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(174, 49);
            this.btnPrevious.TabIndex = 0;
            this.btnPrevious.Text = "<  Prevoius";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(82)))), ((int)(((byte)(97)))));
            this.groupBox1.Controls.Add(this.cbEmployee);
            this.groupBox1.Controls.Add(this.btnSeeShiftsOfEmployee);
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(1256, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 303);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee\'s shifts management";
            // 
            // cbEmployee
            // 
            this.cbEmployee.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbEmployee.FormattingEnabled = true;
            this.cbEmployee.Location = new System.Drawing.Point(220, 74);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(259, 27);
            this.cbEmployee.TabIndex = 46;
            // 
            // btnSeeShiftsOfEmployee
            // 
            this.btnSeeShiftsOfEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(10)))), ((int)(((byte)(103)))));
            this.btnSeeShiftsOfEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeeShiftsOfEmployee.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSeeShiftsOfEmployee.ForeColor = System.Drawing.Color.White;
            this.btnSeeShiftsOfEmployee.Location = new System.Drawing.Point(264, 232);
            this.btnSeeShiftsOfEmployee.Name = "btnSeeShiftsOfEmployee";
            this.btnSeeShiftsOfEmployee.Size = new System.Drawing.Size(198, 43);
            this.btnSeeShiftsOfEmployee.TabIndex = 40;
            this.btnSeeShiftsOfEmployee.Text = "See shifts of employee";
            this.btnSeeShiftsOfEmployee.UseVisualStyleBackColor = false;
            this.btnSeeShiftsOfEmployee.Click += new System.EventHandler(this.btnSeeShiftsOfEmployee_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblID.ForeColor = System.Drawing.Color.White;
            this.lblID.Location = new System.Drawing.Point(21, 71);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(182, 26);
            this.lblID.TabIndex = 39;
            this.lblID.Text = "Employee\'s name:";
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(10)))), ((int)(((byte)(103)))));
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(264, 146);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(198, 43);
            this.btnRemove.TabIndex = 37;
            this.btnRemove.Text = "Remove Shift";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(10)))), ((int)(((byte)(103)))));
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(24, 146);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(177, 43);
            this.btnAdd.TabIndex = 36;
            this.btnAdd.Text = "Add Shift";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(10)))), ((int)(((byte)(103)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(24, 232);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(177, 43);
            this.btnUpdate.TabIndex = 38;
            this.btnUpdate.Text = "Update Shift";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(82)))), ((int)(((byte)(97)))));
            this.groupBox2.Controls.Add(this.btnSeeShifts);
            this.groupBox2.Controls.Add(this.monthCalendar1);
            this.groupBox2.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(1270, 375);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(489, 369);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "See the shifts on the selected date";
            // 
            // btnSeeShifts
            // 
            this.btnSeeShifts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(10)))), ((int)(((byte)(103)))));
            this.btnSeeShifts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeeShifts.Font = new System.Drawing.Font("Cambria", 10.8F);
            this.btnSeeShifts.ForeColor = System.Drawing.Color.White;
            this.btnSeeShifts.Location = new System.Drawing.Point(90, 317);
            this.btnSeeShifts.Name = "btnSeeShifts";
            this.btnSeeShifts.Size = new System.Drawing.Size(294, 40);
            this.btnSeeShifts.TabIndex = 1;
            this.btnSeeShifts.Text = "See shifts";
            this.btnSeeShifts.UseVisualStyleBackColor = false;
            this.btnSeeShifts.Click += new System.EventHandler(this.btnSeeShifts_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(90, 43);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Font = new System.Drawing.Font("Cambria", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEmployeeName.ForeColor = System.Drawing.Color.White;
            this.lblEmployeeName.Location = new System.Drawing.Point(51, 177);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(0, 38);
            this.lblEmployeeName.TabIndex = 45;
            // 
            // cName
            // 
            this.cName.HeaderText = "Name";
            this.cName.MinimumWidth = 6;
            this.cName.Name = "cName";
            this.cName.ReadOnly = true;
            this.cName.Width = 150;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 125;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.Width = 125;
            // 
            // MomentOfTheDay
            // 
            this.MomentOfTheDay.HeaderText = "Moment of the day";
            this.MomentOfTheDay.MinimumWidth = 6;
            this.MomentOfTheDay.Name = "MomentOfTheDay";
            this.MomentOfTheDay.Width = 175;
            // 
            // cDepartment
            // 
            this.cDepartment.HeaderText = "Department";
            this.cDepartment.MinimumWidth = 8;
            this.cDepartment.Name = "cDepartment";
            this.cDepartment.Width = 150;
            // 
            // FormSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1800, 817);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.btnSeeShiftsToday);
            this.Controls.Add(this.ScheduleTable);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblSiftsOn);
            this.Controls.Add(this.btnPrevious);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "FormSchedule";
            this.Text = "Employees\' Shifts";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DataGridView ScheduleTable;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblSiftsOn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSeeShifts;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnSeeShiftsOfEmployee;
        private System.Windows.Forms.Button btnSeeShiftsToday;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.ComboBox cbEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn MomentOfTheDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn cDepartment;
    }
}