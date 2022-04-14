
namespace MediaBazaar.forms
{
    partial class FormSchedulePerDepartment
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
            this.lblDate = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblSiftsOn = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbDepartments = new System.Windows.Forms.ComboBox();
            this.lblDep = new System.Windows.Forms.Label();
            this.ScheduleTable = new System.Windows.Forms.DataGridView();
            this.cName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MomentOfTheDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleTable)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(409, 49);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(57, 28);
            this.lblDate.TabIndex = 20;
            this.lblDate.Text = "date";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(10)))), ((int)(((byte)(103)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(582, 44);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(155, 39);
            this.btnNext.TabIndex = 19;
            this.btnNext.Text = "Next  >";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblSiftsOn
            // 
            this.lblSiftsOn.AutoSize = true;
            this.lblSiftsOn.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSiftsOn.ForeColor = System.Drawing.Color.White;
            this.lblSiftsOn.Location = new System.Drawing.Point(297, 49);
            this.lblSiftsOn.Name = "lblSiftsOn";
            this.lblSiftsOn.Size = new System.Drawing.Size(106, 28);
            this.lblSiftsOn.TabIndex = 21;
            this.lblSiftsOn.Text = "Shifts on:";
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(10)))), ((int)(((byte)(103)))));
            this.btnPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrevious.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Location = new System.Drawing.Point(95, 44);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(155, 39);
            this.btnPrevious.TabIndex = 18;
            this.btnPrevious.Text = "<  Prevoius";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(10)))), ((int)(((byte)(103)))));
            this.label2.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1137, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(414, 28);
            this.label2.TabIndex = 23;
            this.label2.Text = "Select a department to see its schedule:";
            // 
            // cbDepartments
            // 
            this.cbDepartments.FormattingEnabled = true;
            this.cbDepartments.Location = new System.Drawing.Point(1142, 351);
            this.cbDepartments.Name = "cbDepartments";
            this.cbDepartments.Size = new System.Drawing.Size(409, 24);
            this.cbDepartments.TabIndex = 24;
            this.cbDepartments.SelectedIndexChanged += new System.EventHandler(this.cbDepartments_SelectedIndexChanged);
            // 
            // lblDep
            // 
            this.lblDep.AutoSize = true;
            this.lblDep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(10)))), ((int)(((byte)(103)))));
            this.lblDep.Font = new System.Drawing.Font("Cambria", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDep.ForeColor = System.Drawing.Color.White;
            this.lblDep.Location = new System.Drawing.Point(855, 78);
            this.lblDep.Name = "lblDep";
            this.lblDep.Size = new System.Drawing.Size(214, 28);
            this.lblDep.TabIndex = 25;
            this.lblDep.Text = "SALES Department";
            // 
            // ScheduleTable
            // 
            this.ScheduleTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(82)))), ((int)(((byte)(97)))));
            this.ScheduleTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScheduleTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cName,
            this.Email,
            this.Date,
            this.MomentOfTheDay});
            this.ScheduleTable.Location = new System.Drawing.Point(95, 121);
            this.ScheduleTable.Name = "ScheduleTable";
            this.ScheduleTable.RowHeadersWidth = 51;
            this.ScheduleTable.RowTemplate.Height = 24;
            this.ScheduleTable.Size = new System.Drawing.Size(974, 501);
            this.ScheduleTable.TabIndex = 26;
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
            // FormSchedulePerDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1600, 654);
            this.Controls.Add(this.ScheduleTable);
            this.Controls.Add(this.lblDep);
            this.Controls.Add(this.cbDepartments);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblSiftsOn);
            this.Controls.Add(this.btnPrevious);
            this.Name = "FormSchedulePerDepartment";
            this.Text = "FormSchedulePerDepartment";
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblSiftsOn;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDepartments;
        private System.Windows.Forms.Label lblDep;
        private System.Windows.Forms.DataGridView ScheduleTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn cName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn MomentOfTheDay;
    }
}