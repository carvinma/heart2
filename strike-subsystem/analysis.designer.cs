namespace strike_subsystem
{
    partial class analysis
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
            Dundas.Charting.WinControl.ChartArea chartArea1 = new Dundas.Charting.WinControl.ChartArea();
            Dundas.Charting.WinControl.Legend legend1 = new Dundas.Charting.WinControl.Legend();
            Dundas.Charting.WinControl.Series series1 = new Dundas.Charting.WinControl.Series();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button_comp = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.chart1 = new Dundas.Charting.WinControl.Chart();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(100, 71);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(344, 218);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.Location = new System.Drawing.Point(498, 71);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 23;
            this.dataGridView2.Size = new System.Drawing.Size(372, 218);
            this.dataGridView2.TabIndex = 9;
            // 
            // button_comp
            // 
            this.button_comp.Location = new System.Drawing.Point(885, 217);
            this.button_comp.Name = "button_comp";
            this.button_comp.Size = new System.Drawing.Size(80, 35);
            this.button_comp.TabIndex = 3;
            this.button_comp.Text = "开始比较";
            this.button_comp.UseVisualStyleBackColor = true;
            this.button_comp.Click += new System.EventHandler(this.button_comp_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(885, 71);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(131, 88);
            this.listBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(636, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 35);
            this.button1.TabIndex = 5;
            this.button1.Text = "添加比较";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(885, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 37);
            this.button2.TabIndex = 6;
            this.button2.Text = "删除比较项";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Azure;
            this.chart1.BackGradientEndColor = System.Drawing.Color.SkyBlue;
            this.chart1.BackGradientType = Dundas.Charting.WinControl.GradientType.DiagonalLeft;
            this.chart1.BorderLineColor = System.Drawing.Color.LightGray;
            this.chart1.BorderSkin.FrameBackColor = System.Drawing.Color.LightSkyBlue;
            this.chart1.BorderSkin.FrameBackGradientEndColor = System.Drawing.Color.DodgerBlue;
            chartArea1.AxisX.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisX.MajorGrid.LineStyle = Dundas.Charting.WinControl.ChartDashStyle.Dot;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY.MajorGrid.LineStyle = Dundas.Charting.WinControl.ChartDashStyle.Dot;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.DimGray;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.DimGray;
            chartArea1.Name = "Default";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.BorderColor = System.Drawing.Color.Transparent;
            legend1.Docking = Dundas.Charting.WinControl.LegendDocking.Top;
            legend1.Name = "Default";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(100, 336);
            this.chart1.Name = "chart1";
            this.chart1.Palette = Dundas.Charting.WinControl.ChartColorPalette.SemiTransparent;
            series1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            series1.Name = "Default";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(865, 287);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(100, 469);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 23;
            this.dataGridView3.Size = new System.Drawing.Size(344, 154);
            this.dataGridView3.TabIndex = 8;
            this.dataGridView3.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(98, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "用户信息";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(494, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "测试统计";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(885, 265);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 33);
            this.button3.TabIndex = 12;
            this.button3.Text = "返回";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // analysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 689);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button_comp);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "analysis";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button_comp;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Dundas.Charting.WinControl.Chart chart1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
    }
}

