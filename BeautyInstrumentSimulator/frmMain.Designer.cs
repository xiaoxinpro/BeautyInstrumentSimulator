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
            this.menuOpenSerial = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSerial = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFunction = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCmd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClearCmd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFontCmd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuShowLogCmd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuShowSendData = new System.Windows.Forms.ToolStripMenuItem();
            this.menuShowRcvData = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuShowCmdTime = new System.Windows.Forms.ToolStripMenuItem();
            this.menuShowCmdHead = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuOutputCmd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveCmd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.statusMain = new System.Windows.Forms.StatusStrip();
            this.tsSerial = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsBaudRate = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.timUart = new System.Windows.Forms.Timer(this.components);
            this.rtCmd = new System.Windows.Forms.RichTextBox();
            this.timTime = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtRcvError = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtRcvVersion = new System.Windows.Forms.TextBox();
            this.txtRcvRhH = new System.Windows.Forms.TextBox();
            this.menuRcvRh = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuRcvRhSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuRcvRhOpenXls = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRcvRhOpenChart = new System.Windows.Forms.ToolStripMenuItem();
            this.txtRcvAdjust = new System.Windows.Forms.TextBox();
            this.txtRcvThTemp = new System.Windows.Forms.TextBox();
            this.txtRcvHotTemp = new System.Windows.Forms.TextBox();
            this.txtRcvRh3 = new System.Windows.Forms.TextBox();
            this.txtRcvRh2 = new System.Windows.Forms.TextBox();
            this.txtRcvRh1 = new System.Windows.Forms.TextBox();
            this.txtRcvTime = new System.Windows.Forms.TextBox();
            this.txtRcvMode = new System.Windows.Forms.TextBox();
            this.txtRcvStatus = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTaskInfo = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.menuMain.SuspendLayout();
            this.statusMain.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuRcvRh.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(6, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(515, 33);
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
            this.cbRH.Location = new System.Drawing.Point(162, 6);
            this.cbRH.Margin = new System.Windows.Forms.Padding(2);
            this.cbRH.Name = "cbRH";
            this.cbRH.Size = new System.Drawing.Size(52, 25);
            this.cbRH.TabIndex = 2;
            this.cbRH.SelectedIndexChanged += new System.EventHandler(this.cbRH_SelectedIndexChanged);
            this.cbRH.SelectionChangeCommitted += new System.EventHandler(this.cbRH_SelectionChangeCommitted);
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
            this.cbAPP.Location = new System.Drawing.Point(303, 6);
            this.cbAPP.Margin = new System.Windows.Forms.Padding(2);
            this.cbAPP.Name = "cbAPP";
            this.cbAPP.Size = new System.Drawing.Size(77, 25);
            this.cbAPP.TabIndex = 2;
            this.cbAPP.SelectionChangeCommitted += new System.EventHandler(this.cbAPP_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(231, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "APP状态：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "水份检测：";
            // 
            // btnEnd
            // 
            this.btnEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnd.Location = new System.Drawing.Point(440, 2);
            this.btnEnd.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(75, 29);
            this.btnEnd.TabIndex = 0;
            this.btnEnd.Text = "退出";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnOpenFind
            // 
            this.btnOpenFind.Enabled = false;
            this.btnOpenFind.Location = new System.Drawing.Point(2, 2);
            this.btnOpenFind.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenFind.Name = "btnOpenFind";
            this.btnOpenFind.Size = new System.Drawing.Size(75, 29);
            this.btnOpenFind.TabIndex = 0;
            this.btnOpenFind.Text = "开启查询";
            this.btnOpenFind.UseVisualStyleBackColor = true;
            this.btnOpenFind.Click += new System.EventHandler(this.btnOpenFind_Click);
            // 
            // menuMain
            // 
            this.menuMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuOpenSerial,
            this.menuSerial,
            this.menuFunction,
            this.menuCmd,
            this.menuAbout});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuMain.Size = new System.Drawing.Size(532, 24);
            this.menuMain.TabIndex = 2;
            this.menuMain.Text = "menuStrip1";
            // 
            // menuOpenSerial
            // 
            this.menuOpenSerial.Name = "menuOpenSerial";
            this.menuOpenSerial.ShortcutKeyDisplayString = "";
            this.menuOpenSerial.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.menuOpenSerial.Size = new System.Drawing.Size(68, 22);
            this.menuOpenSerial.Text = "打开串口";
            this.menuOpenSerial.Click += new System.EventHandler(this.打开端口ToolStripMenuItem_Click);
            // 
            // menuSerial
            // 
            this.menuSerial.Name = "menuSerial";
            this.menuSerial.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.menuSerial.Size = new System.Drawing.Size(68, 22);
            this.menuSerial.Text = "串口设置";
            this.menuSerial.Click += new System.EventHandler(this.设置ToolStripMenuItem_Click);
            // 
            // menuFunction
            // 
            this.menuFunction.Name = "menuFunction";
            this.menuFunction.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.menuFunction.Size = new System.Drawing.Size(68, 22);
            this.menuFunction.Text = "功能设置";
            this.menuFunction.Click += new System.EventHandler(this.menuFunction_Click);
            // 
            // menuCmd
            // 
            this.menuCmd.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuClearCmd,
            this.menuFontCmd,
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
            this.menuCmd.Name = "menuCmd";
            this.menuCmd.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.B)));
            this.menuCmd.Size = new System.Drawing.Size(44, 22);
            this.menuCmd.Text = "报文";
            // 
            // menuClearCmd
            // 
            this.menuClearCmd.Name = "menuClearCmd";
            this.menuClearCmd.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.menuClearCmd.Size = new System.Drawing.Size(148, 22);
            this.menuClearCmd.Text = "清空报文";
            this.menuClearCmd.Click += new System.EventHandler(this.menuClearCmd_Click);
            // 
            // menuFontCmd
            // 
            this.menuFontCmd.Name = "menuFontCmd";
            this.menuFontCmd.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.menuFontCmd.Size = new System.Drawing.Size(148, 22);
            this.menuFontCmd.Text = "报文样式";
            this.menuFontCmd.Click += new System.EventHandler(this.menuFontCmd_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(145, 6);
            // 
            // menuShowLogCmd
            // 
            this.menuShowLogCmd.Checked = true;
            this.menuShowLogCmd.CheckOnClick = true;
            this.menuShowLogCmd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuShowLogCmd.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuShowLogCmd.Name = "menuShowLogCmd";
            this.menuShowLogCmd.Size = new System.Drawing.Size(148, 22);
            this.menuShowLogCmd.Text = "显示提示信息";
            // 
            // menuShowSendData
            // 
            this.menuShowSendData.Checked = true;
            this.menuShowSendData.CheckOnClick = true;
            this.menuShowSendData.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuShowSendData.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuShowSendData.Name = "menuShowSendData";
            this.menuShowSendData.Size = new System.Drawing.Size(148, 22);
            this.menuShowSendData.Text = "显示发送数据";
            // 
            // menuShowRcvData
            // 
            this.menuShowRcvData.Checked = true;
            this.menuShowRcvData.CheckOnClick = true;
            this.menuShowRcvData.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuShowRcvData.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuShowRcvData.Name = "menuShowRcvData";
            this.menuShowRcvData.Size = new System.Drawing.Size(148, 22);
            this.menuShowRcvData.Text = "显示接收数据";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(145, 6);
            // 
            // menuShowCmdTime
            // 
            this.menuShowCmdTime.Checked = true;
            this.menuShowCmdTime.CheckOnClick = true;
            this.menuShowCmdTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuShowCmdTime.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuShowCmdTime.Name = "menuShowCmdTime";
            this.menuShowCmdTime.Size = new System.Drawing.Size(148, 22);
            this.menuShowCmdTime.Text = "显示报文时间";
            // 
            // menuShowCmdHead
            // 
            this.menuShowCmdHead.Checked = true;
            this.menuShowCmdHead.CheckOnClick = true;
            this.menuShowCmdHead.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuShowCmdHead.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuShowCmdHead.Name = "menuShowCmdHead";
            this.menuShowCmdHead.Size = new System.Drawing.Size(148, 22);
            this.menuShowCmdHead.Text = "显示报文头";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(145, 6);
            // 
            // menuOutputCmd
            // 
            this.menuOutputCmd.Name = "menuOutputCmd";
            this.menuOutputCmd.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.menuOutputCmd.Size = new System.Drawing.Size(148, 22);
            this.menuOutputCmd.Text = "动态输出";
            this.menuOutputCmd.Click += new System.EventHandler(this.menuOutputCmd_Click);
            // 
            // menuSaveCmd
            // 
            this.menuSaveCmd.Name = "menuSaveCmd";
            this.menuSaveCmd.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.menuSaveCmd.Size = new System.Drawing.Size(148, 22);
            this.menuSaveCmd.Text = "保存报文";
            this.menuSaveCmd.Click += new System.EventHandler(this.menuSaveCmd_Click);
            // 
            // menuAbout
            // 
            this.menuAbout.Name = "menuAbout";
            this.menuAbout.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.menuAbout.Size = new System.Drawing.Size(44, 22);
            this.menuAbout.Text = "关于";
            this.menuAbout.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // statusMain
            // 
            this.statusMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSerial,
            this.tsBaudRate,
            this.tsTime,
            this.tsStatus});
            this.statusMain.Location = new System.Drawing.Point(0, 435);
            this.statusMain.Name = "statusMain";
            this.statusMain.Padding = new System.Windows.Forms.Padding(0, 0, 7, 0);
            this.statusMain.Size = new System.Drawing.Size(532, 26);
            this.statusMain.TabIndex = 3;
            this.statusMain.Text = "statusStrip1";
            // 
            // tsSerial
            // 
            this.tsSerial.AutoToolTip = true;
            this.tsSerial.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsSerial.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsSerial.Name = "tsSerial";
            this.tsSerial.Size = new System.Drawing.Size(72, 21);
            this.tsSerial.Text = "串口：关闭";
            this.tsSerial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsBaudRate
            // 
            this.tsBaudRate.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsBaudRate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsBaudRate.Name = "tsBaudRate";
            this.tsBaudRate.Size = new System.Drawing.Size(92, 21);
            this.tsBaudRate.Text = "波特率：9600 ";
            // 
            // tsTime
            // 
            this.tsTime.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tsTime.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsTime.Name = "tsTime";
            this.tsTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tsTime.Size = new System.Drawing.Size(48, 21);
            this.tsTime.Text = "时间：";
            this.tsTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tsStatus
            // 
            this.tsStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsStatus.Name = "tsStatus";
            this.tsStatus.Size = new System.Drawing.Size(116, 21);
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
            this.rtCmd.Location = new System.Drawing.Point(6, 66);
            this.rtCmd.Margin = new System.Windows.Forms.Padding(2);
            this.rtCmd.Name = "rtCmd";
            this.rtCmd.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtCmd.Size = new System.Drawing.Size(380, 327);
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
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoScroll = true;
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.txtRcvError);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.txtRcvVersion);
            this.panel2.Controls.Add(this.txtRcvRhH);
            this.panel2.Controls.Add(this.txtRcvAdjust);
            this.panel2.Controls.Add(this.txtRcvThTemp);
            this.panel2.Controls.Add(this.txtRcvHotTemp);
            this.panel2.Controls.Add(this.txtRcvRh3);
            this.panel2.Controls.Add(this.txtRcvRh2);
            this.panel2.Controls.Add(this.txtRcvRh1);
            this.panel2.Controls.Add(this.txtRcvTime);
            this.panel2.Controls.Add(this.txtRcvMode);
            this.panel2.Controls.Add(this.txtRcvStatus);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(388, 66);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(134, 366);
            this.panel2.TabIndex = 5;
            // 
            // txtRcvError
            // 
            this.txtRcvError.Enabled = false;
            this.txtRcvError.Font = new System.Drawing.Font("微软雅黑", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRcvError.Location = new System.Drawing.Point(58, 293);
            this.txtRcvError.Margin = new System.Windows.Forms.Padding(2);
            this.txtRcvError.Name = "txtRcvError";
            this.txtRcvError.ReadOnly = true;
            this.txtRcvError.Size = new System.Drawing.Size(52, 21);
            this.txtRcvError.TabIndex = 3;
            this.txtRcvError.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(10, 291);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 20);
            this.label14.TabIndex = 2;
            this.label14.Text = "异常：";
            // 
            // txtRcvVersion
            // 
            this.txtRcvVersion.Enabled = false;
            this.txtRcvVersion.Font = new System.Drawing.Font("微软雅黑", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRcvVersion.Location = new System.Drawing.Point(58, 268);
            this.txtRcvVersion.Margin = new System.Windows.Forms.Padding(2);
            this.txtRcvVersion.Name = "txtRcvVersion";
            this.txtRcvVersion.ReadOnly = true;
            this.txtRcvVersion.Size = new System.Drawing.Size(52, 21);
            this.txtRcvVersion.TabIndex = 1;
            // 
            // txtRcvRhH
            // 
            this.txtRcvRhH.ContextMenuStrip = this.menuRcvRh;
            this.txtRcvRhH.Enabled = false;
            this.txtRcvRhH.Font = new System.Drawing.Font("微软雅黑", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRcvRhH.Location = new System.Drawing.Point(58, 242);
            this.txtRcvRhH.Margin = new System.Windows.Forms.Padding(2);
            this.txtRcvRhH.Name = "txtRcvRhH";
            this.txtRcvRhH.ReadOnly = true;
            this.txtRcvRhH.Size = new System.Drawing.Size(52, 21);
            this.txtRcvRhH.TabIndex = 1;
            this.txtRcvRhH.TextChanged += new System.EventHandler(this.txtRcvRhH_TextChanged);
            // 
            // menuRcvRh
            // 
            this.menuRcvRh.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuRcvRh.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuRcvRhSave,
            this.toolStripMenuItem4,
            this.menuRcvRhOpenXls,
            this.menuRcvRhOpenChart});
            this.menuRcvRh.Name = "menuRcvRh";
            this.menuRcvRh.Size = new System.Drawing.Size(125, 76);
            // 
            // menuRcvRhSave
            // 
            this.menuRcvRhSave.Name = "menuRcvRhSave";
            this.menuRcvRhSave.Size = new System.Drawing.Size(124, 22);
            this.menuRcvRhSave.Text = "保存数据";
            this.menuRcvRhSave.Click += new System.EventHandler(this.menuRcvRhSave_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(121, 6);
            // 
            // menuRcvRhOpenXls
            // 
            this.menuRcvRhOpenXls.Name = "menuRcvRhOpenXls";
            this.menuRcvRhOpenXls.Size = new System.Drawing.Size(124, 22);
            this.menuRcvRhOpenXls.Text = "打开表格";
            this.menuRcvRhOpenXls.Click += new System.EventHandler(this.menuRcvRhOpenXls_Click);
            // 
            // menuRcvRhOpenChart
            // 
            this.menuRcvRhOpenChart.Name = "menuRcvRhOpenChart";
            this.menuRcvRhOpenChart.Size = new System.Drawing.Size(124, 22);
            this.menuRcvRhOpenChart.Text = "导出图表";
            this.menuRcvRhOpenChart.Click += new System.EventHandler(this.menuRcvRhOpenChart_Click);
            // 
            // txtRcvAdjust
            // 
            this.txtRcvAdjust.Enabled = false;
            this.txtRcvAdjust.Font = new System.Drawing.Font("微软雅黑", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRcvAdjust.Location = new System.Drawing.Point(58, 64);
            this.txtRcvAdjust.Margin = new System.Windows.Forms.Padding(2);
            this.txtRcvAdjust.Name = "txtRcvAdjust";
            this.txtRcvAdjust.ReadOnly = true;
            this.txtRcvAdjust.Size = new System.Drawing.Size(52, 21);
            this.txtRcvAdjust.TabIndex = 1;
            // 
            // txtRcvThTemp
            // 
            this.txtRcvThTemp.Enabled = false;
            this.txtRcvThTemp.Font = new System.Drawing.Font("微软雅黑", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRcvThTemp.Location = new System.Drawing.Point(58, 217);
            this.txtRcvThTemp.Margin = new System.Windows.Forms.Padding(2);
            this.txtRcvThTemp.Name = "txtRcvThTemp";
            this.txtRcvThTemp.ReadOnly = true;
            this.txtRcvThTemp.Size = new System.Drawing.Size(52, 21);
            this.txtRcvThTemp.TabIndex = 1;
            // 
            // txtRcvHotTemp
            // 
            this.txtRcvHotTemp.Enabled = false;
            this.txtRcvHotTemp.Font = new System.Drawing.Font("微软雅黑", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRcvHotTemp.Location = new System.Drawing.Point(58, 192);
            this.txtRcvHotTemp.Margin = new System.Windows.Forms.Padding(2);
            this.txtRcvHotTemp.Name = "txtRcvHotTemp";
            this.txtRcvHotTemp.ReadOnly = true;
            this.txtRcvHotTemp.Size = new System.Drawing.Size(52, 21);
            this.txtRcvHotTemp.TabIndex = 1;
            // 
            // txtRcvRh3
            // 
            this.txtRcvRh3.Enabled = false;
            this.txtRcvRh3.Font = new System.Drawing.Font("微软雅黑", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRcvRh3.Location = new System.Drawing.Point(58, 166);
            this.txtRcvRh3.Margin = new System.Windows.Forms.Padding(2);
            this.txtRcvRh3.Name = "txtRcvRh3";
            this.txtRcvRh3.ReadOnly = true;
            this.txtRcvRh3.Size = new System.Drawing.Size(52, 21);
            this.txtRcvRh3.TabIndex = 1;
            // 
            // txtRcvRh2
            // 
            this.txtRcvRh2.Enabled = false;
            this.txtRcvRh2.Font = new System.Drawing.Font("微软雅黑", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRcvRh2.Location = new System.Drawing.Point(58, 140);
            this.txtRcvRh2.Margin = new System.Windows.Forms.Padding(2);
            this.txtRcvRh2.Name = "txtRcvRh2";
            this.txtRcvRh2.ReadOnly = true;
            this.txtRcvRh2.Size = new System.Drawing.Size(52, 21);
            this.txtRcvRh2.TabIndex = 1;
            // 
            // txtRcvRh1
            // 
            this.txtRcvRh1.Enabled = false;
            this.txtRcvRh1.Font = new System.Drawing.Font("微软雅黑", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRcvRh1.Location = new System.Drawing.Point(58, 115);
            this.txtRcvRh1.Margin = new System.Windows.Forms.Padding(2);
            this.txtRcvRh1.Name = "txtRcvRh1";
            this.txtRcvRh1.ReadOnly = true;
            this.txtRcvRh1.Size = new System.Drawing.Size(52, 21);
            this.txtRcvRh1.TabIndex = 1;
            // 
            // txtRcvTime
            // 
            this.txtRcvTime.Enabled = false;
            this.txtRcvTime.Font = new System.Drawing.Font("微软雅黑", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRcvTime.Location = new System.Drawing.Point(58, 90);
            this.txtRcvTime.Margin = new System.Windows.Forms.Padding(2);
            this.txtRcvTime.Name = "txtRcvTime";
            this.txtRcvTime.ReadOnly = true;
            this.txtRcvTime.Size = new System.Drawing.Size(52, 21);
            this.txtRcvTime.TabIndex = 1;
            // 
            // txtRcvMode
            // 
            this.txtRcvMode.Enabled = false;
            this.txtRcvMode.Font = new System.Drawing.Font("微软雅黑", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRcvMode.Location = new System.Drawing.Point(58, 38);
            this.txtRcvMode.Margin = new System.Windows.Forms.Padding(2);
            this.txtRcvMode.Name = "txtRcvMode";
            this.txtRcvMode.ReadOnly = true;
            this.txtRcvMode.Size = new System.Drawing.Size(52, 21);
            this.txtRcvMode.TabIndex = 1;
            // 
            // txtRcvStatus
            // 
            this.txtRcvStatus.Enabled = false;
            this.txtRcvStatus.Font = new System.Drawing.Font("微软雅黑", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRcvStatus.Location = new System.Drawing.Point(58, 13);
            this.txtRcvStatus.Margin = new System.Windows.Forms.Padding(2);
            this.txtRcvStatus.Name = "txtRcvStatus";
            this.txtRcvStatus.ReadOnly = true;
            this.txtRcvStatus.Size = new System.Drawing.Size(52, 21);
            this.txtRcvStatus.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 266);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "版本：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ContextMenuStrip = this.menuRcvRh;
            this.label12.ForeColor = System.Drawing.Color.Blue;
            this.label12.Location = new System.Drawing.Point(10, 241);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "参数：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 62);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "强度：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 216);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "环温：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 190);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "散热：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 164);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "弹性：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 139);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "油份：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 114);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "水份：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 88);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "时长：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 37);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "模式：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "状态：";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.txtTaskInfo);
            this.panel3.Location = new System.Drawing.Point(6, 398);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(380, 34);
            this.panel3.TabIndex = 6;
            // 
            // txtTaskInfo
            // 
            this.txtTaskInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTaskInfo.Enabled = false;
            this.txtTaskInfo.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTaskInfo.Location = new System.Drawing.Point(0, 4);
            this.txtTaskInfo.Name = "txtTaskInfo";
            this.txtTaskInfo.ReadOnly = true;
            this.txtTaskInfo.Size = new System.Drawing.Size(380, 23);
            this.txtTaskInfo.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(532, 461);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusMain);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuMain);
            this.Controls.Add(this.rtCmd);
            this.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.MainMenuStrip = this.menuMain;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(548, 259);
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuRcvRh.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnOpenFind;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem menuOpenSerial;
        private System.Windows.Forms.ToolStripMenuItem menuSerial;
        private System.Windows.Forms.ToolStripMenuItem menuFunction;
        private System.Windows.Forms.ToolStripMenuItem menuCmd;
        private System.Windows.Forms.ToolStripMenuItem menuClearCmd;
        private System.Windows.Forms.ToolStripMenuItem menuSaveCmd;
        private System.Windows.Forms.StatusStrip statusMain;
        private System.Windows.Forms.ComboBox cbRH;
        private System.Windows.Forms.ComboBox cbAPP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem menuAbout;
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtRcvVersion;
        private System.Windows.Forms.TextBox txtRcvRhH;
        private System.Windows.Forms.TextBox txtRcvAdjust;
        private System.Windows.Forms.TextBox txtRcvThTemp;
        private System.Windows.Forms.TextBox txtRcvHotTemp;
        private System.Windows.Forms.TextBox txtRcvRh3;
        private System.Windows.Forms.TextBox txtRcvRh2;
        private System.Windows.Forms.TextBox txtRcvRh1;
        private System.Windows.Forms.TextBox txtRcvTime;
        private System.Windows.Forms.TextBox txtRcvMode;
        private System.Windows.Forms.TextBox txtRcvStatus;
        private System.Windows.Forms.ToolStripMenuItem menuFontCmd;
        private System.Windows.Forms.ContextMenuStrip menuRcvRh;
        private System.Windows.Forms.ToolStripMenuItem menuRcvRhSave;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem menuRcvRhOpenXls;
        private System.Windows.Forms.ToolStripMenuItem menuRcvRhOpenChart;
        private System.Windows.Forms.TextBox txtRcvError;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtTaskInfo;
    }
}

