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
        private MySqlDataAdapter mDataAdapter1;
        private MySqlDataAdapter mDataAdapter2;
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
            mDataAdapter1 = new MySqlDataAdapter("select * from singer", conn);
            dsinger = new DataSet();
            string singername;
            mDataAdapter1.Fill(dsinger, "singer");
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
            //mDataAdapter = new MySqlDataAdapter("select * from song", conn);
            //dsall = new DataSet();
            //mDataAdapter.Fill(dsall, "hard");
            //dataGridView1.DataSource = dsall.Tables["hard"];
            //pinyinPanel.Visible = true;
            //pinyinPanel.BringToFront();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //清空上一次搜索出歌曲的列表listBox1
            listBox1.Items.Clear();
            int index = listBox3.SelectedIndex;
            //显示歌手图片
            mDataAdapter2 = new MySqlDataAdapter("select * from singer where singername= \'" + listBox3.Items[index]+"\'", conn);
            dsinger = new DataSet();
            mDataAdapter2.Fill(dsinger, "singer");
            DataRow dr1 = dsinger.Tables["singer"].Rows[0];
            pictureBox1.ImageLocation = @dr1.Field<string>("photopath");
            //显示歌手名字
            label4.Text= dr1.Field<string>("singername");
            //显示歌曲列表
            string singerid = dr1.Field<int>("singerid")+"";
            mDataAdapter1 = new MySqlDataAdapter("select * from song where singerid =" + singerid, conn);
            dsong = new DataSet();
            mDataAdapter1.Fill(dsong, "song");
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

            mDataAdapter1 = new MySqlDataAdapter("select * from song where songid =" +listSongid[index], conn); 
            dsong = new DataSet();
            mDataAdapter1.Fill(dsong, "song");
            DataRow dr = dsong.Tables["song"].Rows[0];
            listSongpath.Add(@dr.Field<string>("path"));
        }
    }
}
