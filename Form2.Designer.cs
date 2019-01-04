namespace KTV
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.ChooseSongName = new System.Windows.Forms.Button();
            this.ChooseCategory = new System.Windows.Forms.Button();
            this.ChoosePingyin = new System.Windows.Forms.Button();
            this.ChooseSinger = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.publicPanel1 = new System.Windows.Forms.Panel();
            this.Vounmn = new System.Windows.Forms.Button();
            this.NeedHelp = new System.Windows.Forms.Button();
            this.SeeSong = new System.Windows.Forms.Button();
            this.NextSong = new System.Windows.Forms.Button();
            this.ReSing = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Button();
            this.publicpanel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.songNamePanel = new System.Windows.Forms.Panel();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.searchBox = new System.Windows.Forms.ListBox();
            this.button95 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.singerPanel1 = new System.Windows.Forms.Panel();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.button49 = new System.Windows.Forms.Button();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.button14 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.publicPanel1.SuspendLayout();
            this.publicpanel2.SuspendLayout();
            this.songNamePanel.SuspendLayout();
            this.singerPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ChooseSongName
            // 
            this.ChooseSongName.Location = new System.Drawing.Point(428, 12);
            this.ChooseSongName.Margin = new System.Windows.Forms.Padding(4);
            this.ChooseSongName.Name = "ChooseSongName";
            this.ChooseSongName.Size = new System.Drawing.Size(114, 166);
            this.ChooseSongName.TabIndex = 11;
            this.ChooseSongName.Text = "歌名点歌";
            this.ChooseSongName.UseVisualStyleBackColor = true;
            this.ChooseSongName.Click += new System.EventHandler(this.ChooseSongName_Click);
            // 
            // ChooseCategory
            // 
            this.ChooseCategory.Location = new System.Drawing.Point(16, 12);
            this.ChooseCategory.Margin = new System.Windows.Forms.Padding(4);
            this.ChooseCategory.Name = "ChooseCategory";
            this.ChooseCategory.Size = new System.Drawing.Size(114, 166);
            this.ChooseCategory.TabIndex = 8;
            this.ChooseCategory.Text = "类型点歌";
            this.ChooseCategory.UseVisualStyleBackColor = true;
            this.ChooseCategory.Click += new System.EventHandler(this.ChooseCategory_Click);
            // 
            // ChoosePingyin
            // 
            this.ChoosePingyin.Location = new System.Drawing.Point(154, 12);
            this.ChoosePingyin.Margin = new System.Windows.Forms.Padding(4);
            this.ChoosePingyin.Name = "ChoosePingyin";
            this.ChoosePingyin.Size = new System.Drawing.Size(120, 166);
            this.ChoosePingyin.TabIndex = 9;
            this.ChoosePingyin.Text = "拼音点歌";
            this.ChoosePingyin.UseVisualStyleBackColor = true;
            this.ChoosePingyin.Click += new System.EventHandler(this.ChoosePingyin_Click);
            // 
            // ChooseSinger
            // 
            this.ChooseSinger.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ChooseSinger.Location = new System.Drawing.Point(302, 12);
            this.ChooseSinger.Margin = new System.Windows.Forms.Padding(4);
            this.ChooseSinger.Name = "ChooseSinger";
            this.ChooseSinger.Size = new System.Drawing.Size(110, 166);
            this.ChooseSinger.TabIndex = 10;
            this.ChooseSinger.Text = "歌手点歌";
            this.ChooseSinger.UseVisualStyleBackColor = true;
            this.ChooseSinger.Click += new System.EventHandler(this.ChooseSinger_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ChoosePingyin);
            this.panel1.Controls.Add(this.ChooseSongName);
            this.panel1.Controls.Add(this.ChooseSinger);
            this.panel1.Controls.Add(this.ChooseCategory);
            this.panel1.Location = new System.Drawing.Point(14, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(566, 196);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // publicPanel1
            // 
            this.publicPanel1.Controls.Add(this.Vounmn);
            this.publicPanel1.Controls.Add(this.NeedHelp);
            this.publicPanel1.Controls.Add(this.SeeSong);
            this.publicPanel1.Controls.Add(this.NextSong);
            this.publicPanel1.Controls.Add(this.ReSing);
            this.publicPanel1.Controls.Add(this.Home);
            this.publicPanel1.Location = new System.Drawing.Point(18, 744);
            this.publicPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.publicPanel1.Name = "publicPanel1";
            this.publicPanel1.Size = new System.Drawing.Size(1204, 122);
            this.publicPanel1.TabIndex = 13;
            // 
            // Vounmn
            // 
            this.Vounmn.Location = new System.Drawing.Point(692, 32);
            this.Vounmn.Margin = new System.Windows.Forms.Padding(4);
            this.Vounmn.Name = "Vounmn";
            this.Vounmn.Size = new System.Drawing.Size(99, 84);
            this.Vounmn.TabIndex = 5;
            this.Vounmn.Text = "音量";
            this.Vounmn.UseVisualStyleBackColor = true;
            // 
            // NeedHelp
            // 
            this.NeedHelp.Location = new System.Drawing.Point(562, 32);
            this.NeedHelp.Margin = new System.Windows.Forms.Padding(4);
            this.NeedHelp.Name = "NeedHelp";
            this.NeedHelp.Size = new System.Drawing.Size(99, 84);
            this.NeedHelp.TabIndex = 4;
            this.NeedHelp.Text = "服务";
            this.NeedHelp.UseVisualStyleBackColor = true;
            // 
            // SeeSong
            // 
            this.SeeSong.Location = new System.Drawing.Point(440, 32);
            this.SeeSong.Margin = new System.Windows.Forms.Padding(4);
            this.SeeSong.Name = "SeeSong";
            this.SeeSong.Size = new System.Drawing.Size(99, 84);
            this.SeeSong.TabIndex = 3;
            this.SeeSong.Text = "已点";
            this.SeeSong.UseVisualStyleBackColor = true;
            // 
            // NextSong
            // 
            this.NextSong.Location = new System.Drawing.Point(308, 32);
            this.NextSong.Margin = new System.Windows.Forms.Padding(4);
            this.NextSong.Name = "NextSong";
            this.NextSong.Size = new System.Drawing.Size(99, 84);
            this.NextSong.TabIndex = 2;
            this.NextSong.Text = "切歌";
            this.NextSong.UseVisualStyleBackColor = true;
            // 
            // ReSing
            // 
            this.ReSing.Location = new System.Drawing.Point(180, 32);
            this.ReSing.Margin = new System.Windows.Forms.Padding(4);
            this.ReSing.Name = "ReSing";
            this.ReSing.Size = new System.Drawing.Size(99, 84);
            this.ReSing.TabIndex = 1;
            this.ReSing.Text = "重唱";
            this.ReSing.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(51, 32);
            this.Home.Margin = new System.Windows.Forms.Padding(4);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(99, 84);
            this.Home.TabIndex = 0;
            this.Home.Text = "主界面";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // publicpanel2
            // 
            this.publicpanel2.Controls.Add(this.listBox2);
            this.publicpanel2.Controls.Add(this.label1);
            this.publicpanel2.Controls.Add(this.textBox1);
            this.publicpanel2.Controls.Add(this.label2);
            this.publicpanel2.Controls.Add(this.textBox2);
            this.publicpanel2.Controls.Add(this.label3);
            this.publicpanel2.Location = new System.Drawing.Point(0, 2);
            this.publicpanel2.Margin = new System.Windows.Forms.Padding(4);
            this.publicpanel2.Name = "publicpanel2";
            this.publicpanel2.Size = new System.Drawing.Size(1204, 58);
            this.publicpanel2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(158, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "正在播放：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(280, 9);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(256, 28);
            this.textBox1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(556, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "下一首：";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(666, 10);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(218, 28);
            this.textBox2.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(4, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "label3";
            // 
            // songNamePanel
            // 
            this.songNamePanel.Controls.Add(this.textBox14);
            this.songNamePanel.Controls.Add(this.searchBox);
            this.songNamePanel.Controls.Add(this.button95);
            this.songNamePanel.Location = new System.Drawing.Point(14, 286);
            this.songNamePanel.Name = "songNamePanel";
            this.songNamePanel.Size = new System.Drawing.Size(332, 327);
            this.songNamePanel.TabIndex = 74;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(46, 21);
            this.textBox14.Margin = new System.Windows.Forms.Padding(4);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(170, 28);
            this.textBox14.TabIndex = 47;
            this.textBox14.Text = "歌名";
            // 
            // searchBox
            // 
            this.searchBox.FormattingEnabled = true;
            this.searchBox.ItemHeight = 18;
            this.searchBox.Location = new System.Drawing.Point(22, 62);
            this.searchBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(283, 238);
            this.searchBox.TabIndex = 46;
            // 
            // button95
            // 
            this.button95.Location = new System.Drawing.Point(228, 18);
            this.button95.Margin = new System.Windows.Forms.Padding(4);
            this.button95.Name = "button95";
            this.button95.Size = new System.Drawing.Size(80, 34);
            this.button95.TabIndex = 49;
            this.button95.Text = "搜索";
            this.button95.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // singerPanel1
            // 
            this.singerPanel1.Controls.Add(this.listBox3);
            this.singerPanel1.Controls.Add(this.button49);
            this.singerPanel1.Controls.Add(this.textBox13);
            this.singerPanel1.Controls.Add(this.button14);
            this.singerPanel1.Controls.Add(this.button11);
            this.singerPanel1.Controls.Add(this.button4);
            this.singerPanel1.Controls.Add(this.button3);
            this.singerPanel1.Controls.Add(this.button2);
            this.singerPanel1.Controls.Add(this.button1);
            this.singerPanel1.Location = new System.Drawing.Point(776, 80);
            this.singerPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.singerPanel1.Name = "singerPanel1";
            this.singerPanel1.Size = new System.Drawing.Size(411, 440);
            this.singerPanel1.TabIndex = 75;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 18;
            this.listBox3.Location = new System.Drawing.Point(24, 144);
            this.listBox3.Margin = new System.Windows.Forms.Padding(4);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(350, 274);
            this.listBox3.TabIndex = 75;
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // button49
            // 
            this.button49.Location = new System.Drawing.Point(274, 12);
            this.button49.Margin = new System.Windows.Forms.Padding(4);
            this.button49.Name = "button49";
            this.button49.Size = new System.Drawing.Size(102, 45);
            this.button49.TabIndex = 74;
            this.button49.Text = "搜索";
            this.button49.UseVisualStyleBackColor = true;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(24, 12);
            this.textBox13.Margin = new System.Windows.Forms.Padding(4);
            this.textBox13.Multiline = true;
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(229, 43);
            this.textBox13.TabIndex = 72;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(264, 105);
            this.button14.Margin = new System.Windows.Forms.Padding(4);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(112, 34);
            this.button14.TabIndex = 45;
            this.button14.Text = "全部";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(142, 102);
            this.button11.Margin = new System.Windows.Forms.Padding(4);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(112, 34);
            this.button11.TabIndex = 42;
            this.button11.Text = "欧美女歌手";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(21, 102);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 34);
            this.button4.TabIndex = 41;
            this.button4.Text = "欧美男歌手";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(264, 66);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 34);
            this.button3.TabIndex = 40;
            this.button3.Text = "华语组合";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(142, 66);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 34);
            this.button2.TabIndex = 39;
            this.button2.Text = "华语女歌手";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 66);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 38;
            this.button1.Text = "华语男歌手";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.listBox1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(360, 348);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(549, 304);
            this.panel3.TabIndex = 76;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 18;
            this.listBox1.Location = new System.Drawing.Point(210, 22);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(302, 256);
            this.listBox1.TabIndex = 14;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 240);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 56;
            this.label4.Text = "label4";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(30, 42);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 194);
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 18;
            this.listBox2.Location = new System.Drawing.Point(932, 0);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(242, 58);
            this.listBox2.TabIndex = 14;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 868);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.songNamePanel);
            this.Controls.Add(this.singerPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.publicpanel2);
            this.Controls.Add(this.publicPanel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.publicPanel1.ResumeLayout(false);
            this.publicpanel2.ResumeLayout(false);
            this.publicpanel2.PerformLayout();
            this.songNamePanel.ResumeLayout(false);
            this.songNamePanel.PerformLayout();
            this.singerPanel1.ResumeLayout(false);
            this.singerPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ChooseSongName;
        private System.Windows.Forms.Button ChooseCategory;
        private System.Windows.Forms.Button ChoosePingyin;
        private System.Windows.Forms.Button ChooseSinger;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel publicPanel1;
        private System.Windows.Forms.Button Vounmn;
        private System.Windows.Forms.Button NeedHelp;
        private System.Windows.Forms.Button SeeSong;
        private System.Windows.Forms.Button NextSong;
        private System.Windows.Forms.Button ReSing;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Panel publicpanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel songNamePanel;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.ListBox searchBox;
        private System.Windows.Forms.Button button95;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel singerPanel1;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button button49;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox2;
    }
}