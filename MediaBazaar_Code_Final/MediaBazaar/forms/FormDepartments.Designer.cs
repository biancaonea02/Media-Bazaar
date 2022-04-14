
namespace MediaBazaar.forms
{
    partial class FormDepartments
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewAllDepartments = new System.Windows.Forms.Button();
            this.btnUpdateDepartment = new System.Windows.Forms.Button();
            this.btnRemoveDepartment = new System.Windows.Forms.Button();
            this.btnAddDepartment = new System.Windows.Forms.Button();
            this.tbSearchDepartment = new System.Windows.Forms.TextBox();
            this.lbDepartments = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(70, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 38);
            this.label2.TabIndex = 56;
            this.label2.Text = "All departments";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(10)))), ((int)(((byte)(103)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(805, 81);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(301, 33);
            this.btnSearch.TabIndex = 55;
            this.btnSearch.Text = "Search by Department Name";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(70, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 38);
            this.label1.TabIndex = 54;
            this.label1.Text = "Search department";
            // 
            // btnViewAllDepartments
            // 
            this.btnViewAllDepartments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(10)))), ((int)(((byte)(103)))));
            this.btnViewAllDepartments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAllDepartments.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAllDepartments.ForeColor = System.Drawing.Color.White;
            this.btnViewAllDepartments.Location = new System.Drawing.Point(77, 519);
            this.btnViewAllDepartments.Name = "btnViewAllDepartments";
            this.btnViewAllDepartments.Size = new System.Drawing.Size(258, 38);
            this.btnViewAllDepartments.TabIndex = 53;
            this.btnViewAllDepartments.Text = "View All Departments";
            this.btnViewAllDepartments.UseVisualStyleBackColor = false;
            this.btnViewAllDepartments.Click += new System.EventHandler(this.btnViewAllDepartments_Click);
            // 
            // btnUpdateDepartment
            // 
            this.btnUpdateDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(10)))), ((int)(((byte)(103)))));
            this.btnUpdateDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateDepartment.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDepartment.ForeColor = System.Drawing.Color.White;
            this.btnUpdateDepartment.Location = new System.Drawing.Point(1241, 519);
            this.btnUpdateDepartment.Name = "btnUpdateDepartment";
            this.btnUpdateDepartment.Size = new System.Drawing.Size(258, 38);
            this.btnUpdateDepartment.TabIndex = 52;
            this.btnUpdateDepartment.Text = "Update selected department\r\n";
            this.btnUpdateDepartment.UseVisualStyleBackColor = false;
            this.btnUpdateDepartment.Click += new System.EventHandler(this.btnUpdateDepartment_Click);
            // 
            // btnRemoveDepartment
            // 
            this.btnRemoveDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(10)))), ((int)(((byte)(103)))));
            this.btnRemoveDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveDepartment.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveDepartment.ForeColor = System.Drawing.Color.White;
            this.btnRemoveDepartment.Location = new System.Drawing.Point(848, 519);
            this.btnRemoveDepartment.Name = "btnRemoveDepartment";
            this.btnRemoveDepartment.Size = new System.Drawing.Size(258, 38);
            this.btnRemoveDepartment.TabIndex = 51;
            this.btnRemoveDepartment.Text = "Remove selected department";
            this.btnRemoveDepartment.UseVisualStyleBackColor = false;
            this.btnRemoveDepartment.Click += new System.EventHandler(this.btnRemoveDepartment_Click);
            // 
            // btnAddDepartment
            // 
            this.btnAddDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(10)))), ((int)(((byte)(103)))));
            this.btnAddDepartment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDepartment.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDepartment.ForeColor = System.Drawing.Color.White;
            this.btnAddDepartment.Location = new System.Drawing.Point(445, 519);
            this.btnAddDepartment.Name = "btnAddDepartment";
            this.btnAddDepartment.Size = new System.Drawing.Size(258, 38);
            this.btnAddDepartment.TabIndex = 50;
            this.btnAddDepartment.Text = "Add department";
            this.btnAddDepartment.UseVisualStyleBackColor = false;
            this.btnAddDepartment.Click += new System.EventHandler(this.btnAddDepartment_Click);
            // 
            // tbSearchDepartment
            // 
            this.tbSearchDepartment.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchDepartment.Location = new System.Drawing.Point(77, 87);
            this.tbSearchDepartment.Name = "tbSearchDepartment";
            this.tbSearchDepartment.Size = new System.Drawing.Size(644, 27);
            this.tbSearchDepartment.TabIndex = 49;
            this.tbSearchDepartment.Text = "Search";
            // 
            // lbDepartments
            // 
            this.lbDepartments.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbDepartments.FormattingEnabled = true;
            this.lbDepartments.HorizontalScrollbar = true;
            this.lbDepartments.ItemHeight = 27;
            this.lbDepartments.Location = new System.Drawing.Point(77, 206);
            this.lbDepartments.Name = "lbDepartments";
            this.lbDepartments.ScrollAlwaysVisible = true;
            this.lbDepartments.Size = new System.Drawing.Size(1422, 274);
            this.lbDepartments.TabIndex = 48;
            // 
            // FormDepartments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1600, 654);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnViewAllDepartments);
            this.Controls.Add(this.btnUpdateDepartment);
            this.Controls.Add(this.btnRemoveDepartment);
            this.Controls.Add(this.btnAddDepartment);
            this.Controls.Add(this.tbSearchDepartment);
            this.Controls.Add(this.lbDepartments);
            this.Name = "FormDepartments";
            this.Text = "FormDepartments";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewAllDepartments;
        private System.Windows.Forms.Button btnUpdateDepartment;
        private System.Windows.Forms.Button btnRemoveDepartment;
        private System.Windows.Forms.Button btnAddDepartment;
        private System.Windows.Forms.TextBox tbSearchDepartment;
        private System.Windows.Forms.ListBox lbDepartments;
    }
}