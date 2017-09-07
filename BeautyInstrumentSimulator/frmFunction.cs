using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using INIFILE;

namespace BeautyInstrumentSimulator
{
    public partial class frmFunction : Form
    {
        public frmFunction()
        {
            InitializeComponent();
        }

        private void frmFunction_Load(object sender, EventArgs e)
        {
            Function.LoadFunction();
            txtTickTime.Text = Function.F_TICKTIME;
        }

        private void frmFunction_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            Function.SaveFunction();
        }

        private void txtTickTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')//这是允许输入退格键  
            {
                if ((e.KeyChar < '0') || (e.KeyChar > '9'))//这是允许输入0-9数字  
                {
                    e.Handled = true;
                }
            }
        }

        private void txtTickTime_Validated(object sender, EventArgs e)
        {
            if(txtTickTime.Text == "")
            {
                txtTickTime.Text = Function.F_TICKTIME;
            }
            else if(Convert.ToInt32(txtTickTime.Text) < 10)
            {
                txtTickTime.Text = "10";
            }
            else if(Convert.ToInt32(txtTickTime.Text) > 10000)
            {
                txtTickTime.Text = "10000";
            }
        }
    }
}
