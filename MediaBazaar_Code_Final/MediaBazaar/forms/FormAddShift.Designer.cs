namespace MediaBazaar.forms
{
    partial class FormAddShift
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
            this.btnAddShift = new System.Windows.Forms.Button();
            this.SelectDateCalendar = new System.Windows.Forms.MonthCalendar();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbMomentOfDay = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAddShift
            // 
            this.btnAddShift.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(11)))), ((int)(((byte)(64)))));
            this.btnAddShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddShift.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddShift.ForeColor = System.Drawing.Color.White;
            this.btnAddShift.Location = new System.Drawing.Point(53, 445);
            this.btnAddShift.Name = "btnAddShift";
            this.btnAddShift.Size = new System.Drawing.Size(262, 31);
            this.btnAddShift.TabIndex = 20;
            this.btnAddShift.Text = "Add Shift";
            this.btnAddShift.UseVisualStyleBackColor = false;
            this.btnAddShift.Click += new System.EventHandler(this.btnAddShift_Click_1);
            // 
            // SelectDateCalendar
            // 
            this.SelectDateCalendar.BackColor = System.Drawing.SystemColors.Info;
            this.SelectDateCalendar.Location = new System.Drawing.Point(53, 213);
            this.SelectDateCalendar.MaxSelectionCount = 1;
            this.SelectDateCalendar.Name = "SelectDateCalendar";
            this.SelectDateCalendar.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(55, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "Select date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(49, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Moment of the day:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 28);
            this.label4.TabIndex = 21;
            this.label4.Text = "New Shift";
            // 
            // cbMomentOfDay
            // 
            this.cbMomentOfDay.FormattingEnabled = true;
            this.cbMomentOfDay.Items.AddRange(new object[] {
            "morning",
            "afternoon",
            "evening"});
            this.cbMomentOfDay.Location = new System.Drawing.Point(53, 120);
            this.cbMomentOfDay.Name = "cbMomentOfDay";
            this.cbMomentOfDay.Size = new System.Drawing.Size(171, 24);
            this.cbMomentOfDay.TabIndex = 22;
            // 
            // FormAddShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(400, 508);
            this.Controls.Add(this.cbMomentOfDay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAddShift);
            this.Controls.Add(this.SelectDateCalendar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormAddShift";
            this.Text = "Add Shift";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddShift;
        private System.Windows.Forms.MonthCalendar SelectDateCalendar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbMomentOfDay;
    }
}