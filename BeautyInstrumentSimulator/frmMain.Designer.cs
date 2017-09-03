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
            this.cbRH = new System.Windows.Forms.ComboBox();
            this.cbAPP = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnOpenFind = new System.Windows.Forms.Button();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.打开端口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.功能设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.报文ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClearCmd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveCmd = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusMain = new System.Windows.Forms.StatusStrip();
            this.tsSerial = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsBaudRate = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.timUart = new System.Windows.Forms.Timer(this.components);
            this.rtCmd = new System.Windows.Forms.RichTextBox();
            this.timTime = new System.Windows.Forms.Timer(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuShowLogCmd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuShowRcvData = new System.Windows.Forms.ToolStripMenuItem();
            this.menuShowSendData = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuShowCmdTime = new System.Windows.Forms.ToolStripMenuItem();
            this.menuShowCmdHead = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuOutputCmd = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuMain.SuspendLayout();
            this.statusMain.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1030, 66);
            this.panel1.TabIndex = 1;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(462, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "APP状态：";
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
            // btnEnd
            // 
            this.btnEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnd.Location = new System.Drawing.Point(880, 3);
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
            this.menuMain.Size = new System.Drawing.Size(1054, 42);
            this.menuMain.TabIndex = 2;
            this.menuMain.Text = "menuStrip1";
            // 
            // 打开端口ToolStripMenuItem
            // 
            this.打开端口ToolStripMenuItem.Name = "打开端口ToolStripMenuItem";
            this.打开端口ToolStripMenuItem.Size = new System.Drawing.Size(122, 38);
            this.打开端口ToolStripMenuItem.Text = "打开串口";
            this.打开端口ToolStripMenuItem.Click += new System.EventHandler(this.打开端口ToolStripMenuItem_Click);
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(122, 38);
            this.设置ToolStripMenuItem.Text = "串口设置";
            this.设置ToolStripMenuItem.Click += new System.EventHandler(this.设置ToolStripMenuItem_Click);
            // 
            // 功能设置ToolStripMenuItem
            // 
            this.功能设置ToolStripMenuItem.Name = "功能设置ToolStripMenuItem";
            this.功能设置ToolStripMenuItem.Size = new System.Drawing.Size(122, 38);
            this.功能设置ToolStripMenuItem.Text = "功能设置";
            // 
            // 报文ToolStripMenuItem
            // 
            this.报文ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuClearCmd,
            this.toolStripMenuItem1,
            this.menuShowLogCmd,
            this.menuShowSendData,
            this.menuShowRcvData,
            this.toolStripMenuItem2,
            this.menuShowCmdTime,
            this.menuShowCmdHead,
            this.toolStripMenuItem3,
            this.menuOutputCmd,
            this.menuSaveCmd});
            this.报文ToolStripMenuItem.Name = "报文ToolStripMenuItem";
            this.报文ToolStripMenuItem.Size = new System.Drawing.Size(74, 38);
            this.报文ToolStripMenuItem.Text = "报文";
            // 
            // menuClearCmd
            // 
            this.menuClearCmd.Name = "menuClearCmd";
            this.menuClearCmd.Size = new System.Drawing.Size(268, 38);
            this.menuClearCmd.Text = "清空报文";
            this.menuClearCmd.Click += new System.EventHandler(this.menuClearCmd_Click);
            // 
            // menuSaveCmd
            // 
            this.menuSaveCmd.Name = "menuSaveCmd";
            this.menuSaveCmd.Size = new System.Drawing.Size(268, 38);
            this.menuSaveCmd.Text = "保存报文";
            this.menuSaveCmd.Click += new System.EventHandler(this.menuSaveCmd_Click);
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(74, 38);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // statusMain
            // 
            this.statusMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSerial,
            this.tsBaudRate,
            this.tsTime,
            this.tsStatus});
            this.statusMain.Location = new System.Drawing.Point(0, 689);
            this.statusMain.Name = "statusMain";
            this.statusMain.Size = new System.Drawing.Size(1054, 40);
            this.statusMain.TabIndex = 3;
            this.statusMain.Text = "statusStrip1";
            // 
            // tsSerial
            // 
            this.tsSerial.AutoSize = false;
            this.tsSerial.AutoToolTip = true;
            this.tsSerial.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsSerial.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsSerial.Name = "tsSerial";
            this.tsSerial.Size = new System.Drawing.Size(90, 35);
            this.tsSerial.Text = "串口：关闭   ";
            this.tsSerial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsBaudRate
            // 
            this.tsBaudRate.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsBaudRate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBaudRate.Name = "tsBaudRate";
            this.tsBaudRate.Size = new System.Drawing.Size(177, 35);
            this.tsBaudRate.Text = "波特率：9600 ";
            // 
            // tsTime
            // 
            this.tsTime.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsTime.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsTime.Name = "tsTime";
            this.tsTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsTime.Size = new System.Drawing.Size(90, 35);
            this.tsTime.Text = "时间：";
            this.tsTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tsStatus
            // 
            this.tsStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsStatus.Name = "tsStatus";
            this.tsStatus.Size = new System.Drawing.Size(230, 35);
            this.tsStatus.Text = "状态：等待开启串口";
            this.tsStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.rtCmd.Font = new System.Drawing.Font("宋体", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtCmd.Location = new System.Drawing.Point(12, 131);
            this.rtCmd.Name = "rtCmd";
            this.rtCmd.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtCmd.Size = new System.Drawing.Size(1030, 540);
            this.rtCmd.TabIndex = 4;
            this.rtCmd.Text = "";
            this.rtCmd.TextChanged += new System.EventHandler(this.rtCmd_TextChanged);
            // 
            // timTime
            // 
            this.timTime.Enabled = true;
            this.timTime.Interval = 1000;
            this.timTime.Tick += new System.EventHandler(this.timTime_Tick);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(265, 6);
            // 
            // menuShowLogCmd
            // 
            this.menuShowLogCmd.Checked = true;
            this.menuShowLogCmd.CheckOnClick = true;
            this.menuShowLogCmd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuShowLogCmd.Name = "menuShowLogCmd";
            this.menuShowLogCmd.Size = new System.Drawing.Size(268, 38);
            this.menuShowLogCmd.Text = "显示提示信息";
            // 
            // menuShowRcvData
            // 
            this.menuShowRcvData.Checked = true;
            this.menuShowRcvData.CheckOnClick = true;
            this.menuShowRcvData.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuShowRcvData.Name = "menuShowRcvData";
            this.menuShowRcvData.Size = new System.Drawing.Size(268, 38);
            this.menuShowRcvData.Text = "显示接收数据";
            // 
            // menuShowSendData
            // 
            this.menuShowSendData.Checked = true;
            this.menuShowSendData.CheckOnClick = true;
            this.menuShowSendData.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuShowSendData.Name = "menuShowSendData";
            this.menuShowSendData.Size = new System.Drawing.Size(268, 38);
            this.menuShowSendData.Text = "显示发送数据";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(265, 6);
            // 
            // menuShowCmdTime
            // 
            this.menuShowCmdTime.Checked = true;
            this.menuShowCmdTime.CheckOnClick = true;
            this.menuShowCmdTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuShowCmdTime.Name = "menuShowCmdTime";
            this.menuShowCmdTime.Size = new System.Drawing.Size(268, 38);
            this.menuShowCmdTime.Text = "显示报文时间";
            // 
            // menuShowCmdHead
            // 
            this.menuShowCmdHead.Checked = true;
            this.menuShowCmdHead.CheckOnClick = true;
            this.menuShowCmdHead.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuShowCmdHead.Name = "menuShowCmdHead";
            this.menuShowCmdHead.Size = new System.Drawing.Size(268, 38);
            this.menuShowCmdHead.Text = "显示报文头";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(265, 6);
            // 
            // menuOutputCmd
            // 
            this.menuOutputCmd.Name = "menuOutputCmd";
            this.menuOutputCmd.Size = new System.Drawing.Size(268, 38);
            this.menuOutputCmd.Text = "动态输出";
            this.menuOutputCmd.Click += new System.EventHandler(this.menuOutputCmd_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1054, 729);
            this.Controls.Add(this.statusMain);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuMain);
            this.Controls.Add(this.rtCmd);
            this.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.MainMenuStrip = this.menuMain;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1080, 480);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "美容仪模拟器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.statusMain.ResumeLayout(false);
            this.statusMain.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem menuClearCmd;
        private System.Windows.Forms.ToolStripMenuItem menuSaveCmd;
        private System.Windows.Forms.StatusStrip statusMain;
        private System.Windows.Forms.ComboBox cbRH;
        private System.Windows.Forms.ComboBox cbAPP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.Timer timUart;
        private System.Windows.Forms.RichTextBox rtCmd;
        private System.Windows.Forms.ToolStripStatusLabel tsSerial;
        private System.Windows.Forms.ToolStripStatusLabel tsBaudRate;
        private System.Windows.Forms.ToolStripStatusLabel tsTime;
        private System.Windows.Forms.ToolStripStatusLabel tsStatus;
        private System.Windows.Forms.Timer timTime;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuShowLogCmd;
        private System.Windows.Forms.ToolStripMenuItem menuShowSendData;
        private System.Windows.Forms.ToolStripMenuItem menuShowRcvData;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem menuShowCmdTime;
        private System.Windows.Forms.ToolStripMenuItem menuShowCmdHead;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem menuOutputCmd;
    }
}

