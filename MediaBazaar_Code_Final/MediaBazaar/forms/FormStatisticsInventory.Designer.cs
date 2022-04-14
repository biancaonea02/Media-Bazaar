
namespace MediaBazaar.forms
{
    partial class FormStatisticsInventory
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title7 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title8 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title9 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.panelFormsContent = new System.Windows.Forms.Panel();
            this.btnStatisticsCategory = new System.Windows.Forms.Button();
            this.cbCategories = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chartQuantSold = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTopQuantity = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartCategoryQuantity = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelFormsContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartQuantSold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCategoryQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // panelFormsContent
            // 
            this.panelFormsContent.Controls.Add(this.btnStatisticsCategory);
            this.panelFormsContent.Controls.Add(this.cbCategories);
            this.panelFormsContent.Controls.Add(this.label1);
            this.panelFormsContent.Controls.Add(this.chartQuantSold);
            this.panelFormsContent.Controls.Add(this.chartTopQuantity);
            this.panelFormsContent.Controls.Add(this.chartCategoryQuantity);
            this.panelFormsContent.Location = new System.Drawing.Point(2, 2);
            this.panelFormsContent.Name = "panelFormsContent";
            this.panelFormsContent.Size = new System.Drawing.Size(1593, 651);
            this.panelFormsContent.TabIndex = 0;
            // 
            // btnStatisticsCategory
            // 
            this.btnStatisticsCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(10)))), ((int)(((byte)(103)))));
            this.btnStatisticsCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatisticsCategory.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStatisticsCategory.ForeColor = System.Drawing.Color.White;
            this.btnStatisticsCategory.Location = new System.Drawing.Point(394, 163);
            this.btnStatisticsCategory.Name = "btnStatisticsCategory";
            this.btnStatisticsCategory.Size = new System.Drawing.Size(159, 31);
            this.btnStatisticsCategory.TabIndex = 22;
            this.btnStatisticsCategory.Text = "See info";
            this.btnStatisticsCategory.UseVisualStyleBackColor = false;
            this.btnStatisticsCategory.Click += new System.EventHandler(this.btnStatisticsCategory_Click_1);
            // 
            // cbCategories
            // 
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.Items.AddRange(new object[] {
            "LAPTOPS",
            "SPEAKERS",
            "GAMES",
            "CONSOLES",
            "HEADPHONE",
            "CABLES",
            "CHARGERS",
            "ACCESSORIES"});
            this.cbCategories.Location = new System.Drawing.Point(101, 168);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(278, 24);
            this.cbCategories.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(95, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 76);
            this.label1.TabIndex = 20;
            this.label1.Text = "Select a category to see\r\n its complete overview";
            // 
            // chartQuantSold
            // 
            this.chartQuantSold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(82)))), ((int)(((byte)(97)))));
            chartArea7.Name = "ChartArea1";
            this.chartQuantSold.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chartQuantSold.Legends.Add(legend7);
            this.chartQuantSold.Location = new System.Drawing.Point(865, 38);
            this.chartQuantSold.Name = "chartQuantSold";
            this.chartQuantSold.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "Products sold";
            this.chartQuantSold.Series.Add(series7);
            this.chartQuantSold.Size = new System.Drawing.Size(687, 268);
            this.chartQuantSold.TabIndex = 19;
            title7.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            title7.ForeColor = System.Drawing.Color.White;
            title7.Name = "Title1";
            title7.Text = "Number of sold products per category";
            this.chartQuantSold.Titles.Add(title7);
            // 
            // chartTopQuantity
            // 
            this.chartTopQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(82)))), ((int)(((byte)(97)))));
            chartArea8.Name = "ChartArea1";
            this.chartTopQuantity.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chartTopQuantity.Legends.Add(legend8);
            this.chartTopQuantity.Location = new System.Drawing.Point(865, 359);
            this.chartTopQuantity.Name = "chartTopQuantity";
            this.chartTopQuantity.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.Legend = "Legend1";
            series8.Name = "Quantity";
            this.chartTopQuantity.Series.Add(series8);
            this.chartTopQuantity.Size = new System.Drawing.Size(687, 268);
            this.chartTopQuantity.TabIndex = 18;
            this.chartTopQuantity.Text = "chartBestSeller";
            title8.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            title8.ForeColor = System.Drawing.Color.White;
            title8.Name = "Title1";
            title8.Text = "Top 5 Products based on the quantity";
            this.chartTopQuantity.Titles.Add(title8);
            // 
            // chartCategoryQuantity
            // 
            this.chartCategoryQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(82)))), ((int)(((byte)(97)))));
            chartArea9.Name = "ChartArea1";
            this.chartCategoryQuantity.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chartCategoryQuantity.Legends.Add(legend9);
            this.chartCategoryQuantity.Location = new System.Drawing.Point(101, 259);
            this.chartCategoryQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chartCategoryQuantity.Name = "chartCategoryQuantity";
            this.chartCategoryQuantity.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series9.Legend = "Legend1";
            series9.Name = "CategoryQuantity";
            series9.YValuesPerPoint = 4;
            this.chartCategoryQuantity.Series.Add(series9);
            this.chartCategoryQuantity.Size = new System.Drawing.Size(534, 368);
            this.chartCategoryQuantity.TabIndex = 17;
            this.chartCategoryQuantity.Text = "chart1";
            title9.Font = new System.Drawing.Font("Cambria", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            title9.ForeColor = System.Drawing.Color.White;
            title9.Name = "Title1";
            title9.Text = "Number of products from each category";
            this.chartCategoryQuantity.Titles.Add(title9);
            // 
            // FormStatisticsInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1600, 654);
            this.Controls.Add(this.panelFormsContent);
            this.Name = "FormStatisticsInventory";
            this.Text = "Inventory Statistics";
            this.panelFormsContent.ResumeLayout(false);
            this.panelFormsContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartQuantSold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTopQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartCategoryQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelFormsContent;
        private System.Windows.Forms.Button btnStatisticsCategory;
        private System.Windows.Forms.ComboBox cbCategories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartQuantSold;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTopQuantity;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCategoryQuantity;
    }
}