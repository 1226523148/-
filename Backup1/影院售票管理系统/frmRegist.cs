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
    public partial class frmRegist : Form
    {
        static string strConn = ConfigurationManager.ConnectionStrings["dbConnStr"].ConnectionString;
        SqlConnection conn = new SqlConnection(strConn);
        SqlCommand cmd = new SqlCommand();
        public frmRegist()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text.ToString()==""||this.textBox3.Text.ToString()==""||this.textBox2.Text.ToString()=="")
            {
                MessageBox.Show("请输入会员详细信息");
            } 
            else
            {
                string strI = "insert into Cus values('" + this.textBox1.Text.ToString() + "','" + this.textBox2.Text.ToString() + "','" + this.comboBox1.Text.ToString() + "','" + this.textBox3.Text.ToString() + "')";
                SqlCommand cmd = new SqlCommand(strI, conn);

                conn.Open();
                cmd.ExecuteScalar();
                conn.Close();
                this.textBox3.Text = "";
                this.textBox2.Text = "";
                this.textBox1.Text = "";
                MessageBox.Show("添加会员信息成功,登录号为手机号，密码为证件号后六位", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }
        }

        private void frmRegist_Load(object sender, EventArgs e)
        {
            this.comboBox1.SelectedIndex = 0;
        }
    }
}
