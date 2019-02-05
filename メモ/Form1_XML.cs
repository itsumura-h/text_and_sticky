using System;using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

//環境設定のバックアップ

namespace メモ
{
    public partial class Form1 : Form
    {
        //---------------関数---------------
        private void LoadSetting()
        {
            //ユーザーにより値が設定されないうちはロードしない
            if (Properties.Settings.Default.Initialized)
            {
                this.Top = Properties.Settings.Default.Top;
                this.Left = Properties.Settings.Default.Left;
                this.Height = Properties.Settings.Default.Height;
                this.Width = Properties.Settings.Default.Width;
                textBox1.BackColor = Properties.Settings.Default.BackColor;
                this.Opacity = Properties.Settings.Default.Opacity;
                this.editFilePath = Properties.Settings.Default.Path;
                autoSaveFlag = Properties.Settings.Default.AutoSaveFlag;
                autoSaveInterval = Properties.Settings.Default.AutoSaveInterval;
                textBox1.ForeColor = Properties.Settings.Default.FontColor;

                try
                {
                    textBox1.Font = Properties.Settings.Default.Font;
                }
                catch (ArgumentException)
                {
                    textBox1.Font = new Font("ＭＳ Ｐゴシック", (float)9.25);
                }

                if (autoSaveFlag)
                {
                    timer1.Interval = (int)autoSaveInterval * 60000;
                    timer1.Enabled = true;
                }
            }
        }

        private void SaveSetting()
        {
            Properties.Settings.Default["Top"] = this.Top;
            Properties.Settings.Default["Left"] = this.Left;
            Properties.Settings.Default["Height"] = this.Height;
            Properties.Settings.Default["Width"] = this.Width;
            Properties.Settings.Default["BackColor"] = textBox1.BackColor;
            Properties.Settings.Default["Opacity"] = this.Opacity;
            Properties.Settings.Default["Path"] = editFilePath;
            Properties.Settings.Default["Initialized"] = true;
            Properties.Settings.Default["AutoSaveFlag"] = autoSaveFlag;
            Properties.Settings.Default["AutoSaveInterval"] = autoSaveInterval;
            Properties.Settings.Default["Font"] = textBox1.Font;
            Properties.Settings.Default["FontColor"] = textBox1.ForeColor;
            Properties.Settings.Default.Save();
        }

        //---------------動作---------------
        //フォームをロードした時
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSetting();

            const string MSGBOX_TITLE = "ファイルオープン";
            string oldPath = Properties.Settings.Default.Path;

            if (Properties.Settings.Default.Path.Length > 0)
            {                
                try
                {
                    //テキストファイルの内容をロード
                    textBox1.Text = File.ReadAllText(oldPath, Encoding.Default);
                    this.Text = GetFileNameString(editFilePath, '\\');
                    setDirty(false);
                    dirtyCheck();
                }
                catch (Exception ex)
                {
                    //ファイルの読み込みでエラーが発生した時にExceptionの内容を表示
                    MessageBox.Show(this, ex.Message, MSGBOX_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }

    public partial class FormSetting : Form
    {
        //---------------関数---------------
        private void LoadEnvironmentSetting()
        {
            //ユーザーにより値が設定されないいうちはロードしない
            if (Properties.Settings.Default.Initialized)
            {
                this.Top = Properties.Settings.Default.E_Top;
                this.Left = Properties.Settings.Default.E_Left;
                this.Height = Properties.Settings.Default.E_Height;
                this.Width = Properties.Settings.Default.E_Width;
            }
        }

        private void SaveEnvironmentSetting()
        {
            Properties.Settings.Default["E_Top"] = this.Top;
            Properties.Settings.Default["E_Left"] = this.Left;
            Properties.Settings.Default["E_Height"] = this.Height;
            Properties.Settings.Default["E_Width"] = this.Width;
            Properties.Settings.Default["E_Initialized"] = true;
            Properties.Settings.Default.Save();
        }

        //---------------動作---------------
        //フォームをロードした時
        private void FormSetting_Load(object sender, EventArgs e)
        {
            LoadEnvironmentSetting();
        }
    }
}