namespace strike_subsystem
{
    partial class Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.Form_Panel = new System.Windows.Forms.Panel();
            this.Button_Exit = new System.Windows.Forms.Button();
            this.Button_Analysis = new System.Windows.Forms.Button();
            this.Button_Exam = new System.Windows.Forms.Button();
            this.Button_Manage_p = new System.Windows.Forms.Button();
            this.Button_New_p = new System.Windows.Forms.Button();
            this.Welcome_BG = new System.Windows.Forms.PictureBox();
            this.Form_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Welcome_BG)).BeginInit();
            this.SuspendLayout();
            // 
            // Form_Panel
            // 
            this.Form_Panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Form_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.Form_Panel.Controls.Add(this.Button_Exit);
            this.Form_Panel.Controls.Add(this.Button_Analysis);
            this.Form_Panel.Controls.Add(this.Button_Exam);
            this.Form_Panel.Controls.Add(this.Button_Manage_p);
            this.Form_Panel.Controls.Add(this.Button_New_p);
            this.Form_Panel.Controls.Add(this.Welcome_BG);
            this.Form_Panel.Location = new System.Drawing.Point(0, 0);
            this.Form_Panel.Name = "Form_Panel";
            this.Form_Panel.Size = new System.Drawing.Size(900, 685);
            this.Form_Panel.TabIndex = 0;
            // 
            // Button_Exit
            // 
            this.Button_Exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Exit.Location = new System.Drawing.Point(674, 501);
            this.Button_Exit.Name = "Button_Exit";
            this.Button_Exit.Size = new System.Drawing.Size(100, 30);
            this.Button_Exit.TabIndex = 29;
            this.Button_Exit.Text = "退    出";
            this.Button_Exit.UseVisualStyleBackColor = true;
            this.Button_Exit.Click += new System.EventHandler(this.Button_Exit_Click);
            // 
            // Button_Analysis
            // 
            this.Button_Analysis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Analysis.Location = new System.Drawing.Point(797, 394);
            this.Button_Analysis.Name = "Button_Analysis";
            this.Button_Analysis.Size = new System.Drawing.Size(100, 120);
            this.Button_Analysis.TabIndex = 28;
            this.Button_Analysis.UseVisualStyleBackColor = true;
            this.Button_Analysis.Visible = false;
            this.Button_Analysis.Click += new System.EventHandler(this.Button_Analysis_Click);
            // 
            // Button_Exam
            // 
            this.Button_Exam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Exam.Location = new System.Drawing.Point(3, 411);
            this.Button_Exam.Name = "Button_Exam";
            this.Button_Exam.Size = new System.Drawing.Size(100, 120);
            this.Button_Exam.TabIndex = 27;
            this.Button_Exam.UseVisualStyleBackColor = true;
            this.Button_Exam.Visible = false;
            this.Button_Exam.Click += new System.EventHandler(this.Button_Exam_Click);
            // 
            // Button_Manage_p
            // 
            this.Button_Manage_p.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_Manage_p.Image = ((System.Drawing.Image)(resources.GetObject("Button_Manage_p.Image")));
            this.Button_Manage_p.Location = new System.Drawing.Point(538, 272);
            this.Button_Manage_p.Name = "Button_Manage_p";
            this.Button_Manage_p.Size = new System.Drawing.Size(180, 199);
            this.Button_Manage_p.TabIndex = 26;
            this.Button_Manage_p.UseVisualStyleBackColor = true;
            this.Button_Manage_p.Click += new System.EventHandler(this.Button_Manage_p_Click);
            // 
            // Button_New_p
            // 
            this.Button_New_p.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Button_New_p.Image = ((System.Drawing.Image)(resources.GetObject("Button_New_p.Image")));
            this.Button_New_p.Location = new System.Drawing.Point(178, 271);
            this.Button_New_p.Name = "Button_New_p";
            this.Button_New_p.Size = new System.Drawing.Size(180, 199);
            this.Button_New_p.TabIndex = 25;
            this.Button_New_p.UseVisualStyleBackColor = true;
            this.Button_New_p.Click += new System.EventHandler(this.Button_New_p_Click);
            // 
            // Welcome_BG
            // 
            this.Welcome_BG.ErrorImage = null;
            this.Welcome_BG.InitialImage = null;
            this.Welcome_BG.Location = new System.Drawing.Point(0, 0);
            this.Welcome_BG.Name = "Welcome_BG";
            this.Welcome_BG.Size = new System.Drawing.Size(900, 685);
            this.Welcome_BG.TabIndex = 0;
            this.Welcome_BG.TabStop = false;
            this.Welcome_BG.Click += new System.EventHandler(this.Welcome_BG_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(900, 685);
            this.Controls.Add(this.Form_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Welcome";
            this.Text = "Welcome";
            this.Form_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Welcome_BG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Form_Panel;
        private System.Windows.Forms.PictureBox Welcome_BG;
        private System.Windows.Forms.Button Button_Exit;
        private System.Windows.Forms.Button Button_Manage_p;
        private System.Windows.Forms.Button Button_New_p;
        private System.Windows.Forms.Button Button_Analysis;
        private System.Windows.Forms.Button Button_Exam;
    }
}