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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void 注册会员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegist fRegist = new frmRegist();
            fRegist.ShowDialog();
        }

        private void 查询会员ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQCus fQCus = new frmQCus();
            fQCus.ShowDialog();
        }

        private void 添加影片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddMovie fAddMovie = new frmAddMovie();
            fAddMovie.ShowDialog();
        }

        private void 修改影片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQMovie fQMovie = new frmQMovie();
            fQMovie.ShowDialog();
        }

        private void 排片ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPP fPP = new frmPP();
            fPP.ShowDialog();
        }

        private void 购票ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGP fGP = new frmGP();
            fGP.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (frmLogin.strT=='C'.ToString())
            {
                this.会员管理ToolStripMenuItem.Visible = false;

                this.影片管理ToolStripMenuItem.Visible = false;
            } 
            
        }
    }
}
