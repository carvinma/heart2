namespace strike_subsystem
{
    partial class Manage_p
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manage_p));
            this.Button_delete = new System.Windows.Forms.Button();
            this.UserName = new System.Windows.Forms.TextBox();
            this.UHeight = new System.Windows.Forms.TextBox();
            this.Button_search = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Remark = new System.Windows.Forms.TextBox();
            this.UWeight = new System.Windows.Forms.TextBox();
            this.Search_name = new System.Windows.Forms.TextBox();
            this.DataList = new System.Windows.Forms.DataGridView();
            this.Birthday = new System.Windows.Forms.DateTimePicker();
            this.UserSex2 = new System.Windows.Forms.RadioButton();
            this.UserSex1 = new System.Windows.Forms.RadioButton();
            this.Button_submit = new System.Windows.Forms.Button();
            this.Button_exit = new System.Windows.Forms.Button();
            this.Manage_p_BG = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Manage_p_BG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_delete
            // 
            this.Button_delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_delete.Location = new System.Drawing.Point(555, 578);
            this.Button_delete.Name = "Button_delete";
            this.Button_delete.Size = new System.Drawing.Size(100, 30);
            this.Button_delete.TabIndex = 11;
            this.Button_delete.Text = "删    除";
            this.Button_delete.UseVisualStyleBackColor = true;
            this.Button_delete.Click += new System.EventHandler(this.Button_delete_Click);
            // 
            // UserName
            // 
            this.UserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserName.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UserName.Location = new System.Drawing.Point(540, 198);
            this.UserName.Name = "UserName";
            this.UserName.ReadOnly = true;
            this.UserName.Size = new System.Drawing.Size(80, 26);
            this.UserName.TabIndex = 2;
            this.UserName.TabStop = false;
            // 
            // UHeight
            // 
            this.UHeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UHeight.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UHeight.Location = new System.Drawing.Point(540, 242);
            this.UHeight.Name = "UHeight";
            this.UHeight.Size = new System.Drawing.Size(80, 26);
            this.UHeight.TabIndex = 5;
            this.UHeight.TextChanged += new System.EventHandler(this.UHeight_TextChanged);
            // 
            // Button_search
            // 
            this.Button_search.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_search.Location = new System.Drawing.Point(313, 510);
            this.Button_search.Name = "Button_search";
            this.Button_search.Size = new System.Drawing.Size(75, 23);
            this.Button_search.TabIndex = 2;
            this.Button_search.Text = "搜  索";
            this.Button_search.UseVisualStyleBackColor = true;
            this.Button_search.Click += new System.EventHandler(this.Button_search_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.Remark);
            this.panel1.Controls.Add(this.UWeight);
            this.panel1.Controls.Add(this.Button_delete);
            this.panel1.Controls.Add(this.UserName);
            this.panel1.Controls.Add(this.UHeight);
            this.panel1.Controls.Add(this.Button_search);
            this.panel1.Controls.Add(this.Search_name);
            this.panel1.Controls.Add(this.DataList);
            this.panel1.Controls.Add(this.Birthday);
            this.panel1.Controls.Add(this.UserSex2);
            this.panel1.Controls.Add(this.UserSex1);
            this.panel1.Controls.Add(this.Button_submit);
            this.panel1.Controls.Add(this.Button_exit);
            this.panel1.Controls.Add(this.Manage_p_BG);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 685);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(288, 578);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 77;
            this.button1.Text = "开始检测";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(415, 358);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 30;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(429, 146);
            this.dataGridView1.TabIndex = 76;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Remark
            // 
            this.Remark.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Remark.Location = new System.Drawing.Point(744, 287);
            this.Remark.Name = "Remark";
            this.Remark.Size = new System.Drawing.Size(96, 26);
            this.Remark.TabIndex = 9;
            // 
            // UWeight
            // 
            this.UWeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UWeight.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UWeight.Location = new System.Drawing.Point(744, 242);
            this.UWeight.Name = "UWeight";
            this.UWeight.Size = new System.Drawing.Size(96, 26);
            this.UWeight.TabIndex = 6;
            this.UWeight.TextChanged += new System.EventHandler(this.UWeight_TextChanged);
            // 
            // Search_name
            // 
            this.Search_name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Search_name.Location = new System.Drawing.Point(185, 512);
            this.Search_name.Name = "Search_name";
            this.Search_name.Size = new System.Drawing.Size(113, 21);
            this.Search_name.TabIndex = 1;
            // 
            // DataList
            // 
            this.DataList.AllowUserToAddRows = false;
            this.DataList.AllowUserToDeleteRows = false;
            this.DataList.AllowUserToResizeRows = false;
            this.DataList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataList.Location = new System.Drawing.Point(108, 231);
            this.DataList.MultiSelect = false;
            this.DataList.Name = "DataList";
            this.DataList.ReadOnly = true;
            this.DataList.RowHeadersVisible = false;
            this.DataList.RowHeadersWidth = 10;
            this.DataList.RowTemplate.Height = 23;
            this.DataList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataList.Size = new System.Drawing.Size(291, 273);
            this.DataList.TabIndex = 0;
            this.DataList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataList_CellClick);
            // 
            // Birthday
            // 
            this.Birthday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Birthday.CalendarFont = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Birthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Birthday.Location = new System.Drawing.Point(540, 292);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(91, 21);
            this.Birthday.TabIndex = 7;
            // 
            // UserSex2
            // 
            this.UserSex2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserSex2.AutoSize = true;
            this.UserSex2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.UserSex2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UserSex2.Location = new System.Drawing.Point(792, 203);
            this.UserSex2.Name = "UserSex2";
            this.UserSex2.Size = new System.Drawing.Size(42, 20);
            this.UserSex2.TabIndex = 4;
            this.UserSex2.Text = "女";
            this.UserSex2.UseVisualStyleBackColor = false;
            // 
            // UserSex1
            // 
            this.UserSex1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserSex1.AutoSize = true;
            this.UserSex1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.UserSex1.Checked = true;
            this.UserSex1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UserSex1.Location = new System.Drawing.Point(751, 203);
            this.UserSex1.Name = "UserSex1";
            this.UserSex1.Size = new System.Drawing.Size(42, 20);
            this.UserSex1.TabIndex = 3;
            this.UserSex1.TabStop = true;
            this.UserSex1.Text = "男";
            this.UserSex1.UseVisualStyleBackColor = false;
            // 
            // Button_submit
            // 
            this.Button_submit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_submit.Location = new System.Drawing.Point(430, 578);
            this.Button_submit.Name = "Button_submit";
            this.Button_submit.Size = new System.Drawing.Size(100, 30);
            this.Button_submit.TabIndex = 10;
            this.Button_submit.Text = "修    改";
            this.Button_submit.UseVisualStyleBackColor = true;
            this.Button_submit.Click += new System.EventHandler(this.Button_submit_Click);
            // 
            // Button_exit
            // 
            this.Button_exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_exit.Location = new System.Drawing.Point(680, 578);
            this.Button_exit.Name = "Button_exit";
            this.Button_exit.Size = new System.Drawing.Size(100, 30);
            this.Button_exit.TabIndex = 12;
            this.Button_exit.Text = "返    回";
            this.Button_exit.UseVisualStyleBackColor = true;
            this.Button_exit.Click += new System.EventHandler(this.Button_exit_Click);
            // 
            // Manage_p_BG
            // 
            this.Manage_p_BG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Manage_p_BG.Image = ((System.Drawing.Image)(resources.GetObject("Manage_p_BG.Image")));
            this.Manage_p_BG.Location = new System.Drawing.Point(0, 0);
            this.Manage_p_BG.Name = "Manage_p_BG";
            this.Manage_p_BG.Size = new System.Drawing.Size(900, 685);
            this.Manage_p_BG.TabIndex = 74;
            this.Manage_p_BG.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // Manage_p
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(900, 685);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Manage_p";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage_p";
            this.Load += new System.EventHandler(this.Manage_p_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Manage_p_BG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_delete;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox UHeight;
        private System.Windows.Forms.Button Button_search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Search_name;
        private System.Windows.Forms.DataGridView DataList;
        private System.Windows.Forms.DateTimePicker Birthday;
        private System.Windows.Forms.RadioButton UserSex2;
        private System.Windows.Forms.RadioButton UserSex1;
        private System.Windows.Forms.Button Button_submit;
        private System.Windows.Forms.Button Button_exit;
        private System.Windows.Forms.PictureBox Manage_p_BG;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.TextBox UWeight;
        private System.Windows.Forms.TextBox Remark;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}