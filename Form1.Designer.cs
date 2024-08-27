namespace Mini_cash_management_system
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.incCatMasBtn = new System.Windows.Forms.Button();
            this.expCatMasBtn = new System.Windows.Forms.Button();
            this.recExpBtn = new System.Windows.Forms.Button();
            this.recIncBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.panelcontent = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dashboard = new System.Windows.Forms.Button();
            this.labelUsr = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelcontent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.dashboard);
            this.panel1.Controls.Add(this.incCatMasBtn);
            this.panel1.Controls.Add(this.expCatMasBtn);
            this.panel1.Controls.Add(this.recExpBtn);
            this.panel1.Controls.Add(this.recIncBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 776);
            this.panel1.TabIndex = 0;
            // 
            // incCatMasBtn
            // 
            this.incCatMasBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incCatMasBtn.Location = new System.Drawing.Point(14, 546);
            this.incCatMasBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.incCatMasBtn.Name = "incCatMasBtn";
            this.incCatMasBtn.Size = new System.Drawing.Size(192, 111);
            this.incCatMasBtn.TabIndex = 6;
            this.incCatMasBtn.Text = "Income Category Master";
            this.incCatMasBtn.UseVisualStyleBackColor = true;
            this.incCatMasBtn.Click += new System.EventHandler(this.incCatMasBtn_Click);
            // 
            // expCatMasBtn
            // 
            this.expCatMasBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expCatMasBtn.Location = new System.Drawing.Point(14, 428);
            this.expCatMasBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.expCatMasBtn.Name = "expCatMasBtn";
            this.expCatMasBtn.Size = new System.Drawing.Size(192, 110);
            this.expCatMasBtn.TabIndex = 5;
            this.expCatMasBtn.Text = "Expense Category Master";
            this.expCatMasBtn.UseVisualStyleBackColor = true;
            this.expCatMasBtn.Click += new System.EventHandler(this.expCatMasBtn_Click);
            // 
            // recExpBtn
            // 
            this.recExpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recExpBtn.Location = new System.Drawing.Point(14, 206);
            this.recExpBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.recExpBtn.Name = "recExpBtn";
            this.recExpBtn.Size = new System.Drawing.Size(192, 68);
            this.recExpBtn.TabIndex = 3;
            this.recExpBtn.Text = "Record Expenses";
            this.recExpBtn.UseVisualStyleBackColor = true;
            this.recExpBtn.Click += new System.EventHandler(this.recExpBtn_Click);
            // 
            // recIncBtn
            // 
            this.recIncBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recIncBtn.Location = new System.Drawing.Point(14, 316);
            this.recIncBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.recIncBtn.Name = "recIncBtn";
            this.recIncBtn.Size = new System.Drawing.Size(192, 71);
            this.recIncBtn.TabIndex = 4;
            this.recIncBtn.Text = "Record \r\nIncome";
            this.recIncBtn.UseVisualStyleBackColor = true;
            this.recIncBtn.Click += new System.EventHandler(this.recIncBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelUsr);
            this.panel2.Controls.Add(this.logOutBtn);
            this.panel2.Controls.Add(this.homeBtn);
            this.panel2.Controls.Add(this.closeBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(225, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(967, 52);
            this.panel2.TabIndex = 1;
            // 
            // logOutBtn
            // 
            this.logOutBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logOutBtn.BackgroundImage")));
            this.logOutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logOutBtn.Location = new System.Drawing.Point(789, 4);
            this.logOutBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(54, 45);
            this.logOutBtn.TabIndex = 2;
            this.logOutBtn.UseVisualStyleBackColor = true;
            this.logOutBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homeBtn.BackgroundImage")));
            this.homeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.homeBtn.Location = new System.Drawing.Point(849, 4);
            this.homeBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(54, 45);
            this.homeBtn.TabIndex = 1;
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeBtn.BackgroundImage")));
            this.closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeBtn.Location = new System.Drawing.Point(910, 4);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(54, 45);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // panelcontent
            // 
            this.panelcontent.Controls.Add(this.label1);
            this.panelcontent.Controls.Add(this.pictureBox1);
            this.panelcontent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontent.Location = new System.Drawing.Point(225, 52);
            this.panelcontent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelcontent.Name = "panelcontent";
            this.panelcontent.Size = new System.Drawing.Size(967, 724);
            this.panelcontent.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(233, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(521, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cash Management System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(968, 722);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dashboard
            // 
            this.dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard.Location = new System.Drawing.Point(14, 80);
            this.dashboard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(192, 68);
            this.dashboard.TabIndex = 7;
            this.dashboard.Text = "Dashboard";
            this.dashboard.UseVisualStyleBackColor = true;
            // 
            // labelUsr
            // 
            this.labelUsr.AutoSize = true;
            this.labelUsr.Location = new System.Drawing.Point(15, 16);
            this.labelUsr.Name = "labelUsr";
            this.labelUsr.Size = new System.Drawing.Size(100, 20);
            this.labelUsr.TabIndex = 3;
            this.labelUsr.Text = "User : Admin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 776);
            this.ControlBox = false;
            this.Controls.Add(this.panelcontent);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelcontent.ResumeLayout(false);
            this.panelcontent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelcontent;
        private System.Windows.Forms.Button incCatMasBtn;
        private System.Windows.Forms.Button expCatMasBtn;
        private System.Windows.Forms.Button recExpBtn;
        private System.Windows.Forms.Button recIncBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logOutBtn;
        private System.Windows.Forms.Button dashboard;
        private System.Windows.Forms.Label labelUsr;
    }
}

