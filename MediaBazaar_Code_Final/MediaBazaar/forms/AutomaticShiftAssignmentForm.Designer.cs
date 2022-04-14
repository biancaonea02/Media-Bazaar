namespace MediaBazaar.forms
{
    partial class AutomaticShiftAssignmentForm
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
            this.gbAutomaticShiftAssignment = new System.Windows.Forms.GroupBox();
            this.btnAutomaticallyAssign = new System.Windows.Forms.Button();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.calendarStartDate = new System.Windows.Forms.MonthCalendar();
            this.gbAutomaticShiftAssignment.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAutomaticShiftAssignment
            // 
            this.gbAutomaticShiftAssignment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(82)))), ((int)(((byte)(97)))));
            this.gbAutomaticShiftAssignment.Controls.Add(this.btnAutomaticallyAssign);
            this.gbAutomaticShiftAssignment.Controls.Add(this.lblStartDate);
            this.gbAutomaticShiftAssignment.Controls.Add(this.calendarStartDate);
            this.gbAutomaticShiftAssignment.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbAutomaticShiftAssignment.ForeColor = System.Drawing.Color.White;
            this.gbAutomaticShiftAssignment.Location = new System.Drawing.Point(205, 85);
            this.gbAutomaticShiftAssignment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbAutomaticShiftAssignment.Name = "gbAutomaticShiftAssignment";
            this.gbAutomaticShiftAssignment.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbAutomaticShiftAssignment.Size = new System.Drawing.Size(983, 595);
            this.gbAutomaticShiftAssignment.TabIndex = 43;
            this.gbAutomaticShiftAssignment.TabStop = false;
            this.gbAutomaticShiftAssignment.Text = "Automatically assign shifts";
            // 
            // btnAutomaticallyAssign
            // 
            this.btnAutomaticallyAssign.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(10)))), ((int)(((byte)(103)))));
            this.btnAutomaticallyAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutomaticallyAssign.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAutomaticallyAssign.ForeColor = System.Drawing.Color.White;
            this.btnAutomaticallyAssign.Location = new System.Drawing.Point(314, 478);
            this.btnAutomaticallyAssign.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAutomaticallyAssign.Name = "btnAutomaticallyAssign";
            this.btnAutomaticallyAssign.Size = new System.Drawing.Size(353, 62);
            this.btnAutomaticallyAssign.TabIndex = 39;
            this.btnAutomaticallyAssign.Text = "Assign";
            this.btnAutomaticallyAssign.UseVisualStyleBackColor = false;
            this.btnAutomaticallyAssign.Click += new System.EventHandler(this.btnAutomaticallyAssign_Click);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(332, 120);
            this.lblStartDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(114, 26);
            this.lblStartDate.TabIndex = 2;
            this.lblStartDate.Text = "Start Date";
            // 
            // calendarStartDate
            // 
            this.calendarStartDate.Location = new System.Drawing.Point(337, 161);
            this.calendarStartDate.Margin = new System.Windows.Forms.Padding(14, 14, 14, 14);
            this.calendarStartDate.Name = "calendarStartDate";
            this.calendarStartDate.TabIndex = 0;
            // 
            // AutomaticShiftAssignmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1394, 759);
            this.Controls.Add(this.gbAutomaticShiftAssignment);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AutomaticShiftAssignmentForm";
            this.Text = "AutomaticShiftAssignmentForm";
            this.gbAutomaticShiftAssignment.ResumeLayout(false);
            this.gbAutomaticShiftAssignment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAutomaticShiftAssignment;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.MonthCalendar calendarStartDate;
        private System.Windows.Forms.Button btnAutomaticallyAssign;
    }
}