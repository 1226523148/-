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
    public partial class frmAddMovie : Form
    {
        static string strConn = ConfigurationManager.ConnectionStrings["dbConnStr"].ConnectionString;
        SqlConnection conn = new SqlConnection(strConn);
        SqlCommand cmd = new SqlCommand();
        public frmAddMovie()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text.ToString() == "" || this.textBox2.Text.ToString() == "" || this.textBox3.Text.ToString() == "" || this.textBox4.Text.ToString() == "" || this.textBox5.Text.ToString() == "" || this.textBox6.Text.ToString() == "")
            {
                MessageBox.Show("请输入影片信息");
            } 
            else
            {
                string strI = "insert into Movie values('" + this.textBox1.Text.ToString() + "','" + this.textBox2.Text.ToString() + "','" + this.textBox3.Text.ToString() + "','" + this.textBox5.Text.ToString() + "'," + int.Parse(this.textBox4.Text.ToString()) + ",'" + this.textBox6.Text.ToString() + "','" + this.textBox7.Text.ToString() + "')";
                SqlCommand cmd = new SqlCommand(strI, conn);

                conn.Open();
                cmd.ExecuteScalar();
                conn.Close();
                this.textBox3.Text = "";
                this.textBox2.Text = "";
                this.textBox1.Text = "";
                this.textBox4.Text = "";
                this.textBox5.Text = "";
                this.textBox6.Text = "";
                this.textBox7.Text = "";
               
                MessageBox.Show("添加影片信息成功", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }
        }
    }
}
