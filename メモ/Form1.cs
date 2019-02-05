using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace メモ
{
    public partial class Form1 : Form
    {
        private bool dirtyFlag = false; //テキストに変更されたことを示すフラグ
        private string editFilePath = ""; //編集中ファイルのパス
        
        public Form1() //コンストラクタ 開いたとき
        {
            InitializeComponent();
            dirtyCheck();
            
            if(timer1.Interval == 0)
            {
                timer1.Interval = 60000;
            }
        }

//---------------関数---------------
        private void setDirty(bool flag)
        {
            dirtyFlag = flag; 
        }

        //テキストが変更された時
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //ダーティフラグをセット
            setDirty(true);
            dirtyCheck();
        }

        private void dirtyCheck()
        {
            if (dirtyFlag == true)
            {
                menuSave.Enabled = true;
            }
            else
            {
                menuSave.Enabled = false;
            }
        }

        //フルパスの文字列からファイル名だけを取り出す関数
        private string GetFileNameString(string filePath, char separateChar)
        {
            try
            {
                string[] strArray = filePath.Split(separateChar);
                return strArray[strArray.Length - 1];
            }
            catch
            {
                return "";
            }
        }

        //上書き保存
        private void saveMethod()
        {
            const string MSGBOX_TITLE = "ファイルの上書き保存";

            //保存先ファイルが存在するかチェック
            if (File.Exists(editFilePath))
            {
                try
                {
                    File.WriteAllText(editFilePath, textBox1.Text, Encoding.Default);
                    setDirty(false);
                    dirtyCheck();
                }
                catch (Exception ex)
                {
                    //ファイル書き込みでエラーが発生したらExceptionを表示
                    MessageBox.Show(this, ex.Message, MSGBOX_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                saveAddMethod();
            }
        }

        //名前を付けて保存
        private void saveAddMethod()
        {
            //ファイルが新規作成だった場合の名前
            const string NEW_FILE_NAME = "新規ファイル.txt";
            //編集中のフルパスがファイル名だけを取り出す
            string fileNameString = GetFileNameString(editFilePath, '\\');

            //ファイル名が空白なら新規テキストをセット
            saveFileDialog1.FileName = (fileNameString == "") ? NEW_FILE_NAME : fileNameString;
            saveFileDialog1.ShowDialog(this);
        }

        //保存していない編集中のテキストがある場合に確認するための関数
        private bool confirm(string msgboxTitle)
        {
            const string MSG_BOX_STRING = "ファイルは保存されていません。\n\nテキストは破棄されます。\n\n保存しますか?";
            if (!dirtyFlag) return true;
            return (MessageBox.Show(MSG_BOX_STRING, msgboxTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes);
        }

        //閉じるとき
        private void endMethod()
        {
            const string MSGBOX_TITLE = "アプリケーションの終了";
            const string MSGBOX_STRING = "ファイルは保存されていません。\n\nテキストは破棄されます。\n\n保存しますか?";
            
            if (dirtyFlag == true)
            {
                DialogResult result = MessageBox.Show(MSGBOX_STRING, MSGBOX_TITLE, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    saveMethod();
                    this.Dispose();
                    this.Close();
                }
                else if(result == DialogResult.No)
                {
                    this.Dispose();
                    this.Close();
                }
            }
            else
            {
                this.Dispose();
                this.Close();
            }
        }

        //ファイルを開く
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            const string MSGBOX_TITLE = "ファイルオープン";

            //選択されたファイルパスを取得
            editFilePath = openFileDialog1.FileName;
            //ダーティフラグ リセット
            setDirty(false);

            try
            {
                if (CheckFileType(editFilePath))
                {
                    //ファイルの中身をロード
                    textBox1.Text = File.ReadAllText(editFilePath, Encoding.Default);
                    //タイトルをロード
                    this.Text = GetFileNameString(editFilePath, '\\');
                    setDirty(false);
                    dirtyCheck();
                }
            }
            catch(Exception ex)
            {
                //ファイルの読み込みでエラーが発生した時にExceptionの内容を表示
                MessageBox.Show(this, ex.Message, MSGBOX_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



//---------------動作---------------
        //新規作成
        //テキストボックスの内容をクリアし、タイトルバーに "無題" あるいは "新規作成" と表示
        private void menuNew_Click(object sender, EventArgs e)
        {
            const string MSGBOX_TITLE = "ファイルの新規作成";
            if (confirm(MSGBOX_TITLE))
            {
                this.Text = "Text & Sticky";
                textBox1.Clear();
                editFilePath = "";
                setDirty(false);
            }
        }

        //メニュー→開く
        private void menuOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(this);
        }

        //メニュー→上書き保存
        private void menuSave_Click(object sender, EventArgs e)
        {
            saveMethod();
        }

        //メニュー→名前を付けて保存
        private void menuSaveAdd_Click(object sender, EventArgs e)
        {
            SaveSetting();
            saveAddMethod();
        }
        
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //ESCボタン押下
            if (e.KeyCode == Keys.Escape)
            {
                SaveSetting();
                endMethod();
            }

            //Alt+Z+X+C 画面の左上に表示
            if(e.Alt == true && e.KeyCode == Keys.Q)
            {
                this.Top = 20;
                this.Left = 20;
                this.Width = 300;
                this.Height = 300;
            }
        }

        //メニュー→終了
        private void menuEnd_Click(object sender, EventArgs e)
        {
            SaveSetting();
            endMethod();
        }

        //右上の×ボタン
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSetting();

            if (dirtyFlag == true)
            {
                const string MSG_BOX_STRING = "ファイルは保存されていません。\n\nテキストは破棄されます。\n\n保存しますか?";

                DialogResult result = MessageBox.Show(MSG_BOX_STRING, "終了", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    saveMethod();
                    this.Dispose();
                    this.Close();
                }
                else if (result == DialogResult.No)
                {
                    this.Dispose();
                    this.Close();
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        //ダイアログで保存or開くを押した時
        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            const string MSGBOX_TITLE = "名前をつけて保存";

            //ダイアログで指定された保存先パスを取得
            editFilePath = saveFileDialog1.FileName;

            try
            {
                //ファイルの書き込み
                File.WriteAllText(editFilePath, textBox1.Text, Encoding.Default);

                //ファイル名をウィンドウタイトルに固定
                this.Text = GetFileNameString(editFilePath, '\\');

                //ダーティフラグリセット
                setDirty(false);
            }
            catch(Exception ex)
            {
                MessageBox.Show(this, ex.Message, MSGBOX_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void 環境設定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSetting FormSetting1 = new FormSetting(this);
            DialogResult result = FormSetting1.ShowDialog();
        }

        private void ショートカットの説明ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShortcutReadme ShortcutReadme1 = new ShortcutReadme();
            DialogResult result = ShortcutReadme1.ShowDialog();
        }

        private void 更新履歴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            update update1 = new update();
            DialogResult result = update1.ShowDialog();
        }
    }
}
