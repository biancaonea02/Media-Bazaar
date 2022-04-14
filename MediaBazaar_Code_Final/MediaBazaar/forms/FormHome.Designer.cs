
namespace MediaBazaar.forms
{
    partial class FormHome
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
            this.btnRemoveNews = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNewAnnouncement = new System.Windows.Forms.TextBox();
            this.btnSaveAnnouncements = new System.Windows.Forms.Button();
            this.btnUpdateNews = new System.Windows.Forms.Button();
            this.lbNews = new System.Windows.Forms.ListBox();
            this.lbEmplHoliday = new System.Windows.Forms.ListBox();
            this.lbEmplSick = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRemoveNews
            // 
            this.btnRemoveNews.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(10)))), ((int)(((byte)(103)))));
            this.btnRemoveNews.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveNews.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRemoveNews.ForeColor = System.Drawing.Color.White;
            this.btnRemoveNews.Location = new System.Drawing.Point(1278, 383);
            this.btnRemoveNews.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveNews.Name = "btnRemoveNews";
            this.btnRemoveNews.Size = new System.Drawing.Size(247, 31);
            this.btnRemoveNews.TabIndex = 38;
            this.btnRemoveNews.Text = "Remove selected";
            this.btnRemoveNews.UseVisualStyleBackColor = false;
            this.btnRemoveNews.Click += new System.EventHandler(this.btnRemoveNews_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(10)))), ((int)(((byte)(103)))));
            this.label1.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(149, 342);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 28);
            this.label1.TabIndex = 33;
            this.label1.Text = "          Who\'s out sick          ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(10)))), ((int)(((byte)(103)))));
            this.label3.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(834, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(303, 28);
            this.label3.TabIndex = 35;
            this.label3.Text = "           News - Happening          ";
            // 
            // tbNewAnnouncement
            // 
            this.tbNewAnnouncement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(174)))), ((int)(((byte)(214)))));
            this.tbNewAnnouncement.Location = new System.Drawing.Point(714, 327);
            this.tbNewAnnouncement.Margin = new System.Windows.Forms.Padding(4);
            this.tbNewAnnouncement.Name = "tbNewAnnouncement";
            this.tbNewAnnouncement.Size = new System.Drawing.Size(811, 22);
            this.tbNewAnnouncement.TabIndex = 36;
            // 
            // btnSaveAnnouncements
            // 
            this.btnSaveAnnouncements.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(10)))), ((int)(((byte)(103)))));
            this.btnSaveAnnouncements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveAnnouncements.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSaveAnnouncements.ForeColor = System.Drawing.Color.White;
            this.btnSaveAnnouncements.Location = new System.Drawing.Point(724, 383);
            this.btnSaveAnnouncements.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveAnnouncements.Name = "btnSaveAnnouncements";
            this.btnSaveAnnouncements.Size = new System.Drawing.Size(247, 31);
            this.btnSaveAnnouncements.TabIndex = 39;
            this.btnSaveAnnouncements.Text = "Save announcements";
            this.btnSaveAnnouncements.UseVisualStyleBackColor = false;
            this.btnSaveAnnouncements.Click += new System.EventHandler(this.btnSaveAnnouncements_Click);
            // 
            // btnUpdateNews
            // 
            this.btnUpdateNews.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(10)))), ((int)(((byte)(103)))));
            this.btnUpdateNews.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateNews.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUpdateNews.ForeColor = System.Drawing.Color.White;
            this.btnUpdateNews.Location = new System.Drawing.Point(1002, 383);
            this.btnUpdateNews.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateNews.Name = "btnUpdateNews";
            this.btnUpdateNews.Size = new System.Drawing.Size(247, 31);
            this.btnUpdateNews.TabIndex = 37;
            this.btnUpdateNews.Text = "Update selected";
            this.btnUpdateNews.UseVisualStyleBackColor = false;
            this.btnUpdateNews.Click += new System.EventHandler(this.btnUpdateNews_Click);
            // 
            // lbNews
            // 
            this.lbNews.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(174)))), ((int)(((byte)(214)))));
            this.lbNews.FormattingEnabled = true;
            this.lbNews.ItemHeight = 16;
            this.lbNews.Location = new System.Drawing.Point(714, 102);
            this.lbNews.Margin = new System.Windows.Forms.Padding(4);
            this.lbNews.Name = "lbNews";
            this.lbNews.Size = new System.Drawing.Size(811, 196);
            this.lbNews.TabIndex = 34;
            this.lbNews.SelectedIndexChanged += new System.EventHandler(this.lbNews_SelectedIndexChanged);
            // 
            // lbEmplHoliday
            // 
            this.lbEmplHoliday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(174)))), ((int)(((byte)(214)))));
            this.lbEmplHoliday.FormattingEnabled = true;
            this.lbEmplHoliday.ItemHeight = 16;
            this.lbEmplHoliday.Location = new System.Drawing.Point(70, 93);
            this.lbEmplHoliday.Margin = new System.Windows.Forms.Padding(4);
            this.lbEmplHoliday.Name = "lbEmplHoliday";
            this.lbEmplHoliday.Size = new System.Drawing.Size(445, 180);
            this.lbEmplHoliday.TabIndex = 31;
            // 
            // lbEmplSick
            // 
            this.lbEmplSick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(174)))), ((int)(((byte)(214)))));
            this.lbEmplSick.FormattingEnabled = true;
            this.lbEmplSick.ItemHeight = 16;
            this.lbEmplSick.Location = new System.Drawing.Point(70, 395);
            this.lbEmplSick.Margin = new System.Windows.Forms.Padding(4);
            this.lbEmplSick.Name = "lbEmplSick";
            this.lbEmplSick.Size = new System.Drawing.Size(445, 180);
            this.lbEmplSick.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(10)))), ((int)(((byte)(103)))));
            this.label2.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(106, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 28);
            this.label2.TabIndex = 30;
            this.label2.Text = "           Who\'s on holidays          ";
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1600, 654);
            this.Controls.Add(this.btnRemoveNews);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNewAnnouncement);
            this.Controls.Add(this.btnSaveAnnouncements);
            this.Controls.Add(this.btnUpdateNews);
            this.Controls.Add(this.lbNews);
            this.Controls.Add(this.lbEmplHoliday);
            this.Controls.Add(this.lbEmplSick);
            this.Controls.Add(this.label2);
            this.Name = "FormHome";
            this.Text = "FormHome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRemoveNews;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNewAnnouncement;
        private System.Windows.Forms.Button btnSaveAnnouncements;
        private System.Windows.Forms.Button btnUpdateNews;
        private System.Windows.Forms.ListBox lbNews;
        private System.Windows.Forms.ListBox lbEmplHoliday;
        private System.Windows.Forms.ListBox lbEmplSick;
        private System.Windows.Forms.Label label2;
    }
}