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
    public partial class frmGP : Form
    {
        string strCno = "";
        string strCState = "";
        DataTable dt = new DataTable();
        static string strConn = ConfigurationManager.ConnectionStrings["dbConnStr"].ConnectionString;
        SqlConnection conn = new SqlConnection(strConn);
        SqlCommand cmd = new SqlCommand();
        public frmGP()
        {
            InitializeComponent();
        }
        //select m.MName,m.MTime,m.MAct,s.mprice,s.mprice,s.mroom,s.mcount,s.mtime,s.mrq from movie m,moviesy s where m.MName=s.MName and s.mcount>0
        private void DataFresh()
        {
            string strRQ = DateTime.Now.ToString("yyyyMMdd");
             conn.Close();
            conn.Open();
            string strSql = "select m.MName as 影片名称,m.MTime as 时长,m.MAct as 主演,s.mprice as 票价,s.mroom as 放映厅,s.mcount as  剩余座位,s.mtime as 上映时间,s.mrq as 上映日期,m.MType as 类型,m.MBZ as 简介 from movie m,moviesy s where m.MName=s.MName and s.mcount>0 and s.mrq>'" + strRQ + "'";
            dt.Clear();
            cmd = new SqlCommand(strSql, conn);


            SqlDataAdapter da = new SqlDataAdapter(strSql, conn);
            da.Fill(dt);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dt;
            conn.Close();
        }
        private void frmGP_Load(object sender, EventArgs e)
        {
            if (frmLogin.strT=="C")

            {
                this.textBox5.Text = frmLogin.strCZY;
                this.textBox5.ReadOnly = true;
              
                conn.Close();
                conn.Open();
                string strN = "";
                string strS = "select [CusType] from Cus where Custel='" + this.textBox5.Text.ToString() + "'";
                cmd = new SqlCommand(strS, conn);
                conn.Close();
                conn.Open();
                this.textBox10.Text = Convert.ToString(cmd.ExecuteScalar());
            }
            
            this.comboBox2.SelectedIndex = 0;
            
            DataFresh();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dataGridView1.CurrentCell.RowIndex;


            this.txtbGo.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();

            this.txtbPrice.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            this.txtbQuantity.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            this.txtbDestination.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            this.txtbDate.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            System.Drawing.Rectangle rec = new System.Drawing.Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y, dataGridView1.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), dataGridView1.RowHeadersDefaultCellStyle.Font, rec, dataGridView1.RowHeadersDefaultCellStyle.ForeColor, TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            string strS = "select Custel from Cus where Custel='" + this.textBox5.Text.ToString()+"'";
            cmd = new SqlCommand(strS,conn);
            conn.Close();
            conn.Open();
            string strN = "";
            strN = Convert.ToString(cmd.ExecuteScalar());
            if (strN=="")
            {
                MessageBox.Show("无此会员信息，请先添加");
                this.textBox5.Text = "";
            } 
            else
            {
                strS = "select [CusType] from Cus where Custel='" + this.textBox5.Text.ToString()+"'";
                cmd = new SqlCommand(strS, conn);
                conn.Close();
                conn.Open();
                this.textBox10.Text = Convert.ToString(cmd.ExecuteScalar());
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox8.Text == "" || this.textBox5.Text == "" || this.textBox6.Text == "")
            {
                MessageBox.Show("请输入购票信息");
            } 
            else
            {
                
                string strPH=DateTime.Now.ToString("yyyyMMddff");
                string strRQ=DateTime.Now.ToString("yyyyMMdd");
                string strI = "insert into GP values('" + strPH + "','" + this.textBox5.Text.ToString() + "'," + int.Parse(this.textBox6.Text.ToString()) + "," + float.Parse(this.textBox8.Text.ToString()) + ",'" + this.txtbGo.Text.ToString() + "','" + this.txtbDate.Text.ToString() + "','" + this.txtbDestination.Text.ToString() + "','" + strRQ + "','" + frmLogin.strCZY + "')";
                SqlCommand cmd = new SqlCommand(strI, conn);
                conn.Close();
                conn.Open();
                cmd.ExecuteScalar();
                conn.Close();
                this.txtbQuantity.Text = "";
                this.txtbPrice.Text = "";
                this.txtbGo.Text = "";
                this.txtbDestination.Text = "";
                this.txtbDate.Text = "";
                this.textBox6.Text = "";
                this.textBox7.Text = "";
                this.textBox8.Text = "";
                MessageBox.Show("购票成功", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                DataFresh();
            }
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            
            if (this.textBox6.Text=="")
            {
                MessageBox.Show("输入购票数量");
            } 
            else
            {
                if (int.Parse(this.textBox6.Text.ToString()) > int.Parse(this.txtbQuantity.Text.ToString()))
            {
                MessageBox.Show("购票数量大于剩余数量");
            }
            else
            {
                if (this.comboBox2.Text.ToString() == "无")
                {
                    if (this.textBox10.Text.ToString() == "普通会员")
                    {
                        this.textBox8.Text = (int.Parse(this.txtbPrice.Text.ToString()) * int.Parse(this.textBox6.Text.ToString()) * 0.9).ToString();
                    }
                    if (this.textBox10.Text.ToString() == "白金会员")
                    {
                        this.textBox8.Text = (int.Parse(this.txtbPrice.Text.ToString()) * int.Parse(this.textBox6.Text.ToString()) * 0.8).ToString();
                    }
                    if (this.textBox10.Text.ToString() == "钻石会员")
                    {
                        this.textBox8.Text = (int.Parse(this.txtbPrice.Text.ToString()) * int.Parse(this.textBox6.Text.ToString()) * 0.7).ToString();
                    }
                }
                if (this.comboBox2.Text.ToString() == "残疾证")
                {
                    this.textBox8.Text = (int.Parse(this.txtbPrice.Text.ToString()) * int.Parse(this.textBox6.Text.ToString()) * 0.1).ToString();
                }
                if (this.comboBox2.Text.ToString() == "学生证")
                {
                    this.textBox8.Text = (int.Parse(this.txtbPrice.Text.ToString()) * int.Parse(this.textBox6.Text.ToString()) * 0.5).ToString();
                }
            }
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
