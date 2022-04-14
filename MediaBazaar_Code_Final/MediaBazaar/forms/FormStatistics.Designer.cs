namespace MediaBazaar.forms
{
    partial class FormStatistics
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title6 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panelFormsContent = new System.Windows.Forms.Panel();
            this.cbEmployee = new System.Windows.Forms.ComboBox();
            this.chartEmployeesDepartment = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnStatisticsEmp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chartGender = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartHoursWorked = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelFormsContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartEmployeesDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHoursWorked)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFormsContent
            // 
            this.panelFormsContent.Controls.Add(this.cbEmployee);
            this.panelFormsContent.Controls.Add(this.chartEmployeesDepartment);
            this.panelFormsContent.Controls.Add(this.btnStatisticsEmp);
            this.panelFormsContent.Controls.Add(this.label1);
            this.panelFormsContent.Controls.Add(this.chartGender);
            this.panelFormsContent.Controls.Add(this.chartHoursWorked);
            this.panelFormsContent.Location = new System.Drawing.Point(12, 13);
            this.panelFormsContent.Name = "panelFormsContent";
            this.panelFormsContent.Size = new System.Drawing.Size(1619, 629);
            this.panelFormsContent.TabIndex = 0;
            // 
            // cbEmployee
            // 
            this.cbEmployee.FormattingEnabled = true;
            this.cbEmployee.Location = new System.Drawing.Point(39, 161);
            this.cbEmployee.Name = "cbEmployee";
            this.cbEmployee.Size = new System.Drawing.Size(287, 24);
            this.cbEmployee.TabIndex = 34;
            // 
            // chartEmployeesDepartment
            // 
            this.chartEmployeesDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(82)))), ((int)(((byte)(97)))));
            chartArea4.Name = "ChartArea1";
            this.chartEmployeesDepartment.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartEmployeesDepartment.Legends.Add(legend4);
            this.chartEmployeesDepartment.Location = new System.Drawing.Point(858, 289);
            this.chartEmployeesDepartment.Name = "chartEmployeesDepartment";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            series4.Legend = "Legend1";
            series4.Name = "Number of employees per department";
            series4.YValuesPerPoint = 2;
            this.chartEmployeesDepartment.Series.Add(series4);
            this.chartEmployeesDepartment.Size = new System.Drawing.Size(693, 323);
            this.chartEmployeesDepartment.TabIndex = 33;
            this.chartEmployeesDepartment.Text = "chart1";
            title4.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            title4.ForeColor = System.Drawing.Color.White;
            title4.Name = "Title1";
            title4.Text = "Number of employees per department";
            this.chartEmployeesDepartment.Titles.Add(title4);
            // 
            // btnStatisticsEmp
            // 
            this.btnStatisticsEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(10)))), ((int)(((byte)(103)))));
            this.btnStatisticsEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatisticsEmp.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStatisticsEmp.ForeColor = System.Drawing.Color.White;
            this.btnStatisticsEmp.Location = new System.Drawing.Point(345, 156);
            this.btnStatisticsEmp.Name = "btnStatisticsEmp";
            this.btnStatisticsEmp.Size = new System.Drawing.Size(177, 31);
            this.btnStatisticsEmp.TabIndex = 31;
            this.btnStatisticsEmp.Text = "See info";
            this.btnStatisticsEmp.UseVisualStyleBackColor = false;
            this.btnStatisticsEmp.Click += new System.EventHandler(this.btnStatisticsEmp_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 76);
            this.label1.TabIndex = 30;
            this.label1.Text = "Select an employee to see \r\na complete overview ";
            // 
            // chartGender
            // 
            this.chartGender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(82)))), ((int)(((byte)(97)))));
            chartArea5.Name = "ChartArea1";
            this.chartGender.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chartGender.Legends.Add(legend5);
            this.chartGender.Location = new System.Drawing.Point(858, 16);
            this.chartGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartGender.Name = "chartGender";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series5.Legend = "Legend1";
            series5.Name = "Gender";
            this.chartGender.Series.Add(series5);
            this.chartGender.Size = new System.Drawing.Size(693, 244);
            this.chartGender.TabIndex = 29;
            this.chartGender.Text = "chart3";
            title5.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            title5.ForeColor = System.Drawing.Color.White;
            title5.Name = "Title1";
            title5.Text = "Gender Statistics";
            this.chartGender.Titles.Add(title5);
            // 
            // chartHoursWorked
            // 
            this.chartHoursWorked.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(82)))), ((int)(((byte)(97)))));
            chartArea6.Name = "ChartArea1";
            this.chartHoursWorked.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartHoursWorked.Legends.Add(legend6);
            this.chartHoursWorked.Location = new System.Drawing.Point(31, 289);
            this.chartHoursWorked.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartHoursWorked.Name = "chartHoursWorked";
            this.chartHoursWorked.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;
            series6.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            series6.LabelForeColor = System.Drawing.Color.White;
            series6.Legend = "Legend1";
            series6.Name = "Hours Worked";
            series6.XValueMember = "Employee";
            series6.YValueMembers = "Hours Worked";
            series6.YValuesPerPoint = 2;
            this.chartHoursWorked.Series.Add(series6);
            this.chartHoursWorked.Size = new System.Drawing.Size(660, 323);
            this.chartHoursWorked.TabIndex = 28;
            this.chartHoursWorked.Text = "chartHoursWorked";
            title6.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            title6.ForeColor = System.Drawing.Color.White;
            title6.Name = "Title1";
            title6.Text = "Top 4 employees based on hours worked";
            this.chartHoursWorked.Titles.Add(title6);
            // 
            // FormStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1600, 654);
            this.Controls.Add(this.panelFormsContent);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormStatistics";
            this.Text = "FormStatistics";
            this.panelFormsContent.ResumeLayout(false);
            this.panelFormsContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartEmployeesDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHoursWorked)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFormsContent;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEmployeesDepartment;
        private System.Windows.Forms.Button btnStatisticsEmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGender;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHoursWorked;
        private System.Windows.Forms.ComboBox cbEmployee;
    }
}