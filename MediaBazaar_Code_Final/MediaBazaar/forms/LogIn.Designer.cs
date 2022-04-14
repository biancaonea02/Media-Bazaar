namespace MediaBazaar.forms
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.btnLogIn = new System.Windows.Forms.Button();
            this.lblWelcomeBack = new System.Windows.Forms.Label();
            this.tbPasswordLogin = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbEmailLogin = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLogIn.ForeColor = System.Drawing.Color.Transparent;
            this.btnLogIn.Location = new System.Drawing.Point(300, 339);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(349, 42);
            this.btnLogIn.TabIndex = 17;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // lblWelcomeBack
            // 
            this.lblWelcomeBack.AutoSize = true;
            this.lblWelcomeBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.lblWelcomeBack.Font = new System.Drawing.Font("Cambria", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWelcomeBack.ForeColor = System.Drawing.Color.White;
            this.lblWelcomeBack.Location = new System.Drawing.Point(224, 73);
            this.lblWelcomeBack.Name = "lblWelcomeBack";
            this.lblWelcomeBack.Size = new System.Drawing.Size(562, 57);
            this.lblWelcomeBack.TabIndex = 18;
            this.lblWelcomeBack.Text = "           Welcome back!          ";
            // 
            // tbPasswordLogin
            // 
            this.tbPasswordLogin.BackColor = System.Drawing.Color.White;
            this.tbPasswordLogin.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPasswordLogin.ForeColor = System.Drawing.Color.Black;
            this.tbPasswordLogin.Location = new System.Drawing.Point(384, 236);
            this.tbPasswordLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPasswordLogin.Name = "tbPasswordLogin";
            this.tbPasswordLogin.PasswordChar = '*';
            this.tbPasswordLogin.Size = new System.Drawing.Size(402, 31);
            this.tbPasswordLogin.TabIndex = 22;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(210, 189);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(106, 33);
            this.lblEmail.TabIndex = 19;
            this.lblEmail.Text = "E-mail:";
            // 
            // tbEmailLogin
            // 
            this.tbEmailLogin.BackColor = System.Drawing.Color.White;
            this.tbEmailLogin.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbEmailLogin.ForeColor = System.Drawing.Color.Black;
            this.tbEmailLogin.Location = new System.Drawing.Point(384, 191);
            this.tbEmailLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbEmailLogin.Name = "tbEmailLogin";
            this.tbEmailLogin.Size = new System.Drawing.Size(402, 31);
            this.tbEmailLogin.TabIndex = 21;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPassword.ForeColor = System.Drawing.Color.Transparent;
            this.lblPassword.Location = new System.Drawing.Point(210, 233);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(147, 33);
            this.lblPassword.TabIndex = 20;
            this.lblPassword.Text = "Password:";
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(979, 465);
            this.Controls.Add(this.lblWelcomeBack);
            this.Controls.Add(this.tbPasswordLogin);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.tbEmailLogin);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.btnLogIn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LogIn";
            this.Text = "Log In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Label lblWelcomeBack;
        private System.Windows.Forms.TextBox tbPasswordLogin;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox tbEmailLogin;
        private System.Windows.Forms.Label lblPassword;
    }
}