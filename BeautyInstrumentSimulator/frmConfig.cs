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

namespace BeautyInstrumentSimulator
{
    public partial class frmConfig : Form
    {
        frmMain FormMain;

        public frmConfig()
        {
            InitializeComponent();
        }

        //初始化
        private void frmConfig_Load_1(object sender, EventArgs e)
        {
            INIFILE.Profile.LoadProfile();//加载所有

            // 预置波特率
            switch (Profile.G_BAUDRATE)
            {
                case "1200":
                    cbBaudRate.SelectedIndex = 0;
                    break;
                case "2400":
                    cbBaudRate.SelectedIndex = 1;
                    break;
                case "4800":
                    cbBaudRate.SelectedIndex = 2;
                    break;
                case "7200":
                    cbBaudRate.SelectedIndex = 3;
                    break;
                case "9600":
                    cbBaudRate.SelectedIndex = 4;
                    break;
                case "14400":
                    cbBaudRate.SelectedIndex = 5;
                    break;
                case "19200":
                    cbBaudRate.SelectedIndex = 6;
                    break;
                case "38400":
                    cbBaudRate.SelectedIndex = 7;
                    break;
                case "115200":
                    cbBaudRate.SelectedIndex = 8;
                    break;
                case "128000":
                    cbBaudRate.SelectedIndex = 9;
                    break;
                default:
                    {
                        MessageBox.Show("波特率预置参数错误。");
                        return;
                    }
            }

            //预置波特率
            switch (Profile.G_DATABITS)
            {
                case "5":
                    cbDataBits.SelectedIndex = 0;
                    break;
                case "6":
                    cbDataBits.SelectedIndex = 1;
                    break;
                case "7":
                    cbDataBits.SelectedIndex = 2;
                    break;
                case "8":
                    cbDataBits.SelectedIndex = 3;
                    break;
                default:
                    {
                        MessageBox.Show("数据位预置参数错误。");
                        return;
                    }

            }
            //预置停止位
            switch (Profile.G_STOP)
            {
                case "1":
                    cbStop.SelectedIndex = 0;
                    break;
                case "1.5":
                    cbStop.SelectedIndex = 1;
                    break;
                case "2":
                    cbStop.SelectedIndex = 2;
                    break;
                default:
                    {
                        MessageBox.Show("停止位预置参数错误。");
                        return;
                    }
            }

            //预置校验位
            switch (Profile.G_PARITY)
            {
                case "NONE":
                    cbParity.SelectedIndex = 0;
                    break;
                case "ODD":
                    cbParity.SelectedIndex = 1;
                    break;
                case "EVEN":
                    cbParity.SelectedIndex = 2;
                    break;
                default:
                    {
                        MessageBox.Show("校验位预置参数错误。");
                        return;
                    }
            }

            //预置发送数据格式
            switch (Profile.G_DATA_SENDSTR)
            {
                case "FALSE":
                    rbSend16.Checked = true;
                    break;
                case "TRUE":
                    rbSendStr.Checked = true;
                    break;
                default:
                    {
                        MessageBox.Show("发送数据格式预置参数错误。");
                        return;
                    }
            }

            //预置接收数据格式
            switch (Profile.G_DATA_RCVSTR)
            {
                case "FALSE":
                    rbRcv16.Checked = true;
                    break;
                case "TRUE":
                    rbRcvStr.Checked = true;
                    break;
                default:
                    {
                        MessageBox.Show("接收数据格式预置参数错误。");
                        return;
                    }
            }

            //检查是否含有串口
            if (SerialPort.GetPortNames().Length == 0)
            {
                MessageBox.Show("请连接串口设备！", "Error");
                return;
            }

            FormMain = new frmMain();

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SaveSerialData();
            this.Hide();
            if(FormMain.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                FormMain.Show();
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            SaveSerialData();
            if (btnEnd.Text == "退出")
            {
                System.Environment.Exit(0);
            }
            else
            {
                this.Hide();
            }
        }

        private void timSerial_Tick(object sender, EventArgs e)
        {
            //获取串口列表
            string[] arrSerialPortNames = SerialPort.GetPortNames();

            //检查是否含有串口
            if (arrSerialPortNames.Length == 0)
            {
                btnSwitch.Enabled = false;
                btnOK.Enabled = false;
                if (cbSerial.Items.Count > 0)
                {
                    this.Focus(); //使下拉列表失去焦点后清空列表
                    cbSerial.Items.Clear();
                    MessageBox.Show("串口设备失去连接！", "Error");
                }
                return;
            }

            //获取现有串口列表
            List<string> SerialList = new List<string>(); 
            for (int i = 0; i < cbSerial.Items.Count; i++)
            {
                SerialList.Add(cbSerial.Items[i].ToString());
            }

            //判断现有串口和获取的串口列表是否相同
            if (CompareArray(SerialList.ToArray(), arrSerialPortNames) == false)
            {
                //清除串口列表
                this.Focus(); //使下拉列表失去焦点后清空列表
                cbSerial.Items.Clear();

                //添加串口项目
                foreach (string s in arrSerialPortNames)
                {
                    cbSerial.Items.Add(s);
                }

                //串口设置默认选择项
                cbSerial.SelectedIndex = 0;
                btnSwitch.Enabled = true;
                btnOK.Enabled = true;
            }

        }

        private void frmConfig_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSerialData();
        }

        //判断两个字符串数组是否相同
        private static bool CompareArray(string[] arr1,string[] arr2)
        {
            var q = from a in arr1 join b in arr2 on a equals b select a;
            bool flag = arr1.Length == arr2.Length && q.Count() == arr1.Length;
            return flag;//内容相同返回true,反之返回false。
        }

        //保存串口信息
        private void SaveSerialData()
        {
            //设置各“串口设置”
            string strBaudRate = cbBaudRate.Text;
            string strDateBits = cbDataBits.Text;
            string strStopBits = cbStop.Text;
            Int32 iBaudRate = Convert.ToInt32(strBaudRate);
            Int32 iDateBits = Convert.ToInt32(strDateBits);
            Profile.StrPortName = cbSerial.Text;
            Profile.G_BAUDRATE = iBaudRate + "";       //波特率
            Profile.G_DATABITS = iDateBits + "";       //数据位
            switch (cbStop.Text)            //停止位
            {
                case "1":
                    Profile.G_STOP = "1";
                    break;
                case "1.5":
                    Profile.G_STOP = "1.5";
                    break;
                case "2":
                    Profile.G_STOP = "2";
                    break;
                default:
                    MessageBox.Show("Error：参数不正确!", "Error");
                    break;
            }
            switch (cbParity.Text)             //校验位
            {
                case "无":
                    Profile.G_PARITY = "NONE";
                    break;
                case "奇校验":
                    Profile.G_PARITY = "ODD";
                    break;
                case "偶校验":
                    Profile.G_PARITY = "EVEN";
                    break;
                default:
                    MessageBox.Show("Error：参数不正确!", "Error");
                    break;
            }

            if (rbSendStr.Checked)
            {
                Profile.G_DATA_SENDSTR = "TRUE";
            }
            else
            {
                Profile.G_DATA_SENDSTR = "FALSE";
            }

            if (rbRcvStr.Checked)
            {
                Profile.G_DATA_RCVSTR = "TRUE";
            }
            else
            {
                Profile.G_DATA_RCVSTR = "FALSE";
            }   
            Profile.SaveProfile();
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            cbBaudRate.SelectedIndex = 4;
            cbParity.SelectedIndex = 0;
            cbDataBits.SelectedIndex = 3;
            cbStop.SelectedIndex = 0;
        }
    }
}
