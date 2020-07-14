namespace 影院售票管理系统
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.txtbUserpassword = new System.Windows.Forms.TextBox();
            this.lblUserpassword = new System.Windows.Forms.Label();
            this.txtbUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnOut = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRegistered = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbUserpassword
            // 
            this.txtbUserpassword.Location = new System.Drawing.Point(207, 85);
            this.txtbUserpassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtbUserpassword.Name = "txtbUserpassword";
            this.txtbUserpassword.PasswordChar = '*';
            this.txtbUserpassword.Size = new System.Drawing.Size(233, 25);
            this.txtbUserpassword.TabIndex = 12;
            // 
            // lblUserpassword
            // 
            this.lblUserpassword.AutoSize = true;
            this.lblUserpassword.BackColor = System.Drawing.Color.White;
            this.lblUserpassword.Location = new System.Drawing.Point(60, 90);
            this.lblUserpassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserpassword.Name = "lblUserpassword";
            this.lblUserpassword.Size = new System.Drawing.Size(75, 15);
            this.lblUserpassword.TabIndex = 16;
            this.lblUserpassword.Text = "用户密码:";
            // 
            // txtbUsername
            // 
            this.txtbUsername.Location = new System.Drawing.Point(207, 24);
            this.txtbUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtbUsername.Name = "txtbUsername";
            this.txtbUsername.Size = new System.Drawing.Size(233, 25);
            this.txtbUsername.TabIndex = 11;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(60, 29);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(75, 15);
            this.lblUsername.TabIndex = 14;
            this.lblUsername.Text = "用户名称:";
            // 
            // btnOut
            // 
            this.btnOut.Image = ((System.Drawing.Image)(resources.GetObject("btnOut.Image")));
            this.btnOut.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOut.Location = new System.Drawing.Point(340, 143);
            this.btnOut.Margin = new System.Windows.Forms.Padding(4);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(100, 29);
            this.btnOut.TabIndex = 15;
            this.btnOut.Text = "退出";
            this.btnOut.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogin.Location = new System.Drawing.Point(48, 143);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(100, 29);
            this.btnLogin.TabIndex = 13;
            this.btnLogin.Text = "登录";
            this.btnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRegistered
            // 
            this.btnRegistered.Location = new System.Drawing.Point(187, 143);
            this.btnRegistered.Name = "btnRegistered";
            this.btnRegistered.Size = new System.Drawing.Size(100, 29);
            this.btnRegistered.TabIndex = 17;
            this.btnRegistered.Text = "注册";
            this.btnRegistered.UseVisualStyleBackColor = true;
            this.btnRegistered.Click += new System.EventHandler(this.btnRegistered_Click);
            this.btnRegistered.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnRegistered_KeyDown);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 216);
            this.Controls.Add(this.btnRegistered);
            this.Controls.Add(this.txtbUserpassword);
            this.Controls.Add(this.lblUserpassword);
            this.Controls.Add(this.txtbUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnLogin);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "登录";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbUserpassword;
        private System.Windows.Forms.Label lblUserpassword;
        private System.Windows.Forms.TextBox txtbUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnOut;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnRegistered;
    }
}