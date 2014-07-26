namespace strike_subsystem
{
    partial class New_p
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Remark = new System.Windows.Forms.TextBox();
            this.UWeight = new System.Windows.Forms.TextBox();
            this.Birthday = new System.Windows.Forms.DateTimePicker();
            this.Button_submit = new System.Windows.Forms.Button();
            this.UserSex2 = new System.Windows.Forms.RadioButton();
            this.UserSex1 = new System.Windows.Forms.RadioButton();
            this.Contacts = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.TextBox();
            this.UHeight = new System.Windows.Forms.TextBox();
            this.Button_exit = new System.Windows.Forms.Button();
            this.New_p_BG = new System.Windows.Forms.PictureBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.New_p_BG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.Remark);
            this.panel1.Controls.Add(this.UWeight);
            this.panel1.Controls.Add(this.Birthday);
            this.panel1.Controls.Add(this.Button_submit);
            this.panel1.Controls.Add(this.UserSex2);
            this.panel1.Controls.Add(this.UserSex1);
            this.panel1.Controls.Add(this.Contacts);
            this.panel1.Controls.Add(this.UserName);
            this.panel1.Controls.Add(this.UHeight);
            this.panel1.Controls.Add(this.Button_exit);
            this.panel1.Controls.Add(this.New_p_BG);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 685);
            this.panel1.TabIndex = 2;
            // 
            // Remark
            // 
            this.Remark.Location = new System.Drawing.Point(300, 508);
            this.Remark.Name = "Remark";
            this.Remark.Size = new System.Drawing.Size(450, 21);
            this.Remark.TabIndex = 7;
            this.Remark.Visible = false;
            // 
            // UWeight
            // 
            this.UWeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UWeight.Location = new System.Drawing.Point(300, 358);
            this.UWeight.MaxLength = 10;
            this.UWeight.Name = "UWeight";
            this.UWeight.Size = new System.Drawing.Size(150, 21);
            this.UWeight.TabIndex = 4;
            this.UWeight.TextChanged += new System.EventHandler(this.UWeight_TextChanged);
            // 
            // Birthday
            // 
            this.Birthday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Birthday.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Birthday.Location = new System.Drawing.Point(300, 408);
            this.Birthday.Name = "Birthday";
            this.Birthday.Size = new System.Drawing.Size(150, 21);
            this.Birthday.TabIndex = 5;
            // 
            // Button_submit
            // 
            this.Button_submit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_submit.Location = new System.Drawing.Point(540, 578);
            this.Button_submit.Name = "Button_submit";
            this.Button_submit.Size = new System.Drawing.Size(100, 30);
            this.Button_submit.TabIndex = 8;
            this.Button_submit.Text = "保    存";
            this.Button_submit.UseVisualStyleBackColor = true;
            this.Button_submit.Click += new System.EventHandler(this.Button_submit_Click);
            // 
            // UserSex2
            // 
            this.UserSex2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserSex2.AutoSize = true;
            this.UserSex2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.UserSex2.Location = new System.Drawing.Point(415, 258);
            this.UserSex2.Name = "UserSex2";
            this.UserSex2.Size = new System.Drawing.Size(35, 16);
            this.UserSex2.TabIndex = 2;
            this.UserSex2.Text = "女";
            this.UserSex2.UseVisualStyleBackColor = false;
            // 
            // UserSex1
            // 
            this.UserSex1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserSex1.AutoSize = true;
            this.UserSex1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(241)))), ((int)(((byte)(245)))));
            this.UserSex1.Checked = true;
            this.UserSex1.Location = new System.Drawing.Point(300, 258);
            this.UserSex1.Name = "UserSex1";
            this.UserSex1.Size = new System.Drawing.Size(35, 16);
            this.UserSex1.TabIndex = 1;
            this.UserSex1.TabStop = true;
            this.UserSex1.Text = "男";
            this.UserSex1.UseVisualStyleBackColor = false;
            // 
            // Contacts
            // 
            this.Contacts.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Contacts.Location = new System.Drawing.Point(300, 458);
            this.Contacts.MaxLength = 50;
            this.Contacts.Name = "Contacts";
            this.Contacts.Size = new System.Drawing.Size(150, 21);
            this.Contacts.TabIndex = 6;
            // 
            // UserName
            // 
            this.UserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserName.Location = new System.Drawing.Point(300, 208);
            this.UserName.MaxLength = 10;
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(150, 21);
            this.UserName.TabIndex = 0;
            this.UserName.TextChanged += new System.EventHandler(this.UserName_TextChanged);
            this.UserName.Leave += new System.EventHandler(this.UserName_Leave);
            // 
            // UHeight
            // 
            this.UHeight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UHeight.Location = new System.Drawing.Point(300, 308);
            this.UHeight.MaxLength = 10;
            this.UHeight.Name = "UHeight";
            this.UHeight.Size = new System.Drawing.Size(150, 21);
            this.UHeight.TabIndex = 3;
            this.UHeight.TextChanged += new System.EventHandler(this.UHeight_TextChanged);
            // 
            // Button_exit
            // 
            this.Button_exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_exit.Location = new System.Drawing.Point(680, 578);
            this.Button_exit.Name = "Button_exit";
            this.Button_exit.Size = new System.Drawing.Size(100, 30);
            this.Button_exit.TabIndex = 9;
            this.Button_exit.Text = "返    回";
            this.Button_exit.UseVisualStyleBackColor = true;
            this.Button_exit.Click += new System.EventHandler(this.Button_exit_Click);
            // 
            // New_p_BG
            // 
            this.New_p_BG.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.New_p_BG.Location = new System.Drawing.Point(0, 0);
            this.New_p_BG.Name = "New_p_BG";
            this.New_p_BG.Size = new System.Drawing.Size(900, 685);
            this.New_p_BG.TabIndex = 45;
            this.New_p_BG.TabStop = false;
            this.New_p_BG.Click += new System.EventHandler(this.New_p_BG_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // New_p
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(900, 685);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "New_p";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New_p";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.New_p_BG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker Birthday;
        private System.Windows.Forms.Button Button_submit;
        private System.Windows.Forms.RadioButton UserSex2;
        private System.Windows.Forms.RadioButton UserSex1;
        private System.Windows.Forms.TextBox Contacts;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox UHeight;
        private System.Windows.Forms.Button Button_exit;
        private System.Windows.Forms.PictureBox New_p_BG;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.TextBox UWeight;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.TextBox Remark;
    }
}