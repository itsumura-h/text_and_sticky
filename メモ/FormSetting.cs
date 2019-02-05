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
    /*
    http://qiita.com/mik_claire/items/b0d1e22438f66d4eb0bf
    http://qiita.com/39_isao/items/b84919a31a6a671aeed6
    http://www.atmarkit.co.jp/ait/articles/0806/12/news139.html
     */
    public partial class FormSetting : Form
    {
        Form1 f1;

        public FormSetting(Form1 f)　//コンストラクタ引数にメインクラスへの参照を置く
        {
            f1 = f; //メインフォームへの参照を保存
            LoadEnvironmentSetting();
            InitializeComponent();

            //自動保存
            checkBox1.Checked = f1.AutoSaveFlag_getset;
            if (f1.AutoSaveInterval_getset > 0)
            {
                numericAutoSaveInterval.Value = f1.AutoSaveInterval_getset;
            }
            else
            {
                numericAutoSaveInterval.Value = 1;
            }

            //透過度
            trackBar1.Value = (int)(f1.Opacity_getset * 100);
            labelOpacity.Text = trackBar1.Value.ToString();

            //背景色
            colorDialog1.Color = f1.BackColor_getset;
            labelColor.Text = f1.BackColor_getset.ToString();
            panelColor.BackColor = f1.BackColor_getset;

            //フォント
            if(f1.textBox1.Font.Size < 9)
            {
                numericUpDownFont.Value = 9;
            }
            else
            {
                numericUpDownFont.Value = (decimal)f1.textBox1.Font.Size;
            }
            colorDialog2.Color = f1.textBox1.ForeColor;
            panelFontColor.BackColor = f1.textBox1.ForeColor;
        }

        //バーを動かすと透過度が変化
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            labelOpacity.Text = trackBar1.Value.ToString();
        }

        //背景色の変更ボタン
        private void buttonBackColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            labelColor.Text = colorDialog1.Color.ToString();
            panelColor.BackColor = colorDialog1.Color;

        }

        //デフォルトに戻す
        private void buttonDefo_Click(object sender, EventArgs e)
        {
            trackBar1.Value = 70;
            labelOpacity.Text = trackBar1.Value.ToString();
            colorDialog1.Color = Color.White;
            labelColor.Text = colorDialog1.Color.ToString();
            panelColor.BackColor = colorDialog1.Color;
        }

        //文字色
        private void buttonFontColor_Click(object sender, EventArgs e)
        {
            colorDialog2.ShowDialog();
            panelFontColor.BackColor = colorDialog2.Color;
        }

        //保存ボタン
        private void buttonSavePic_Click(object sender, EventArgs e)
        {
            SaveEnvironmentSetting();
            f1.BackColor_getset = colorDialog1.Color;
            f1.Opacity_getset = (double)trackBar1.Value / 100;
            f1.AutoSaveFlag_getset = checkBox1.Checked;
            f1.AutoSaveInterval_getset = numericAutoSaveInterval.Value;
            f1.textBox1.Font = new Font("ＭＳ Ｐゴシック", (float)numericUpDownFont.Value);
            f1.textBox1.ForeColor = colorDialog2.Color;
            this.Close();
            colorDialog1.Dispose();
            colorDialog2.Dispose();
            Dispose();
        }

        private void FormSetting_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveEnvironmentSetting();
        }
    }


    public partial class Form1 : Form
    {
        //自動保存フラグ
        private bool autoSaveFlag;
        public bool AutoSaveFlag_getset
        {
            get { return autoSaveFlag; }
            set { autoSaveFlag = value; }
        }

        //自動保存間隔
        private decimal autoSaveInterval;
        public decimal AutoSaveInterval_getset
        {
            get { return autoSaveInterval; }
            set { autoSaveInterval = value; }
        }

        //不透過率
        public double Opacity_getset
        {
            get { return this.Opacity; }
            set { this.Opacity = value; }
        }

        //背景色
        public Color BackColor_getset
        {
            get { return textBox1.BackColor; }
            set { textBox1.BackColor = value; }
        }

        //ツール→画面設定
        private void 設定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSetting FormSetting1 = new FormSetting(this);
            DialogResult result = FormSetting1.ShowDialog();
        }
    }
}