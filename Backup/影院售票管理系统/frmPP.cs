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
    public partial class frmPP : Form
    {
        string strCno = "";
        string strCState = "";
        DataTable dt = new DataTable();
        static string strConn = ConfigurationManager.ConnectionStrings["dbConnStr"].ConnectionString;
        SqlConnection conn = new SqlConnection(strConn);
        SqlCommand cmd = new SqlCommand();
        public frmPP()
        {
            InitializeComponent();
        }

        private void frmPP_Load(object sender, EventArgs e)
        {
            this.dateTimePicker1.MinDate = DateTime.Now;
            this.dateTimePicker2.MinDate = DateTime.Now;
            this.comboBox1.SelectedIndex = 0;
            conn.Close();
            conn.Open();
            string strSql = "SELECT [MName] as 名称,[MLanguage] as 语言,[MDirector] as 导演,[MAct] as 主演,[MTime] as 时长,[MBZ] as 备注,[MType] as 类型 FROM [Movie] where MName not in (select MName from pp)";
            dt.Clear();
            cmd = new SqlCommand(strSql, conn);


            SqlDataAdapter da = new SqlDataAdapter(strSql, conn);
            da.Fill(dt);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string strSql = "";
            if (this.textBox7.Text.ToString() == "")
            {
                strSql = "SELECT [MName] as 名称,[MLanguage] as 语言,[MDirector] as 导演,[MAct] as 主演,[MTime] as 时长,[MBZ] as 备注,[MType] as 类型 FROM [Movie]";
            }
            else
            {
                if (this.comboBox1.Text.ToString() == "导演")
                {
                    strSql = "SELECT [MName] as 名称,[MLanguage] as 语言,[MDirector] as 导演,[MAct] as 主演,[MTime] as 时长,[MBZ] as 备注,[MType] as 类型 FROM [Movie] where MDirector like '%" + this.textBox7.Text.ToString() + "%' and MName not in (select MName from pp)";
                }
                if (this.comboBox1.Text.ToString() == "主演")
                {
                    strSql = "SELECT [MName] as 名称,[MLanguage] as 语言,[MDirector] as 导演,[MAct] as 主演,[MTime] as 时长,[MBZ] as 备注,[MType] as 类型 FROM [Movie]  where MAct like '%" + this.textBox7.Text.ToString() + "%' and MName not in (select MName from pp)";
                }
                else
                {
                    strSql = "SELECT [MName] as 名称,[MLanguage] as 语言,[MDirector] as 导演,[MAct] as 主演,[MTime] as 时长,[MBZ] as 备注,[MType] as 类型 FROM [Movie]  where MName like '%" + this.textBox7.Text.ToString() + "%' MName not in (select MName from pp)";
                }
                dt.Clear();
                cmd = new SqlCommand(strSql, conn);


                SqlDataAdapter da = new SqlDataAdapter(strSql, conn);
                da.Fill(dt);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dt;
                conn.Close();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentCell.RowIndex;
            strCno = dataGridView1.Rows[i].Cells[0].Value.ToString();
            this.textBox1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            this.textBox1.ReadOnly = true;
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            System.Drawing.Rectangle rec = new System.Drawing.Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, dataGridView1.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dataGridView1.RowHeadersDefaultCellStyle.Font, rec, dataGridView1.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text.ToString()==""||this.textBox1.Text.ToString()==""||this.textBox1.Text.ToString()==""||this.textBox1.Text.ToString()==""||this.textBox1.Text.ToString()=="")
            {
                MessageBox.Show("请输入排片信息");
            } 
            else
            {
                if (dateTimePicker1.Value > dateTimePicker2.Value)
                {
                    MessageBox.Show("下架日期小于上映日期，错误");
                } 
                else
                {
                    string strB = dateTimePicker1.Value.ToString("yyyyMMdd");
                    string strE = dateTimePicker2.Value.ToString("yyyyMMdd");
                    string strI = "insert into PP values('" + this.textBox1.Text.ToString() + "'," + int.Parse(this.textBox2.Text.ToString()) + ",'" + this.textBox3.Text.ToString() + "'," + int.Parse(this.textBox4.Text.ToString()) + ",'" + this.textBox5.Text.ToString() + "','" + strB + "','" + strE + "')";
                    SqlCommand cmd = new SqlCommand(strI, conn);

                    conn.Open();
                    cmd.ExecuteScalar();
                    conn.Close();
                    this.textBox3.Text = "";
                    this.textBox2.Text = "";
                    this.textBox1.Text = "";
                    this.textBox4.Text = "";
                    this.textBox5.Text = "";
                    MessageBox.Show("排片成功", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    conn.Close();
                    conn.Open();
                    string strSql = "SELECT [MName] as 名称,[MLanguage] as 语言,[MDirector] as 导演,[MAct] as 主演,[MTime] as 时长,[MBZ] as 备注,[MType] as 类型 FROM [Movie] where MName not in (select MName from pp)";
                    dt.Clear();
                    cmd = new SqlCommand(strSql, conn);


                    SqlDataAdapter da = new SqlDataAdapter(strSql, conn);
                    da.Fill(dt);

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = dt;
                    conn.Close();
                    this.textBox1.ReadOnly = false;
                }
            }
        }
    }
}
