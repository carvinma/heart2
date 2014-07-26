namespace strike_subsystem
{
    partial class VideoRateDisplay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Dundas.Charting.WinControl.ChartArea chartArea5 = new Dundas.Charting.WinControl.ChartArea();
            Dundas.Charting.WinControl.ChartArea chartArea6 = new Dundas.Charting.WinControl.ChartArea();
            Dundas.Charting.WinControl.Legend legend3 = new Dundas.Charting.WinControl.Legend();
            Dundas.Charting.WinControl.Series series9 = new Dundas.Charting.WinControl.Series();
            Dundas.Charting.WinControl.Series series10 = new Dundas.Charting.WinControl.Series();
            Dundas.Charting.WinControl.Series series11 = new Dundas.Charting.WinControl.Series();
            Dundas.Charting.WinControl.Series series12 = new Dundas.Charting.WinControl.Series();
            Dundas.Charting.WinControl.Title title3 = new Dundas.Charting.WinControl.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoRateDisplay));
            this.chart1 = new Dundas.Charting.WinControl.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.vcap = new AxVIDEOCAPXLib.AxVideoCapX();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Sp = new System.IO.Ports.SerialPort(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vcap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.AlwaysRecreateHotregions = true;
            this.chart1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.chart1.BackGradientEndColor = System.Drawing.Color.White;
            this.chart1.BackGradientType = Dundas.Charting.WinControl.GradientType.DiagonalLeft;
            this.chart1.BorderLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            this.chart1.BorderLineStyle = Dundas.Charting.WinControl.ChartDashStyle.Solid;
            this.chart1.BorderSkin.FrameBackColor = System.Drawing.Color.CornflowerBlue;
            this.chart1.BorderSkin.FrameBackGradientEndColor = System.Drawing.Color.CornflowerBlue;
            this.chart1.BorderSkin.FrameBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chart1.BorderSkin.FrameBorderWidth = 2;
            this.chart1.BorderSkin.PageColor = System.Drawing.Color.AliceBlue;
            this.chart1.BorderSkin.SkinStyle = Dundas.Charting.WinControl.BorderSkinStyle.Emboss;
            chartArea5.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea5.AxisX.MinorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea5.AxisX.MinorTickMark.Size = 2F;
            chartArea5.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea5.AxisX2.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea5.AxisX2.MinorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea5.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea5.AxisY.MinorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea5.AxisY.MinorTickMark.Size = 2F;
            chartArea5.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea5.AxisY2.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea5.AxisY2.MinorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea5.BackColor = System.Drawing.Color.White;
            chartArea5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            chartArea5.BorderStyle = Dundas.Charting.WinControl.ChartDashStyle.Solid;
            chartArea5.Name = "Default";
            chartArea5.ShadowOffset = 2;
            chartArea6.Name = "daixie";
            this.chart1.ChartAreas.Add(chartArea5);
            this.chart1.ChartAreas.Add(chartArea6);
            legend3.Alignment = System.Drawing.StringAlignment.Center;
            legend3.BackColor = System.Drawing.Color.White;
            legend3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            legend3.Docking = Dundas.Charting.WinControl.LegendDocking.Top;
            legend3.Name = "Default";
            legend3.ShadowOffset = 2;
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(744, 87);
            this.chart1.Name = "chart1";
            this.chart1.Palette = Dundas.Charting.WinControl.ChartColorPalette.Dundas;
            series9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series9.BorderWidth = 2;
            series9.ChartType = "Spline";
            series9.Color = System.Drawing.Color.Red;
            series9.Name = "即时心率";
            series9.PaletteCustomColors = new System.Drawing.Color[0];
            series9.ShadowOffset = 2;
            series10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series10.BorderWidth = 2;
            series10.ChartType = "Spline";
            series10.Name = "平均心率";
            series10.PaletteCustomColors = new System.Drawing.Color[0];
            series10.ShadowOffset = 2;
            series11.BorderWidth = 2;
            series11.ChartArea = "daixie";
            series11.ChartType = "Spline";
            series11.Color = System.Drawing.Color.Lime;
            series11.Name = "代谢率";
            series11.PaletteCustomColors = new System.Drawing.Color[0];
            series12.Color = System.Drawing.Color.Fuchsia;
            series12.MarkerColor = System.Drawing.Color.White;
            series12.Name = "记录心率";
            series12.PaletteCustomColors = new System.Drawing.Color[0];
            series12.ShowLabelAsValue = true;
            series12.YValuesPerPoint = 2;
            this.chart1.Series.Add(series9);
            this.chart1.Series.Add(series10);
            this.chart1.Series.Add(series11);
            this.chart1.Series.Add(series12);
            this.chart1.Size = new System.Drawing.Size(520, 520);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.Name = "Title1";
            title3.Text = "心率和代谢率随时间变化图";
            this.chart1.Titles.Add(title3);
            this.chart1.UI.Toolbar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            this.chart1.UI.Toolbar.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            this.chart1.UI.Toolbar.BorderSkin.SkinStyle = Dundas.Charting.WinControl.BorderSkinStyle.Emboss;
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.vcap);
            this.panel1.Location = new System.Drawing.Point(78, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 520);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // vcap
            // 
            this.vcap.Enabled = true;
            this.vcap.Location = new System.Drawing.Point(11, 32);
            this.vcap.Name = "vcap";
            this.vcap.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("vcap.OcxState")));
            this.vcap.Size = new System.Drawing.Size(640, 480);
            this.vcap.TabIndex = 14;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Cyan;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(78, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1200, 60);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("楷体_GB2312", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(535, 614);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 50);
            this.button1.TabIndex = 3;
            this.button1.Text = "返回";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.BackColor = System.Drawing.Color.Green;
            this.label_name.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_name.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label_name.Location = new System.Drawing.Point(197, 30);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(0, 29);
            this.label_name.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Green;
            this.label1.Font = new System.Drawing.Font("楷体_GB2312", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(197, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "11";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(503, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "22";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(827, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "33";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(1115, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "44";
            // 
            // Sp
            // 
            this.Sp.BaudRate = 115200;
            this.Sp.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.sp_DataReceived);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "姓名";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(386, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "即时心率";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(706, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "平均心率";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(998, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "代谢率";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("楷体_GB2312", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(162, 614);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 50);
            this.button2.TabIndex = 17;
            this.button2.Text = "视频全屏";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Green;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Font = new System.Drawing.Font("楷体_GB2312", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(694, 614);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 50);
            this.button3.TabIndex = 18;
            this.button3.Text = "数据全屏";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // VideoRateDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_name);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VideoRateDisplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "心率叠加";
            this.Load += new System.EventHandler(this.VideoRateDisplay_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VideoRateDisplay_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vcap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Dundas.Charting.WinControl.Chart chart1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private AxVIDEOCAPXLib.AxVideoCapX vcap;
        private System.IO.Ports.SerialPort Sp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}