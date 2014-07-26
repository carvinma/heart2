using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace strike_subsystem
{
    public partial class exam : Form

    {
        int readytime = 5,downcouter=59;
        int j = 0,k=0;
        int total = 0;
        byte[] data = new byte[7];
        double ptime=0;
        double ctime = 0;
        double Tinteval;
        double mean,var;
        int examid=0;
        bool start=false;
        string username;
        double[] T_interval = new double[300];
        int times15, times30, times45, times60;

        private Thread addDataRunner;
        private DateTime minValue, maxValue;
        // Thread Add Data delegate
        public delegate void AddDataDelegate();
        public AddDataDelegate addDataDel;

        OleDbConnection exam_conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\strike.accdb");
        private OleDbConnection _userConn = new OleDbConnection("Data Source=" + "D:\\UserInfo.mdb;Jet OLEDB:Engine Type=5;Provider=Microsoft.Jet.OLEDB.4.0"); //数据库连接
        delegate void Sdelegate();
        public exam()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            chart1.Visible = false;
            chart2.Visible = false;
            button1.Enabled = false;
            label_onTest.Visible = false;
            pictureBox1.Image=Image.FromFile("images\\DigitNum\\6.jpg");
            pictureBox2.Image = Image.FromFile("images\\DigitNum\\0.jpg");
            //open connection
            exam_conn.Open();

            minValue =DateTime.Now;
            maxValue = minValue.AddSeconds(30);

            chart3.ChartAreas[0].AxisX.Minimum = minValue.ToOADate();
            chart3.ChartAreas[0].AxisX.Maximum = maxValue.ToOADate();

            // Reset number of series in the chart.
            chart3.Series.Clear();

            Dundas.Charting.WinControl.Series newSeries = new Dundas.Charting.WinControl.Series("敲击间隔实时显示");
            newSeries.Type = Dundas.Charting.WinControl.SeriesChartType.Line;
            newSeries.BorderWidth = 1;
            newSeries.Color = Color.FromArgb(224, 64, 10);
            newSeries.ShadowOffset = 1;
            newSeries.XValueType = Dundas.Charting.WinControl.ChartValueTypes.Time;
            chart3.Series.Add(newSeries);

            //从UserInfo读取用户姓名
            OleDbDataAdapter adp = new OleDbDataAdapter("select UserId,UserName from UserInfo order by UserID desc", _userConn);
            DataSet ds = new DataSet();
            adp.Fill(ds, "UserInfo");
            username = ds.Tables[0].Rows[0][1].ToString();
            textBox_username.Text=username; //更新显示
            ds.Dispose();                   

            //从score读取测试号
            OleDbDataAdapter Sel_examID = new OleDbDataAdapter("select examID from score order by ID desc", exam_conn);
            DataSet ReadID = new DataSet();
            Sel_examID.Fill(ReadID, "examID");
            if (ReadID == null)
                examid = 1;
            else
                examid = (int)ReadID.Tables[0].Rows[0][0]+1;
            ReadID.Dispose();

            textBox_examID.Text = examid.ToString();
            #region serial port check
            string[] Pnames = System.IO.Ports.SerialPort.GetPortNames();
            foreach (string Pname in Pnames)
            {
                Sp.PortName = Pname;
                try
                {
                    Sp.Open();
                    Sp.Close();
                }
                catch
                {

                }
            }
#endregion
        }
        public void setID(string uname)
        {
            username = uname;
            textBox_username.Text = uname;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ThreadStart addDataThreadStart = new ThreadStart(AddDataThreadLoop);
            addDataRunner = new Thread(addDataThreadStart);

            addDataDel += new AddDataDelegate(AddData);
            //addDataRunner.Start();
        }
        private void AddDataThreadLoop()
        {
            try
            {
                while (true)
                {
                    // Invoke method must be used to interact with the chart
                    // control on the form!
                    chart3.Invoke(addDataDel);

                    // Thread is inactive for 200ms
                    Thread.Sleep(100);
                }
            }
            catch
            {
                // Thread is aborted
            }
        }
        public void AddData()
        {
            DateTime timeStamp = DateTime.Now;

            foreach (Dundas.Charting.WinControl.Series ptSeries in chart3.Series)
            {
                AddNewPoint(timeStamp, ptSeries);
            }
        }
        public void AddNewPoint(DateTime timeStamp, Dundas.Charting.WinControl.Series ptSeries)
        {
            // Add new data point to its series.
            ptSeries.Points.AddXY(timeStamp.ToOADate(), Tinteval);

             //remove all points from the source series older than 20 seconds.
            double removeBefore = timeStamp.AddSeconds((double)(20) * (-1)).ToOADate();

            //remove oldest values to maintain a constant number of data points
            while (ptSeries.Points[0].XValue < removeBefore)
            {
                ptSeries.Points.RemoveAt(0);
            }

            chart3.ChartAreas[0].AxisX.Minimum = ptSeries.Points[0].XValue;
            chart3.ChartAreas[0].AxisX.Maximum = DateTime.FromOADate(ptSeries.Points[0].XValue).AddSeconds(30).ToOADate();

            chart3.Invalidate();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (readytime>0)
            {
                label_timeleft.Text = Convert.ToString(readytime-1);
                //label1.Text = (string)downcouter;
                readytime--;
            }
            else if (readytime == 0)
            {
                label_onTest.Visible = true;
                readytime = -1;
                if (Sp.IsOpen)
                {
                    Sp.Close();
                }
                Sp.Open();
                byte[] start = { 0xAA };
                this.Sp.Write(start, 0, 1);
                addDataRunner.Start();
            }
            else
            {
                
                pictureBox1.Image = Image.FromFile("images\\DigitNum\\"+downcouter/10+".jpg");
                pictureBox2.Image = Image.FromFile("images\\DigitNum\\" + downcouter % 10 + ".jpg");
                downcouter--;
            }
            if (downcouter == 0)
            {
                button1.Enabled = true;
                timer1.Stop();
                label_onTest.Text = "测试结束";
                pictureBox2.Image = Image.FromFile("images\\DigitNum\\0.jpg");
                addDataRunner.Abort();
            }

        }

        private void Sp_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            int length = Sp.BytesToRead;
            byte temp;
            byte[] sdata = new byte[9];
            for (int i = 0; i < length; i++)
            {
                //j = (j == 6) ? 0 : j;
                
                temp = (byte)Sp.ReadByte();
                if (temp == 0xff)
                {
                    start = true;
                    continue;
                }
                if(start)
                {
                    
                    sdata[j++] = temp;
                    if ((j == 9)&&(sdata[0]==0xaa)&&(sdata[1]==0x55))
                    {
                        Array.Copy(sdata, 2, data, 0, 7);
                        start = false;
                        j = 0;
                        Sdelegate Cd = new Sdelegate(Cal);
                        Invoke(Cd, new object[] { });
                    }      
                }

            }

        }

        private void Cal()
        {
            total =(int)data[0];
            ctime = (int)data[2] * 10 + (int)data[3] + 0.1*(int)data[4]+0.01*(int)data[5] ;
            Tinteval = ctime - ptime;
            if (ctime < 15)
                times15++;
            else if (ctime < 30)
                times30++;
            else if (ctime < 45)
                times45++;
            else
                times60++;
            T_interval[k++] = Tinteval;
            ptime = ctime;
            string sql = "Insert into score(examID,username,times,inteval)values(" + examid + ",'" + username + "'," + total + "," + Tinteval + ")";
            OleDbCommand cmd = new OleDbCommand(sql, exam_conn);
            cmd.ExecuteNonQuery();
            //Sdelegate ps = new Sdelegate(realDraw);
            //Invoke(ps, new object[] { });

            //textBox2.Text += Convert.ToString((int)data[0]) + " " + Convert.ToString((int)data[1]) + " " + Convert.ToString((int)data[2]) + " " + Convert.ToString((int)data[3]) + " " + Convert.ToString((int)data[4]) + " " + Convert.ToString((int)data[5]) + " "+Convert.ToString((int)data[6]) + "\n";
        }
        private void draw_p()
        {
            double[] x = new double[total];
            double[] y = new double[total];
            double[] z = new double[total];
            for (int i = 0; i < total; i++)
            {
                y[i] = mean;
                z[i] = var;
            }
            Array.Copy(T_interval, x, total);
            chart1.Series["transient interval"].Points.DataBindY(x);
            chart1.Series["mean interval"].Points.DataBindY(y);
            chart1.Series["interval variance"].Points.DataBindY(z);
            string []xv={"between 0-14s","between 15-29s","between 30-44s","between 45-59s"};
            int []yv={times15,times30,times45,times60};
            chart2.Series["Serial1"].Points.DataBindXY(xv,yv);       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Visible = true;
            Sp.Close();
            chart2.Visible = true;
            chart3.Visible = false;
            double sum=0,vari=0;
            for (int m = 0; m < total; m++)
            {
                sum += T_interval[m];  
            }
            mean = sum / total;
            for(int m=0;m<total;m++)
                vari+=Math.Pow(T_interval[m]-mean,2.0);
            var=vari/total;
            label_times.Text = total.ToString()+"次";
            label_scoreMean.Text=mean.ToString()+"秒";
            label1.Text=((int)((-50)*mean+100)).ToString();
            string sql = "Insert into score(examID,username,times,inteval,mean)values(" + examid + ",'" + username + "'," + total + "," + Tinteval + "," + mean + ")";
            OleDbCommand cmd = new OleDbCommand(sql, exam_conn);
            cmd.ExecuteNonQuery();
            Sdelegate sc = new Sdelegate(draw_p);
            Invoke(sc, new object[] { });
            exam_conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            username = textBox_username.Text.Trim();
            button_ready.Enabled = false;
            timer1.Enabled = true;
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

     }
}
