namespace BeautyInstrumentSimulator
{
    partial class frmFunction
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtTickTime = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbProtocolSend = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "命令发送周期：";
            // 
            // txtTickTime
            // 
            this.txtTickTime.Location = new System.Drawing.Point(207, 41);
            this.txtTickTime.Name = "txtTickTime";
            this.txtTickTime.Size = new System.Drawing.Size(129, 43);
            this.txtTickTime.TabIndex = 1;
            this.txtTickTime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTickTime_KeyPress);
            this.txtTickTime.Validated += new System.EventHandler(this.txtTickTime_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "毫秒";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 35);
            this.label3.TabIndex = 0;
            this.label3.Text = "发送命令协议：";
            // 
            // cbProtocolSend
            // 
            this.cbProtocolSend.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProtocolSend.FormattingEnabled = true;
            this.cbProtocolSend.Items.AddRange(new object[] {
            "协议01",
            "协议02"});
            this.cbProtocolSend.Location = new System.Drawing.Point(207, 104);
            this.cbProtocolSend.Name = "cbProtocolSend";
            this.cbProtocolSend.Size = new System.Drawing.Size(129, 43);
            this.cbProtocolSend.TabIndex = 3;
            // 
            // frmFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(444, 176);
            this.Controls.Add(this.cbProtocolSend);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTickTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmFunction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "功能设置";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmFunction_FormClosing);
            this.Load += new System.EventHandler(this.frmFunction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTickTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbProtocolSend;
    }
}