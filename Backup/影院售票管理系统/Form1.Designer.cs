namespace 影院售票管理系统
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.会员管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注册会员ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询会员ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.影片管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.添加影片ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改影片ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.排片ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.购票ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.会员管理ToolStripMenuItem,
            this.影片管理ToolStripMenuItem,
            this.购票ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(714, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 会员管理ToolStripMenuItem
            // 
            this.会员管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.注册会员ToolStripMenuItem,
            this.查询会员ToolStripMenuItem});
            this.会员管理ToolStripMenuItem.Name = "会员管理ToolStripMenuItem";
            this.会员管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.会员管理ToolStripMenuItem.Text = "会员管理";
            // 
            // 注册会员ToolStripMenuItem
            // 
            this.注册会员ToolStripMenuItem.Name = "注册会员ToolStripMenuItem";
            this.注册会员ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.注册会员ToolStripMenuItem.Text = "注册会员";
            this.注册会员ToolStripMenuItem.Click += new System.EventHandler(this.注册会员ToolStripMenuItem_Click);
            // 
            // 查询会员ToolStripMenuItem
            // 
            this.查询会员ToolStripMenuItem.Name = "查询会员ToolStripMenuItem";
            this.查询会员ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.查询会员ToolStripMenuItem.Text = "查询会员";
            this.查询会员ToolStripMenuItem.Click += new System.EventHandler(this.查询会员ToolStripMenuItem_Click);
            // 
            // 影片管理ToolStripMenuItem
            // 
            this.影片管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.添加影片ToolStripMenuItem,
            this.修改影片ToolStripMenuItem,
            this.排片ToolStripMenuItem});
            this.影片管理ToolStripMenuItem.Name = "影片管理ToolStripMenuItem";
            this.影片管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.影片管理ToolStripMenuItem.Text = "影片管理";
            // 
            // 添加影片ToolStripMenuItem
            // 
            this.添加影片ToolStripMenuItem.Name = "添加影片ToolStripMenuItem";
            this.添加影片ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.添加影片ToolStripMenuItem.Text = "添加影片";
            this.添加影片ToolStripMenuItem.Click += new System.EventHandler(this.添加影片ToolStripMenuItem_Click);
            // 
            // 修改影片ToolStripMenuItem
            // 
            this.修改影片ToolStripMenuItem.Name = "修改影片ToolStripMenuItem";
            this.修改影片ToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.修改影片ToolStripMenuItem.Text = "修改/修改影片";
            this.修改影片ToolStripMenuItem.Click += new System.EventHandler(this.修改影片ToolStripMenuItem_Click);
            // 
            // 排片ToolStripMenuItem
            // 
            this.排片ToolStripMenuItem.Name = "排片ToolStripMenuItem";
            this.排片ToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.排片ToolStripMenuItem.Text = "排片";
            this.排片ToolStripMenuItem.Click += new System.EventHandler(this.排片ToolStripMenuItem_Click);
            // 
            // 购票ToolStripMenuItem
            // 
            this.购票ToolStripMenuItem.Name = "购票ToolStripMenuItem";
            this.购票ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.购票ToolStripMenuItem.Text = "购票";
            this.购票ToolStripMenuItem.Click += new System.EventHandler(this.购票ToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 447);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "影院售票管理系统";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 会员管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 注册会员ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询会员ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 影片管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 添加影片ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改影片ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 排片ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 购票ToolStripMenuItem;
    }
}

