
namespace MediaBazaar.forms
{
    partial class FormStatisticsEmployee
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblFree = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblWage = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chartAttendence = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAbsent = new System.Windows.Forms.Label();
            this.cbPeriod = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblLate = new System.Windows.Forms.Label();
            this.lblPresent = new System.Windows.Forms.Label();
            this.lblDep = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnTextFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartAttendence)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(10)))), ((int)(((byte)(103)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(43, 319);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(133, 33);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "<Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblFree
            // 
            this.lblFree.AutoSize = true;
            this.lblFree.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblFree.ForeColor = System.Drawing.Color.White;
            this.lblFree.Location = new System.Drawing.Point(337, 213);
            this.lblFree.Name = "lblFree";
            this.lblFree.Size = new System.Drawing.Size(62, 23);
            this.lblFree.TabIndex = 22;
            this.lblFree.Text = "label9";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHours.ForeColor = System.Drawing.Color.White;
            this.lblHours.Location = new System.Drawing.Point(337, 173);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(62, 23);
            this.lblHours.TabIndex = 21;
            this.lblHours.Text = "label8";
            // 
            // lblWage
            // 
            this.lblWage.AutoSize = true;
            this.lblWage.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWage.ForeColor = System.Drawing.Color.White;
            this.lblWage.Location = new System.Drawing.Point(337, 133);
            this.lblWage.Name = "lblWage";
            this.lblWage.Size = new System.Drawing.Size(62, 23);
            this.lblWage.TabIndex = 20;
            this.lblWage.Text = "label7";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(337, 94);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(62, 23);
            this.lblEmail.TabIndex = 19;
            this.lblEmail.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(53, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 23);
            this.label5.TabIndex = 18;
            this.label5.Text = "Hours worked:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(53, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 23);
            this.label4.TabIndex = 17;
            this.label4.Text = "Free days:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(53, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 23);
            this.label3.TabIndex = 16;
            this.label3.Text = "Hourly wage:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(53, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 23);
            this.label2.TabIndex = 15;
            this.label2.Text = "E-mail:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(52, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 28);
            this.label1.TabIndex = 14;
            this.label1.Text = "label1";
            // 
            // chartAttendence
            // 
            this.chartAttendence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(82)))), ((int)(((byte)(97)))));
            chartArea1.Name = "ChartArea1";
            this.chartAttendence.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartAttendence.Legends.Add(legend1);
            this.chartAttendence.Location = new System.Drawing.Point(749, 295);
            this.chartAttendence.Name = "chartAttendence";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(50)))), ((int)(((byte)(158)))));
            series1.LabelForeColor = System.Drawing.Color.White;
            series1.Legend = "Legend1";
            series1.Name = "Present";
            series1.ShadowColor = System.Drawing.Color.White;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(171)))), ((int)(((byte)(115)))));
            series2.Legend = "Legend1";
            series2.Name = "Absent";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            series3.Legend = "Legend1";
            series3.Name = "Late";
            series3.YValuesPerPoint = 2;
            this.chartAttendence.Series.Add(series1);
            this.chartAttendence.Series.Add(series2);
            this.chartAttendence.Series.Add(series3);
            this.chartAttendence.Size = new System.Drawing.Size(747, 327);
            this.chartAttendence.TabIndex = 24;
            this.chartAttendence.Text = "chart2";
            title1.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            title1.ForeColor = System.Drawing.Color.White;
            title1.Name = "Title1";
            title1.Text = "Attendence for the last 5 weeks";
            this.chartAttendence.Titles.Add(title1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(82)))), ((int)(((byte)(97)))));
            this.groupBox1.Controls.Add(this.lblAbsent);
            this.groupBox1.Controls.Add(this.cbPeriod);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblLate);
            this.groupBox1.Controls.Add(this.lblPresent);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(749, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(747, 189);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Attendence";
            // 
            // lblAbsent
            // 
            this.lblAbsent.AutoSize = true;
            this.lblAbsent.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAbsent.Location = new System.Drawing.Point(540, 138);
            this.lblAbsent.Name = "lblAbsent";
            this.lblAbsent.Size = new System.Drawing.Size(69, 22);
            this.lblAbsent.TabIndex = 8;
            this.lblAbsent.Text = "Absent:";
            // 
            // cbPeriod
            // 
            this.cbPeriod.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbPeriod.FormattingEnabled = true;
            this.cbPeriod.Items.AddRange(new object[] {
            "Last week",
            "Last 2 weeks"});
            this.cbPeriod.Location = new System.Drawing.Point(27, 76);
            this.cbPeriod.Name = "cbPeriod";
            this.cbPeriod.Size = new System.Drawing.Size(660, 29);
            this.cbPeriod.TabIndex = 1;
            this.cbPeriod.SelectedIndexChanged += new System.EventHandler(this.cbPeriod_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(25, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Period:";
            // 
            // lblLate
            // 
            this.lblLate.AutoSize = true;
            this.lblLate.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLate.Location = new System.Drawing.Point(301, 138);
            this.lblLate.Name = "lblLate";
            this.lblLate.Size = new System.Drawing.Size(51, 22);
            this.lblLate.TabIndex = 7;
            this.lblLate.Text = "Late:";
            // 
            // lblPresent
            // 
            this.lblPresent.AutoSize = true;
            this.lblPresent.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPresent.Location = new System.Drawing.Point(26, 138);
            this.lblPresent.Name = "lblPresent";
            this.lblPresent.Size = new System.Drawing.Size(76, 22);
            this.lblPresent.TabIndex = 2;
            this.lblPresent.Text = "Present:";
            // 
            // lblDep
            // 
            this.lblDep.AutoSize = true;
            this.lblDep.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblDep.ForeColor = System.Drawing.Color.White;
            this.lblDep.Location = new System.Drawing.Point(337, 259);
            this.lblDep.Name = "lblDep";
            this.lblDep.Size = new System.Drawing.Size(62, 23);
            this.lblDep.TabIndex = 28;
            this.lblDep.Text = "label9";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(53, 259);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 23);
            this.label10.TabIndex = 27;
            this.label10.Text = "Department:";
            // 
            // btnTextFile
            // 
            this.btnTextFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(10)))), ((int)(((byte)(103)))));
            this.btnTextFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTextFile.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnTextFile.ForeColor = System.Drawing.Color.White;
            this.btnTextFile.Location = new System.Drawing.Point(280, 319);
            this.btnTextFile.Name = "btnTextFile";
            this.btnTextFile.Size = new System.Drawing.Size(345, 33);
            this.btnTextFile.TabIndex = 29;
            this.btnTextFile.Text = "Save overview";
            this.btnTextFile.UseVisualStyleBackColor = false;
            this.btnTextFile.Click += new System.EventHandler(this.btnTextFile_Click);
            // 
            // FormStatisticsEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1600, 654);
            this.Controls.Add(this.btnTextFile);
            this.Controls.Add(this.lblDep);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chartAttendence);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblFree);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblWage);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormStatisticsEmployee";
            this.Text = "FormStatisticsEmployee";
            ((System.ComponentModel.ISupportInitialize)(this.chartAttendence)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblFree;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblWage;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAttendence;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPresent;
        private System.Windows.Forms.ComboBox cbPeriod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDep;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnTextFile;
        private System.Windows.Forms.Label lblAbsent;
        private System.Windows.Forms.Label lblLate;
    }
}