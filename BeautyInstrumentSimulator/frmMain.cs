using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using INIFILE;
using DocDetector.Core.Extensions;
using System.IO;

namespace BeautyInstrumentSimulator
{
    public partial class frmMain : Form
    {
        public SerialPort sp1 = new SerialPort();
        frmFunction FormFunction = new frmFunction();
        frmAbout FormAbout = new frmAbout();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            //加载报文配置
            Cmd.LoadCmd();
            menuShowLogCmd.Checked = Cmd.C_SHOW_LOG == "TRUE" ? true : false;
            menuShowRcvData.Checked = Cmd.C_SHOW_RCV == "TRUE" ? true : false;
            menuShowSendData.Checked = Cmd.C_SHOW_SEND == "TRUE" ? true : false;
            menuShowCmdHead.Checked = Cmd.C_SHOW_HEAD == "TRUE" ? true : false;
            menuShowCmdTime.Checked = Cmd.C_SHOW_TIME == "TRUE" ? true : false;
            FontConverter fc = new FontConverter();
            try
            {
                rtCmd.Font = (Font)fc.ConvertFromInvariantString(Cmd.C_FONT);
            }
            catch (NotSupportedException)
            {
                Cmd.C_FONT = fc.ConvertToInvariantString(rtCmd.Font);
                Console.WriteLine("读取字体异常，已恢复：" + Cmd.C_FONT);
                throw;
            }

            //界面初始化
            Function.LoadFunction();
            if (((Function.F_MAIN_X) != "NULL") && ((Function.F_MAIN_Y) != "NULL")) 
            {
                int left = Convert.ToInt32(Function.F_MAIN_X);
                int top = Convert.ToInt32(Function.F_MAIN_Y);
                if (left >= 0 && top >= 0) 
                {
                    this.Left = left;
                    this.Top = top;
                    if(Convert.ToInt32(Function.F_MAIN_WIDTH) >= this.MinimumSize.Width)
                    {
                        this.Width = Convert.ToInt32(Function.F_MAIN_WIDTH);
                    }
                    if (Convert.ToInt32(Function.F_MAIN_HEIGHT) >= this.MinimumSize.Height)
                    {
                        this.Height = Convert.ToInt32(Function.F_MAIN_HEIGHT);
                    }
                }
            }
            cbRH.SelectedIndex = 0;
            cbAPP.SelectedIndex = 0;

            //串口配置初始化
            sp1 = new SerialPort();
            Control.CheckForIllegalCrossThreadCalls = false;    //这个类中我们不检查跨线程的调用是否合法(因为.net 2.0以后加强了安全机制,，不允许在winform中直接跨线程访问控件的属性)
            sp1.DataReceived += new SerialDataReceivedEventHandler(sp1_DataReceived);           
            sp1.DtrEnable = true;
            sp1.RtsEnable = true;
            sp1.Close();

            rtCmd.Clear();
            funcOutputLog("准备就绪，等待串口开启。");

            //打开串口
            funcOpenSerialPort();
        }

        private void rtCmd_TextChanged(object sender, EventArgs e)
        {
            rtCmd.SelectionStart = rtCmd.Text.Length;
            rtCmd.SelectionLength = 0;
            rtCmd.ScrollToCaret();
        }

        private void 设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            funcCloseSerialPort();
            this.Hide();
            this.DialogResult = DialogResult.OK;
        }

        private void menuFunction_Click(object sender, EventArgs e)
        {
            FormFunction.Show();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout.Show();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            funcSaveConfig();
            if (this.DialogResult != DialogResult.OK)
            {
                System.Environment.Exit(0);
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            funcSaveConfig();
            System.Environment.Exit(0);
        }

        private void 打开端口ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (menuOpenSerial.Text == "打开串口")
            {
                //打开串口
                funcOpenSerialPort();
            }
            else
            {
                //关闭串口
                funcCloseSerialPort();
            }
        }

        private void btnOpenFind_Click(object sender, EventArgs e)
        {
            if (btnOpenFind.Text == "开启查询")
            {
                //打开自动发送数据
                funcOpenUart();
            }
            else
            {
                //关闭自动发送数据
                funcCloseUart();
                funcOutputLog("通信功能已关闭");
            }
        }

        void sp1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (sp1.IsOpen)
            {
                //输出当前时间
                string strTextBuff = "";

                byte[] byteRead = new byte[sp1.BytesToRead];    //BytesToRead:sp1接收的字符个数
                if (Profile.G_DATA_RCVSTR == "TRUE")            //接收字符串格式
                {
                    try
                    {
                        strTextBuff += sp1.ReadLine();
                        sp1.DiscardInBuffer();                  //清空SerialPort控件的Buffer 
                    }
                    catch (System.Exception ex)
                    {
                        funcOutputLog("【接收出错】" + ex.Message, "错误");
                        return;
                    }
                }
                else                                            //接收16进制格式
                {
                    try
                    {
                        Byte[] receivedData = new Byte[sp1.BytesToRead];        //创建接收字节数组
                        sp1.Read(receivedData, 0, receivedData.Length);         //读取数据
                        RcvDataProcess(receivedData);                           //接收数据处理
                        sp1.DiscardInBuffer();                                  //清空SerialPort控件的Buffer
                        if(receivedData.Length <= 0)
                        {
                            return;
                        }
                        string strRcv = null;
                        for (int i = 0; i < receivedData.Length; i++)
                        {
                            strRcv += (i > 0) ? " " : "";
                            strRcv += receivedData[i].ToString("X2");           //16进制显示
                        }
                        strTextBuff += strRcv;

                    }
                    catch (System.Exception ex)
                    {
                        funcOutputLog("【接收出错】" + ex.Message, "错误");
                        return;
                    }
                }
                funcOutputLog(strTextBuff, "接收");
            }
            else
            {
                funcOutputLog("【串口出错】串口没有被打开。", "错误");
            }
        }

        void sp1_DataSend(string strBuff)
        {
            if (sp1.IsOpen)
            {
                //输出当前时间
                string strTextBuff = "";

                if (Profile.G_DATA_SENDSTR == "TRUE")    //字符串格式发送
                {
                    sp1.WriteLine(strBuff);
                    strTextBuff += strBuff;
                }
                else                                    //16进制格式发送
                {
                    string strBuffHex = strBuff;
                    strBuffHex = strBuffHex.Trim();     //去除前后空字符
                    strBuffHex = strBuffHex.Replace(',', ' ');  //去掉英文逗号
                    strBuffHex = strBuffHex.Replace('，', ' '); //去掉中文逗号
                    strBuffHex = strBuffHex.Replace("0x", "");  //去掉0x
                    strBuffHex = strBuffHex.Replace("0X", "");  //去掉0X
                    string[] strArray = strBuffHex.Split(' ');
                    int byteBufferLength = strArray.Length;
                    for (int i = 0; i < strArray.Length; i++)
                    {
                        if (strArray[i] == "")
                        {
                            byteBufferLength--;
                        }
                    }
                    byte[] byteBuffer = new byte[byteBufferLength];
                    int ii = 0;
                    for (int i = 0; i < strArray.Length; i++)        //对获取的字符做相加运算
                    {

                        Byte[] bytesOfStr = Encoding.Default.GetBytes(strArray[i]);

                        int decNum = 0;
                        if (strArray[i] == "")
                        {
                            continue;
                        }
                        else
                        {
                            decNum = Convert.ToInt32(strArray[i], 16); //atrArray[i] == 12时，temp == 18 
                        }

                        try    //防止输错，使其只能输入一个字节的字符
                        {
                            byteBuffer[ii] = Convert.ToByte(decNum);
                        }
                        catch (System.Exception)
                        {
                            funcOutputLog("【发送出错】字节越界，请逐个字节输入！", "错误");
                            return;
                        }
                        ii++;
                    }
                    try
                    {
                        sp1.Write(byteBuffer, 0, byteBuffer.Length);
                    }
                    catch (Exception)
                    {
                        funcCloseSerialPort();
                        MessageBox.Show("串口设备出现异常，请重新连接。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                    strTextBuff += strBuffHex;
                }
                funcOutputLog(strTextBuff, "发送");
            }
        }

        public void funcOpenSerialPort()
        {
            if (!sp1.IsOpen)
            {
                try
                {
                    sp1.PortName = Profile.G_PORTNAME;
                    sp1.BaudRate = Convert.ToInt32(Profile.G_BAUDRATE);
                    sp1.DataBits = Convert.ToInt32(Profile.G_DATABITS);
                    switch (Profile.G_STOP)
                    {
                        case "1":
                            sp1.StopBits = StopBits.One;
                            break;
                        case "1.5":
                            sp1.StopBits = StopBits.OnePointFive;
                            break;
                        case "2":
                            sp1.StopBits = StopBits.Two;
                            break;
                        default:
                            MessageBox.Show("Error：参数不正确!", "Error");
                            break;
                    }
                    switch (Profile.G_PARITY)             //校验位
                    {
                        case "NONE":
                            sp1.Parity = Parity.None;
                            break;
                        case "ODD":
                            sp1.Parity = Parity.Odd;
                            break;
                        case "EVEN":
                            sp1.Parity = Parity.Even;
                            break;
                        default:
                            MessageBox.Show("Error：参数不正确!", "Error");
                            break;
                    }
                    if (sp1.IsOpen == true)//如果打开状态，则先关闭一下
                    {
                        sp1.Close();
                    }
                    sp1.Open();     //打开串口
                    menuOpenSerial.Text = "关闭串口";
                    tsSerial.Text = "串口：" + Profile.G_PORTNAME;
                    funcOutputLog("串口" + Profile.G_PORTNAME + "已经开启");
                    btnOpenFind.Enabled = true;
                    funcCloseUart();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message + "\r\n请重新连接串口设备或点击串口设置重新选择串口", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnOpenFind.Enabled = false;
                    funcCloseUart();
                    menuOpenSerial.Text = "打开串口";
                    tsSerial.Text = "串口：关闭";
                    return;
                }
            }
            else
            {
                MessageBox.Show("端口已被打开", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        public void funcCloseSerialPort()
        {
            btnOpenFind.Enabled = false;
            funcCloseUart();
            menuOpenSerial.Text = "打开串口";
            funcOutputLog("串口" + Profile.G_PORTNAME + "已经关闭");
            tsSerial.Text = "串口：关闭";

            try
            {
                sp1.Close();
            }
            catch
            {
                return;
            }

        }

        public void funcOpenUart()
        {
            if (sp1.IsOpen)
            {
                timUart.Interval = 500;
                timUart.Enabled = true;
                btnOpenFind.Text = "关闭查询";
                funcOutputLog("通信功能已开启");
            }
            else
            {
                funcCloseUart();
                btnOpenFind.Enabled = false;
            }
        }

        public void funcCloseUart()
        {
            cbAPP.SelectedIndex = 0;
            cbRH.SelectedIndex = 0;
            timUart.Enabled = false;
            btnOpenFind.Text = "开启查询";
        }

        public void funcSaveConfig()
        {
            //报文配置
            Cmd.C_SHOW_HEAD = menuShowCmdHead.Checked ? "TRUE" : "FALSE";
            Cmd.C_SHOW_TIME = menuShowCmdTime.Checked ? "TRUE" : "FALSE";
            Cmd.C_SHOW_LOG = menuShowLogCmd.Checked ? "TRUE" : "FALSE";
            Cmd.C_SHOW_SEND = menuShowSendData.Checked ? "TRUE" : "FALSE";
            Cmd.C_SHOW_RCV = menuShowRcvData.Checked ? "TRUE" : "FALSE";
            FontConverter fc = new FontConverter();
            Cmd.C_FONT = fc.ConvertToInvariantString(rtCmd.Font);
            Cmd.SaveCmd();

            //功能配置
            Function.F_MAIN_HEIGHT = Convert.ToString(this.Height);
            Function.F_MAIN_WIDTH = Convert.ToString(this.Width);
            Function.F_MAIN_X = Convert.ToString(this.Location.X);
            Function.F_MAIN_Y = Convert.ToString(this.Location.Y);
            Function.SaveFunction();
        }

        public void funcOutputLog(string strLog,string strHead = "提示")
        {
            if ((strHead == "提示") || (strHead == "错误") || (strHead == "警告") || (strHead == "状态"))
            {
                tsStatus.Text = "状态：" + strLog;
                if (!menuShowLogCmd.Checked || (strHead == "状态"))
                {
                    return;
                }
            }

            Color color = Color.Black;
            switch (strHead)
            {
                case "提示":
                    color = Color.Black;
                    break;
                case "发送":
                    color = Color.Blue;
                    if (!menuShowSendData.Checked) return;
                    break;
                case "接收":
                    color = Color.Green;
                    if (!menuShowRcvData.Checked) return;
                    break;
                case "错误":
                    color = Color.Red;
                    break;
                case "警告":
                    color = Color.Orange;
                    break;
                default:
                    return;
            }

            string strTime = "";
            if (menuShowCmdTime.Checked)
            {
                strTime = DateTime.Now.ToString() + " -> ";
            }

            if (menuShowCmdHead.Checked)
            {
                strHead = "【" + strHead + "】";
            }
            else
            {
                strHead = "";
            }

            rtCmd.AppendTextColorful(strHead + strTime + strLog, color);

            if (menuOutputCmd.Checked && (strHead=="【发送】" || strHead=="【接收】"))
            {
                try
                {
                    StreamWriter swOutputCmd = File.AppendText(strOutputCmd);
                    swOutputCmd.WriteLine(strHead + strTime + strLog);
                    swOutputCmd.Flush();
                    swOutputCmd.Close();
                }
                catch
                {
                    menuOutputCmd.Checked = false;
                    MessageBox.Show("动态输出文件无法写入，已关闭。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }

        }

        private void RcvDataProcess(byte[] byteBuff)
        {
            if(byteBuff.Length == 17)
            {
                if ((byteBuff[0] == 0x22) && (byteBuff[1] == 0x0F) && (byteBuff[2] == 0xA5)) 
                {
                    if(byteBuff[16] == Uart.byteCheakSum(byteBuff, 2, 14))
                    {
                        //状态
                        switch (byteBuff[4])
                        {
                            case 0x00:
                                txtRcvStatus.Text = "关机";
                                break;
                            case 0x01:
                                txtRcvStatus.Text = "运行中";
                                break;
                            case 0x02:
                                txtRcvStatus.Text = "暂停";
                                break;
                            case 0x03:
                                txtRcvStatus.Text = "完成";
                                break;
                            case 0xA1:
                                txtRcvStatus.Text = "配置";
                                break;
                            default:
                                txtRcvStatus.Text = "未定义" + byteBuff[4].ToString("X2");
                                break;
                        }

                        //模式
                        if (Uart.isBinTest(byteBuff[5], 3))
                        {
                            txtRcvMode.Text = "水份检测";
                            txtRcvAdjust.Text = "无";
                        }
                        else
                        {
                            string strMode = "无";
                            string strAdjust = "无"; 
                            if(Uart.isBinTest(byteBuff[5], 0))
                            {
                                strAdjust = "弱";
                            }
                            if (Uart.isBinTest(byteBuff[5], 1))
                            {
                                strAdjust = "中";
                            }
                            if (Uart.isBinTest(byteBuff[5], 2))
                            {
                                strAdjust = "强";
                            }
                            if (Uart.isBinTest(byteBuff[5], 4))
                            {
                                strMode = "清洁";
                            }
                            if (Uart.isBinTest(byteBuff[5], 5))
                            {
                                strMode = "保湿";
                            }
                            if (Uart.isBinTest(byteBuff[5], 6))
                            {
                                strMode = "导入";
                            }
                            if (Uart.isBinTest(byteBuff[5], 7))
                            {
                                strMode = "冷敷";
                            }
                            txtRcvMode.Text = strMode;
                            txtRcvAdjust.Text = strAdjust;
                        }

                        //运行时长
                        txtRcvTime.Text = byteBuff[6].ToString() + "秒";

                        //水份百分比
                        txtRcvRh1.Text = byteBuff[7].ToString() + "%";

                        //油分百分比
                        txtRcvRh2.Text = byteBuff[8].ToString() + "%";

                        //弹性百分比
                        txtRcvRh3.Text = byteBuff[9].ToString() + "%";

                        //加热片温度
                        txtRcvHotTemp.Text = byteBuff[10].ToString() + "℃";

                        //环境温度
                        txtRcvThTemp.Text = byteBuff[11].ToString() + "℃";

                        //水份参数
                        txtRcvRhH.Text = "0x" + byteBuff[12].ToString("X2") + byteBuff[13].ToString("X2");

                        //软件版本号
                        txtRcvVersion.Text = "V"+byteBuff[15].ToString();
                    }
                    else
                    {
                        //检验和错误
                    }
                }
            }
        }

        private bool isSendDataChange = false;
        private static byte byteSendDataRH = 0x00;
        private void cbRH_SelectionChangeCommitted(object sender, EventArgs e)
        {
            byte tmp = 0x00;
            if(cbRH.SelectedIndex == 1)
            {
                tmp = 0x08;
            }
            else
            {
                tmp = 0x00;
            }
            if (tmp != byteSendDataRH) 
            {
                isSendDataChange = true;
                byteSendDataRH = tmp;
            }
        }

        private static byte byteSendDataAPP = 0x00;
        private void cbAPP_SelectionChangeCommitted(object sender, EventArgs e)
        {
            byte tmp = 0x00;
            switch (cbAPP.SelectedIndex)
            {
                case 1:
                    tmp = 0xA0;
                    break;
                case 2:
                    tmp = 0xA1;
                    break;
                case 3:
                    tmp = 0xA2;
                    break;
                case 4:
                    tmp = 0xAE;
                    break;
                default:
                    tmp = 0x00;
                    break;
            }
            if(tmp != byteSendDataAPP)
            {
                isSendDataChange = true;
                byteSendDataAPP = tmp;
            }
        }

        private static int intCharNum = 0;
        private void timUart_Tick(object sender, EventArgs e)
        {
            byte[] byteSendData = { 0x22, 0x06, 0xA5, 0x00, 0x00, 0x00, 0x01, 0x00 };
            //设置命令帧类型
            if (isSendDataChange)
            {
                isSendDataChange = false;
                byteSendData[3] = 0x01;
            }

            //设置APP状态
            byteSendData[4] = byteSendDataAPP;
            if (byteSendDataAPP != 0x00)
            {
                byteSendDataAPP = 0x00;
                cbAPP.SelectedIndex = 0; // 复位APP状态
            }

            //设置水份检测开关
            byteSendData[5] = byteSendDataRH;

            //计算校验和
            byteSendData[byteSendData.Length - 1] = Uart.byteCheakSum(byteSendData, 2, 5);

            //发送数据
            sp1_DataSend(Uart.byteToHexStr(byteSendData));

            if (++intCharNum > 3)
            {
                intCharNum = 1;
            }
            funcOutputLog("串口通信中" + new string('.', intCharNum), "状态");
        }

        private void timTime_Tick(object sender, EventArgs e)
        {
            tsTime.Text =  DateTime.Now.ToString() + " ";
            tsBaudRate.Text = "波特率：" + Profile.G_BAUDRATE + " ";
            if(menuOpenSerial.Text == "打开串口")
            {
                funcOutputLog("串口" + Profile.G_PORTNAME + "已经关闭", "状态");
            }
            else if(btnOpenFind.Text == "开启查询")
            {
                funcOutputLog("等待开启查询。", "状态");
            }
        }

        private void menuClearCmd_Click(object sender, EventArgs e)
        {
            rtCmd.Clear();
        }

        private void menuSaveCmd_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "文本格式|*.txt|所有格式|*.*";
            save.RestoreDirectory = true;
            save.FilterIndex = 1;
            if (save.ShowDialog() == DialogResult.OK)
            {
                funcOutputLog("报文保存中。。。", "状态");
                string str = save.FileName;
                StreamWriter sw = File.CreateText(str);
                sw.Write(this.rtCmd.Text.Replace("\n", "\r\n"));
                sw.Flush();
                sw.Close();
                funcOutputLog("报文保存完成", "状态");
            }
        }

        private static string strOutputCmd = "";
        private void menuOutputCmd_Click(object sender, EventArgs e)
        {
            if (menuOutputCmd.Checked)
            {
                menuOutputCmd.Checked = false;
                return;
            }
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "文本格式|*.txt|所有格式|*.*";
            save.RestoreDirectory = true;
            save.FilterIndex = 1;
            if (save.ShowDialog() == DialogResult.OK)
            {
                strOutputCmd = save.FileName;
                StreamWriter swOutputCmd = File.CreateText(strOutputCmd);
                swOutputCmd.Write("");
                swOutputCmd.Flush();
                swOutputCmd.Close();
                funcOutputLog("开启报文动态输出", "状态");
                menuOutputCmd.Checked = true;
            }
        }

        private void menuFontCmd_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            font.Font = rtCmd.Font;
            if(font.ShowDialog() == DialogResult.OK)
            {
                rtCmd.Font = font.Font;
            }
        }

    }
}
