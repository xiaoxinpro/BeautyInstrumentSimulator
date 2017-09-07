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
        }

        private void frmFunction_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            Function.SaveFunction();
        }
    }
}
