namespace MediaBazaar.forms
{
    partial class FormUpdateShift
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
            this.cbShiftsUpdate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdateShift = new System.Windows.Forms.Button();
            this.cbMoment = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbShiftsUpdate
            // 
            this.cbShiftsUpdate.FormattingEnabled = true;
            this.cbShiftsUpdate.Location = new System.Drawing.Point(31, 78);
            this.cbShiftsUpdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbShiftsUpdate.Name = "cbShiftsUpdate";
            this.cbShiftsUpdate.Size = new System.Drawing.Size(480, 24);
            this.cbShiftsUpdate.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Moment of the day:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 33);
            this.label1.TabIndex = 20;
            this.label1.Text = "Select shift";
            // 
            // btnUpdateShift
            // 
            this.btnUpdateShift.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(11)))), ((int)(((byte)(64)))));
            this.btnUpdateShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateShift.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUpdateShift.ForeColor = System.Drawing.Color.White;
            this.btnUpdateShift.Location = new System.Drawing.Point(82, 247);
            this.btnUpdateShift.Name = "btnUpdateShift";
            this.btnUpdateShift.Size = new System.Drawing.Size(363, 35);
            this.btnUpdateShift.TabIndex = 19;
            this.btnUpdateShift.Text = "Update Shift";
            this.btnUpdateShift.UseVisualStyleBackColor = false;
            this.btnUpdateShift.Click += new System.EventHandler(this.btnUpdateShift_Click_1);
            // 
            // cbMoment
            // 
            this.cbMoment.FormattingEnabled = true;
            this.cbMoment.Items.AddRange(new object[] {
            "morning",
            "afternoon",
            "evening"});
            this.cbMoment.Location = new System.Drawing.Point(239, 164);
            this.cbMoment.Name = "cbMoment";
            this.cbMoment.Size = new System.Drawing.Size(272, 24);
            this.cbMoment.TabIndex = 24;
            // 
            // FormUpdateShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(61)))), ((int)(((byte)(83)))));
            this.ClientSize = new System.Drawing.Size(525, 310);
            this.Controls.Add(this.cbMoment);
            this.Controls.Add(this.cbShiftsUpdate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdateShift);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormUpdateShift";
            this.Text = "Update Shift";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbShiftsUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdateShift;
        private System.Windows.Forms.ComboBox cbMoment;
    }
}