namespace UserSessionManagerSIngleton
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.listBoxSession = new System.Windows.Forms.ListBox();
            this.btnCheckSession = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(32, 39);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(75, 13);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Not Logged In";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(32, 82);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(58, 13);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username:";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(32, 111);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(32, 13);
            this.lblRole.TabIndex = 2;
            this.lblRole.Text = "Role:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(132, 79);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 3;
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(132, 108);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(100, 20);
            this.txtRole.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(142, 151);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(142, 180);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // listBoxSession
            // 
            this.listBoxSession.FormattingEnabled = true;
            this.listBoxSession.Location = new System.Drawing.Point(372, 39);
            this.listBoxSession.Name = "listBoxSession";
            this.listBoxSession.Size = new System.Drawing.Size(372, 251);
            this.listBoxSession.TabIndex = 7;
            // 
            // btnCheckSession
            // 
            this.btnCheckSession.Location = new System.Drawing.Point(127, 209);
            this.btnCheckSession.Name = "btnCheckSession";
            this.btnCheckSession.Size = new System.Drawing.Size(90, 23);
            this.btnCheckSession.TabIndex = 8;
            this.btnCheckSession.Text = "Check Session";
            this.btnCheckSession.UseVisualStyleBackColor = true;
            this.btnCheckSession.Click += new System.EventHandler(this.btnCheckSession_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCheckSession);
            this.Controls.Add(this.listBoxSession);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblStatus);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ListBox listBoxSession;
        private System.Windows.Forms.Button btnCheckSession;
    }
}

