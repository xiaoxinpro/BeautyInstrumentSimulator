using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BeautyInstrumentSimulator
{
    class Chart
    {
        static string strDirectory = "";
        /// <summary>
        /// 表格文件转为js数组文件
        /// </summary>
        /// <param name="xlsPath">表格文件目录</param>
        /// <param name="xRow">横坐标数据列号</param>
        /// <param name="dataRows">数据列</param>
        /// <returns>返回是否成功生成</returns>
        public static bool XlsToJs(string xlsPath, int xRow = 1, params int[] dataRows)
        {
            //判断表格文件是否存在
            if (!File.Exists(xlsPath))
            {
                MessageBox.Show("表格文件不存在。", "错误301", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            //设置输出目录
            strDirectory = System.AppDomain.CurrentDomain.SetupInformation.ApplicationBase + @"Chart\";
            if (!Directory.Exists(strDirectory))
            {
                try
                {
                    Directory.CreateDirectory(strDirectory);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "错误302", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            try
            {
                //创建文件
                StreamReader sr = new StreamReader(xlsPath, Encoding.GetEncoding("gb2312"));
                StreamWriter sw = new StreamWriter(strDirectory + @"chart.js", false, Encoding.GetEncoding("gb2312"));
                StreamWriter swX = new StreamWriter(strDirectory + @"ChartDataX.js", false, Encoding.GetEncoding("gb2312"));
                StreamWriter[] swArr = new StreamWriter[dataRows.Length];
                int chMax = 1;
                sw.Write("var seriesArray = [");
                for (int ch = 0; ch < dataRows.Length; ch++)
                {
                    sw.WriteLine("{name:'AD" + (ch + 1) + "',type:'line',smooth:true,symbol: 'none',sampling: 'average',data: data" + ch + "},");
                    swArr[ch] = new StreamWriter(strDirectory + "ChartData" + ch + ".js", false, Encoding.GetEncoding("gb2312"));
                    swArr[ch].Write("var data" + ch + " = new Array(0");
                    chMax = dataRows[ch] > chMax ? dataRows[ch] : chMax;
                }
                sw.Write("];");
                sw.Flush();
                sw.Close();
                int i = 0;
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    i++;
                    string[] strArray = line.Trim().Split('\t');
                    if (strArray.Length >= chMax && IsInt(strArray[xRow - 1]))
                    {
                        swX.Write("," + new System.Data.DataTable().Compute(strArray[xRow - 1].Replace("=", ""), ""));
                        for (int ch = 0; ch < dataRows.Length; ch++)
                        {
                            swArr[ch].Write("," + new System.Data.DataTable().Compute(strArray[dataRows[ch] - 1].Replace("=", ""), ""));
                        }
                    }
                    else
                    {
                        continue;
                    }
                }

                //关闭文件
                swX.Write(");");
                swX.Flush();
                swX.Close();
                for (int ch = 0; ch < dataRows.Length; ch++)
                {
                    swArr[ch].Write(");");
                    swArr[ch].Flush();
                    swArr[ch].Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "错误303", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        /// <summary>
        /// 打开图表文件
        /// </summary>
        /// <param name="strPath">路径</param>
        public static void OpenChart(string strPath = null)
        {
            if (strPath == null)
            {
                strPath = strDirectory + @"index.html";
            }
            if (File.Exists(strPath))
            {
                System.Diagnostics.Process.Start(strPath);
            }
            else
            {
                MessageBox.Show("路径" + strPath + "不存在。", "错误305", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 判断字符串是否为整数
        /// </summary>
        /// <param name="value">字符串</param>
        /// <returns></returns>
        private static bool IsInt(string value)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(value, @"^[+-]?\d*$");
        }
    }
}
