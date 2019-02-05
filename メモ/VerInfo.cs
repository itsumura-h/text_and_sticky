using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace メモ
{
    public partial class VerInfo : Form
    {
        DateTime finishdaytime = new DateTime(2017, 01, 09, 18, 10, 00);


        public VerInfo()
        {
            InitializeComponent();

            label1.Text = "バージョン1.4 Designed and Developed by Mehdi";
            label2.Text = "2017年1月9日完成";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            try
            {
                DateTime nowtime = DateTime.Now;
                TimeSpan progress = nowtime - finishdaytime;
                label3.Text = "完成から" + progress.ToString(@"dd'日'hh'時間'mm'分'ss'秒'") + "経過しました";
            }
            catch(System.ArgumentOutOfRangeException)
            {
                this.Close();
            }
        }

        //リンク
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/mehdibrucetx");
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }
    }

    //---------------動作---------------
    public partial class Form1 : Form
    {
        private void バージョン情報AToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerInfo VerInfo1 = new VerInfo();
            DialogResult result = VerInfo1.ShowDialog();
        }
    }
}
