using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace strike_subsystem
{
    public partial class analysis : Form
    {
        private OleDbConnection _userConn = new OleDbConnection("Data Source=" + "D:\\UserInfo.mdb;Jet OLEDB:Engine Type=5;Provider=Microsoft.Jet.OLEDB.4.0"); //数据库连接

        OleDbConnection strikeConnectionString=new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\strike.accdb");
        DataSet chartDisplay = new DataSet();
        public analysis()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            //strikeConnectionString.Open();
            DataSet UserInfo = new DataSet();
            _userConn.Open();
            OleDbDataAdapter userInfoAdp = new OleDbDataAdapter("select UserName as 姓名,UserID as 测试号 ,R_date as 录入时间 from UserInfo", _userConn);
            userInfoAdp.Fill(UserInfo, "UserInfo");
            dataGridView1.DataSource = UserInfo.Tables["UserInfo"];
            _userConn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“strikeDataSet1.score”中。您可以根据需要移动或移除它。
            //this.scoreTableAdapter.Fill(this.strikeDataSet1.score);
            // TODO: 这行代码将数据加载到表“strikeDataSet.score”中。您可以根据需要移动或移除它。
           // this.scoreTableAdapter.Fill(this.strikeDataSet.score);
            // TODO: 这行代码将数据加载到表“userInfoDataSet.UserInfo”中。您可以根据需要移动或移除它。
            

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //label1.Text = dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString();
            //label2.Text = dataGridView1[1, dataGridView1.CurrentCell.RowIndex].Value.ToString();
            //label3.Text = dataGridView1[2, dataGridView1.CurrentCell.RowIndex].Value.ToString();
            this.display();
        }
        public void display()
        {
            strikeConnectionString.Open();
            string name = dataGridView1[0, dataGridView1.CurrentCell.RowIndex].Value.ToString();
          
            OleDbDataAdapter dap = new OleDbDataAdapter("select username as 姓名,examID as 测试号,times as 次数,mean as 平均时间间隔,Rtime as 测试时间 from score where (username='"+name+"') and (mean is not Null)", strikeConnectionString);
            DataSet ds = new DataSet();
            dap.Fill(ds, "data");
            dataGridView2.DataSource = ds.Tables["data"];
            strikeConnectionString.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string strListbox = dataGridView2[0, dataGridView2.CurrentCell.RowIndex].Value.ToString()
                +","+"测试号："+" "+dataGridView2[1,dataGridView2.CurrentCell.RowIndex].Value.ToString();
            listBox1.Items.Add(strListbox);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button_comp_Click(object sender, EventArgs e)
        {
            //string [] comp=new string[listBox1.Items.Count];
            strikeConnectionString.Open();
            chartDisplay.Clear();
            chart1.Series.Clear();
            int length = listBox1.Items.Count;
            string sql1 = "";
            string comp;
            string [] info = new string[2];
            string[] name = new string[length];
            for (int i = 0; i < length; i++)
            {
                comp=listBox1.Items[i].ToString();
                info=comp.Split(' ');
                name[i] = info[0];
                sql1 = "select username,examID,times,inteval,Rtime,label from score where" + " "+"(examID=" + Convert.ToInt32(info[1]) + ")"+";";
                OleDbDataAdapter adp = new OleDbDataAdapter(sql1, strikeConnectionString);
                adp.Fill(chartDisplay, "selecData");
                //sql += sql1;
            }
            

            dataGridView3.DataSource =chartDisplay.Tables["selecData"];

            DataTableReader reader = chartDisplay.CreateDataReader();
            if (length == 1)

            // Data bind chart to a table where all rows are grouped in series by the "Name" column
                chart1.DataBindCrossTab(reader,"username", "times", "inteval","Label=label");
            else if(name[1]==name[0])
                chart1.DataBindCrossTab(reader, "Rtime", "times", "inteval", "Label=label");
            else
                chart1.DataBindCrossTab(reader, "username", "times", "inteval", "Label=label");

            //chart1.Series["7"].Type = Dundas.Charting.WinControl.SeriesChartType.Spline;
            //chart1.Series = Dundas.Charting.WinControl.SeriesChartType.Spline;
           // chart1.Series["3"].Type = SeriesChartType.Spline;
            //Chart1.DataBindCrossTab(
            //    myReader,
            //    "username",
            //    "times",
            //    "interval",
            //    "Label=Commissions{C}");

            // Close the reader and the connection
            //myReader.Close();
            strikeConnectionString.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
