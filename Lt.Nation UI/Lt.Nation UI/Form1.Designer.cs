namespace Lt.Nation_UI
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtBxUsername = new System.Windows.Forms.TextBox();
            this.txtBxPassword = new System.Windows.Forms.TextBox();
            this.txtBxEmail = new System.Windows.Forms.TextBox();
            this.txtBxToken = new System.Windows.Forms.TextBox();
            this.btnshowlog = new System.Windows.Forms.Button();
            this.btnShowRegister = new System.Windows.Forms.Button();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBxUsername
            // 
            this.txtBxUsername.Location = new System.Drawing.Point(23, 45);
            this.txtBxUsername.Name = "txtBxUsername";
            this.txtBxUsername.Size = new System.Drawing.Size(327, 20);
            this.txtBxUsername.TabIndex = 0;
            // 
            // txtBxPassword
            // 
            this.txtBxPassword.Location = new System.Drawing.Point(23, 100);
            this.txtBxPassword.Name = "txtBxPassword";
            this.txtBxPassword.Size = new System.Drawing.Size(327, 20);
            this.txtBxPassword.TabIndex = 1;
            // 
            // txtBxEmail
            // 
            this.txtBxEmail.Location = new System.Drawing.Point(23, 146);
            this.txtBxEmail.Name = "txtBxEmail";
            this.txtBxEmail.Size = new System.Drawing.Size(327, 20);
            this.txtBxEmail.TabIndex = 2;
            this.txtBxEmail.Visible = false;
            // 
            // txtBxToken
            // 
            this.txtBxToken.Location = new System.Drawing.Point(23, 198);
            this.txtBxToken.Name = "txtBxToken";
            this.txtBxToken.Size = new System.Drawing.Size(327, 20);
            this.txtBxToken.TabIndex = 3;
            this.txtBxToken.Visible = false;
            // 
            // btnshowlog
            // 
            this.btnshowlog.Location = new System.Drawing.Point(59, 12);
            this.btnshowlog.Name = "btnshowlog";
            this.btnshowlog.Size = new System.Drawing.Size(75, 23);
            this.btnshowlog.TabIndex = 4;
            this.btnshowlog.Text = "Login";
            this.btnshowlog.UseVisualStyleBackColor = true;
            this.btnshowlog.Click += new System.EventHandler(this.Btnshowlog_Click);
            // 
            // btnShowRegister
            // 
            this.btnShowRegister.Location = new System.Drawing.Point(222, 12);
            this.btnShowRegister.Name = "btnShowRegister";
            this.btnShowRegister.Size = new System.Drawing.Size(75, 23);
            this.btnShowRegister.TabIndex = 5;
            this.btnShowRegister.Text = "Register";
            this.btnShowRegister.UseVisualStyleBackColor = true;
            this.btnShowRegister.Click += new System.EventHandler(this.BtnShowRegister_Click);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(147, 250);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(75, 23);
            this.BtnLogin.TabIndex = 6;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(147, 250);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 285);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.btnShowRegister);
            this.Controls.Add(this.btnshowlog);
            this.Controls.Add(this.txtBxToken);
            this.Controls.Add(this.txtBxEmail);
            this.Controls.Add(this.txtBxPassword);
            this.Controls.Add(this.txtBxUsername);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lt. Nations Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxUsername;
        private System.Windows.Forms.TextBox txtBxPassword;
        private System.Windows.Forms.TextBox txtBxEmail;
        private System.Windows.Forms.TextBox txtBxToken;
        private System.Windows.Forms.Button btnshowlog;
        private System.Windows.Forms.Button btnShowRegister;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button btnRegister;
    }
}