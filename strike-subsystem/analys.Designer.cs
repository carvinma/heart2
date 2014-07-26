namespace strike_subsystem
{
    partial class analys
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
            Dundas.Charting.WinControl.ChartArea chartArea3 = new Dundas.Charting.WinControl.ChartArea();
            Dundas.Charting.WinControl.ChartArea chartArea4 = new Dundas.Charting.WinControl.ChartArea();
            Dundas.Charting.WinControl.Legend legend2 = new Dundas.Charting.WinControl.Legend();
            Dundas.Charting.WinControl.Series series5 = new Dundas.Charting.WinControl.Series();
            Dundas.Charting.WinControl.Series series6 = new Dundas.Charting.WinControl.Series();
            Dundas.Charting.WinControl.Series series7 = new Dundas.Charting.WinControl.Series();
            Dundas.Charting.WinControl.Series series8 = new Dundas.Charting.WinControl.Series();
            Dundas.Charting.WinControl.Title title2 = new Dundas.Charting.WinControl.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(analys));
            this.button1 = new System.Windows.Forms.Button();
            this.chart1 = new Dundas.Charting.WinControl.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_from = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_to = new System.Windows.Forms.TextBox();
            this.button_confirm = new System.Windows.Forms.Button();
            this.button_print = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("楷体_GB2312", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(699, 580);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "返回";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            chartArea3.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisX.MinorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisX.MinorTickMark.Size = 2F;
            chartArea3.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisX2.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisX2.MinorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisY.MinorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisY.MinorTickMark.Size = 2F;
            chartArea3.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea3.AxisY2.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea3.AxisY2.MinorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea3.BackColor = System.Drawing.Color.White;
            chartArea3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            chartArea3.BorderStyle = Dundas.Charting.WinControl.ChartDashStyle.Solid;
            chartArea3.Name = "Default";
            chartArea3.ShadowOffset = 2;
            chartArea4.Name = "daixie";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.ChartAreas.Add(chartArea4);
            legend2.Alignment = System.Drawing.StringAlignment.Center;
            legend2.BackColor = System.Drawing.Color.White;
            legend2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            legend2.Docking = Dundas.Charting.WinControl.LegendDocking.Top;
            legend2.Name = "Default";
            legend2.ShadowOffset = 2;
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(638, 54);
            this.chart1.Name = "chart1";
            this.chart1.Palette = Dundas.Charting.WinControl.ChartColorPalette.Dundas;
            series5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series5.BorderWidth = 2;
            series5.ChartType = "Spline";
            series5.Color = System.Drawing.Color.Red;
            series5.Name = "即时心率";
            series5.PaletteCustomColors = new System.Drawing.Color[0];
            series5.ShadowOffset = 2;
            series6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            series6.BorderWidth = 2;
            series6.ChartType = "Spline";
            series6.Name = "平均心率";
            series6.PaletteCustomColors = new System.Drawing.Color[0];
            series6.ShadowOffset = 2;
            series7.BorderWidth = 2;
            series7.ChartArea = "daixie";
            series7.ChartType = "Spline";
            series7.Color = System.Drawing.Color.Lime;
            series7.Name = "代谢率";
            series7.PaletteCustomColors = new System.Drawing.Color[0];
            series8.Color = System.Drawing.Color.Fuchsia;
            series8.MarkerColor = System.Drawing.Color.White;
            series8.Name = "记录心率";
            series8.PaletteCustomColors = new System.Drawing.Color[0];
            series8.ShowLabelAsValue = true;
            series8.YValuesPerPoint = 2;
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Size = new System.Drawing.Size(520, 520);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            title2.Text = "心率和代谢率随时间变化图";
            this.chart1.Titles.Add(title2);
            this.chart1.UI.Toolbar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(59)))), ((int)(((byte)(105)))));
            this.chart1.UI.Toolbar.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            this.chart1.UI.Toolbar.BorderSkin.SkinStyle = Dundas.Charting.WinControl.BorderSkinStyle.Emboss;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(454, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 8;
            this.label1.Text = "统计起止时间(秒)";
            // 
            // textBox_from
            // 
            this.textBox_from.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_from.Location = new System.Drawing.Point(592, 21);
            this.textBox_from.Name = "textBox_from";
            this.textBox_from.Size = new System.Drawing.Size(56, 26);
            this.textBox_from.TabIndex = 9;
            this.textBox_from.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(651, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "-";
            // 
            // textBox_to
            // 
            this.textBox_to.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox_to.Location = new System.Drawing.Point(668, 21);
            this.textBox_to.Name = "textBox_to";
            this.textBox_to.Size = new System.Drawing.Size(59, 26);
            this.textBox_to.TabIndex = 11;
            // 
            // button_confirm
            // 
            this.button_confirm.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_confirm.Location = new System.Drawing.Point(747, 19);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(73, 28);
            this.button_confirm.TabIndex = 12;
            this.button_confirm.Text = "确定";
            this.button_confirm.UseVisualStyleBackColor = true;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // button_print
            // 
            this.button_print.BackColor = System.Drawing.Color.Green;
            this.button_print.Font = new System.Drawing.Font("楷体_GB2312", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_print.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_print.Location = new System.Drawing.Point(457, 580);
            this.button_print.Name = "button_print";
            this.button_print.Size = new System.Drawing.Size(148, 50);
            this.button_print.TabIndex = 13;
            this.button_print.Text = "打印";
            this.button_print.UseVisualStyleBackColor = false;
            this.button_print.Click += new System.EventHandler(this.button_print_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.DocumentName = "printDialog1";
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(186, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 520);
            this.panel1.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(292, 420);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 21);
            this.label12.TabIndex = 9;
            this.label12.Text = "_p";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(292, 333);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 21);
            this.label11.TabIndex = 8;
            this.label11.Text = "_p";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(292, 232);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 21);
            this.label10.TabIndex = 7;
            this.label10.Text = "_p";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(292, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 21);
            this.label9.TabIndex = 6;
            this.label9.Text = "_p";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(292, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 21);
            this.label8.TabIndex = 5;
            this.label8.Text = "_p";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(148, 420);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 21);
            this.label7.TabIndex = 4;
            this.label7.Text = "方差";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(148, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 21);
            this.label6.TabIndex = 3;
            this.label6.Text = "最低心率";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(148, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "最高心率";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(148, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "平均心率";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(148, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "姓名";
            // 
            // analys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1200, 666);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_print);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.textBox_to);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_from);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "analys";
            this.Text = "2";
            this.Load += new System.EventHandler(this.analys_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private Dundas.Charting.WinControl.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_from;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_to;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.Button button_print;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}