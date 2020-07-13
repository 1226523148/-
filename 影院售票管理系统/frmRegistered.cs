using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 影院售票管理系统
{
    public partial class frmRegisteredId : Form
    {
        public frmRegisteredId()
        {
            InitializeComponent();
        }

        private void txtbUsername_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// FrmValidate_Load()。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       
        private void frmRegistered_Load(object sender, EventArgs e)
        {
       
            {
                //用户名最多允许输入10位。
                this.txtbUsername.MaxLength = 10;
                //密码最多允许输入15位。
                this.txtbPassword.MaxLength = 15;
                this.txtbConfirm_password.MaxLength = 15;

                this.txtbUsername.Text = "创建后不可更改";
                this.txtbConfirm_password.Text = " ";
                this.txtbConfirm_password.Text = " ";
            }


        }

        /// <summary>
        /// txtUName_TextChanged()。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private bool f_IsNoUName = false;       //标识用户名是否为空。
        private bool f_IsUNameMouseClick = false;       //标识用户名输入框是否触发了MouseClick事件。

        private bool f_IsNoUPwd = false;       //标识密码是否为空。
        private bool f_IsUPwdMouseClick = false;       //标识密码输入框是否触发了MouseClick事件。

        private void txtUName_TextChanged(object sender, EventArgs e)
      
        {
            //获取用户名长度。
            int uNameLength = this.txtbUsername.Text.Trim().Length;

            if (!f_IsUNameMouseClick)       //如果未触发MouseClick事件。
            {
                if (uNameLength == 0)       //如果用户名输入框为空。
                {
                    f_IsNoUName = true;
                    this.txtbUsername.Text = "最少1位，最多10位";
                    this.txtbUsername.Font = new Font("宋体", 9, FontStyle.Italic);
                    this.txtbUsername.ForeColor = ColorTranslator.FromHtml("#666666");
                }
            }
        }


        /// <summary>
        /// txtUName_MouseClick()。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtUName_MouseClick(object sender, MouseEventArgs e)
        {
            if (f_IsNoUName)        //如果用户名为空。
            {
                //标识触发了MouseClick事件。
                f_IsUNameMouseClick = true;
                this.txtbUsername.Text = "";
            }
        }


        /// <summary>
        /// txtUName_Leave()。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtbUsername_Leave(object sender, EventArgs e)
        {
            //获取用户名长度。
            int uNameLength = this.txtbUsername.Text.Trim().Length;

            if (uNameLength == 0)       //如果用户名输入框为空。
            {
                //标识用户名为空。
                f_IsNoUName = true;
                this.txtbUsername.Text = "最少1位，最多10位";
                this.txtbUsername.Font = new Font("宋体", 9, FontStyle.Italic);
                this.txtbUsername.ForeColor = ColorTranslator.FromHtml("#666666");
            }
        }


        /// <summary>
        /// txtUName_KeyDown()。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtUName_KeyDown(object sender, KeyEventArgs e)
        {
            //恢复正常字体。
            this.txtbUsername.Font = new Font("宋体", 9);
            this.txtbUsername.ForeColor = ColorTranslator.FromHtml("#000000");

            //获取用户名长度。
            int uNameLength = this.txtbUsername.Text.Trim().Length;

            if (uNameLength == 0)       //如果用户名输入框为空。
            {
                //标识用户名为空。
                f_IsNoUName = true;
            }
            else
            {
                //标识用户名不为空。
                f_IsNoUName = false;
            }

            if (f_IsNoUName)        //防止按了删除按键后，用户名为空的情况。
            {
                f_IsNoUName = false;
            }
        }



        /// <summary>
        /// txtUName_KeyUp()。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtUName_KeyUp(object sender, KeyEventArgs e)
        {
            //获取用户名长度。
            int uNameLength = this.txtbUsername.Text.Trim().Length;

            if (uNameLength >= 1)       //如果用户名不少于1位。
            {
                if (f_IsNoUName)        //如果用户名为空。
                {
                    return;
                }

                //标识用户名不为空。
                f_IsNoUName = false;
            }
            else
            {
                //标识用户名为空。
                f_IsNoUName = true;
            }
        }
        ///密码
        /// <summary>
        /// txtUPwd_TextChanged()。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtUPwd_TextChanged(object sender, EventArgs e)
        {
            //获取密码长度。
            int uPwdLength = this.txtbPassword.Text.Trim().Length;

            if (!f_IsUPwdMouseClick)       //如果未触发MouseClick事件。
            {
                if (uPwdLength == 0)       //如果密码输入框为空。
                {
                    //标识密码为空。
                    f_IsNoUPwd = true;
                    this.txtbPassword.Text = "最少8位，最多15位";
                    this.txtbPassword.Font = new Font("宋体", 9, FontStyle.Italic);
                    this.txtbPassword.ForeColor = ColorTranslator.FromHtml("#666666");
                }
            }
        }


        /// <summary>
        /// txtUPwd_MouseClick()。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtUPwd_MouseClick(object sender, MouseEventArgs e)
        {
            if (f_IsNoUPwd)        //如果密码为空。
            {
                //标识触发了MouseClick事件。
                f_IsUPwdMouseClick = true;
                this.txtbPassword.Text = "";
            }
        }


        /// <summary>
        /// txtUPwd_Leave()。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtUPwd_Leave(object sender, EventArgs e)
        {
            //获取密码长度。
            int uPwdLength = this.txtbPassword.Text.Trim().Length;

            if (uPwdLength == 0)       //如果密码输入框为空。
            {
                //标识密码为空。
                f_IsNoUPwd = true;
                this.txtbPassword.Text = "最少8位，最多15位";
                this.txtbPassword.Font = new Font("宋体", 9, FontStyle.Italic);
                this.txtbPassword.ForeColor = ColorTranslator.FromHtml("#666666");
            }
        }


        /// <summary>
        /// txtUPwd_KeyDown()。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtUPwd_KeyDown(object sender, KeyEventArgs e)
        {
            //恢复正常字体。
            this.txtbPassword.Font = new Font("宋体", 9);
            this.txtbPassword.ForeColor = ColorTranslator.FromHtml("#000000");

            //获取密码长度。
            int uPwdLength = this.txtbPassword.Text.Trim().Length;

            if (uPwdLength == 0)       //如果密码输入框为空。
            {
                //标识密码为空。
                f_IsNoUPwd = true;
            }
            else
            {
                //标识密码不为空。
                f_IsNoUPwd = false;
            }

            if (f_IsNoUPwd)        //防止按了删除按键后，密码为空的情况。
            {
                f_IsNoUPwd = false;
            }
        }



        /// <summary>
        /// txtUPwd_KeyUp()。
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtUPwd_KeyUp(object sender, KeyEventArgs e)
        {
            //获取密码长度。
            int uPwdLength = this.txtbPassword.Text.Trim().Length;

            if (uPwdLength >= 1)       //如果密码不少于1位。
            {
                if (f_IsNoUPwd)        //如果密码为空。
                {
                    return;
                }

                //标识密码不为空。
                f_IsNoUPwd = false;
            }
            else
            {
                //标识密码为空。
                f_IsNoUPwd = true;
            }
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}
