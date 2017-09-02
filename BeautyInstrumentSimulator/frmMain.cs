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

namespace BeautyInstrumentSimulator
{
    public partial class frmMain : Form
    {
        public SerialPort sp1 = new SerialPort();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            //界面初始化
            cbRH.SelectedIndex = 0;
            cbAPP.SelectedIndex = 0;

            //串口配置初始化
            Control.CheckForIllegalCrossThreadCalls = false;    //这个类中我们不检查跨线程的调用是否合法(因为.net 2.0以后加强了安全机制,，不允许在winform中直接跨线程访问控件的属性)
            sp1.DataReceived += new SerialDataReceivedEventHandler(sp1_DataReceived);           
            sp1.DtrEnable = true;
            sp1.RtsEnable = true;
            sp1.Close();
        }

        private void rtCmd_TextChanged(object sender, EventArgs e)
        {
            rtCmd.SelectionStart = rtCmd.Text.Length;
            rtCmd.SelectionLength = 0;
            rtCmd.ScrollToCaret();
        }

        private void 设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.DialogResult = DialogResult.OK;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(this.DialogResult != DialogResult.OK)
            {
                System.Environment.Exit(0);
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void 打开端口ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (打开端口ToolStripMenuItem.Text == "打开串口")
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
            if(btnOpenFind.Text == "开启查询")
            {
                //打开自动发送数据
                funcOpenUart();
            }
            else
            {
                //关闭自动发送数据
                funcCloseUart();
            }
        }

        void sp1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (sp1.IsOpen)
            {
                //输出当前时间
                string strTextBuff = "【接收】" + DateTime.Now.ToString() + " -> ";

                byte[] byteRead = new byte[sp1.BytesToRead];    //BytesToRead:sp1接收的字符个数
                if (Profile.G_DATA_RCVSTR == "TRUE")            //接收字符串格式
                {
                    strTextBuff += sp1.ReadLine();
                    sp1.DiscardInBuffer();                      //清空SerialPort控件的Buffer 
                }
                else                                            //接收16进制格式
                {
                    try
                    {
                        Byte[] receivedData = new Byte[sp1.BytesToRead];        //创建接收字节数组
                        sp1.Read(receivedData, 0, receivedData.Length);         //读取数据
                        sp1.DiscardInBuffer();                                  //清空SerialPort控件的Buffer
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
                        rtCmd.AppendTextColorful("【接收出错】"+ ex.Message, Color.Red);
                        return;
                    }
                }
                rtCmd.AppendTextColorful(strTextBuff, Color.Green);
            }
            else
            {
                rtCmd.AppendTextColorful("【串口出错】串口没有被打开。" , Color.Red);
            }
        }

        void sp1_DataSend(string strBuff)
        {
            if (sp1.IsOpen)
            {
                //输出当前时间
                string strTextBuff = "【发送】" + DateTime.Now.ToString() + " -> ";

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
                        catch (System.Exception ex)
                        {
                            rtCmd.AppendTextColorful("【发送出错】字节越界，请逐个字节输入！", Color.Red);
                            return;
                        }
                        ii++;
                    }
                    sp1.Write(byteBuffer, 0, byteBuffer.Length);
                    strTextBuff += strBuffHex;
                }
                rtCmd.AppendTextColorful(strTextBuff, Color.Blue);
            }
        }

        public void funcOpenSerialPort()
        {
            if (!sp1.IsOpen)
            {
                try
                {
                    sp1.PortName = Profile.StrPortName;
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
                    打开端口ToolStripMenuItem.Text = "关闭串口";
                    btnOpenFind.Enabled = true;
                    funcCloseUart();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message, "Error");
                    btnOpenFind.Enabled = false;
                    funcCloseUart();
                    打开端口ToolStripMenuItem.Text = "打开串口";
                    return;
                }
            }
            else
            {
                MessageBox.Show("端口已被打开","Error");
            }
        }

        public void funcCloseSerialPort()
        {
            if (sp1.IsOpen)
            {
                try
                {
                    sp1.Close();
                }
                catch
                {
                    MessageBox.Show("关闭串口时发生未知错误。", "Error");
                    return;
                }
                btnOpenFind.Enabled = false;
                funcCloseUart();
                打开端口ToolStripMenuItem.Text = "打开串口";
            }
        }

        public void funcOpenUart()
        {
            if (sp1.IsOpen)
            {
                timUart.Interval = 1000;
                timUart.Enabled = true;
                btnOpenFind.Text = "关闭查询";
            }
            else
            {
                funcCloseUart();
                btnOpenFind.Enabled = false;
            }
        }

        public void funcCloseUart()
        {
            timUart.Enabled = false;
            btnOpenFind.Text = "开启查询";
        }

        private void timUart_Tick(object sender, EventArgs e)
        {
            sp1_DataSend("00 11 22 33 44 55 66 77 88 99");
        }

    }
}
