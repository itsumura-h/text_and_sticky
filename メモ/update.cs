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
    public partial class update : Form
    {
        public update()
        {
            InitializeComponent();
            label1.Text = updateHistory();
        }

        private string updateHistory()
        {
            string V10 = "1.0  2016年12月30日\n文字入力、読み込み、保存、背景色と透過度の変更\n\n";
            string V11 = "1.1　2017年1月7日\nバージョン情報画面\n\n";
            string V12 = "1.2　2017年1月9日\n自動保存機能、時間経過画面\n\n";
            string V13 = "1.3　2017年1月11日\n文字サイズ変更、ツイッターリンク、更新履歴画面、ショートカットの説明画面\n\n";
            string V14 = "1.4  2017年1月19日\n文字カラー変更、アプリの画面外移動対策";

            return V10 + V11 + V12 + V13 + V14;
        }
    }
}
