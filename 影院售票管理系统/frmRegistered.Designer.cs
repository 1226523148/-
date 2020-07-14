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
            this.txtbPassword = new System.Windows.Forms.TextBox();
            this.txtbConfirm_password = new System.Windows.Forms.TextBox();
            this.txtbId = new System.Windows.Forms.TextBox();
            this.txtbPhone = new System.Windows.Forms.TextBox();
            this.txtbMailbox = new System.Windows.Forms.TextBox();
            this.txtbName = new System.Windows.Forms.TextBox();
            this.cmbxPassenger = new System.Windows.Forms.ComboBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtbUsername = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnOut = new System.Windows.Forms.Button();
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
            this.lblPassword.Location = new System.Drawing.Point(35, 102);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(67, 15);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "登录密码";
            // 
            // lblConfirm_password
            // 
            this.lblConfirm_password.AutoSize = true;
            this.lblConfirm_password.Location = new System.Drawing.Point(35, 138);
            this.lblConfirm_password.Name = "lblConfirm_password";
            this.lblConfirm_password.Size = new System.Drawing.Size(67, 15);
            this.lblConfirm_password.TabIndex = 2;
            this.lblConfirm_password.Text = "确认密码";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(35, 177);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(52, 15);
            this.lblID.TabIndex = 3;
            this.lblID.Text = "身份证";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(35, 214);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(37, 15);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "姓名";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(35, 286);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(121, 15);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "手机号码（+86）";
            // 
            // lblMailbox
            // 
            this.lblMailbox.AutoSize = true;
            this.lblMailbox.Location = new System.Drawing.Point(35, 247);
            this.lblMailbox.Name = "lblMailbox";
            this.lblMailbox.Size = new System.Drawing.Size(37, 15);
            this.lblMailbox.TabIndex = 6;
            this.lblMailbox.Text = "邮箱";
            // 
            // lblPassenger
            // 
            this.lblPassenger.AutoSize = true;
            this.lblPassenger.Location = new System.Drawing.Point(35, 316);
            this.lblPassenger.Name = "lblPassenger";
            this.lblPassenger.Size = new System.Drawing.Size(67, 15);
            this.lblPassenger.TabIndex = 7;
            this.lblPassenger.Text = "旅客类型";
            // 
            // txtbPassword
            // 
            this.txtbPassword.Font = new System.Drawing.Font("宋体", 7F);
            this.txtbPassword.Location = new System.Drawing.Point(162, 102);
            this.txtbPassword.Name = "txtbPassword";
            this.txtbPassword.Size = new System.Drawing.Size(244, 21);
            this.txtbPassword.TabIndex = 10;
            this.txtbPassword.TextChanged += new System.EventHandler(this.txtbPassword_TextChanged);
            // 
            // txtbConfirm_password
            // 
            this.txtbConfirm_password.Font = new System.Drawing.Font("宋体", 7F);
            this.txtbConfirm_password.Location = new System.Drawing.Point(162, 138);
            this.txtbConfirm_password.Name = "txtbConfirm_password";
            this.txtbConfirm_password.PasswordChar = '*';
            this.txtbConfirm_password.Size = new System.Drawing.Size(244, 21);
            this.txtbConfirm_password.TabIndex = 11;
            // 
            // txtbId
            // 
            this.txtbId.Font = new System.Drawing.Font("宋体", 7F);
            this.txtbId.Location = new System.Drawing.Point(162, 177);
            this.txtbId.Name = "txtbId";
            this.txtbId.PasswordChar = '*';
            this.txtbId.ReadOnly = true;
            this.txtbId.Size = new System.Drawing.Size(244, 21);
            this.txtbId.TabIndex = 13;
            // 
            // txtbPhone
            // 
            this.txtbPhone.Font = new System.Drawing.Font("宋体", 7F);
            this.txtbPhone.Location = new System.Drawing.Point(162, 280);
            this.txtbPhone.Name = "txtbPhone";
            this.txtbPhone.Size = new System.Drawing.Size(244, 21);
            this.txtbPhone.TabIndex = 14;
            // 
            // txtbMailbox
            // 
            this.txtbMailbox.Font = new System.Drawing.Font("宋体", 7F);
            this.txtbMailbox.Location = new System.Drawing.Point(162, 247);
            this.txtbMailbox.Name = "txtbMailbox";
            this.txtbMailbox.Size = new System.Drawing.Size(244, 21);
            this.txtbMailbox.TabIndex = 17;
            // 
            // txtbName
            // 
            this.txtbName.Font = new System.Drawing.Font("宋体", 7F);
            this.txtbName.Location = new System.Drawing.Point(162, 214);
            this.txtbName.Name = "txtbName";
            this.txtbName.Size = new System.Drawing.Size(244, 21);
            this.txtbName.TabIndex = 18;
            // 
            // cmbxPassenger
            // 
            this.cmbxPassenger.FormattingEnabled = true;
            this.cmbxPassenger.Items.AddRange(new object[] {
            "成人",
            "儿童",
            "学生",
            "残疾军人，伤残人民警察"});
            this.cmbxPassenger.Location = new System.Drawing.Point(162, 313);
            this.cmbxPassenger.Name = "cmbxPassenger";
            this.cmbxPassenger.Size = new System.Drawing.Size(244, 23);
            this.cmbxPassenger.TabIndex = 19;
            this.cmbxPassenger.Text = "成人";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(35, 65);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(37, 15);
            this.lblSex.TabIndex = 20;
            this.lblSex.Text = "性别";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "男",
            "女"});
            this.comboBox1.Location = new System.Drawing.Point(162, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(244, 23);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.Text = "男";
            // 
            // txtbUsername
            // 
            this.txtbUsername.Font = new System.Drawing.Font("宋体", 7F);
            this.txtbUsername.Location = new System.Drawing.Point(162, 33);
            this.txtbUsername.Name = "txtbUsername";
            this.txtbUsername.Size = new System.Drawing.Size(244, 21);
            this.txtbUsername.TabIndex = 22;
            this.txtbUsername.TabStop = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(331, 352);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 32);
            this.btnSubmit.TabIndex = 23;
            this.btnSubmit.Text = "提交";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(38, 352);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(75, 32);
            this.btnOut.TabIndex = 24;
            this.btnOut.Text = "退出";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // frmRegisteredId
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 412);
            this.Controls.Add(this.btnOut);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtbUsername);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.cmbxPassenger);
            this.Controls.Add(this.txtbName);
            this.Controls.Add(this.txtbMailbox);
            this.Controls.Add(this.txtbPhone);
            this.Controls.Add(this.txtbId);
            this.Controls.Add(this.txtbConfirm_password);
            this.Controls.Add(this.txtbPassword);
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
        private System.Windows.Forms.TextBox txtbPassword;
        private System.Windows.Forms.TextBox txtbConfirm_password;
        private System.Windows.Forms.TextBox txtbId;
        private System.Windows.Forms.TextBox txtbPhone;
        private System.Windows.Forms.TextBox txtbMailbox;
        private System.Windows.Forms.TextBox txtbName;
        private System.Windows.Forms.ComboBox cmbxPassenger;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtbUsername;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnOut;
    }
}