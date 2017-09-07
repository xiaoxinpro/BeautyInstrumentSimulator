using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace INIFILE
{
    class Function
    {
        public static void LoadFunction()
        {
            string strPath = AppDomain.CurrentDomain.BaseDirectory;
            _file = new IniFile(strPath + "Cfg.ini");
            F_NAME = _file.ReadString("FUNCTION", "Name", "美容仪模拟器");    //读数据，下同
            F_TICKTIME = _file.ReadString("FUNCTION", "TickTime", "500");
            F_DATA_SEND = _file.ReadString("FUNCTION", "DataSend", "NULL");
            F_DATA_RCV = _file.ReadString("FUNCTION", "DataRcv", "NULL");
        }

        public static void SaveFunction()
        {
            string strPath = AppDomain.CurrentDomain.BaseDirectory;
            _file = new IniFile(strPath + "Cfg.ini");
            _file.WriteString("FUNCTION", "Name", F_NAME);            //写数据，下同
            _file.WriteString("FUNCTION", "TickTime", F_TICKTIME);
            _file.WriteString("FUNCTION", "DataSend", F_DATA_SEND);
            _file.WriteString("FUNCTION", "DataRcv", F_DATA_RCV);
        }

        private static IniFile _file;

        public static string F_NAME = "美容仪模拟器";
        public static string F_TICKTIME = "500";
        public static string F_DATA_SEND = "NULL";
        public static string F_DATA_RCV = "NULL";

    }
}

