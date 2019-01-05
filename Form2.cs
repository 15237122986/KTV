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

        private static string mysqlconn = "database=ktv;password=1111;user=root;server=localhost;";//data Source=MySQL;charset=utf-8";
        private MySqlConnection conn;
        private MySqlDataAdapter SongAdapter;
        private MySqlDataAdapter SingerAdapter;
        private DataSet dsong;
        private DataSet dsinger;
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection(mysqlconn);
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ChooseSinger_Click(object sender, EventArgs e)
        {
            SongAdapter = new MySqlDataAdapter("select * from singer", conn);
            dsinger = new DataSet();
            string singername;
            SongAdapter.Fill(dsinger, "singer");
            // dataGridView1.DataSource = dsall.Tables["singer"];//歌手名
            foreach (DataRow dr in dsinger.Tables["singer"].Rows)
            {
                singername = dr.Field<string>("singername");
                listBox3.Items.Add(singername);
            }

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
           //categoryPanel2.Visible = true;
            //categoryPanel2.BringToFront();
        }

        private void ChoosePingyin_Click(object sender, EventArgs e)
        {       
            pinyinPanel.Visible = true;
            pinyinPanel.BringToFront();
        }

        private void ChooseSongName_Click(object sender, EventArgs e)
        {
            songNamePanel.Visible = true;
            songNamePanel.BringToFront();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
        }

//////////////////////////搜索歌手//////////////////////////////////////

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //清空上一次搜索出歌曲的列表listBox1和listSongid
            listBox1.Items.Clear();
            listSongid.Clear();

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
            listBox2.Items.Add(listBox1.Items[index]);

            SongAdapter = new MySqlDataAdapter("select * from song where songid =" +listSongid[index], conn); 
            dsong = new DataSet();
            SongAdapter.Fill(dsong, "song");
            DataRow dr = dsong.Tables["song"].Rows[0];
            listSongpath.Add(@dr.Field<string>("path"));
        }

        //搜索歌手名
        private void button49_Click(object sender, EventArgs e)
        {
            //清空上一次搜索出歌曲的列表listBox1和listSongid
            listBox1.Items.Clear();
            listSongid.Clear();
            //显示歌手图片
            SingerAdapter = new MySqlDataAdapter("select * from singer where singername= \'" + textBox13.Text + "\'", conn);
            dsinger = new DataSet();
            SingerAdapter.Fill(dsinger, "singer");
            if (dsinger.Tables["singer"].Rows.Count == 0)
                MessageBox.Show("对不起，没有找到该歌手！");
            else
            {
                DataRow dr1 = dsinger.Tables["singer"].Rows[0];
                pictureBox1.ImageLocation = @dr1.Field<string>("photopath");
                //显示歌手名字
                label4.Text = dr1.Field<string>("singername");
                //显示歌曲列表
                string singerid = dr1.Field<int>("singerid") + "";
                SongAdapter = new MySqlDataAdapter("select * from song where singerid =" + singerid, conn);
                dsong = new DataSet();
                SongAdapter.Fill(dsong, "song");
                string songitem;

                foreach (DataRow dr in dsong.Tables["song"].Rows)
                {
                    songitem = dr.Field<string>("songname") + "  " + textBox13.Text;
                    listBox1.Items.Add(songitem);
                    listSongid.Add(dr.Field<int>("songid") + "");
                }
            }
        }
//////////////////////////搜索歌手//////////////////////////////////////

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

        //<-删除一个字母
        private void button6_Click(object sender, EventArgs e)
        {
            string pinyintext = textBox3.Text;
            pinyintext = pinyintext.Substring(0, pinyintext.Length - 1);
            textBox3.Text = pinyintext;
        }

        //X
        private void button22_Click(Object sender, EventArgs e)
        {
            textBox3.AppendText("X");
        }
        private void button78_Click(object sender, EventArgs e)
        {
            textBox3.AppendText("A");
        }

        private void button77_Click(object sender, EventArgs e)
        {
            textBox3.AppendText("B");
        }

        private void button76_Click(object sender, EventArgs e)
        {
            textBox3.AppendText("C");
        }

        private void button75_Click_1(object sender, EventArgs e)
        {
            textBox3.AppendText("D");
        }

        private void button74_Click(object sender, EventArgs e)
        {
            textBox3.AppendText("E");
        }

        private void button73_Click(object sender, EventArgs e)
        {
            textBox3.AppendText("F");
        }

        private void button72_Click(object sender, EventArgs e)
        {
            textBox3.AppendText("G");
        }

        private void button71_Click(object sender, EventArgs e)
        {
            textBox3.AppendText("H");
        }

        private void button70_Click(object sender, EventArgs e)
        {
            textBox3.AppendText("I");
        }

        private void button69_Click(object sender, EventArgs e)
        {
            textBox3.AppendText("J");
        }

        private void button68_Click(object sender, EventArgs e)
        {
            textBox3.AppendText("K");
        }

        private void button67_Click(object sender, EventArgs e)
        {
            textBox3.AppendText("L");
        }

        private void button66_Click(object sender, EventArgs e)
        {
            textBox3.AppendText("M");
        }

        private void button65_Click(object sender, EventArgs e)
        {
            textBox3.AppendText("N");
        }

        private void button64_Click(object sender, EventArgs e)
        {
            textBox3.AppendText("O");
        }

        private void button63_Click(object sender, EventArgs e)
        {
            textBox3.AppendText("P");
        }

        private void button62_Click(object sender, EventArgs e)
        {
            textBox3.AppendText("Q");
        }

        private void button61_Click(object sender, EventArgs e)
        {
            textBox3.AppendText("R");
        }

        private void button60_Click(object sender, EventArgs e)
        {
            textBox3.AppendText("S");
        }

        private void button59_Click(object sender, EventArgs e)
        {
            textBox3.AppendText("T");
        }

        private void button58_Click(object sender, EventArgs e)
        {
            textBox3.AppendText("U");
        }

        private void button57_Click(object sender, EventArgs e)
        {
            textBox3.AppendText("V");
        }

        private void button51_Click(object sender, EventArgs e)
        {
            textBox3.AppendText("W");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox3.AppendText("Y");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox3.AppendText("Z");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox3.AppendText("0");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox3.AppendText("1");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox3.AppendText("2");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox3.AppendText("3");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox3.AppendText("4");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox3.AppendText("5");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox3.AppendText("6");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox3.AppendText("7");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox3.AppendText("8");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox3.AppendText("9");
        }
        //////////////////////////播放、切歌、顶歌、重唱、删除//////////////////////////////////////
    }
}
