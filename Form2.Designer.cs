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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.songNamePanel = new System.Windows.Forms.Panel();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.searchBox = new System.Windows.Forms.ListBox();
            this.button95 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
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
            this.panel1.SuspendLayout();
            this.publicPanel1.SuspendLayout();
            this.publicpanel2.SuspendLayout();
            this.songNamePanel.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ChooseSongName
            // 
            this.ChooseSongName.Location = new System.Drawing.Point(285, 8);
            this.ChooseSongName.Name = "ChooseSongName";
            this.ChooseSongName.Size = new System.Drawing.Size(76, 111);
            this.ChooseSongName.TabIndex = 11;
            this.ChooseSongName.Text = "歌名点歌";
            this.ChooseSongName.UseVisualStyleBackColor = true;
            this.ChooseSongName.Click += new System.EventHandler(this.ChooseSongName_Click);
            // 
            // ChooseCategory
            // 
            this.ChooseCategory.Location = new System.Drawing.Point(11, 8);
            this.ChooseCategory.Name = "ChooseCategory";
            this.ChooseCategory.Size = new System.Drawing.Size(76, 111);
            this.ChooseCategory.TabIndex = 8;
            this.ChooseCategory.Text = "类型点歌";
            this.ChooseCategory.UseVisualStyleBackColor = true;
            this.ChooseCategory.Click += new System.EventHandler(this.ChooseCategory_Click);
            // 
            // ChoosePingyin
            // 
            this.ChoosePingyin.Location = new System.Drawing.Point(103, 8);
            this.ChoosePingyin.Name = "ChoosePingyin";
            this.ChoosePingyin.Size = new System.Drawing.Size(80, 111);
            this.ChoosePingyin.TabIndex = 9;
            this.ChoosePingyin.Text = "拼音点歌";
            this.ChoosePingyin.UseVisualStyleBackColor = true;
            this.ChoosePingyin.Click += new System.EventHandler(this.ChoosePingyin_Click);
            // 
            // ChooseSinger
            // 
            this.ChooseSinger.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ChooseSinger.Location = new System.Drawing.Point(201, 8);
            this.ChooseSinger.Name = "ChooseSinger";
            this.ChooseSinger.Size = new System.Drawing.Size(73, 111);
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
            this.panel1.Location = new System.Drawing.Point(9, 45);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 131);
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
            this.publicPanel1.Location = new System.Drawing.Point(12, 496);
            this.publicPanel1.Name = "publicPanel1";
            this.publicPanel1.Size = new System.Drawing.Size(803, 81);
            this.publicPanel1.TabIndex = 13;
            // 
            // Vounmn
            // 
            this.Vounmn.Location = new System.Drawing.Point(461, 21);
            this.Vounmn.Name = "Vounmn";
            this.Vounmn.Size = new System.Drawing.Size(66, 56);
            this.Vounmn.TabIndex = 5;
            this.Vounmn.Text = "音量";
            this.Vounmn.UseVisualStyleBackColor = true;
            // 
            // NeedHelp
            // 
            this.NeedHelp.Location = new System.Drawing.Point(375, 21);
            this.NeedHelp.Name = "NeedHelp";
            this.NeedHelp.Size = new System.Drawing.Size(66, 56);
            this.NeedHelp.TabIndex = 4;
            this.NeedHelp.Text = "服务";
            this.NeedHelp.UseVisualStyleBackColor = true;
            // 
            // SeeSong
            // 
            this.SeeSong.Location = new System.Drawing.Point(293, 21);
            this.SeeSong.Name = "SeeSong";
            this.SeeSong.Size = new System.Drawing.Size(66, 56);
            this.SeeSong.TabIndex = 3;
            this.SeeSong.Text = "已点";
            this.SeeSong.UseVisualStyleBackColor = true;
            // 
            // NextSong
            // 
            this.NextSong.Location = new System.Drawing.Point(205, 21);
            this.NextSong.Name = "NextSong";
            this.NextSong.Size = new System.Drawing.Size(66, 56);
            this.NextSong.TabIndex = 2;
            this.NextSong.Text = "切歌";
            this.NextSong.UseVisualStyleBackColor = true;
            // 
            // ReSing
            // 
            this.ReSing.Location = new System.Drawing.Point(120, 21);
            this.ReSing.Name = "ReSing";
            this.ReSing.Size = new System.Drawing.Size(66, 56);
            this.ReSing.TabIndex = 1;
            this.ReSing.Text = "重唱";
            this.ReSing.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.Home.Location = new System.Drawing.Point(34, 21);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(66, 56);
            this.Home.TabIndex = 0;
            this.Home.Text = "主界面";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // publicpanel2
            // 
            this.publicpanel2.Controls.Add(this.label1);
            this.publicpanel2.Controls.Add(this.textBox1);
            this.publicpanel2.Controls.Add(this.label2);
            this.publicpanel2.Controls.Add(this.textBox2);
            this.publicpanel2.Controls.Add(this.label3);
            this.publicpanel2.Controls.Add(this.comboBox1);
            this.publicpanel2.Controls.Add(this.textBox4);
            this.publicpanel2.Location = new System.Drawing.Point(0, 1);
            this.publicpanel2.Name = "publicpanel2";
            this.publicpanel2.Size = new System.Drawing.Size(803, 39);
            this.publicpanel2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(105, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 14);
            this.label1.TabIndex = 10;
            this.label1.Text = "正在播放：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(187, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 21);
            this.textBox1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(371, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 14);
            this.label2.TabIndex = 11;
            this.label2.Text = "下一首：";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(444, 7);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(147, 21);
            this.textBox2.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "label3";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(749, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(42, 20);
            this.comboBox1.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(706, 6);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(37, 21);
            this.textBox4.TabIndex = 7;
            // 
            // songNamePanel
            // 
            this.songNamePanel.Controls.Add(this.textBox14);
            this.songNamePanel.Controls.Add(this.searchBox);
            this.songNamePanel.Controls.Add(this.button95);
            this.songNamePanel.Location = new System.Drawing.Point(9, 191);
            this.songNamePanel.Margin = new System.Windows.Forms.Padding(2);
            this.songNamePanel.Name = "songNamePanel";
            this.songNamePanel.Size = new System.Drawing.Size(221, 218);
            this.songNamePanel.TabIndex = 74;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(31, 14);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(115, 21);
            this.textBox14.TabIndex = 47;
            this.textBox14.Text = "歌名";
            // 
            // searchBox
            // 
            this.searchBox.FormattingEnabled = true;
            this.searchBox.ItemHeight = 12;
            this.searchBox.Location = new System.Drawing.Point(15, 41);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(190, 160);
            this.searchBox.TabIndex = 46;
            // 
            // button95
            // 
            this.button95.Location = new System.Drawing.Point(152, 12);
            this.button95.Name = "button95";
            this.button95.Size = new System.Drawing.Size(53, 23);
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
            // panel5
            // 
            this.panel5.Controls.Add(this.listBox3);
            this.panel5.Controls.Add(this.button49);
            this.panel5.Controls.Add(this.textBox13);
            this.panel5.Controls.Add(this.button14);
            this.panel5.Controls.Add(this.button11);
            this.panel5.Controls.Add(this.button4);
            this.panel5.Controls.Add(this.button3);
            this.panel5.Controls.Add(this.button2);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Location = new System.Drawing.Point(517, 53);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(274, 293);
            this.panel5.TabIndex = 75;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 12;
            this.listBox3.Location = new System.Drawing.Point(16, 96);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(235, 184);
            this.listBox3.TabIndex = 75;
            // 
            // button49
            // 
            this.button49.Location = new System.Drawing.Point(183, 8);
            this.button49.Name = "button49";
            this.button49.Size = new System.Drawing.Size(68, 30);
            this.button49.TabIndex = 74;
            this.button49.Text = "搜索";
            this.button49.UseVisualStyleBackColor = true;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(16, 8);
            this.textBox13.Multiline = true;
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(154, 30);
            this.textBox13.TabIndex = 72;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(176, 70);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(75, 23);
            this.button14.TabIndex = 45;
            this.button14.Text = "全部";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(95, 68);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 42;
            this.button11.Text = "欧美女歌手";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(14, 68);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 41;
            this.button4.Text = "欧美男歌手";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(176, 44);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 40;
            this.button3.Text = "华语组合";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(95, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 39;
            this.button2.Text = "华语女歌手";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 38;
            this.button1.Text = "华语男歌手";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.listBox1);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(240, 232);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(366, 203);
            this.panel3.TabIndex = 76;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(140, 15);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(203, 172);
            this.listBox1.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 56;
            this.label4.Text = "label4";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(20, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 129);
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 579);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.songNamePanel);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.publicpanel2);
            this.Controls.Add(this.publicPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.publicPanel1.ResumeLayout(false);
            this.publicpanel2.ResumeLayout(false);
            this.publicpanel2.PerformLayout();
            this.songNamePanel.ResumeLayout(false);
            this.songNamePanel.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Panel songNamePanel;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.ListBox searchBox;
        private System.Windows.Forms.Button button95;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel5;
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
    }
}