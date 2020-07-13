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
    public partial class frmQCus : Form
    {
        DataTable dt = new DataTable();
        static string strConn = ConfigurationManager.ConnectionStrings["dbConnStr"].ConnectionString;
        SqlConnection conn = new SqlConnection(strConn);
        SqlCommand cmd = new SqlCommand();
        public frmQCus()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            System.Drawing.Rectangle rec = new System.Drawing.Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, dataGridView1.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dataGridView1.RowHeadersDefaultCellStyle.Font, rec, dataGridView1.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        private void frmQCus_Load(object sender, EventArgs e)
        {
            string strS = "";
            strS = "SELECT [CusName] as 姓名,[CusCard] as 证件号码,[CusType] as 会员类型,[CusTel] as 电话  FROM  [Cus]";
            this.comboBox1.SelectedIndex = 0;
            conn.Close();
            conn.Open();
            dt.Clear();
            cmd = new SqlCommand(strS, conn);


            SqlDataAdapter da = new SqlDataAdapter(strS, conn);
            da.Fill(dt);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strS = "";
            if (this.textBox1.Text.ToString()=="")
            {
                strS="SELECT [CusName] as 姓名,[CusCard] as 证件号码,[CusType] as 会员类型,[CusTel] as 电话  FROM  [Cus]";
            } 
            else
            {
                if (this.comboBox1.Text.ToString()=="手机号")
                {
                    strS = "SELECT [CusName] as 姓名,[CusCard] as 证件号码,[CusType] as 会员类型,[CusTel] as 电话  FROM  [Cus] where CusTel like '%"+this.textBox1.Text.ToString()+"%'";
                } 
                else
                {
                    strS = "SELECT [CusName] as 姓名,[CusCard] as 证件号码,[CusType] as 会员类型,[CusTel] as 电话  FROM  [Cus] where CusName like '%" + this.textBox1.Text.ToString() + "%'";
                }
                conn.Close();
                conn.Open();
                dt.Clear();
                cmd = new SqlCommand(strS, conn);


                SqlDataAdapter da = new SqlDataAdapter(strS, conn);
                da.Fill(dt);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dt;
                conn.Close();
            }
        }
    }
}
