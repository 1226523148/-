namespace 影院售票管理系统
{
    partial class frmGP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grbCar = new System.Windows.Forms.GroupBox();
            this.txtbDate = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtbDestination = new System.Windows.Forms.TextBox();
            this.lblDestination = new System.Windows.Forms.Label();
            this.txtbQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtbPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtbGo = new System.Windows.Forms.TextBox();
            this.lblGo = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.grbCar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbCar
            // 
            this.grbCar.Controls.Add(this.txtbDate);
            this.grbCar.Controls.Add(this.lblDate);
            this.grbCar.Controls.Add(this.txtbDestination);
            this.grbCar.Controls.Add(this.lblDestination);
            this.grbCar.Controls.Add(this.txtbQuantity);
            this.grbCar.Controls.Add(this.lblQuantity);
            this.grbCar.Controls.Add(this.txtbPrice);
            this.grbCar.Controls.Add(this.lblPrice);
            this.grbCar.Controls.Add(this.txtbGo);
            this.grbCar.Controls.Add(this.lblGo);
            this.grbCar.Controls.Add(this.dataGridView1);
            this.grbCar.Location = new System.Drawing.Point(19, 15);
            this.grbCar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbCar.Name = "grbCar";
            this.grbCar.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grbCar.Size = new System.Drawing.Size(1039, 325);
            this.grbCar.TabIndex = 0;
            this.grbCar.TabStop = false;
            this.grbCar.Text = "车票信息";
            this.grbCar.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtbDate
            // 
            this.txtbDate.Location = new System.Drawing.Point(82, 293);
            this.txtbDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbDate.Name = "txtbDate";
            this.txtbDate.ReadOnly = true;
            this.txtbDate.Size = new System.Drawing.Size(132, 25);
            this.txtbDate.TabIndex = 55;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(37, 298);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(37, 15);
            this.lblDate.TabIndex = 54;
            this.lblDate.Text = "日期";
            // 
            // txtbDestination
            // 
            this.txtbDestination.Location = new System.Drawing.Point(759, 260);
            this.txtbDestination.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbDestination.Name = "txtbDestination";
            this.txtbDestination.ReadOnly = true;
            this.txtbDestination.Size = new System.Drawing.Size(132, 25);
            this.txtbDestination.TabIndex = 53;
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(680, 264);
            this.lblDestination.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(52, 15);
            this.lblDestination.TabIndex = 52;
            this.lblDestination.Text = "目的地";
            // 
            // txtbQuantity
            // 
            this.txtbQuantity.Location = new System.Drawing.Point(520, 260);
            this.txtbQuantity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbQuantity.Name = "txtbQuantity";
            this.txtbQuantity.ReadOnly = true;
            this.txtbQuantity.Size = new System.Drawing.Size(132, 25);
            this.txtbQuantity.TabIndex = 51;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(441, 264);
            this.lblQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(67, 15);
            this.lblQuantity.TabIndex = 50;
            this.lblQuantity.Text = "剩余票数";
            // 
            // txtbPrice
            // 
            this.txtbPrice.Location = new System.Drawing.Point(288, 260);
            this.txtbPrice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbPrice.Name = "txtbPrice";
            this.txtbPrice.ReadOnly = true;
            this.txtbPrice.Size = new System.Drawing.Size(132, 25);
            this.txtbPrice.TabIndex = 49;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(241, 264);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(37, 15);
            this.lblPrice.TabIndex = 48;
            this.lblPrice.Text = "票价";
            // 
            // txtbGo
            // 
            this.txtbGo.Location = new System.Drawing.Point(84, 260);
            this.txtbGo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbGo.Name = "txtbGo";
            this.txtbGo.ReadOnly = true;
            this.txtbGo.Size = new System.Drawing.Size(132, 25);
            this.txtbGo.TabIndex = 47;
            // 
            // lblGo
            // 
            this.lblGo.AutoSize = true;
            this.lblGo.Location = new System.Drawing.Point(34, 264);
            this.lblGo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGo.Name = "lblGo";
            this.lblGo.Size = new System.Drawing.Size(52, 15);
            this.lblGo.TabIndex = 46;
            this.lblGo.Text = "出发地";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 26);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1023, 216);
            this.dataGridView1.TabIndex = 45;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox10);
            this.groupBox2.Controls.Add(this.comboBox2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBox6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(16, 348);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1039, 120);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "购票信息";
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(320, 24);
            this.textBox10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox10.Name = "textBox10";
            this.textBox10.ReadOnly = true;
            this.textBox10.Size = new System.Drawing.Size(123, 25);
            this.textBox10.TabIndex = 58;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "无",
            "残疾证",
            "学生证"});
            this.comboBox2.Location = new System.Drawing.Point(116, 74);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 23);
            this.comboBox2.TabIndex = 57;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 78);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 15);
            this.label9.TabIndex = 56;
            this.label9.Text = "特殊证件";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(791, 25);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(132, 25);
            this.textBox7.TabIndex = 55;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(712, 28);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 54;
            this.label8.Text = "联系电话";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(531, 24);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(132, 25);
            this.textBox6.TabIndex = 53;
            this.textBox6.Leave += new System.EventHandler(this.textBox6_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(452, 29);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 15);
            this.label7.TabIndex = 52;
            this.label7.Text = "购票数量";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(241, 29);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 50;
            this.label6.Text = "折扣类型";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(84, 25);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(132, 25);
            this.textBox5.TabIndex = 49;
            this.textBox5.Leave += new System.EventHandler(this.textBox5_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 29);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 48;
            this.label5.Text = "用户";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(195, 494);
            this.textBox8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(132, 25);
            this.textBox8.TabIndex = 51;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(116, 498);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 50;
            this.label10.Text = "合计金额";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(497, 491);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 29);
            this.button1.TabIndex = 52;
            this.button1.Text = "购票";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmGP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbCar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmGP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "购票";
            this.Load += new System.EventHandler(this.frmGP_Load);
            this.grbCar.ResumeLayout(false);
            this.grbCar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbCar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtbGo;
        private System.Windows.Forms.Label lblGo;
        private System.Windows.Forms.TextBox txtbDestination;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.TextBox txtbQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtbPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtbDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox textBox10;
    }
}