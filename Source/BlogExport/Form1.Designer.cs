namespace BlogExport
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnDownLoadAll = new System.Windows.Forms.Button();
            this.BtnDownLoadCurrentPage = new System.Windows.Forms.Button();
            this.BtnParse = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.下载ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.移除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.BtnLast = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.tip = new System.Windows.Forms.Label();
            this.BtnUpdate = new System.Windows.Forms.LinkLabel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.配置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSDNUserTokenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.如何使用ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.提出意见ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.点个赞ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BtnDownLoadAll);
            this.panel1.Controls.Add(this.BtnDownLoadCurrentPage);
            this.panel1.Controls.Add(this.BtnParse);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 419);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(3, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "tonychenn.cn";
            // 
            // BtnDownLoadAll
            // 
            this.BtnDownLoadAll.Enabled = false;
            this.BtnDownLoadAll.Location = new System.Drawing.Point(111, 208);
            this.BtnDownLoadAll.Name = "BtnDownLoadAll";
            this.BtnDownLoadAll.Size = new System.Drawing.Size(75, 34);
            this.BtnDownLoadAll.TabIndex = 6;
            this.BtnDownLoadAll.Text = "下载全部";
            this.BtnDownLoadAll.UseVisualStyleBackColor = true;
            this.BtnDownLoadAll.Click += new System.EventHandler(this.BtnDownLoadAll_Click);
            // 
            // BtnDownLoadCurrentPage
            // 
            this.BtnDownLoadCurrentPage.Enabled = false;
            this.BtnDownLoadCurrentPage.Location = new System.Drawing.Point(11, 208);
            this.BtnDownLoadCurrentPage.Name = "BtnDownLoadCurrentPage";
            this.BtnDownLoadCurrentPage.Size = new System.Drawing.Size(75, 34);
            this.BtnDownLoadCurrentPage.TabIndex = 5;
            this.BtnDownLoadCurrentPage.Text = "下载本页";
            this.BtnDownLoadCurrentPage.UseVisualStyleBackColor = true;
            this.BtnDownLoadCurrentPage.Click += new System.EventHandler(this.BtnDownLoadCurrentPage_Click);
            // 
            // BtnParse
            // 
            this.BtnParse.Location = new System.Drawing.Point(11, 168);
            this.BtnParse.Name = "BtnParse";
            this.BtnParse.Size = new System.Drawing.Size(175, 34);
            this.BtnParse.TabIndex = 4;
            this.BtnParse.Text = "解析";
            this.BtnParse.UseVisualStyleBackColor = true;
            this.BtnParse.Click += new System.EventHandler(this.BtnParse_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(11, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(175, 87);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "粘贴网址到这里";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 61);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "https://blog.csdn.net/u013284706";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(11, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(175, 59);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "类型";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(161, 20);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(206, 54);
            this.listView1.MinimumSize = new System.Drawing.Size(500, 380);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(500, 403);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.下载ToolStripMenuItem,
            this.移除ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 48);
            // 
            // 下载ToolStripMenuItem
            // 
            this.下载ToolStripMenuItem.Name = "下载ToolStripMenuItem";
            this.下载ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.下载ToolStripMenuItem.Text = "下载";
            this.下载ToolStripMenuItem.Click += new System.EventHandler(this.下载ToolStripMenuItem_Click);
            // 
            // 移除ToolStripMenuItem
            // 
            this.移除ToolStripMenuItem.Name = "移除ToolStripMenuItem";
            this.移除ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.移除ToolStripMenuItem.Text = "移除";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icon.png");
            // 
            // BtnLast
            // 
            this.BtnLast.Enabled = false;
            this.BtnLast.Location = new System.Drawing.Point(206, 28);
            this.BtnLast.Name = "BtnLast";
            this.BtnLast.Size = new System.Drawing.Size(75, 23);
            this.BtnLast.TabIndex = 2;
            this.BtnLast.Text = "上一页";
            this.BtnLast.UseVisualStyleBackColor = true;
            this.BtnLast.Click += new System.EventHandler(this.BtnLast_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnNext.Enabled = false;
            this.BtnNext.Location = new System.Drawing.Point(631, 27);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(75, 23);
            this.BtnNext.TabIndex = 3;
            this.BtnNext.Text = "下一页";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // tip
            // 
            this.tip.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tip.AutoSize = true;
            this.tip.Location = new System.Drawing.Point(402, 35);
            this.tip.Name = "tip";
            this.tip.Size = new System.Drawing.Size(101, 12);
            this.tip.TabIndex = 4;
            this.tip.Text = "第{0}页(共{1}页)";
            this.tip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.AutoSize = true;
            this.BtnUpdate.Location = new System.Drawing.Point(287, 39);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(53, 12);
            this.BtnUpdate.TabIndex = 5;
            this.BtnUpdate.TabStop = true;
            this.BtnUpdate.Text = "刷新列表";
            this.BtnUpdate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BtnUpdate_LinkClicked);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.配置ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(707, 25);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 配置ToolStripMenuItem
            // 
            this.配置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cSDNUserTokenToolStripMenuItem});
            this.配置ToolStripMenuItem.Name = "配置ToolStripMenuItem";
            this.配置ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.配置ToolStripMenuItem.Text = "配置";
            // 
            // cSDNUserTokenToolStripMenuItem
            // 
            this.cSDNUserTokenToolStripMenuItem.Name = "cSDNUserTokenToolStripMenuItem";
            this.cSDNUserTokenToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.cSDNUserTokenToolStripMenuItem.Text = "CSDN UserToken";
            this.cSDNUserTokenToolStripMenuItem.Click += new System.EventHandler(this.cSDNUserTokenToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.如何使用ToolStripMenuItem,
            this.提出意见ToolStripMenuItem,
            this.点个赞ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 如何使用ToolStripMenuItem
            // 
            this.如何使用ToolStripMenuItem.Name = "如何使用ToolStripMenuItem";
            this.如何使用ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.如何使用ToolStripMenuItem.Text = "如何使用";
            this.如何使用ToolStripMenuItem.Click += new System.EventHandler(this.如何使用ToolStripMenuItem_Click);
            // 
            // 提出意见ToolStripMenuItem
            // 
            this.提出意见ToolStripMenuItem.Name = "提出意见ToolStripMenuItem";
            this.提出意见ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.提出意见ToolStripMenuItem.Text = "提出意见";
            this.提出意见ToolStripMenuItem.Click += new System.EventHandler(this.提出意见ToolStripMenuItem_Click);
            // 
            // 点个赞ToolStripMenuItem
            // 
            this.点个赞ToolStripMenuItem.Name = "点个赞ToolStripMenuItem";
            this.点个赞ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.点个赞ToolStripMenuItem.Text = "点个赞";
            this.点个赞ToolStripMenuItem.Click += new System.EventHandler(this.点个赞ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 448);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.BtnUpdate);
            this.Controls.Add(this.tip);
            this.Controls.Add(this.BtnNext);
            this.Controls.Add(this.BtnLast);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnParse;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button BtnLast;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Label tip;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 下载ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 移除ToolStripMenuItem;
        private System.Windows.Forms.LinkLabel BtnUpdate;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button BtnDownLoadAll;
        private System.Windows.Forms.Button BtnDownLoadCurrentPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 配置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cSDNUserTokenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 如何使用ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 提出意见ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 点个赞ToolStripMenuItem;
    }
}

