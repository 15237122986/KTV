using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace KTV
{
    public partial class Form2 : Form
    {
        //用来存储音乐文件的全路径
        List<string> listSongpath = new List<string>();
        //用来存储音乐文件的id
        List<string> listSongid = new List<string>();

        private static string mysqlconn = "database=ktv;password=123456;user=root;server=localhost;";//data Source=MySQL;charset=utf-8";
        private MySqlConnection conn;
        private MySqlDataAdapter SongAdapter;
        private MySqlDataAdapter SingerAdapter;
        private DataSet dsong;
        private DataSet dsinger;
        private string where;
        //private MySqlCommand findsong,findsinger;
        //private MySqlDataReader sdr,sdr2;
               
        private Boolean textBoxHasText = false;

        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection(mysqlconn);
            this.songNamePanel.Visible = false;
            this.singerPanel1.Visible = false;
            this.panel3.Visible = false;
            this.panel2.Visible = false;
            this.pinyinPanel.Visible = false;
            this.singerPanel1.Visible = false;
        }
        //歌手点歌
        private void ChooseSinger_Click(object sender, EventArgs e)
        {
            where = "歌手";
            panel1.Visible = false;
            this.textBox13.Clear();
            listBox3.Items.Clear();
            listSongid.Clear();

            singerPanel1.Visible = true;
            singerPanel1.BringToFront();
        }

        private void Vounmn_Click(object sender, EventArgs e)
        {

        }

        

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void ChooseCategory_Click(object sender, EventArgs e)
        {
           this.panel1.Visible = false;
            this.panel2.Visible = true;
            this.panel2.BringToFront();
        }

        private void ChoosePingyin_Click(object sender, EventArgs e)
        {
            //this.textBox3.Text = "请输入歌曲歌名的首字母";
            //this.textBox3.ForeColor = Color.LightBlue;
            this.textBox3.Clear();
            this.listBox4.Items.Clear();
            panel1.Visible = false;
            pinyinPanel.Visible = true;
            pinyinPanel.BringToFront();
        }

        private void ChooseSongName_Click(object sender, EventArgs e)
        {
            this.panel1.Visible = false;
            this.songNameTextBox.Clear();
            this.songNameListBox.Items.Clear();
            this.songNamePanel.Visible = true;
            this.songNamePanel.BringToFront();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
            songNamePanel.Visible = false;
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            this.pinyinPanel.Visible = false;
            this.singerPanel1.Visible = false;
        }

//////////////////////////////////////////////////////搜索类别////////////////////////////////////////
 private void LanguageButtons_Click(object sender, EventArgs e)
        {
            where = "分类";
            Button topic = (Button)sender;
            this.panel2.Visible = false;
            this.panel3.Visible = true;
            this.label4.Text = topic.Text;
            string picpath = "C:\\Users\\tianyang\\Pictures\\Saved Pictures\\"+topic.Text+".jpg";
            this.pictureBox1.Load(picpath);
            this.listBox1.Items.Clear();
            listSongid.Clear();

            //显示歌曲列表
            SongAdapter = new MySqlDataAdapter("select * from song where language = \'" + topic.Text + "\'", conn);
            dsong = new DataSet();
            SongAdapter.Fill(dsong, "song");
            string songitem;
            DataRow dr1;
            foreach (DataRow dr in dsong.Tables["song"].Rows)
            {
                SingerAdapter = new MySqlDataAdapter("select * from singer where singerid= " + dr.Field<int>("singerid"), conn);
                dsinger = new DataSet();
                SingerAdapter.Fill(dsinger, "singer");

                dr1 = dsinger.Tables["singer"].Rows[0];
                songitem = dr.Field<string>("songname") + "  " + dr1.Field<string>("singername");
                CCWin.SkinControl.SkinListBoxItem songsitem = new CCWin.SkinControl.SkinListBoxItem(songitem);
                listBox1.Items.Add(songsitem);
                listSongid.Add(dr.Field<int>("songid") + "");
            }
        }
        private void TopicButtons_Click(object sender, EventArgs e)
        {
            where = "分类";
            Button topic =(Button)sender;
            this.panel2.Visible = false;
            this.panel3.Visible=true;
            this.label4.Text =topic.Text;
            string picpath = "C:\\Users\\tianyang\\Pictures\\Saved Pictures\\"+topic.Text+".jpg";
            this.pictureBox1.Load(picpath);
            this.listBox1.Items.Clear();
            listSongid.Clear();

            //显示歌曲列表
            SongAdapter = new MySqlDataAdapter("select * from song where songtopic = \'" + topic.Text + "\'", conn);//应为songtopic,改了数据库再说
            dsong = new DataSet();
            SongAdapter.Fill(dsong, "song");
            string songitem;
            DataRow dr1;
            foreach (DataRow dr in dsong.Tables["song"].Rows)
            {
                    SingerAdapter = new MySqlDataAdapter("select * from singer where singerid= " + dr.Field<int>("singerid"), conn);
                    dsinger = new DataSet();
                    SingerAdapter.Fill(dsinger, "singer");

                    dr1 = dsinger.Tables["singer"].Rows[0];
                    songitem = dr.Field<string>("songname")+ "  " + dr1.Field<string>("singername");
                CCWin.SkinControl.SkinListBoxItem songsitem = new CCWin.SkinControl.SkinListBoxItem(songitem);
                listBox1.Items.Add(songsitem);
                listSongid.Add(dr.Field<int>("songid") + "");
            }
        }
        private void MoodButtons_Click(object sender, EventArgs e)
        {

            where = "分类";
            Button topic = (Button)sender;
            this.panel2.Visible = false;
            this.panel3.Visible = true;
            this.label4.Text = topic.Text;
            string picpath = "C:\\Users\\tianyang\\Pictures\\Saved Pictures\\" + topic.Text + ".jpg";
            this.pictureBox1.Load(picpath);
            this.listBox1.Items.Clear();
            listSongid.Clear();

            //显示歌曲列表
            SongAdapter = new MySqlDataAdapter("select * from song where songtype = \'" + topic.Text + "\'", conn);//应为mood,改了数据库再说
            dsong = new DataSet();
            SongAdapter.Fill(dsong, "song");
            string songitem;
            DataRow dr1;
            foreach (DataRow dr in dsong.Tables["song"].Rows)
            {
                SingerAdapter = new MySqlDataAdapter("select * from singer where singerid= " + dr.Field<int>("singerid"), conn);
                dsinger = new DataSet();
                SingerAdapter.Fill(dsinger, "singer");

                dr1 = dsinger.Tables["singer"].Rows[0];
                songitem = dr.Field<string>("songname") + "  " + dr1.Field<string>("singername");
                CCWin.SkinControl.SkinListBoxItem songsitem = new CCWin.SkinControl.SkinListBoxItem(songitem);
                listBox1.Items.Add(songsitem);
                listSongid.Add(dr.Field<int>("songid") + "");
            }
        }
        private void GenreButtons_Click(object sender,EventArgs e)
        {
            where = "分类";
            Button topic = (Button)sender;
            this.panel2.Visible = false;
            this.panel3.Visible = true;
            this.label4.Text = topic.Text;
            string picpath = "C:\\Users\\tianyang\\Pictures\\Saved Pictures\\" + topic.Text + ".jpg";
            this.pictureBox1.Load(picpath);
            this.listBox1.Items.Clear();
            listSongid.Clear();

            //显示歌曲列表
            SongAdapter = new MySqlDataAdapter("select * from song where songgenre = \'" + topic.Text + "\'", conn);//应为songtopic,改了数据库再说
            dsong = new DataSet();
            SongAdapter.Fill(dsong, "song");
            string songitem;
            DataRow dr1;
            foreach (DataRow dr in dsong.Tables["song"].Rows)
            {
                SingerAdapter = new MySqlDataAdapter("select * from singer where singerid= " + dr.Field<int>("singerid"), conn);
                dsinger = new DataSet();
                SingerAdapter.Fill(dsinger, "singer");

                dr1 = dsinger.Tables["singer"].Rows[0];
                songitem = dr.Field<string>("songname") + "  " + dr1.Field<string>("singername");

                CCWin.SkinControl.SkinListBoxItem songsitem = new CCWin.SkinControl.SkinListBoxItem(songitem);
                listBox1.Items.Add(songsitem);

                listSongid.Add(dr.Field<int>("songid") + "");
            }
        }
////////////////////////////////////////////////搜索类别////////////////////////////////////////

////////////////////////////////////////////////搜索歌名////////////////////////////////////////

        /*private void songNameTextBox_Enter(object sender,EventArgs e)
        {
            if (textBoxHasText == false) songNameTextBox.Text= "";
            songNameTextBox.ForeColor = Color.Black;
        }
        private void songNameTextBox_Leave(object sender,EventArgs e)
        {
            if (songNameTextBox.Text == "")
            {
                songNameTextBox.Text = "请输入歌名";
                songNameTextBox.ForeColor = Color.LightBlue;
                textBoxHasText = false;
            }
            else textBoxHasText = true;
        }*/
        private void  songNameSearch_Click(object sender, EventArgs e)
        {
            if ((this.songNameTextBox.Text != "" && this.songNameTextBox.Text != "请输入歌名"))
            {
                //清空上一次搜索出歌曲的列表listBox1
                songNameListBox.Items.Clear();
                listSongid.Clear();

                //显示歌曲列表
                SongAdapter = new MySqlDataAdapter("select * from song where songname = \'" + songNameTextBox.Text + "\'", conn);
                dsong = new DataSet();
                SongAdapter.Fill(dsong, "song");
                string songitem;
                DataRow dr1;
                if (dsong.Tables["song"].Rows.Count == 0) MessageBox.Show("对不起，没有找到这首歌！");
                else
                {
                    foreach (DataRow dr in dsong.Tables["song"].Rows)
                    {

                        SingerAdapter = new MySqlDataAdapter("select * from singer where singerid= " + dr.Field<int>("singerid"), conn);
                        dsinger = new DataSet();
                        SingerAdapter.Fill(dsinger, "singer");

                        dr1 = dsinger.Tables["singer"].Rows[0];
                        songitem = songNameTextBox.Text + "  " + dr1.Field<string>("singername");
                        songNameListBox.Items.Add(songitem);
                        listSongid.Add(dr.Field<int>("songid") + "");
                    }
                }
            }
            else MessageBox.Show("请输入歌名");
        }
        //将拼音搜索出的歌曲添加到“已点列表”
        private void songNameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = songNameListBox.SelectedIndex;
            //添加到“已点歌单”
            listBox2.Items.Add(songNameListBox.Items[index]);

            SongAdapter = new MySqlDataAdapter("select * from song where songid =" + listSongid[index], conn);
            dsong = new DataSet();
            SongAdapter.Fill(dsong, "song");
            DataRow dr = dsong.Tables["song"].Rows[0];
            listSongpath.Add(@dr.Field<string>("path"));
        }
        ////////////////////////////////////////////////搜索歌名////////////////////////////////////////

        ////////////////////////////////////////////////////////////搜索歌手//////////////////////////////////////

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //清空上一次搜索出歌曲的列表listBox1和listSongid
            listBox1.Items.Clear();
            listSongid.Clear();

            int index = listBox3.SelectedIndex;
            
            //显示搜索歌曲的panel
            panel3.Visible = true;
            panel3.BringToFront();
            
            //显示歌手图片
            SingerAdapter = new MySqlDataAdapter("select * from singer where singername= \'" + listBox3.Items[index]+"\'", conn);
            dsinger = new DataSet();
            SingerAdapter.Fill(dsinger, "singer");
            DataRow dr1 = dsinger.Tables["singer"].Rows[0];
            pictureBox1.ImageLocation = @dr1.Field<string>("photopath");
            //显示歌手名字
            label4.Text= dr1.Field<string>("singername");
            //显示歌曲列表
            string singerid = dr1.Field<int>("singerid")+"";
            SongAdapter = new MySqlDataAdapter("select * from song where singerid =" + singerid, conn);
            dsong = new DataSet();
            SongAdapter.Fill(dsong, "song");
            string songitem;

            foreach (DataRow dr in dsong.Tables["song"].Rows)
            {
                songitem = dr.Field<string>("songname") + "  " + listBox3.Items[index];
                CCWin.SkinControl.SkinListBoxItem songsitem = new CCWin.SkinControl.SkinListBoxItem(songitem);
                listBox1.Items.Add(songsitem);
                listSongid.Add(dr.Field<int>("songid") + "");
            }
            
        }

        //搜索歌手名
        private void button49_Click(object sender, EventArgs e)
        {
            //清空上一次搜索出歌曲的列表listBox1和listSongid
            this.listBox3.Items.Clear();
            listSongid.Clear();
            
            //显示歌手图片
            SingerAdapter = new MySqlDataAdapter("select * from singer where singername= \'" + textBox13.Text + "\'", conn);
            dsinger = new DataSet();
            SingerAdapter.Fill(dsinger, "singer");
            if (dsinger.Tables["singer"].Rows.Count == 0)
                MessageBox.Show("对不起，没有找到该歌手！");
            else
            {
                foreach (DataRow dr in dsinger.Tables["singer"].Rows)
                {                 
                    listBox3.Items.Add(dr.Field<string>("singername"));
                }
            }
            
            }

        //将歌手搜索出的歌添加到“已点歌单”
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            int index = listBox1.SelectedIndex;
            //添加到“已点歌单”
            listBox2.Items.Add(listBox1.Items[index]);

            SongAdapter = new MySqlDataAdapter("select * from song where songid =" + listSongid[index], conn);
            dsong = new DataSet();
            SongAdapter.Fill(dsong, "song");
            DataRow dr = dsong.Tables["song"].Rows[0];
            listSongpath.Add(@dr.Field<string>("path"));
        }

        //男歌手
        private void button1_Click(object sender, EventArgs e)
        {
            //清空上一次搜索出歌曲的列表listBox1和listSongid
            listBox3.Items.Clear();
            listSongid.Clear();

            SingerAdapter = new MySqlDataAdapter("select * from singer where singercategory= \'" +"男歌手"+"\'", conn);
            dsinger = new DataSet();
            SingerAdapter.Fill(dsinger, "singer");
            foreach (DataRow dr in dsinger.Tables["singer"].Rows)
            {
                listBox3.Items.Add(dr.Field<string>("singername"));
            }     
    }   
        //女歌手
        private void button2_Click(object sender, EventArgs e)
        {
            //清空上一次搜索出歌曲的列表listBox1和listSongid
            listBox3.Items.Clear();
            listSongid.Clear();

            SingerAdapter = new MySqlDataAdapter("select * from singer where singercategory= \'" + "女歌手" + "\'", conn);
            dsinger = new DataSet();
            SingerAdapter.Fill(dsinger, "singer");
            foreach (DataRow dr in dsinger.Tables["singer"].Rows)
            {
                listBox3.Items.Add(dr.Field<string>("singername"));
            }
        }
        //组合
        private void button3_Click(object sender, EventArgs e)
        {
            //清空上一次搜索出歌曲的列表listBox1和listSongid
            listBox3.Items.Clear();
            listSongid.Clear();

            SingerAdapter = new MySqlDataAdapter("select * from singer where singercategory= \'" + "组合" + "\'", conn);
            dsinger = new DataSet();
            SingerAdapter.Fill(dsinger, "singer");
            foreach (DataRow dr in dsinger.Tables["singer"].Rows)
            {
                listBox3.Items.Add(dr.Field<string>("singername"));
            }
        }
        //全部
        private void button14_Click(object sender, EventArgs e)
        {
            //清空上一次搜索出歌曲的列表listBox1和listSongid
            listBox3.Items.Clear();
            listSongid.Clear();
           
            SingerAdapter = new MySqlDataAdapter("select * from singer ", conn);
            dsinger = new DataSet();
            SingerAdapter.Fill(dsinger, "singer");
            foreach (DataRow dr in dsinger.Tables["singer"].Rows)
            {
                listBox3.Items.Add(dr.Field<string>("singername"));
            }
        }
        //////////////////////////搜索歌手////////////////////////////////////////////////

        //////////////////////////播放、切歌、顶歌、重唱、删除//////////////////////////////////////
        //播放
        private void play_Click(object sender, EventArgs e)
        {
            if (listSongpath.Count != 0)
            {
                if (playButton.Text == "播放")
                {
                    textBox1.Text = listBox2.Items[0].ToString();
                    
                    MediaPlayer1.URL = listSongpath[0];
                    MediaPlayer1.Ctlcontrols.play();
                    playButton.Text = "暂停";

                }
                else
                {
                    MediaPlayer1.Ctlcontrols.pause();
                    playButton.Text = "播放";
                }
            }
            else { MessageBox.Show("没有待播放歌曲了，请点歌！"); }
        }

        //重唱
        private void ReSing_Click(object sender, EventArgs e)
        {
            if (listSongpath.Count != 0)
            {
                MediaPlayer1.Ctlcontrols.stop();
                MediaPlayer1.Ctlcontrols.play();
            }
            else { MessageBox.Show("没有待播放歌曲了，请点歌！"); }
        }

        //切歌
        private void NextSong_Click(object sender, EventArgs e)
        {
            panel7.Size = new Size(Convert.ToInt32(panel1.Width * 1.1), Convert.ToInt32(panel1.Height * 1.1));
            panel7.BringToFront();
            if (listSongpath.Count != 0)
            {
                //注意REmove()里的参数是Object value而不是Index!!!
                listBox2.Items.Remove(listBox2.Items[0]);
                listSongpath.RemoveAt(0);
                if(listBox2.Items.Count == 0) textBox1.Text = "";
            }
            else
            {
                
                MessageBox.Show("没有待播放歌曲了，请点歌！");
            }
            MediaPlayer1.Ctlcontrols.stop();

            if (listSongpath.Count != 0)
            {
                MediaPlayer1.URL = listSongpath[0];
                MediaPlayer1.Ctlcontrols.play();
                textBox1.Text = listBox2.Items[0].ToString();
            }
        }

        //顶歌
        private void topButtonutton_Click(object sender, EventArgs e)
        {
            int index = listBox2.SelectedIndex;
            if (index >0)
            {
                string tempL = listSongpath[index]; //中间变量
                Object tempB = listBox2.Items[index]; //中间变量
                for (int i = index; i > 0; i--)
                {
                    listSongpath[i] = listSongpath[i - 1];//将index前面的所有歌都向后移一位
                    listBox2.Items[i] = listBox2.Items[i - 1];
                }
                listSongpath[1] = tempL;
                listBox2.Items[1] = tempB;
            }
            else if(index==0) MessageBox.Show("该歌曲已经在顶部了！");
            else
                MessageBox.Show("没有选中列", "错误提示框");
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex >= 0)//如果选中某列
                listBox2.Items.Remove(listBox2.Items[listBox2.SelectedIndex]);//删除所选列
            else
                MessageBox.Show("没有选中列", "错误提示框");
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void songNamePanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void singerPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //拼音搜索
        private void button5_Click(object sender, EventArgs e)
        {
            //清空上一次搜索结果和listSongid
            listBox4.Items.Clear();
            listSongid.Clear();
      
            //显示歌曲列表
            SongAdapter = new MySqlDataAdapter("select * from song where songpinyin = \'" + textBox3.Text+"\'", conn);
            dsong = new DataSet();
            SongAdapter.Fill(dsong, "song");
            string songitem;

            if (dsong.Tables["song"].Rows.Count == 0)

                MessageBox.Show("对不起，没有找到对应的歌，请重新输入！");
            else
            {
                
                foreach (DataRow dr in dsong.Tables["song"].Rows)
                {
                    //找到对应歌手名
                    SingerAdapter = new MySqlDataAdapter("select * from singer where singerid =" + dr.Field<int>("singerid"), conn);
                    dsinger = new DataSet();
                    SingerAdapter.Fill(dsinger, "singer");
                    DataRow dr1 = dsinger.Tables["singer"].Rows[0];
                    songitem = dr.Field<string>("songname") + "  " + dr1.Field<string>("singername");
                    listBox4.Items.Add(songitem);
                    listSongid.Add(dr.Field<int>("songid") + "");
                }
            }
        }

        //将搜索列表listBox4添到“已点列表”listBox2
        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox4.SelectedIndex;
            //添加到“已点歌单”
            listBox2.Items.Add(listBox4.Items[index]);

            SongAdapter = new MySqlDataAdapter("select * from song where songid =" + listSongid[index], conn);
            dsong = new DataSet();
            SongAdapter.Fill(dsong, "song");
            DataRow dr = dsong.Tables["song"].Rows[0];
            listSongpath.Add(@dr.Field<string>("path"));
        }



        //清空
        private void button7_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        //<-删除一个字母
        private void button6_Click(object sender, EventArgs e)
        {
            string pinyintext = textBox3.Text;
            if (pinyintext.Length > 0) pinyintext = pinyintext.Substring(0, pinyintext.Length - 1);
            else MessageBox.Show("已经没有字母了！");
            textBox3.Text = pinyintext;
        }

        
        private void pinyinButtons_Click(object sender, EventArgs e)
        {
            if (this.textBox3.Text == "请输入歌曲歌名的首字母") this.textBox3.Text = null;
            this.textBox3.ForeColor = Color.Black;
            Button button = (Button)sender;
            textBox3.AppendText(button.Text);
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            //添加到“已点歌单”
            listBox2.Items.Add(listBox1.Items[index]);

            SongAdapter = new MySqlDataAdapter("select * from song where songid =" + listSongid[index], conn);
            dsong = new DataSet();
            SongAdapter.Fill(dsong, "song");
            DataRow dr = dsong.Tables["song"].Rows[0];
            listSongpath.Add(@dr.Field<string>("path"));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.panel3.Visible = false;
            if (where == "分类")
                this.panel2.Visible = true;
            else if (where == "歌手")
                this.singerPanel1.Visible = true;
            else;
        }

        private void publicPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //////////////////////////播放、切歌、顶歌、重唱、删除//////////////////////////////////////
    }
}
