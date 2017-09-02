namespace BeautyInstrumentSimulator
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnOpenFind = new System.Windows.Forms.Button();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.打开端口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.功能设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.报文ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.清空报文ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存报文ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusMain = new System.Windows.Forms.StatusStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAPP = new System.Windows.Forms.ComboBox();
            this.cbRH = new System.Windows.Forms.ComboBox();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timUart = new System.Windows.Forms.Timer(this.components);
            this.rtCmd = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.cbRH);
            this.panel1.Controls.Add(this.cbAPP);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnEnd);
            this.panel1.Controls.Add(this.btnOpenFind);
            this.panel1.Location = new System.Drawing.Point(12, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 66);
            this.panel1.TabIndex = 1;
            // 
            // btnEnd
            // 
            this.btnEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnd.Location = new System.Drawing.Point(800, 3);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(150, 58);
            this.btnEnd.TabIndex = 0;
            this.btnEnd.Text = "退出";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnOpenFind
            // 
            this.btnOpenFind.Enabled = false;
            this.btnOpenFind.Location = new System.Drawing.Point(3, 3);
            this.btnOpenFind.Name = "btnOpenFind";
            this.btnOpenFind.Size = new System.Drawing.Size(150, 58);
            this.btnOpenFind.TabIndex = 0;
            this.btnOpenFind.Text = "开启查询";
            this.btnOpenFind.UseVisualStyleBackColor = true;
            this.btnOpenFind.Click += new System.EventHandler(this.btnOpenFind_Click);
            // 
            // menuMain
            // 
            this.menuMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.打开端口ToolStripMenuItem,
            this.设置ToolStripMenuItem,
            this.功能设置ToolStripMenuItem,
            this.报文ToolStripMenuItem,
            this.关于ToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(974, 39);
            this.menuMain.TabIndex = 2;
            this.menuMain.Text = "menuStrip1";
            // 
            // 打开端口ToolStripMenuItem
            // 
            this.打开端口ToolStripMenuItem.Name = "打开端口ToolStripMenuItem";
            this.打开端口ToolStripMenuItem.Size = new System.Drawing.Size(122, 35);
            this.打开端口ToolStripMenuItem.Text = "打开串口";
            this.打开端口ToolStripMenuItem.Click += new System.EventHandler(this.打开端口ToolStripMenuItem_Click);
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(122, 35);
            this.设置ToolStripMenuItem.Text = "串口设置";
            this.设置ToolStripMenuItem.Click += new System.EventHandler(this.设置ToolStripMenuItem_Click);
            // 
            // 功能设置ToolStripMenuItem
            // 
            this.功能设置ToolStripMenuItem.Name = "功能设置ToolStripMenuItem";
            this.功能设置ToolStripMenuItem.Size = new System.Drawing.Size(122, 35);
            this.功能设置ToolStripMenuItem.Text = "功能设置";
            // 
            // 报文ToolStripMenuItem
            // 
            this.报文ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.清空报文ToolStripMenuItem,
            this.保存报文ToolStripMenuItem});
            this.报文ToolStripMenuItem.Name = "报文ToolStripMenuItem";
            this.报文ToolStripMenuItem.Size = new System.Drawing.Size(74, 35);
            this.报文ToolStripMenuItem.Text = "报文";
            // 
            // 清空报文ToolStripMenuItem
            // 
            this.清空报文ToolStripMenuItem.Name = "清空报文ToolStripMenuItem";
            this.清空报文ToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.清空报文ToolStripMenuItem.Text = "清空报文";
            // 
            // 保存报文ToolStripMenuItem
            // 
            this.保存报文ToolStripMenuItem.Name = "保存报文ToolStripMenuItem";
            this.保存报文ToolStripMenuItem.Size = new System.Drawing.Size(268, 38);
            this.保存报文ToolStripMenuItem.Text = "保存报文";
            // 
            // statusMain
            // 
            this.statusMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusMain.Location = new System.Drawing.Point(0, 547);
            this.statusMain.Name = "statusMain";
            this.statusMain.Size = new System.Drawing.Size(974, 22);
            this.statusMain.TabIndex = 3;
            this.statusMain.Text = "statusStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "水份检测：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(462, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "APP状态：";
            // 
            // cbAPP
            // 
            this.cbAPP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAPP.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cbAPP.FormattingEnabled = true;
            this.cbAPP.Items.AddRange(new object[] {
            "无变化",
            "初次连接",
            "重新连接",
            "查找设备",
            "通信失败"});
            this.cbAPP.Location = new System.Drawing.Point(606, 11);
            this.cbAPP.Name = "cbAPP";
            this.cbAPP.Size = new System.Drawing.Size(150, 39);
            this.cbAPP.TabIndex = 2;
            // 
            // cbRH
            // 
            this.cbRH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRH.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cbRH.FormattingEnabled = true;
            this.cbRH.Items.AddRange(new object[] {
            "关闭",
            "开启"});
            this.cbRH.Location = new System.Drawing.Point(323, 11);
            this.cbRH.Name = "cbRH";
            this.cbRH.Size = new System.Drawing.Size(100, 39);
            this.cbRH.TabIndex = 2;
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(74, 35);
            this.关于ToolStripMenuItem.Text = "关于";
            // 
            // timUart
            // 
            this.timUart.Interval = 300;
            this.timUart.Tick += new System.EventHandler(this.timUart_Tick);
            // 
            // rtCmd
            // 
            this.rtCmd.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtCmd.Location = new System.Drawing.Point(15, 131);
            this.rtCmd.Name = "rtCmd";
            this.rtCmd.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtCmd.Size = new System.Drawing.Size(950, 740);
            this.rtCmd.TabIndex = 4;
            this.rtCmd.Text = "";
            this.rtCmd.TextChanged += new System.EventHandler(this.rtCmd_TextChanged);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(974, 569);
            this.Controls.Add(this.rtCmd);
            this.Controls.Add(this.statusMain);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuMain);
            this.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.MainMenuStrip = this.menuMain;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "美容仪模拟器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnOpenFind;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem 打开端口ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 功能设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 报文ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 清空报文ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存报文ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusMain;
        private System.Windows.Forms.ComboBox cbRH;
        private System.Windows.Forms.ComboBox cbAPP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.Timer timUart;
        private System.Windows.Forms.RichTextBox rtCmd;
    }
}

