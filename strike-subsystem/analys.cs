using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
namespace strike_subsystem
{
    public partial class analys : Form
    {
        string name;
        string height;
        string sex;
        string weight;
        string videoPath;
        string ratePath;
        StreamReader sr;
        int totalsecs;
        List<double> pointList;
        public void setInfo(string n,string v,string r)
        {
            pointList = new List<double>();
            name=n;
            videoPath = v;
            ratePath = r;
            sr = new StreamReader("data\\" + ratePath);
            

        }
        public void setMoreInfo(string sex,string Height,string weight)
        {
            this.sex = sex;
            this.height = Height;
            this.weight = weight;
        }
        public analys()
        {
            InitializeComponent();
        }
        private void readData()
        {
            string t;
            char[] sep = new char[] { ',' };
            while ((t = sr.ReadLine())!=null)
            {
                string[] ds = t.Split(sep);
                int i=int.Parse(ds[0]);
                totalsecs = i;
                chart1.Series["即时心率"].Points.AddXY(i, double.Parse(ds[1]));
                pointList.Add(double.Parse(ds[1]));
                chart1.Series["平均心率"].Points.AddXY(i, double.Parse(ds[2]));
                chart1.Series["代谢率"].Points.AddXY(i, double.Parse(ds[3]));
                if (ds.Length == 5)
                {
                    chart1.Series["记录心率"].Points.AddXY(i, double.Parse(ds[4]));
                }
            }
            chart1.Invalidate();
            textBox_to.Text = totalsecs.ToString();
            double sum = 0, min = 4000, max = 0, cov = 0;
            for (int i = 0; i < pointList.Count; i++)
            {
                double cur = pointList[i];
                sum += cur;

                max = cur > max ? cur : max;
                min = cur < min ? cur : min;
            }
            double avg = 1.0 * sum / pointList.Count;
            avg = Math.Round(avg, 2);
            for (int i = 0; i < pointList.Count; i++)
            {
                double cur = pointList[i];
                cov += (cur - avg) * (cur - avg);
            }
            cov = Math.Round(Math.Sqrt(avg),2);
            label8.Text = name;
            label9.Text = avg.ToString();
            label10.Text = max.ToString();
            label11.Text = min.ToString();
            label12.Text = cov.ToString();
        }
        private void analys_Load(object sender, EventArgs e)
        {
            chart1.ChartAreas[0].CursorX.UserEnabled = true;
            chart1.ChartAreas[0].CursorX.UserSelection = true;
            chart1.ChartAreas[0].AxisX.View.Zoomable = true;
            chart1.ChartAreas[0].AxisX.ScrollBar.PositionInside=true;
            chart1.ChartAreas[0].AxisY.Minimum = 50;
            chart1.ChartAreas[0].AxisY.Maximum = 240;
            
            readData();
            //if (System.IO.File.Exists("video\\" + videoPath))
            //{
            //    vcap.PlayerOpen("video\\" + videoPath);
            //    vcap.PlayerStart();
            //}
            //else
            //{
            //    vcap.Visible = false;
            //    Point l = chart1.Location;
            //    chart1.Location = new Point((this.Width - chart1.Width) / 2, l.Y);
            //    chart1.Visible = true;
            //    //MessageBox.Show("视频不存在");
            //}
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            if (textBox_from.Text == "" || textBox_to.Text == "")
            {
                MessageBox.Show("请输入起止时间！");
                return;
            }
            int s = int.Parse(textBox_from.Text.Trim());
            int t = int.Parse(textBox_to.Text.Trim());
            chart1.ChartAreas[0].AxisX.View.Zoom(s, t);
            chart1.Invalidate();
            //System.Collections.IEnumerator enm=chart1.Series["即时心率"].Points.GetEnumerator();

            //while (enm.MoveNext())
            //{
            //    Dundas.Charting.WinControl.DataPoint cur=(Dundas.Charting.WinControl.DataPoint)enm;
            //    double x=cur.XValue;
            //}
            double sum = 0,min=4000,max=0,cov=0;
            for (int i = s; i < t;i++ )
            {
                double cur = pointList[i];
                sum += cur;
                
                max = cur> max ? cur : max;
                min = cur < min ? cur : min;
            }
            double avg = 1.0 * sum / (t - s);
            avg = Math.Round(avg, 2);
            for (int i = s; i < t; i++)
            {
                double cur = pointList[i];
                cov += (cur - avg) * (cur - avg);
            }
            cov = Math.Round(Math.Sqrt(avg));
            label9.Text = avg.ToString();
            label10.Text = max.ToString();
            label11.Text = min.ToString();
            label12.Text = cov.ToString();
            label8.Text = name;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            StringFormat titleFormat = new StringFormat();
            titleFormat.Alignment = StringAlignment.Center;
            StringFormat imFormat = new StringFormat();
            imFormat.Alignment = StringAlignment.Center;
            Font titlefont = new Font("宋体", 20, FontStyle.Bold);
            Font imfont = new Font("宋体", 14, FontStyle.Bold);
            Font textfont = new Font("宋体", 14, FontStyle.Regular);
            Pen linePen = new Pen(new SolidBrush(Color.Black), 5);
            SolidBrush drawbrush = new SolidBrush(Color.Black);
            g.DrawString("心率叠加统计结果", titlefont, drawbrush, new Point(400, 20), titleFormat);//title
            g.DrawString("姓名：   " , imfont, drawbrush, new Point(400, 80), titleFormat);
            g.DrawString(label8.Text, textfont, drawbrush, new Point(460, 80), imFormat);
            g.DrawString("平均心率：   " , imfont, drawbrush, new Point(400, 120), titleFormat);
            g.DrawString(label9.Text, textfont, drawbrush, new Point(480, 120), imFormat);
            g.DrawString("最高心率：   " , imfont, drawbrush, new Point(400, 160), titleFormat);
            g.DrawString(label10.Text, textfont, drawbrush, new Point(460, 160), imFormat);
            g.DrawString("最低心率：  " , imfont, drawbrush, new Point(400, 200), titleFormat);
            g.DrawString(label11.Text, textfont, drawbrush, new Point(460, 200), imFormat);
            g.DrawString("方差：   " , imfont, drawbrush, new Point(400, 240), titleFormat);
            g.DrawString(label12.Text, textfont, drawbrush, new Point(460, 240), imFormat);
            chart1.Printing.PrintPaint(g,new Rectangle(150,340,chart1.Width,chart1.Height));
        }

        private void button_print_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == this.printDialog1.ShowDialog())
            {
                printDocument1.Print();
            }
        }
    }
}
