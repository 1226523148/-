namespace 影院售票管理系统
{
    partial class frmRegisteredId
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblConfirm_password = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblMailbox = new System.Windows.Forms.Label();
            this.lblPassenger = new System.Windows.Forms.Label();
            this.txtbUsername = new System.Windows.Forms.TextBox();
            this.txtbPassword = new System.Windows.Forms.TextBox();
            this.txtbConfirm_password = new System.Windows.Forms.TextBox();
            this.txtbId = new System.Windows.Forms.TextBox();
            this.txtbPhone = new System.Windows.Forms.TextBox();
            this.txtbMailbox = new System.Windows.Forms.TextBox();
            this.txtbName = new System.Windows.Forms.TextBox();
            this.cmbxPassenger = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(35, 33);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(52, 15);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "用户名";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(35, 75);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(67, 15);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "登录密码";
            // 
            // lblConfirm_password
            // 
            this.lblConfirm_password.AutoSize = true;
            this.lblConfirm_password.Location = new System.Drawing.Point(35, 113);
            this.lblConfirm_password.Name = "lblConfirm_password";
            this.lblConfirm_password.Size = new System.Drawing.Size(67, 15);
            this.lblConfirm_password.TabIndex = 2;
            this.lblConfirm_password.Text = "确认密码";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(35, 153);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(52, 15);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "身份证";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(35, 194);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(37, 15);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "姓名";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(35, 265);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(121, 15);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "手机号码（+86）";
            // 
            // lblMailbox
            // 
            this.lblMailbox.AutoSize = true;
            this.lblMailbox.Location = new System.Drawing.Point(35, 228);
            this.lblMailbox.Name = "lblMailbox";
            this.lblMailbox.Size = new System.Drawing.Size(37, 15);
            this.lblMailbox.TabIndex = 6;
            this.lblMailbox.Text = "邮箱";
            // 
            // lblPassenger
            // 
            this.lblPassenger.AutoSize = true;
            this.lblPassenger.Location = new System.Drawing.Point(35, 298);
            this.lblPassenger.Name = "lblPassenger";
            this.lblPassenger.Size = new System.Drawing.Size(67, 15);
            this.lblPassenger.TabIndex = 7;
            this.lblPassenger.Text = "旅客类型";
            // 
            // txtbUsername
            // 
            this.txtbUsername.Enabled = false;
            this.txtbUsername.Font = new System.Drawing.Font("宋体", 7F);
            this.txtbUsername.Location = new System.Drawing.Point(162, 33);
            this.txtbUsername.MaxLength = 30;
            this.txtbUsername.Name = "txtbUsername";
            this.txtbUsername.Size = new System.Drawing.Size(244, 21);
            this.txtbUsername.TabIndex = 9;
            this.txtbUsername.Text = "用户名设置成功后不可修改";
            this.txtbUsername.TextChanged += new System.EventHandler(this.txtbUsername_TextChanged);
            // 
            // txtbPassword
            // 
            this.txtbPassword.Font = new System.Drawing.Font("宋体", 7F);
            this.txtbPassword.Location = new System.Drawing.Point(162, 75);
            this.txtbPassword.Name = "txtbPassword";
            this.txtbPassword.Size = new System.Drawing.Size(244, 21);
            this.txtbPassword.TabIndex = 10;
            this.txtbPassword.Text = "6-20位字母，数字或符号";
            // 
            // txtbConfirm_password
            // 
            this.txtbConfirm_password.Font = new System.Drawing.Font("宋体", 7F);
            this.txtbConfirm_password.Location = new System.Drawing.Point(162, 113);
            this.txtbConfirm_password.Name = "txtbConfirm_password";
            this.txtbConfirm_password.PasswordChar = '*';
            this.txtbConfirm_password.Size = new System.Drawing.Size(244, 21);
            this.txtbConfirm_password.TabIndex = 11;
            this.txtbConfirm_password.Text = "再次输入您的登陆密码";
            // 
            // txtbId
            // 
            this.txtbId.Font = new System.Drawing.Font("宋体", 7F);
            this.txtbId.Location = new System.Drawing.Point(162, 153);
            this.txtbId.Name = "txtbId";
            this.txtbId.PasswordChar = '*';
            this.txtbId.Size = new System.Drawing.Size(244, 21);
            this.txtbId.TabIndex = 13;
            this.txtbId.Text = "请输入身份证号码";
            // 
            // txtbPhone
            // 
            this.txtbPhone.Font = new System.Drawing.Font("宋体", 7F);
            this.txtbPhone.Location = new System.Drawing.Point(162, 265);
            this.txtbPhone.Name = "txtbPhone";
            this.txtbPhone.Size = new System.Drawing.Size(244, 21);
            this.txtbPhone.TabIndex = 14;
            this.txtbPhone.Text = "请输入您的手机号码";
            // 
            // txtbMailbox
            // 
            this.txtbMailbox.Font = new System.Drawing.Font("宋体", 7F);
            this.txtbMailbox.Location = new System.Drawing.Point(162, 228);
            this.txtbMailbox.Name = "txtbMailbox";
            this.txtbMailbox.Size = new System.Drawing.Size(244, 21);
            this.txtbMailbox.TabIndex = 17;
            this.txtbMailbox.Text = "请输入您的邮箱";
            // 
            // txtbName
            // 
            this.txtbName.Font = new System.Drawing.Font("宋体", 7F);
            this.txtbName.Location = new System.Drawing.Point(162, 194);
            this.txtbName.Name = "txtbName";
            this.txtbName.Size = new System.Drawing.Size(244, 21);
            this.txtbName.TabIndex = 18;
            this.txtbName.Text = "请输入姓名";
            // 
            // cmbxPassenger
            // 
            this.cmbxPassenger.FormattingEnabled = true;
            this.cmbxPassenger.Location = new System.Drawing.Point(162, 298);
            this.cmbxPassenger.Name = "cmbxPassenger";
            this.cmbxPassenger.Size = new System.Drawing.Size(244, 23);
            this.cmbxPassenger.TabIndex = 19;
            this.cmbxPassenger.Text = "成人";
            // 
            // frmRegisteredId
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 353);
            this.Controls.Add(this.cmbxPassenger);
            this.Controls.Add(this.txtbName);
            this.Controls.Add(this.txtbMailbox);
            this.Controls.Add(this.txtbPhone);
            this.Controls.Add(this.txtbId);
            this.Controls.Add(this.txtbConfirm_password);
            this.Controls.Add(this.txtbPassword);
            this.Controls.Add(this.txtbUsername);
            this.Controls.Add(this.lblPassenger);
            this.Controls.Add(this.lblMailbox);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblConfirm_password);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsername);
            this.Name = "frmRegisteredId";
            this.Text = "frmRegistered";
            this.Load += new System.EventHandler(this.frmRegistered_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblConfirm_password;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblMailbox;
        private System.Windows.Forms.Label lblPassenger;
        private System.Windows.Forms.TextBox txtbUsername;
        private System.Windows.Forms.TextBox txtbPassword;
        private System.Windows.Forms.TextBox txtbConfirm_password;
        private System.Windows.Forms.TextBox txtbId;
        private System.Windows.Forms.TextBox txtbPhone;
        private System.Windows.Forms.TextBox txtbMailbox;
        private System.Windows.Forms.TextBox txtbName;
        private System.Windows.Forms.ComboBox cmbxPassenger;
    }
}