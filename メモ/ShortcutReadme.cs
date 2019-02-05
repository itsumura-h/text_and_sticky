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
    public partial class ShortcutReadme : Form
    {
        public ShortcutReadme()
        {
            InitializeComponent();
            label1.Text = "ctrl+C コピー\nctrl+V 貼り付け\nctrl+X 切り取り\nctrl+Z 作業を1つ戻す\nctrl+S 保存する\nEsc アプリを終了する";
            label2.Text = "Alt+F メニューを開く\nAlt+T ツールメニューを開く\nAlt+H ヘルプメニューを開く\nAlt+Q 画面左上に移動(画面外ロスト対策)";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }
    }
}
