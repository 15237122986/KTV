
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

        private static string mysqlconn = "database=KTV;password=123456;user=root;server=localhost;";//data Source=MySQL;charset=utf-8";
        //private static string mysqlconn = "database=ktv;password=1111;user=root;server=localhost;";//data Source=MySQL;charset=utf-8";
        private MySqlConnection conn;
        private MySqlDataAdapter SongAdapter,SingerAdapter;
        private DataSet dsong,dsinger;

        private MySqlCommand findsong,findsinger;
        private MySqlDataReader sdr,sdr2;
        
        
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
            
        }


        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void ChooseSinger_Click(object sender, EventArgs e)
        {
            SongAdapter = new MySqlDataAdapter("select * from singer", conn);
            dsinger = new DataSet();
            string singername;
            SongAdapter.Fill(dsinger, "singer");
            // dataGridView1.DataSource = dsong.Tables["singer"];//歌手名
            foreach (DataRow dr in dsinger.Tables["singer"].Rows)
            {
                singername = dr.Field<string>("singername");
                listBox3.Items.Add(singername);
            }

            singerPanel1.Visible = true;
            singerPanel1.BringToFront();
        }
        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //清空上一次搜索出歌曲的列表listBox1
            listBox1.Items.Clear();
            int index = listBox3.SelectedIndex;
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
                listBox1.Items.Add(songitem);
                listSongid.Add(dr.Field<int>("songid") + "");
            }

        }
        //搜索出的歌单
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            int index = listBox1.SelectedIndex;
            //添加到“已点歌单”
            //listBox2.Items.Add(listBox1.Items[index]);

            SongAdapter = new MySqlDataAdapter("select * from song where songid =" +listSongid[index], conn); 
            dsong = new DataSet();
            SongAdapter.Fill(dsong, "song");
            DataRow dr = dsong.Tables["song"].Rows[0];
            listSongpath.Add(@dr.Field<string>("path"));
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
            //categoryPanel2.Visible = true;
            //categoryPanel2.BringToFront();
        }

        private void ChoosePingyin_Click(object sender, EventArgs e)
        {
            SongAdapter = new MySqlDataAdapter("select * from song", conn);
            dsong = new DataSet();
            SongAdapter.Fill(dsong, "hard");
            //dataGridView1.DataSource = dsong.Tables["hard"];
            //pinyinPanel.Visible = true;
            //pinyinPanel.BringToFront();
        }

        private void ChooseSongName_Click(object sender, EventArgs e)
        {
            this.panel1.Visible = false;
            this.songNameListBox.Items.Clear();
            this.songNamePanel.Visible = true;
            this.songNamePanel.BringToFront();
        }

        private void songNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LanguageButtons_Click(object sender, EventArgs e)
        {
            Button topic = (Button)sender;
            this.panel2.Visible = false;
            this.panel3.Visible = true;
            this.label4.Text = topic.Text;
            string picpath = "C:\\Users\\tianyang\\Pictures\\Saved Pictures\\"+topic.Text+".jpg";
            //this.pictureBox1.Load(picpath);
            this.listBox1.Items.Clear();
            listSongid.Clear();

            //显示歌曲列表
            SongAdapter = new MySqlDataAdapter("select * from song where language = \'" + topic.Text + "\'", conn);//应为songtopic,改了数据库再说
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
                listBox1.Items.Add(songitem);
                listSongid.Add(dr.Field<int>("songid") + "");
            }
        }
        private void TopicButtons_Click(object sender, EventArgs e)
        {
            Button topic =(Button)sender;
            this.panel2.Visible = false;
            this.panel3.Visible=true;
            this.label4.Text =topic.Text;
            string picpath = "C:\\Users\\tianyang\\Pictures\\Saved Pictures\\"+topic.Text+".jpg";
            //this.pictureBox1.Load(picpath);
            this.listBox1.Items.Clear();
            listSongid.Clear();

            //显示歌曲列表
            SongAdapter = new MySqlDataAdapter("select * from song where songtype = \'" + topic.Text + "\'", conn);//应为songtopic,改了数据库再说
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
                    listBox1.Items.Add(songitem);
                    listSongid.Add(dr.Field<int>("songid") + "");
            }
        }
        private void MoodButtons_Click(object sender, EventArgs e)
        {
            Button topic = (Button)sender;
            this.panel2.Visible = false;
            this.panel3.Visible = true;
            this.label4.Text = topic.Text;
            string picpath = "C:\\Users\\tianyang\\Pictures\\Saved Pictures\\" + topic.Text + ".jpg";
            //this.pictureBox1.Load(picpath);
            this.listBox1.Items.Clear();
            listSongid.Clear();

            //显示歌曲列表
            SongAdapter = new MySqlDataAdapter("select * from song where songtopic = \'" + topic.Text + "\'", conn);//应为mood,改了数据库再说
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
                listBox1.Items.Add(songitem);
                listSongid.Add(dr.Field<int>("songid") + "");
            }
        }
        private void GenreButtons_Click(object sender,EventArgs e)
        {
            Button topic = (Button)sender;
            this.panel2.Visible = false;
            this.panel3.Visible = true;
            this.label4.Text = topic.Text;
            string picpath = "C:\\Users\\tianyang\\Pictures\\Saved Pictures\\" + topic.Text + ".jpg";
            //this.pictureBox1.Load(picpath);
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
                listBox1.Items.Add(songitem);
                listSongid.Add(dr.Field<int>("songid") + "");
            }
        }

        private void Home_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
            songNamePanel.Visible = false;
            panel1.Visible = true;
            panel2.Visible = false;
            panel3.Visible = false;
            //this.label4.Text = "";
        }
        
        private void songNameTextBox_Enter(object sender,EventArgs e)
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
        }
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
    }
}