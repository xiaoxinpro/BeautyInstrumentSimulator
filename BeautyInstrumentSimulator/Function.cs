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
            F_PROT_SEND = _file.ReadString("FUNCTION", "ProtocolSend", "0");
            F_DATA_SEND = _file.ReadString("FUNCTION", "DataSend", "NULL");
            F_DATA_RCV = _file.ReadString("FUNCTION", "DataRcv", "NULL");
            F_MAIN_HEIGHT = _file.ReadString("FUNCTION", "MainHeight", "0");
            F_MAIN_WIDTH = _file.ReadString("FUNCTION", "MainWidth", "0");
            F_MAIN_X = _file.ReadString("FUNCTION", "MainX", "NULL");
            F_MAIN_Y = _file.ReadString("FUNCTION", "MainY", "NULL");
        }

        public static void SaveFunction()
        {
            string strPath = AppDomain.CurrentDomain.BaseDirectory;
            _file = new IniFile(strPath + "Cfg.ini");
            _file.WriteString("FUNCTION", "Name", F_NAME);            //写数据，下同
            _file.WriteString("FUNCTION", "TickTime", F_TICKTIME);
            _file.WriteString("FUNCTION", "ProtocolSend", F_PROT_SEND);
            _file.WriteString("FUNCTION", "DataSend", F_DATA_SEND);
            _file.WriteString("FUNCTION", "DataRcv", F_DATA_RCV);
            _file.WriteString("FUNCTION", "MainHeight", F_MAIN_HEIGHT);
            _file.WriteString("FUNCTION", "MainWidth", F_MAIN_WIDTH);
            _file.WriteString("FUNCTION", "MainX", F_MAIN_X);
            _file.WriteString("FUNCTION", "MainY", F_MAIN_Y);
        }

        private static IniFile _file;

        public static string F_NAME = "美容仪模拟器";
        public static string F_TICKTIME = "500";
        public static string F_PROT_SEND = "0";
        public static string F_DATA_SEND = "NULL";
        public static string F_DATA_RCV = "NULL";
        public static string F_MAIN_HEIGHT = "0";
        public static string F_MAIN_WIDTH = "0";
        public static string F_MAIN_X = "NULL";
        public static string F_MAIN_Y = "NULL";
    }
}

