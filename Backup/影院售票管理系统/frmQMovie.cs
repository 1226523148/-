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
    public partial class frmQMovie : Form
    {
        string strCno = "";
        string strCState = "";
        DataTable dt = new DataTable();
        static string strConn = ConfigurationManager.ConnectionStrings["dbConnStr"].ConnectionString;
        SqlConnection conn = new SqlConnection(strConn);
        SqlCommand cmd = new SqlCommand();
        public frmQMovie()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string strSql = "";
            if (this.textBox7.Text.ToString()=="")
            {
                strSql = "SELECT [MName] as 名称,[MLanguage] as 语言,[MDirector] as 导演,[MAct] as 主演,[MTime] as 时长,[MBZ] as 备注,[MType] as 类型 FROM [Movie]";
            } 
            else
            {
                if (this.comboBox1.Text.ToString()=="导演")
                {
                    strSql = "SELECT [MName] as 名称,[MLanguage] as 语言,[MDirector] as 导演,[MAct] as 主演,[MTime] as 时长,[MBZ] as 备注,[MType] as 类型 FROM [Movie] where MDirector like '%"+this.textBox7.Text.ToString()+"%'";
                }
                if (this.comboBox1.Text.ToString() == "主演")
                {
                    strSql = "SELECT [MName] as 名称,[MLanguage] as 语言,[MDirector] as 导演,[MAct] as 主演,[MTime] as 时长,[MBZ] as 备注,[MType] as 类型 FROM [Movie]  where MAct like '%" + this.textBox7.Text.ToString() + "%'";
                } 
                else
                {
                    strSql = "SELECT [MName] as 名称,[MLanguage] as 语言,[MDirector] as 导演,[MAct] as 主演,[MTime] as 时长,[MBZ] as 备注,[MType] as 类型 FROM [Movie]  where MName like '%" + this.textBox7.Text.ToString() + "%'";
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

        private void DataFresh()
        {
            conn.Close();
            conn.Open();
            string strSql = "SELECT [MName] as 名称,[MLanguage] as 语言,[MDirector] as 导演,[MAct] as 主演,[MTime] as 时长,[MBZ] as 备注,[MType] as 类型 FROM [Movie]";
            dt.Clear();
            cmd = new SqlCommand(strSql, conn);


            SqlDataAdapter da = new SqlDataAdapter(strSql, conn);
            da.Fill(dt);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dt;
            conn.Close();
        }
        private void frmQMovie_Load(object sender, EventArgs e)
        {
            this.comboBox1.SelectedIndex = 0;
            conn.Close();
            conn.Open();
            string strSql = "SELECT [MName] as 名称,[MLanguage] as 语言,[MDirector] as 导演,[MAct] as 主演,[MTime] as 时长,[MBZ] as 备注,[MType] as 类型 FROM [Movie]";
            dt.Clear();
            cmd = new SqlCommand(strSql, conn);


            SqlDataAdapter da = new SqlDataAdapter(strSql, conn);
            da.Fill(dt);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //SELECT [MName] as 名称,[MLanguage] as 语言,[MDirector] as 导演,[MAct] as 主演,[MTime] as 时长,[MBZ] as 备注,[MType] as 类型 FROM [Movie]
            int i = dataGridView1.CurrentCell.RowIndex;
            strCno = dataGridView1.Rows[i].Cells[0].Value.ToString();
            this.textBox1.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            this.textBox2.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            this.textBox3.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            this.textBox4.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            this.textBox5.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            this.textBox6.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            this.textBox8.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            this.textBox1.ReadOnly = true;
        }

       

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            System.Drawing.Rectangle rec = new System.Drawing.Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, dataGridView1.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dataGridView1.RowHeadersDefaultCellStyle.Font, rec, dataGridView1.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (strCno=="")
            {
                MessageBox.Show("请选择要修改的影片");
            } 
            else
            {
                string strU = "update Movie set MLanguage='" + this.textBox2.Text.ToString() + "',MDirector='" + this.textBox3.Text.ToString() + "',MAct='" + this.textBox6.Text.ToString() + "',MTime=" + int.Parse(this.textBox4.Text.ToString()) + ",MBZ='" + this.textBox8.Text.ToString() + "',MType='" + this.textBox5.Text.ToString() + "' where MName='" +strCno + "'";
                SqlCommand cmd = new SqlCommand(strU, conn);
                conn.Close();
                conn.Open();
                cmd.ExecuteScalar();
                conn.Close();
                this.textBox3.Text = "";
                this.textBox2.Text = "";
                this.textBox1.Text = "";
                this.textBox4.Text = "";
                this.textBox5.Text = "";
                this.textBox6.Text = "";
                this.textBox8.Text = "";
                this.textBox1.Text = "";
                this.textBox1.ReadOnly = false;
                MessageBox.Show("修改影片成功", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            }
        }
    }
}
