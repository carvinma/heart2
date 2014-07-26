namespace strike_subsystem
{
    partial class exam
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Dundas.Charting.WinControl.ChartArea chartArea1 = new Dundas.Charting.WinControl.ChartArea();
            Dundas.Charting.WinControl.Legend legend1 = new Dundas.Charting.WinControl.Legend();
            Dundas.Charting.WinControl.Series series1 = new Dundas.Charting.WinControl.Series();
            Dundas.Charting.WinControl.Series series2 = new Dundas.Charting.WinControl.Series();
            Dundas.Charting.WinControl.Series series3 = new Dundas.Charting.WinControl.Series();
            Dundas.Charting.WinControl.ChartArea chartArea2 = new Dundas.Charting.WinControl.ChartArea();
            Dundas.Charting.WinControl.Legend legend2 = new Dundas.Charting.WinControl.Legend();
            Dundas.Charting.WinControl.Series series4 = new Dundas.Charting.WinControl.Series();
            Dundas.Charting.WinControl.Title title1 = new Dundas.Charting.WinControl.Title();
            Dundas.Charting.WinControl.ChartArea chartArea3 = new Dundas.Charting.WinControl.ChartArea();
            Dundas.Charting.WinControl.Legend legend3 = new Dundas.Charting.WinControl.Legend();
            Dundas.Charting.WinControl.Series series5 = new Dundas.Charting.WinControl.Series();
            this.Sp = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.chart1 = new Dundas.Charting.WinControl.Chart();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.button_ready = new System.Windows.Forms.Button();
            this.chart2 = new Dundas.Charting.WinControl.Chart();
            this.chart3 = new Dundas.Charting.WinControl.Chart();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label_username = new System.Windows.Forms.Label();
            this.label_examID = new System.Windows.Forms.Label();
            this.textBox_examID = new System.Windows.Forms.TextBox();
            this.label_intro = new System.Windows.Forms.Label();
            this.label_timeleft = new System.Windows.Forms.Label();
            this.label_secText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_score = new System.Windows.Forms.Label();
            this.label_scoreMean = new System.Windows.Forms.Label();
            this.label_mean = new System.Windows.Forms.Label();
            this.label_times = new System.Windows.Forms.Label();
            this.label_totalTimes = new System.Windows.Forms.Label();
            this.label_onTest = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Sp
            // 
            this.Sp.BaudRate = 115200;
            this.Sp.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.Sp_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(747, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 60);
            this.button1.TabIndex = 3;
            this.button1.Text = "查看成绩";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chart1.BackGradientEndColor = System.Drawing.Color.White;
            this.chart1.BackGradientType = Dundas.Charting.WinControl.GradientType.DiagonalLeft;
            this.chart1.BorderLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            this.chart1.BorderLineStyle = Dundas.Charting.WinControl.ChartDashStyle.Solid;
            this.chart1.BorderSkin.FrameBackColor = System.Drawing.Color.CornflowerBlue;
            this.chart1.BorderSkin.FrameBackGradientEndColor = System.Drawing.Color.CornflowerBlue;
            this.chart1.BorderSkin.PageColor = System.Drawing.SystemColors.Control;
            this.chart1.BorderSkin.SkinStyle = Dundas.Charting.WinControl.BorderSkinStyle.Emboss;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisX2.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisX2.MinorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY2.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY2.MinorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.BackColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            chartArea1.BorderStyle = Dundas.Charting.WinControl.ChartDashStyle.Solid;
            chartArea1.Name = "Default";
            chartArea1.ShadowOffset = 2;
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Docking = Dundas.Charting.WinControl.LegendDocking.Top;
            legend1.Name = "Default";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(56, 198);
            this.chart1.Name = "chart1";
            this.chart1.Palette = Dundas.Charting.WinControl.ChartColorPalette.Dundas;
            series1.BorderWidth = 2;
            series1.ChartType = "Line";
            series1.Name = "transient interval";
            series1.ShadowOffset = 1;
            series1.XValueType = Dundas.Charting.WinControl.ChartValueTypes.Double;
            series1.YValueType = Dundas.Charting.WinControl.ChartValueTypes.Double;
            series2.ChartType = "Line";
            series2.Name = "mean interval";
            series3.ChartType = "Line";
            series3.Name = "interval variance";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(481, 429);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            this.chart1.UI.Toolbar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            this.chart1.UI.Toolbar.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            this.chart1.UI.Toolbar.BorderSkin.SkinStyle = Dundas.Charting.WinControl.BorderSkinStyle.Emboss;
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(113, 71);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(100, 21);
            this.textBox_username.TabIndex = 5;
            // 
            // button_ready
            // 
            this.button_ready.Location = new System.Drawing.Point(113, 125);
            this.button_ready.Name = "button_ready";
            this.button_ready.Size = new System.Drawing.Size(75, 23);
            this.button_ready.TabIndex = 6;
            this.button_ready.Text = "确认";
            this.button_ready.UseVisualStyleBackColor = true;
            this.button_ready.Click += new System.EventHandler(this.button2_Click);
            // 
            // chart2
            // 
            chartArea2.BorderColor = System.Drawing.Color.Empty;
            chartArea2.Name = "Default";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Alignment = System.Drawing.StringAlignment.Center;
            legend2.Docking = Dundas.Charting.WinControl.LegendDocking.Bottom;
            legend2.Name = "Default";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(543, 198);
            this.chart2.Name = "chart2";
            this.chart2.Palette = Dundas.Charting.WinControl.ChartColorPalette.Pastel;
            series4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series4.ChartType = "Doughnut";
            series4.CustomAttributes = "PieLabelStyle=Outside";
            series4.Name = "Serial1";
            series4.ShadowOffset = 1;
            series4.ShowLabelAsValue = true;
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(424, 429);
            this.chart2.TabIndex = 7;
            this.chart2.Text = "chart2";
            title1.Name = "Title1";
            title1.Text = "distribution map";
            this.chart2.Titles.Add(title1);
            // 
            // chart3
            // 
            this.chart3.BackColor = System.Drawing.Color.MediumSeaGreen;
            chartArea3.Name = "Default";
            this.chart3.ChartAreas.Add(chartArea3);
            legend3.Docking = Dundas.Charting.WinControl.LegendDocking.Top;
            legend3.Name = "Default";
            this.chart3.Legends.Add(legend3);
            this.chart3.Location = new System.Drawing.Point(142, 198);
            this.chart3.Name = "chart3";
            this.chart3.Palette = Dundas.Charting.WinControl.ChartColorPalette.Pastel;
            series5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series5.BorderWidth = 2;
            series5.ChartType = "Line";
            series5.MarkerBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            series5.MarkerColor = System.Drawing.Color.Blue;
            series5.Name = "real time display of time interval";
            series5.ShadowOffset = 1;
            this.chart3.Series.Add(series5);
            this.chart3.Size = new System.Drawing.Size(815, 483);
            this.chart3.TabIndex = 8;
            this.chart3.Text = "chart3";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(400, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(496, 78);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_username.Location = new System.Drawing.Point(57, 72);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(35, 14);
            this.label_username.TabIndex = 11;
            this.label_username.Text = "姓名";
            // 
            // label_examID
            // 
            this.label_examID.AutoSize = true;
            this.label_examID.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_examID.Location = new System.Drawing.Point(54, 39);
            this.label_examID.Name = "label_examID";
            this.label_examID.Size = new System.Drawing.Size(49, 14);
            this.label_examID.TabIndex = 12;
            this.label_examID.Text = "测试号";
            // 
            // textBox_examID
            // 
            this.textBox_examID.Location = new System.Drawing.Point(109, 39);
            this.textBox_examID.Name = "textBox_examID";
            this.textBox_examID.Size = new System.Drawing.Size(100, 21);
            this.textBox_examID.TabIndex = 13;
            // 
            // label_intro
            // 
            this.label_intro.AutoSize = true;
            this.label_intro.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_intro.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label_intro.Location = new System.Drawing.Point(300, 40);
            this.label_intro.Name = "label_intro";
            this.label_intro.Size = new System.Drawing.Size(260, 22);
            this.label_intro.TabIndex = 14;
            this.label_intro.Text = "按下\"确认\"，5秒后开始测试，还剩";
            // 
            // label_timeleft
            // 
            this.label_timeleft.AutoSize = true;
            this.label_timeleft.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_timeleft.ForeColor = System.Drawing.Color.Red;
            this.label_timeleft.Location = new System.Drawing.Point(566, 40);
            this.label_timeleft.Name = "label_timeleft";
            this.label_timeleft.Size = new System.Drawing.Size(20, 22);
            this.label_timeleft.TabIndex = 15;
            this.label_timeleft.Text = "5";
            // 
            // label_secText
            // 
            this.label_secText.AutoSize = true;
            this.label_secText.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_secText.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label_secText.Location = new System.Drawing.Point(589, 40);
            this.label_secText.Name = "label_secText";
            this.label_secText.Size = new System.Drawing.Size(26, 22);
            this.label_secText.TabIndex = 16;
            this.label_secText.Text = "秒";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label_score);
            this.panel1.Controls.Add(this.label_scoreMean);
            this.panel1.Controls.Add(this.label_mean);
            this.panel1.Controls.Add(this.label_times);
            this.panel1.Controls.Add(this.label_totalTimes);
            this.panel1.Controls.Add(this.label_onTest);
            this.panel1.Controls.Add(this.button_ready);
            this.panel1.Controls.Add(this.textBox_username);
            this.panel1.Controls.Add(this.label_username);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(-3, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(995, 587);
            this.panel1.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(899, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 60);
            this.button2.TabIndex = 19;
            this.button2.Text = "返回";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文楷体", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(751, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 21);
            this.label1.TabIndex = 18;
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.Font = new System.Drawing.Font("华文楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_score.ForeColor = System.Drawing.Color.Green;
            this.label_score.Location = new System.Drawing.Point(681, 155);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(50, 21);
            this.label_score.TabIndex = 17;
            this.label_score.Text = "得分";
            // 
            // label_scoreMean
            // 
            this.label_scoreMean.AutoSize = true;
            this.label_scoreMean.Font = new System.Drawing.Font("华文楷体", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_scoreMean.ForeColor = System.Drawing.Color.Red;
            this.label_scoreMean.Location = new System.Drawing.Point(940, 127);
            this.label_scoreMean.Name = "label_scoreMean";
            this.label_scoreMean.Size = new System.Drawing.Size(0, 21);
            this.label_scoreMean.TabIndex = 16;
            // 
            // label_mean
            // 
            this.label_mean.AutoSize = true;
            this.label_mean.Font = new System.Drawing.Font("华文楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_mean.ForeColor = System.Drawing.Color.Green;
            this.label_mean.Location = new System.Drawing.Point(810, 125);
            this.label_mean.Name = "label_mean";
            this.label_mean.Size = new System.Drawing.Size(130, 21);
            this.label_mean.TabIndex = 15;
            this.label_mean.Text = "平均敲击间隔";
            // 
            // label_times
            // 
            this.label_times.AutoSize = true;
            this.label_times.Font = new System.Drawing.Font("华文楷体", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_times.ForeColor = System.Drawing.Color.Red;
            this.label_times.Location = new System.Drawing.Point(751, 127);
            this.label_times.Name = "label_times";
            this.label_times.Size = new System.Drawing.Size(0, 21);
            this.label_times.TabIndex = 14;
            // 
            // label_totalTimes
            // 
            this.label_totalTimes.AutoSize = true;
            this.label_totalTimes.Font = new System.Drawing.Font("华文楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_totalTimes.ForeColor = System.Drawing.Color.Green;
            this.label_totalTimes.Location = new System.Drawing.Point(675, 125);
            this.label_totalTimes.Name = "label_totalTimes";
            this.label_totalTimes.Size = new System.Drawing.Size(70, 21);
            this.label_totalTimes.TabIndex = 13;
            this.label_totalTimes.Text = "总次数";
            // 
            // label_onTest
            // 
            this.label_onTest.AutoSize = true;
            this.label_onTest.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_onTest.ForeColor = System.Drawing.Color.Red;
            this.label_onTest.Location = new System.Drawing.Point(308, 97);
            this.label_onTest.Name = "label_onTest";
            this.label_onTest.Size = new System.Drawing.Size(70, 21);
            this.label_onTest.TabIndex = 12;
            this.label_onTest.Text = "测试中...";
            // 
            // exam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 587);
            this.Controls.Add(this.label_secText);
            this.Controls.Add(this.label_timeleft);
            this.Controls.Add(this.label_intro);
            this.Controls.Add(this.textBox_examID);
            this.Controls.Add(this.label_examID);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chart3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "exam";
            this.Text = "strike system";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort Sp;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private Dundas.Charting.WinControl.Chart chart1;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.Button button_ready;
        private Dundas.Charting.WinControl.Chart chart2;
        private Dundas.Charting.WinControl.Chart chart3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_examID;
        private System.Windows.Forms.TextBox textBox_examID;
        private System.Windows.Forms.Label label_intro;
        private System.Windows.Forms.Label label_timeleft;
        private System.Windows.Forms.Label label_secText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_onTest;
        private System.Windows.Forms.Label label_totalTimes;
        private System.Windows.Forms.Label label_times;
        private System.Windows.Forms.Label label_scoreMean;
        private System.Windows.Forms.Label label_mean;
        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}

