using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data.Common;
using System.Data.Odbc;
using System.Data.Sql;

namespace 影院售票管理系统
{
    public partial class frmLogin : Form
    {
        public static string strCZY = "";
        public static string strT = "";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strUser = "";
            string strPsd = "";
            strUser = this.textBox1.Text.ToString();
            strPsd = this.textBox2.Text.ToString();
            string strConn = ConfigurationManager.ConnectionStrings["dbConnStr"].ConnectionString;
            if (strUser == "" && strPsd == "")
            {
                MessageBox.Show("请输入用户名密码!", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }
            else if (strUser == "" && strPsd != "")
            {
                MessageBox.Show("请输入用户名!", "具提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }
            else if (strUser != "" && strPsd == "")
            {
                MessageBox.Show("请输入密码!", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }
            else
            {
                strCZY = this.textBox1.Text.ToString();
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();
                string strSql1 = "select UserType from ULogin where UserName='" + strUser + "'";
                SqlCommand cmd1 = new SqlCommand(strSql1, conn);
                strT = Convert.ToString(cmd1.ExecuteScalar());
                conn.Close();


                string strSql = "select UserPwd from ULogin where UserName='" + strUser + "'";
                SqlCommand cmd = new SqlCommand(strSql, conn);
                conn.Open();
                string strDBPass = Convert.ToString(cmd.ExecuteScalar());
                if (strDBPass == strPsd)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("请输入正确密码!", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                }
                conn.Close();

            }
        }
    }
}
