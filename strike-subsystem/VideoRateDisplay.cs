using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Data.OleDb;
using System.Diagnostics;
using System.Threading.Tasks;

namespace strike_subsystem
{
    public partial class VideoRateDisplay : Form
    {
        public Manage_p lastfrm;
        //常量
        public const double c0 = -2.340329;
        public const double c1 = 9.290971;
        public int avgNum = 5;
        private double cavgRate = 0;
        private double daixie = 0;
        //seconds avg
        List<double> avglist;
        volatile int i;
        volatile bool isRecord = false;
        double curRate;
        bool start = false;
        int j = 0;
        byte[] data = new byte[6];
        //thread
        volatile Boolean running = true;
        private Thread dispRate;
        //location
        static Point v_loc = new Point(30, 75);
        static Point r_loc = new Point(v_loc.X + 706, v_loc.Y);
        //delegate 
        delegate void updateView(int i, int x);
        delegate void updateCap(int i, double r, double avg, double o);
        //user info        
        string name;
        long userid;
        string videoPath;
        string ratePath;
        //serialize
        StreamWriter sw;
        Point l;
        Boolean isFullScreen = false;
        //private OleDbConnection _userConn = new OleDbConnection("Data Source=" + "D:\\UserInfo.mdb;Jet OLEDB:Engine Type=5;Provider=Microsoft.Jet.OLEDB.4.0"); //数据库连接
        private OleDbConnection _userConn = new OleDbConnection("Data Source=|DataDirectory|\\UserInfo.mdb;Jet OLEDB:Engine Type=5;Provider=Microsoft.Jet.OLEDB.4.0"); //数据库连接

        OleDbDataAdapter adp;
        DataSet ds = new DataSet();
        public VideoRateDisplay()
        {
            InitializeComponent();
            i = 0;
            avglist = new List<double>();

            dispRate = new Thread(new ThreadStart(renderRate));
        }
        public void setUserInfo(string name)
        {
            this.name = name;
            string time = DateTime.Now.ToFileTime().ToString();
            videoPath = name + time + ".AVI";
            vcap.CapFilename = "video\\" + videoPath;
            vcap.SetVideoFormat(640, 480);
            ratePath = name + time + ".txt";
            sw = new StreamWriter("data\\" + ratePath);
            string sql = string.Format("insert into videoRate(UserName,videoPath,ratePath)values('{0}','{1}','{2}')", name, videoPath, ratePath);
            _userConn.Open();
            OleDbCommand cmd = new OleDbCommand(sql, _userConn);
            cmd.ExecuteNonQuery();
            _userConn.Close();
            //int SP_tnum = 0;
            //for (; SP_tnum < 20; SP_tnum++)        //检测串口
            //{
            //    string sp_tname = "COM" + SP_tnum;
            //    try
            //    {
            //        if (Sp.IsOpen)
            //        {
            //            Sp.Close();
            //        }

            //        Sp.PortName = sp_tname;
            //        Sp.Open();

            //    }
            //    catch (System.Exception ex)
            //    {
            //        continue;
            //    }
            //    break;
            //}
            Sp.PortName = "COM1";
            Sp.Open();


        }

        private void VideoRateDisplay_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile("images//vp22.jpg");
            chart1.ChartAreas[0].AxisY.Minimum = 50;
            chart1.ChartAreas[0].AxisY.Maximum = 240;
            chart1.ChartAreas[1].AxisY.Minimum = 400;
            chart1.Series["记录心率"]["PointWidth"] = "0.5";
            vcap.Connected = true;
            vcap.Preview = true;
            int c = vcap.GetVideoCodecCount();

            this.begincap();
            timer1.Start();

        }
        private void renderRate()
        {
            while (running)
            {
                Random r = new Random();
                int rate = 50 + r.Next(100);
                updateView updateChart = new updateView(chartUpdate);
                chart1.BeginInvoke(updateChart, new object[] { i, rate });
                i++;
                Thread.Sleep(1000);
            }
        }
        public void begincap()
        {
            bool suc = vcap.StartCapture();
            int c = 1;
        }
        public void stopcap()
        {
            vcap.StopCapture();
        }
        public void video_only()
        {
            chart1.Visible = false;
            Point l = panel1.Location;
            panel1.Location = new Point((this.Width - vcap.Width) / 2, l.Y);
            panel1.Visible = true;
        }
        public void rate_only()
        {
            panel1.Visible = false;
            Point l = chart1.Location;
            chart1.Location = new Point((this.Width - chart1.Width) / 2, l.Y);
            chart1.Visible = true;
        }
        public void both_dis()
        {
            panel1.Location = v_loc;
            chart1.Location = r_loc;
            chart1.Visible = true;
            panel1.Visible = true;
        }
        public void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form p = this.MdiParent;
            chart1.Visible = false;
            Point l = panel1.Location;
            panel1.Location = new Point((this.Width - vcap.Width) / 2, l.Y);

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void vcap_CaptureStart(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random r = new Random();
            int rate = 50 + r.Next(50);

            updateView updateChart = new updateView(chartUpdate);
            BeginInvoke(updateChart, new object[] { i, rate });
            i++;

        }
        private void capUpdate(int i, double r, double avg, double o)
        {
            DateTime now = DateTime.Now;

            //vcap.SetTextOverlay(0, "即时心率： "+r.ToString()+"   平均心率： "+avg.ToString()+"  代谢率： "+o.ToString(), 30, 30, "Arials", 18, 255, -1);
            vcap.SetTextOverlay(0, "即时心率: " + r.ToString(), 30, 30, "Arials", 18, 255, -1);
            vcap.SetTextOverlay(1, "平均心率: " + avg.ToString(), 220, 30, "Arials", 18, 255, -1);//mch 修改
            vcap.SetTextOverlay(2, "代谢率: " + o.ToString(), 410, 30, "Arials", 18, 255, -1);
            vcap.SetTextOverlay(3, now.ToString(), 400, 400, "Arials", 18, 255, -1);
        }
        private void chartUpdate(int i, int x)
        {
            curRate = x;
            if (i < avgNum)
                avglist.Add(x);
            else
            {
                avglist.RemoveAt(0);
                avglist.Add(x);
            }
            double avgRate = avglist.Average();//pc求平均值  mch
            cavgRate = avgRate;
            double o = c0 + c1 * avgRate;
            daixie = Math.Round(o, 2);
            int totalSecoud = i;
            if (chart1.Series["即时心率"].Points.Count == 0)
            {
                chart1.Series["即时心率"].Points.AddXY(i, x);
                chart1.Series["平均心率"].Points.AddXY(i, avgRate);
                chart1.Series["代谢率"].Points.AddXY(i, o);
                chart1.Invalidate();
                return;
            }
            chart1.Series["即时心率"].Points.AddXY(i, x);
            chart1.Series["平均心率"].Points.AddXY(i, avgRate);
            chart1.Series["代谢率"].Points.AddXY(i, o);
            double before = i - 60;
            while (chart1.Series["即时心率"].Points[0].XValue < before)
            {
                chart1.Series["即时心率"].Points.RemoveAt(0);
            }
            while (chart1.Series["平均心率"].Points[0].XValue < before)
            {
                chart1.Series["平均心率"].Points.RemoveAt(0);
            }
            while (chart1.Series["代谢率"].Points[0].XValue < before)
            {
                chart1.Series["代谢率"].Points.RemoveAt(0);
            }
            chart1.ChartAreas[0].AxisX.Minimum = chart1.Series["即时心率"].Points[0].XValue;
            chart1.ChartAreas[0].AxisX.Maximum = chart1.Series["平均心率"].Points[0].XValue + 60;
            chart1.ChartAreas[1].AxisX.Minimum = chart1.Series["即时心率"].Points[0].XValue;
            chart1.ChartAreas[1].AxisX.Maximum = chart1.Series["平均心率"].Points[0].XValue + 60;
            chart1.Invalidate();
            updateCap uc = new updateCap(capUpdate);
            BeginInvoke(uc, new object[] { i, x, Math.Round(avgRate, 2), Math.Round(o, 2) });
            updateCap um = new updateCap(upMain);

            BeginInvoke(um, new object[] { i, x, Math.Round(avgRate, 2), Math.Round(o, 2) });
            string tm = setAxisX(i);


            if (isRecord)
            {
                sw.WriteLine("{0},{1},{2},{3},{4}", new object[] { i, x, avgRate, o, x });
                isRecord = false;
            }
            else
            {
                sw.WriteLine("{0},{1},{2},{3}", new object[] { i, x, avgRate, o });
            }
        }
        private void upMain(int i, double x, double avg, double o)
        {
            label1.Text = name;
            label2.Text = x.ToString();
            label3.Text = avg.ToString();
            label4.Text = o.ToString();
        }
        private string setAxisX(int seconds)
        {
            int mins = seconds / 60;
            string m = mins < 10 ? "0" + mins.ToString() : mins.ToString();
            int sec = seconds % 60;
            string s = sec < 10 ? "0" + sec.ToString() : sec.ToString();
            return m + ":" + s;
        }
        private int getRealTime(string time)
        {
            string[] tms = time.Split(':');
            int mins = int.Parse(tms[0]);
            int secs = int.Parse(tms[1]);
            return mins * 60 + secs;
        }
        private void VideoRateDisplay_FormClosed(object sender, FormClosedEventArgs e)
        {
            running = false;
            sw.Close();
            sw.Dispose();
            sw = null;
            if (vcap.IsCapturing)
            {
                vcap.StopCapture();
                vcap.Dispose();
                vcap = null;
            }
            if (Sp.IsOpen)
                Sp.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (button3.Text == "数据全屏")
            {

                string sql = string.Format("update videoRate");
                _userConn.Open();
                OleDbCommand cmd = new OleDbCommand("Update videoRate set avgRate = '" + cavgRate + "',daixie=" + daixie + " where UserName='" + name + "'", _userConn);

                int res = cmd.ExecuteNonQuery();
                _userConn.Close();
                Sp.Close();
                this.Hide();
                lastfrm.Show();
                Task.Factory.StartNew(() =>
                {
                    this.Close();
                });

            }
            else
            {
                isFullScreen = !isFullScreen;

                button3.Text = "数据全屏";
                chart1.Location = l;
                panel1.Visible = true;
                chart1.Size = new System.Drawing.Size(520, 520);
            }

        }

        private void chart1_Click(object sender, EventArgs e)
        {
            isRecord = true;
            //if (chart1.Series["记录心率"].Points.Count == 0)
            //{
            //    chart1.Series["记录心率"].Points.AddXY(i, curRate);
            //    chart1.Invalidate();
            //}
            chart1.Series["记录心率"].Points.AddXY(i, curRate);
            double before = i - 60;
            while (chart1.Series["记录心率"].Points[0].XValue < before)
            {
                chart1.Series["记录心率"].Points.RemoveAt(0);
            }
            chart1.Invalidate();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void sp_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            int length = Sp.BytesToRead;
            byte temp;
            byte[] sdata = new byte[6];
            for (int k = 0; k < length; k++)
            {
                temp = (byte)Sp.ReadByte();
                if (temp == 0x55)
                {
                    start = true;
                    continue;
                }
                if (start)
                {

                    sdata[j++] = temp;
                    if (j == 6)
                    {
                        j = 0;
                        start = false;
                        if (sdata[0] == 0xaa)
                        {
                            int hr = sdata[5];
                            Array.Copy(sdata, 0, data, 0, 6);
                            updateView updateChart = new updateView(chartUpdate);  //此处修改获得即刻心率和平均心率
                            BeginInvoke(updateChart, new object[] { i, hr });
                            i++;
                        }
                    }
                }
            }
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            chart1.Hide();
            panel1.Scale(new SizeF(new SizeF(1.5f, 1.5f)));
            //panel1.Location = new Point(50, 50);
            //vcap.Scale(new SizeF(new SizeF(1.5f, 1.5f)));
            //vcap.Size = new Size(800, 600);


        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            isFullScreen = !isFullScreen;
            if (isFullScreen)
            {
                button3.Text = "分屏显示";
                this.button1.Visible = false;
                panel1.Visible = false;
                l = chart1.Location;
                chart1.Location = new Point(Screen.PrimaryScreen.Bounds.Width / 2 - 400, 80);
                //chart1.Scale(new SizeF(new SizeF(1.5f, 1.2f)));
                chart1.Size = new System.Drawing.Size(800, 540);

            }
            else
            {
                this.button1.Visible = true;
                button3.Text = "数据全屏";
                chart1.Location = l;
                panel1.Visible = true;
                chart1.Size = new System.Drawing.Size(520, 520);
            }
        }
    }
}
