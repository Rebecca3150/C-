﻿namespace FoodMis
{
    partial class 客户管理
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_NU = new System.Windows.Forms.TextBox();
            this.textBox_NP2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_Nclear = new DevExpress.XtraEditors.SimpleButton();
            this.textBox_NP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_update = new DevExpress.XtraEditors.SimpleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_P2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_P = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_U = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Uname = new System.Windows.Forms.Label();
            this.button_clear = new DevExpress.XtraEditors.SimpleButton();
            this.button_add = new DevExpress.XtraEditors.SimpleButton();
            this.label2 = new System.Windows.Forms.Label();
            this.button_C = new DevExpress.XtraEditors.SimpleButton();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new DevExpress.XtraEditors.SimpleButton();
            this.button_S = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_SU = new System.Windows.Forms.TextBox();
            this.group_all = new System.Windows.Forms.GroupBox();
            this.listView_cus = new System.Windows.Forms.ListView();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.group_all.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBox_NU);
            this.groupBox2.Controls.Add(this.textBox_NP2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.button_Nclear);
            this.groupBox2.Controls.Add(this.textBox_NP);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.button_update);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(568, 420);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(435, 201);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "修改客户信息";
            // 
            // textBox_NU
            // 
            this.textBox_NU.Location = new System.Drawing.Point(166, 14);
            this.textBox_NU.MaxLength = 15;
            this.textBox_NU.Name = "textBox_NU";
            this.textBox_NU.Size = new System.Drawing.Size(165, 25);
            this.textBox_NU.TabIndex = 7;
           // 
            // textBox_NP2
            // 
            this.textBox_NP2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_NP2.Location = new System.Drawing.Point(166, 102);
            this.textBox_NP2.MaxLength = 15;
            this.textBox_NP2.Multiline = true;
            this.textBox_NP2.Name = "textBox_NP2";
            this.textBox_NP2.Size = new System.Drawing.Size(263, 50);
            this.textBox_NP2.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "地址：";
            // 
            // button_Nclear
            // 
            this.button_Nclear.Location = new System.Drawing.Point(254, 158);
            this.button_Nclear.Name = "button_Nclear";
            this.button_Nclear.Size = new System.Drawing.Size(77, 29);
            this.button_Nclear.TabIndex = 22;
            this.button_Nclear.Text = "重置";
            this.button_Nclear.Click += new System.EventHandler(this.button_Nclear_Click);
            // 
            // textBox_NP
            // 
            this.textBox_NP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_NP.Location = new System.Drawing.Point(166, 60);
            this.textBox_NP.MaxLength = 15;
            this.textBox_NP.Name = "textBox_NP";
            this.textBox_NP.Size = new System.Drawing.Size(165, 25);
            this.textBox_NP.TabIndex = 8;
            this.textBox_NP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_NP_KeyPress);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "联系方式：";
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(166, 158);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(77, 29);
            this.button_update.TabIndex = 21;
            this.button_update.Text = "修改";
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "客户名称：";
            // 
            // textBox_P2
            // 
            this.textBox_P2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_P2.Location = new System.Drawing.Point(158, 108);
            this.textBox_P2.MaxLength = 15;
            this.textBox_P2.Name = "textBox_P2";
            this.textBox_P2.Size = new System.Drawing.Size(165, 25);
            this.textBox_P2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "地址：";
            // 
            // textBox_P
            // 
            this.textBox_P.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_P.Location = new System.Drawing.Point(158, 66);
            this.textBox_P.MaxLength = 15;
            this.textBox_P.Name = "textBox_P";
            this.textBox_P.Size = new System.Drawing.Size(165, 25);
            this.textBox_P.TabIndex = 3;
            this.textBox_P.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_P_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "客户名称：";
            // 
            // textBox_U
            // 
            this.textBox_U.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBox_U.Location = new System.Drawing.Point(158, 20);
            this.textBox_U.MaxLength = 15;
            this.textBox_U.Name = "textBox_U";
            this.textBox_U.Size = new System.Drawing.Size(165, 25);
            this.textBox_U.TabIndex = 2;
            this.textBox_U.TextChanged += new System.EventHandler(this.textBox_U_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Uname);
            this.groupBox1.Controls.Add(this.button_clear);
            this.groupBox1.Controls.Add(this.textBox_P2);
            this.groupBox1.Controls.Add(this.button_add);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_P);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_U);
            this.groupBox1.Location = new System.Drawing.Point(15, 414);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 201);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "添加客户";
            // 
            // Uname
            // 
            this.Uname.AutoSize = true;
            this.Uname.ForeColor = System.Drawing.Color.Red;
            this.Uname.Location = new System.Drawing.Point(330, 23);
            this.Uname.Name = "Uname";
            this.Uname.Size = new System.Drawing.Size(0, 15);
            this.Uname.TabIndex = 21;
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(246, 152);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(77, 29);
            this.button_clear.TabIndex = 20;
            this.button_clear.Text = "重置";
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(158, 152);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(77, 29);
            this.button_add.TabIndex = 19;
            this.button_add.Text = "注册";
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "联系方式：";
            // 
            // button_C
            // 
            this.button_C.Location = new System.Drawing.Point(926, 107);
            this.button_C.Name = "button_C";
            this.button_C.Size = new System.Drawing.Size(77, 29);
            this.button_C.TabIndex = 23;
            this.button_C.Text = "删除";
            this.button_C.Click += new System.EventHandler(this.button_C_Click);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "地址";
            this.columnHeader9.Width = 245;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "联系方式";
            this.columnHeader8.Width = 208;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "客户名称";
            this.columnHeader7.Width = 198;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "编号";
            this.columnHeader6.Width = 162;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(578, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 29);
            this.button1.TabIndex = 15;
            this.button1.Text = "查看全部";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_S
            // 
            this.button_S.Location = new System.Drawing.Point(489, 26);
            this.button_S.Name = "button_S";
            this.button_S.Size = new System.Drawing.Size(77, 29);
            this.button_S.TabIndex = 14;
            this.button_S.Text = "查询";
            this.button_S.Click += new System.EventHandler(this.button_S_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.button_S);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBox_SU);
            this.groupBox3.Location = new System.Drawing.Point(15, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(988, 68);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "查询";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "请输入要查询的客户名称：";
            // 
            // textBox_SU
            // 
            this.textBox_SU.Location = new System.Drawing.Point(228, 31);
            this.textBox_SU.MaxLength = 15;
            this.textBox_SU.Name = "textBox_SU";
            this.textBox_SU.Size = new System.Drawing.Size(236, 25);
            this.textBox_SU.TabIndex = 0;
            // 
            // group_all
            // 
            this.group_all.Controls.Add(this.listView_cus);
            this.group_all.Location = new System.Drawing.Point(15, 130);
            this.group_all.Name = "group_all";
            this.group_all.Size = new System.Drawing.Size(988, 278);
            this.group_all.TabIndex = 22;
            this.group_all.TabStop = false;
            this.group_all.Text = "客户信息";
            // 
            // listView_cus
            // 
            this.listView_cus.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.listView_cus.FullRowSelect = true;
            this.listView_cus.Location = new System.Drawing.Point(6, 24);
            this.listView_cus.Name = "listView_cus";
            this.listView_cus.Size = new System.Drawing.Size(976, 248);
            this.listView_cus.TabIndex = 9;
            this.listView_cus.UseCompatibleStateImageBehavior = false;
            this.listView_cus.View = System.Windows.Forms.View.Details;
            this.listView_cus.SelectedIndexChanged += new System.EventHandler(this.listView_cus_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(330, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 15);
            this.label8.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(338, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 15);
            this.label9.TabIndex = 23;
            // 
            // 客户管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_C);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.group_all);
            this.Name = "客户管理";
            this.Size = new System.Drawing.Size(1019, 643);
            this.Load += new System.EventHandler(this.客户管理_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.group_all.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_NU;
        private System.Windows.Forms.TextBox textBox_NP2;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton button_Nclear;
        private System.Windows.Forms.TextBox textBox_NP;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton button_update;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_P2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_P;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_U;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton button_clear;
        private DevExpress.XtraEditors.SimpleButton button_add;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton button_C;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private DevExpress.XtraEditors.SimpleButton button1;
        private DevExpress.XtraEditors.SimpleButton button_S;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_SU;
        private System.Windows.Forms.GroupBox group_all;
        private System.Windows.Forms.ListView listView_cus;
        private System.Windows.Forms.Label Uname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}
