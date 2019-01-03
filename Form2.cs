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
        private static string mysqlconn = "database=song;password=123456;user=root;server=localhost;";//data Source=MySQL;charset=utf-8";
        private MySqlConnection conn;
        private MySqlDataAdapter mDataAdapter;
        private DataSet dsall;
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
            
            singerPanel.Visible = true;
            singerPanel.BringToFront();
        }

        private void Vounmn_Click(object sender, EventArgs e)
        {

        }

        

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void ChooseCategory_Click(object sender, EventArgs e)
        {
            categoryPanel2.Visible = true;
            categoryPanel2.BringToFront();
        }

        private void ChoosePingyin_Click(object sender, EventArgs e)
        {
            mDataAdapter = new MySqlDataAdapter("select * from song", conn);
            dsall = new DataSet();
            mDataAdapter.Fill(dsall, "hard");
            dataGridView1.DataSource = dsall.Tables["hard"];
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
    }
}
