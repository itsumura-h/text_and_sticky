namespace メモ
{
    partial class FormSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSetting));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.buttonSavePic = new System.Windows.Forms.Button();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panelColor = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBackColor = new System.Windows.Forms.Button();
            this.labelColor = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.labelOpacity = new System.Windows.Forms.Label();
            this.buttonDefo = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.numericAutoSaveInterval = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panelFontColor = new System.Windows.Forms.Panel();
            this.buttonFontColor = new System.Windows.Forms.Button();
            this.numericUpDownFont = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAutoSaveInterval)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFont)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSavePic
            // 
            this.buttonSavePic.Location = new System.Drawing.Point(250, 164);
            this.buttonSavePic.Name = "buttonSavePic";
            this.buttonSavePic.Size = new System.Drawing.Size(90, 23);
            this.buttonSavePic.TabIndex = 9;
            this.buttonSavePic.Text = "保存して閉じる";
            this.buttonSavePic.UseVisualStyleBackColor = true;
            this.buttonSavePic.Click += new System.EventHandler(this.buttonSavePic_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelColor);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.buttonBackColor);
            this.tabPage1.Controls.Add(this.labelColor);
            this.tabPage1.Controls.Add(this.trackBar1);
            this.tabPage1.Controls.Add(this.labelOpacity);
            this.tabPage1.Controls.Add(this.buttonDefo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(339, 127);
            this.tabPage1.TabIndex = 4;
            this.tabPage1.Text = "画面設定";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panelColor
            // 
            this.panelColor.Location = new System.Drawing.Point(105, 58);
            this.panelColor.Name = "panelColor";
            this.panelColor.Size = new System.Drawing.Size(25, 25);
            this.panelColor.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "透過度";
            // 
            // buttonBackColor
            // 
            this.buttonBackColor.Location = new System.Drawing.Point(6, 58);
            this.buttonBackColor.Name = "buttonBackColor";
            this.buttonBackColor.Size = new System.Drawing.Size(93, 25);
            this.buttonBackColor.TabIndex = 2;
            this.buttonBackColor.Text = "背景色の変更";
            this.buttonBackColor.UseVisualStyleBackColor = true;
            this.buttonBackColor.Click += new System.EventHandler(this.buttonBackColor_Click);
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(132, 64);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(35, 12);
            this.labelColor.TabIndex = 8;
            this.labelColor.Text = "label3";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(51, 6);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 30;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(282, 45);
            this.trackBar1.TabIndex = 5;
            this.trackBar1.TickFrequency = 10;
            this.trackBar1.Value = 30;
            // 
            // labelOpacity
            // 
            this.labelOpacity.AutoSize = true;
            this.labelOpacity.Location = new System.Drawing.Point(10, 30);
            this.labelOpacity.Name = "labelOpacity";
            this.labelOpacity.Size = new System.Drawing.Size(35, 12);
            this.labelOpacity.TabIndex = 7;
            this.labelOpacity.Text = "label2";
            // 
            // buttonDefo
            // 
            this.buttonDefo.Location = new System.Drawing.Point(6, 96);
            this.buttonDefo.Name = "buttonDefo";
            this.buttonDefo.Size = new System.Drawing.Size(93, 23);
            this.buttonDefo.TabIndex = 6;
            this.buttonDefo.Text = "デフォルトに戻す";
            this.buttonDefo.UseVisualStyleBackColor = true;
            this.buttonDefo.Click += new System.EventHandler(this.buttonDefo_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.numericAutoSaveInterval);
            this.tabPage2.Controls.Add(this.checkBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(339, 127);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "自動保存";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "分おきに自動保存する";
            // 
            // numericAutoSaveInterval
            // 
            this.numericAutoSaveInterval.Location = new System.Drawing.Point(6, 30);
            this.numericAutoSaveInterval.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericAutoSaveInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericAutoSaveInterval.Name = "numericAutoSaveInterval";
            this.numericAutoSaveInterval.Size = new System.Drawing.Size(34, 19);
            this.numericAutoSaveInterval.TabIndex = 4;
            this.numericAutoSaveInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 6);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(148, 16);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "自動保存機能を使用する";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(5, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(347, 153);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panelFontColor);
            this.tabPage3.Controls.Add(this.buttonFontColor);
            this.tabPage3.Controls.Add(this.numericUpDownFont);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(339, 127);
            this.tabPage3.TabIndex = 5;
            this.tabPage3.Text = "フォント";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panelFontColor
            // 
            this.panelFontColor.Location = new System.Drawing.Point(116, 48);
            this.panelFontColor.Name = "panelFontColor";
            this.panelFontColor.Size = new System.Drawing.Size(23, 23);
            this.panelFontColor.TabIndex = 6;
            // 
            // buttonFontColor
            // 
            this.buttonFontColor.Location = new System.Drawing.Point(15, 48);
            this.buttonFontColor.Name = "buttonFontColor";
            this.buttonFontColor.Size = new System.Drawing.Size(94, 23);
            this.buttonFontColor.TabIndex = 5;
            this.buttonFontColor.Text = "文字カラー変更";
            this.buttonFontColor.UseVisualStyleBackColor = true;
            this.buttonFontColor.Click += new System.EventHandler(this.buttonFontColor_Click);
            // 
            // numericUpDownFont
            // 
            this.numericUpDownFont.Location = new System.Drawing.Point(89, 13);
            this.numericUpDownFont.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownFont.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDownFont.Name = "numericUpDownFont";
            this.numericUpDownFont.Size = new System.Drawing.Size(50, 19);
            this.numericUpDownFont.TabIndex = 4;
            this.numericUpDownFont.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "文字サイズ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 12);
            this.label3.TabIndex = 0;
            // 
            // FormSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(354, 191);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.buttonSavePic);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(370, 230);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(370, 230);
            this.Name = "FormSetting";
            this.Text = "画面設定";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSetting_FormClosing);
            this.Load += new System.EventHandler(this.FormSetting_Load);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericAutoSaveInterval)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFont)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button buttonSavePic;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panelColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBackColor;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label labelOpacity;
        private System.Windows.Forms.Button buttonDefo;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericAutoSaveInterval;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel panelFontColor;
        private System.Windows.Forms.Button buttonFontColor;
        private System.Windows.Forms.NumericUpDown numericUpDownFont;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}