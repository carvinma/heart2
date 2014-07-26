using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace strike_subsystem
{
    public partial class Main_Fram : Form
    {
        //private OleDbConnection _userConn = new OleDbConnection("Data Source=" + "D:\\UserInfo.mdb;Jet OLEDB:Engine Type=5;Provider=Microsoft.Jet.OLEDB.4.0"); //数据库连接
        private OleDbConnection _userConn = new OleDbConnection("Data Source=|DataDirectory|\\UserInfo.mdb;Jet OLEDB:Engine Type=5;Provider=Microsoft.Jet.OLEDB.4.0"); //数据库连接

        private bool data_exist = false;    //数据库中是否有用户

        public Main_Fram()
        {
            InitializeComponent();
            try
            {
                _userConn.Open();
                OleDbCommand cmd = new OleDbCommand("select * from UserInfo", _userConn);
                if (cmd.ExecuteScalar() != null)
                {
                    data_exist = true;
                }
                _userConn.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Main_Fram_Load(object sender, EventArgs e)
        {
            Welcome Form_Wel = new Welcome();
            Form_Wel.MdiParent = this;
            Form_Wel.Show();
            Form_Wel.Dock = DockStyle.Fill;
        }

        public void set_data_exist(bool value)
        {
            data_exist = value;
        }

        public bool get_data_exist()
        {
            return data_exist;
        }

        private void videoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VideoRateDisplay child =(VideoRateDisplay)this.ActiveMdiChild;
            child.video_only();
        }

        private void rate_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VideoRateDisplay child = (VideoRateDisplay)this.ActiveMdiChild;
            child.rate_only();
        }

        private void vr_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VideoRateDisplay child = (VideoRateDisplay)this.ActiveMdiChild;
            child.both_dis();
        }

        private void beginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VideoRateDisplay child = (VideoRateDisplay)this.ActiveMdiChild;
            child.begincap();
        }

        private void endToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VideoRateDisplay child = (VideoRateDisplay)this.ActiveMdiChild;
            child.stopcap();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
