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
        private static string mysqlconn = "database=KTV;password=123456;user=root;server=localhost;";//data Source=MySQL;charset=utf-8";
        private MySqlConnection conn;
        private MySqlDataAdapter mDataAdapter;
        private DataSet dsall;
        //private MySqlCommand cmd;
        //private MySqlDataReader sdr;
        private Boolean textBoxHasText = false;
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection(mysqlconn);
            songNamePanel.Visible = false;
            panel5.Visible = false;
            panel3.Visible = false;
            
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ChooseSinger_Click(object sender, EventArgs e)
        {
            
            //singerPanel.Visible = true;
            //singerPanel.BringToFront();
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
            mDataAdapter = new MySqlDataAdapter("select * from song", conn);
            dsall = new DataSet();
            mDataAdapter.Fill(dsall, "hard");
            //dataGridView1.DataSource = dsall.Tables["hard"];
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

        private void Home_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
            songNamePanel.Visible = false;
            panel1.Visible = true;
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
            if (this.songNameTextBox.Text != "" && this.songNameTextBox.Text != "请输入歌名")
            {
                this.songNameListBox.Items.Clear();
                string songname = this.button95.Text;
                string select = "select * from song where songname=\'";
                select += this.songNameTextBox.Text + "\'";

                try { 
                    conn = new MySqlConnection(mysqlconn);
                    conn.Open();
                    mDataAdapter = new MySqlDataAdapter(select, conn);
                    dsall = new DataSet();
                    mDataAdapter.Fill(dsall);
                    this.songNameListBox.DisplayMember = "songname";
                    this.songNameListBox.ValueMember="path";
                    MessageBox.Show(this.songNameListBox.ValueMember);
                    this.songNameListBox.DataSource = dsall.Tables[0].DefaultView;
                    /*cmd = new MySqlCommand(select, conn);
                    sdr = cmd.ExecuteReader();
                    if (sdr.Read())
                    {
                        this.songNameListBox.Items.Add(sdr["songname"+"songerid"].ToString().Trim());
                        while (sdr.Read())
                        {
                            this.songNameListBox.Items.Add(sdr["songname"+"songerid"].ToString().Trim());
                        }
                    }
                    else MessageBox.Show("Sorry,We don't have this song!");
                    sdr.Close();*/
                    //mDataAdapter = new MySqlDataAdapter(select, conn);
                    //dsall = new DataSet();
                    //mDataAdapter.Fill(dsall, "hard");
                    //dataGridView1.DataSource = dsall.Tables["hard"];
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { conn.Close(); }
            }
        }
    }
}
