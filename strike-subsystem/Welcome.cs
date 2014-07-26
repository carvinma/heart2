using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace strike_subsystem
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
            Welcome_BG.Image = Image.FromFile("images\\Welcome.jpg");
            Button_New_p.Image = Image.FromFile("images\\add-male-user.png");
            Button_Manage_p.Image = Image.FromFile("images\\fa2.png");
            Button_Exam.Image = Image.FromFile("images\\Exam.png");
            Button_Analysis.Image = Image.FromFile("images\\Analysis.png");
        }

        private void Button_New_p_Click(object sender, EventArgs e)
        {
            New_p form_n = new New_p();
            form_n.MdiParent = this.MdiParent;
            form_n.Show();
            form_n.Dock = DockStyle.Fill;
        }

        private void Button_Manage_p_Click(object sender, EventArgs e)
        {
            Main_Fram tForm = (Main_Fram)this.MdiParent;
            if (tForm.get_data_exist())     //判断用户是否为空
            {
                Manage_p form_m = new Manage_p();
                form_m.MdiParent = this.MdiParent;
                form_m.Show();
                form_m.Dock = DockStyle.Fill;
            }
            else
            {
                if (MessageBox.Show("目前没有用户，请添加！", "添加新用户", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    New_p form_n = new New_p();
                    form_n.MdiParent = this.MdiParent;
                    form_n.Show();
                    form_n.Dock = DockStyle.Fill;
                }
            }
        }

        private void Button_Exam_Click(object sender, EventArgs e)
        {
            Main_Fram tForm = (Main_Fram)this.MdiParent;
            if (tForm.get_data_exist())     //判断用户是否为空
            {
                VideoRateDisplay form_e = new VideoRateDisplay();
                form_e.MdiParent = this.MdiParent;
                form_e.Show();
                form_e.Dock = DockStyle.Fill;
            }
            else
            {
                if (MessageBox.Show("目前没有用户，请添加！", "添加新用户", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    New_p form_n = new New_p();
                    form_n.MdiParent = this.MdiParent;
                    form_n.Show();
                    form_n.Dock = DockStyle.Fill;
                }
            }
        }

        private void Button_Analysis_Click(object sender, EventArgs e)
        {
            Main_Fram tForm = (Main_Fram)this.MdiParent;
            if (tForm.get_data_exist())     //判断用户是否为空
            {
                analys form_an = new analys();
                form_an.MdiParent = this.MdiParent;
                form_an.Show();
                form_an.Dock = DockStyle.Fill;
            }
            else
            {
                if (MessageBox.Show("目前没有用户，请添加！", "添加新用户", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    New_p form_n = new New_p();
                    form_n.MdiParent = this.MdiParent;
                    form_n.Show();
                    form_n.Dock = DockStyle.Fill;
                }
            }
        }

        //private void Button_Adjust_Click(object sender, EventArgs e)
        //{
        //    Adjust form_ad = new Adjust();
        //    form_ad.MdiParent = this.MdiParent;
        //    form_ad.Show();
        //    form_ad.Dock = DockStyle.Fill;
        //}

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Welcome_BG_Click(object sender, EventArgs e)
        {

        }

        private void Button_Adjust_Click(object sender, EventArgs e)
        {
            
        }
    }
}
