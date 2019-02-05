namespace メモ
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.menuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSaveAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuEnd = new System.Windows.Forms.ToolStripMenuItem();
            this.ツールToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.環境設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ヘルプHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ショートカットの説明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更新履歴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.バージョン情報AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ブックマークMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.空のブックマーク1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.空のブックマーク2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.空のブックマーク3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.空のブックマーク4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.空のブックマーク5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 24);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(284, 237);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox1_DragDrop);
            this.textBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox1_DragEnter);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "テキストファイル (*.txt)|*.txt|C# ソース(*.cs)|*.cs|全てのファイル (*.*)|*.*";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "テキストファイル (*.txt)|*.txt|C# ソース(*.cs)|*.cs|全てのファイル (*.*)|*.*";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ファイルFToolStripMenuItem
            // 
            this.ファイルFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNew,
            this.menuOpen,
            this.toolStripSeparator,
            this.menuSave,
            this.menuSaveAdd,
            this.toolStripSeparator2,
            this.menuEnd});
            this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.ファイルFToolStripMenuItem.Text = "メニュー(&F)";
            // 
            // menuNew
            // 
            this.menuNew.Image = ((System.Drawing.Image)(resources.GetObject("menuNew.Image")));
            this.menuNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuNew.Name = "menuNew";
            this.menuNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.menuNew.Size = new System.Drawing.Size(184, 22);
            this.menuNew.Text = "新規作成(&N)";
            this.menuNew.Click += new System.EventHandler(this.menuNew_Click);
            // 
            // menuOpen
            // 
            this.menuOpen.Image = ((System.Drawing.Image)(resources.GetObject("menuOpen.Image")));
            this.menuOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuOpen.Name = "menuOpen";
            this.menuOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuOpen.Size = new System.Drawing.Size(184, 22);
            this.menuOpen.Text = "開く(&O)";
            this.menuOpen.Click += new System.EventHandler(this.menuOpen_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(181, 6);
            // 
            // menuSave
            // 
            this.menuSave.Enabled = false;
            this.menuSave.Image = ((System.Drawing.Image)(resources.GetObject("menuSave.Image")));
            this.menuSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menuSave.Name = "menuSave";
            this.menuSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuSave.Size = new System.Drawing.Size(184, 22);
            this.menuSave.Text = "上書き保存(&S)";
            this.menuSave.Click += new System.EventHandler(this.menuSave_Click);
            // 
            // menuSaveAdd
            // 
            this.menuSaveAdd.Name = "menuSaveAdd";
            this.menuSaveAdd.Size = new System.Drawing.Size(184, 22);
            this.menuSaveAdd.Text = "名前を付けて保存";
            this.menuSaveAdd.Click += new System.EventHandler(this.menuSaveAdd_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(181, 6);
            // 
            // menuEnd
            // 
            this.menuEnd.Name = "menuEnd";
            this.menuEnd.Size = new System.Drawing.Size(184, 22);
            this.menuEnd.Text = "終了";
            this.menuEnd.Click += new System.EventHandler(this.menuEnd_Click);
            // 
            // ツールToolStripMenuItem
            // 
            this.ツールToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.環境設定ToolStripMenuItem});
            this.ツールToolStripMenuItem.Name = "ツールToolStripMenuItem";
            this.ツールToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.ツールToolStripMenuItem.Text = "ツール(&T)";
            // 
            // 環境設定ToolStripMenuItem
            // 
            this.環境設定ToolStripMenuItem.Name = "環境設定ToolStripMenuItem";
            this.環境設定ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.環境設定ToolStripMenuItem.Text = "環境設定";
            this.環境設定ToolStripMenuItem.Click += new System.EventHandler(this.環境設定ToolStripMenuItem_Click);
            // 
            // ヘルプHToolStripMenuItem
            // 
            this.ヘルプHToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ショートカットの説明ToolStripMenuItem,
            this.更新履歴ToolStripMenuItem,
            this.バージョン情報AToolStripMenuItem});
            this.ヘルプHToolStripMenuItem.Name = "ヘルプHToolStripMenuItem";
            this.ヘルプHToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.ヘルプHToolStripMenuItem.Text = "ヘルプ(&H)";
            // 
            // ショートカットの説明ToolStripMenuItem
            // 
            this.ショートカットの説明ToolStripMenuItem.Name = "ショートカットの説明ToolStripMenuItem";
            this.ショートカットの説明ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.ショートカットの説明ToolStripMenuItem.Text = "ショートカットの説明";
            this.ショートカットの説明ToolStripMenuItem.Click += new System.EventHandler(this.ショートカットの説明ToolStripMenuItem_Click);
            // 
            // 更新履歴ToolStripMenuItem
            // 
            this.更新履歴ToolStripMenuItem.Name = "更新履歴ToolStripMenuItem";
            this.更新履歴ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.更新履歴ToolStripMenuItem.Text = "更新履歴";
            this.更新履歴ToolStripMenuItem.Click += new System.EventHandler(this.更新履歴ToolStripMenuItem_Click);
            // 
            // バージョン情報AToolStripMenuItem
            // 
            this.バージョン情報AToolStripMenuItem.Name = "バージョン情報AToolStripMenuItem";
            this.バージョン情報AToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.バージョン情報AToolStripMenuItem.Text = "バージョン情報";
            this.バージョン情報AToolStripMenuItem.Click += new System.EventHandler(this.バージョン情報AToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem,
            this.ブックマークMenuItem1,
            this.ツールToolStripMenuItem,
            this.ヘルプHToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ブックマークMenuItem1
            // 
            this.ブックマークMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.空のブックマーク1ToolStripMenuItem,
            this.空のブックマーク2ToolStripMenuItem,
            this.空のブックマーク3ToolStripMenuItem,
            this.空のブックマーク4ToolStripMenuItem,
            this.空のブックマーク5ToolStripMenuItem});
            this.ブックマークMenuItem1.Name = "ブックマークMenuItem1";
            this.ブックマークMenuItem1.Size = new System.Drawing.Size(43, 20);
            this.ブックマークMenuItem1.Text = "履歴";
            // 
            // 空のブックマーク1ToolStripMenuItem
            // 
            this.空のブックマーク1ToolStripMenuItem.Name = "空のブックマーク1ToolStripMenuItem";
            this.空のブックマーク1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.空のブックマーク1ToolStripMenuItem.Text = "履歴1";
            // 
            // 空のブックマーク2ToolStripMenuItem
            // 
            this.空のブックマーク2ToolStripMenuItem.Name = "空のブックマーク2ToolStripMenuItem";
            this.空のブックマーク2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.空のブックマーク2ToolStripMenuItem.Text = "履歴2";
            // 
            // 空のブックマーク3ToolStripMenuItem
            // 
            this.空のブックマーク3ToolStripMenuItem.Name = "空のブックマーク3ToolStripMenuItem";
            this.空のブックマーク3ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.空のブックマーク3ToolStripMenuItem.Text = "履歴3";
            // 
            // 空のブックマーク4ToolStripMenuItem
            // 
            this.空のブックマーク4ToolStripMenuItem.Name = "空のブックマーク4ToolStripMenuItem";
            this.空のブックマーク4ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.空のブックマーク4ToolStripMenuItem.Text = "履歴4";
            // 
            // 空のブックマーク5ToolStripMenuItem
            // 
            this.空のブックマーク5ToolStripMenuItem.Name = "空のブックマーク5ToolStripMenuItem";
            this.空のブックマーク5ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.空のブックマーク5ToolStripMenuItem.Text = "履歴5";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Opacity = 0.7D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Text and Sticky";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        internal System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuNew;
        private System.Windows.Forms.ToolStripMenuItem menuOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem menuSave;
        private System.Windows.Forms.ToolStripMenuItem menuSaveAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menuEnd;
        private System.Windows.Forms.ToolStripMenuItem ツールToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 環境設定ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ヘルプHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ショートカットの説明ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 更新履歴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem バージョン情報AToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ブックマークMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 空のブックマーク1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 空のブックマーク2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 空のブックマーク3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 空のブックマーク4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 空のブックマーク5ToolStripMenuItem;
    }
}

