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

//D&Dでロード

namespace メモ
{
    public partial class Form1 : Form
    {
        //---------------関数---------------
        private bool CheckFileType(string filePath)
        {
            string[] extnArry = { "txt" };
            foreach (string extn in extnArry)
            {
                int dotLen = extn.Length;
                if (extn == filePath.Substring(filePath.Length - dotLen, dotLen))
                {
                    return true;
                }
            }
            return false;
        }


        //---------------動作---------------
        //DDした時
        private void textBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] dlagFilePathArray = (string[])e.Data.GetData(DataFormats.FileDrop, false);

            //複数のファイルがDDされた場合、先頭のファイルパスを取得する
            editFilePath = dlagFilePathArray[0];


            //ファイルがテキスト形式で開けるか確認
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

        private void textBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (CheckFileType(editFilePath))
            {
                //ドラッグされたのがファイルであるか確認
                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                    //データを受け取る
                    e.Effect = DragDropEffects.All;
                else
                    //受け取らない
                    e.Effect = DragDropEffects.None;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
    }
}
