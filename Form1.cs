using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTV
{   

    public partial class Form1 : Form
    {  
        public Form1()
        {
            InitializeComponent();

        }

        //listBox用来存储歌曲的文件名
        //用来存储音乐文件的全路径
        List<string> listSong = new List<string>();

        DirectoryInfo files;
        //获得一个目录下所有文件
        string[] path;

        private void select_button_Click(object sender, EventArgs e)
        {  /*
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择文件";
            ofd.Multiselect = true;
            ofd.InitialDirectory = @"C:\Users\刘迪\Desktop\song";
            ofd.Filter = "音乐文件(*.mp3)|*.mp3|所有文件(*.*)|*.*";
            ofd.ShowDialog();
            */

            string Ppath = @"C:\Users\刘迪\Desktop\song";//存储歌曲的文件夹路径
            files = new DirectoryInfo(Ppath);
            //获得一个目录下所有文件
            path = Directory.GetFiles(Ppath);


            //获取在文件夹中选择的所有文件的全路径
            // string[] path = files.;
            for (int i = 0; i < path.Length; i++)
            {
                Console.WriteLine(path[i]);
                searchBox.Items.Add(Path.GetFileName(path[i]));
                //将音乐文件的全路径存储到泛型集合中
               
            }

        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        //play_button
        private void playButton_Click(object sender, EventArgs e)
        {
            //timer1.Start();
            if (listSong.Count != 0) { 
            if (play_button.Text == "播放")
            {
               
                textBox1.AppendText(chooseBox.Items[0].ToString());

                MediaPlayer1.URL = listSong[0];
                MediaPlayer1.Ctlcontrols.play();
                play_button.Text = "暂停";
                    
            }
            else
            {
                MediaPlayer1.Ctlcontrols.pause();
                play_button.Text = "播放";
            }
            }
            else { MessageBox.Show("没有待播放歌曲了，请点歌！"); }
        }
        
        private void MediaPlayer1_Enter(object sender, EventArgs e)
        {
            if (MediaPlayer1.playState == WMPLib.WMPPlayState.wmppsMediaEnded)
            {
                timer1.Start();
            }
        }

        //cut_button
        private void cutButton_Click(object sender, EventArgs e)
        {
               
            if (listSong.Count != 0)
                {   
                //注意REmove()里的参数是Object value而不是Index!!!
                chooseBox.Items.Remove(chooseBox.Items[0]);
                listSong.RemoveAt(0); 
            }
            else
            {
                
                MessageBox.Show("没有待播放歌曲了，请点歌！");
            }
            MediaPlayer1.Ctlcontrols.stop();

            if (listSong.Count != 0){
                MediaPlayer1.URL = listSong[0];
                MediaPlayer1.Ctlcontrols.play();
            }
        }

        //replay_button
        private void replayButton_Click(object sender, EventArgs e)
        {
            if (listSong.Count != 0)
            {
                MediaPlayer1.Ctlcontrols.stop();
                MediaPlayer1.Ctlcontrols.play();
            }
            else { MessageBox.Show("没有待播放歌曲了，请点歌！"); }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //searchBox是搜索出来的歌曲，点击歌曲可将它添进“已点歌单里”searchBox
        private void searchBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = searchBox.SelectedIndex;
            chooseBox.Items.Add(searchBox.Items[index]);
            listSong.Add(path[index]);
        }

        //“已点歌单里”chooseBox
        private void chooseBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //从songlist第一首开始播放
        //    axWindowsMediaPlayer1.URL = listSong[0];
         //  axWindowsMediaPlayer1.Ctlcontrols.play();
          //  play_button.Text = "暂停";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            //chooseBox.BeginUpdate();//对控件进行重大修改时会用到
            if (chooseBox.SelectedIndex >= 0)//如果选中某列
                chooseBox.Items.Remove(chooseBox.Items[chooseBox.SelectedIndex]);//删除所选列
            else
                MessageBox.Show("没有选中列", "错误提示框");
            //chooseBox.EndUpdate();
        }

        private void topButton_Click(object sender, EventArgs e)
        {
            int index = chooseBox.SelectedIndex;
            if (index >= 0)
            {
                string tempL = listSong[index]; //中间变量
                Object tempB = chooseBox.Items[index]; //中间变量
                for (int i = index; i > 0; i--)
                {
                    listSong[i] = listSong[i - 1];//将index前面的所有歌都向后移一位
                    chooseBox.Items[i] = chooseBox.Items[i - 1];
                }
                listSong[0] = tempL;
                chooseBox.Items[0] = tempB;
            }
            else
                MessageBox.Show("没有选中列", "错误提示框");
        }

        //当调用该控件时，打开timer
        private void MediaPlayer1_StatusChange(object sender, EventArgs e)
        {
                    timer1.Start(); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {   
            Console.WriteLine( MediaPlayer1.playState);
             if (MediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                Console.WriteLine("listSong.Count"+listSong.Count);
                listSong.RemoveAt(0);
                chooseBox.Items.RemoveAt(0);
                Console.WriteLine("listSong.Count" + listSong.Count);
                if (listSong.Count != 0)
                {   
                    MediaPlayer1.URL = listSong[0];
                    MediaPlayer1.Ctlcontrols.play();
                    
                }
                else { timer1.Stop(); MessageBox.Show("没有待播放歌曲了，请点歌！"); }

            }

            }
    }
}
