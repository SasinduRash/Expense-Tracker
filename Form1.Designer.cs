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
            this.signUpBtn = new System.Windows.Forms.Button();
            this.expCatMasBtn = new System.Windows.Forms.Button();
            this.recExpBtn = new System.Windows.Forms.Button();
            this.recIncBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.homeBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.panelcontent = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.logOutBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelcontent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.incCatMasBtn);
            this.panel1.Controls.Add(this.signUpBtn);
            this.panel1.Controls.Add(this.expCatMasBtn);
            this.panel1.Controls.Add(this.recExpBtn);
            this.panel1.Controls.Add(this.recIncBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 621);
            this.panel1.TabIndex = 0;
            // 
            // incCatMasBtn
            // 
            this.incCatMasBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incCatMasBtn.Location = new System.Drawing.Point(12, 437);
            this.incCatMasBtn.Name = "incCatMasBtn";
            this.incCatMasBtn.Size = new System.Drawing.Size(171, 58);
            this.incCatMasBtn.TabIndex = 6;
            this.incCatMasBtn.Text = "Income Category Master";
            this.incCatMasBtn.UseVisualStyleBackColor = true;
            this.incCatMasBtn.Click += new System.EventHandler(this.incCatMasBtn_Click);
            // 
            // signUpBtn
            // 
            this.signUpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpBtn.Location = new System.Drawing.Point(12, 82);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(171, 52);
            this.signUpBtn.TabIndex = 2;
            this.signUpBtn.Text = "Sign up";
            this.signUpBtn.UseVisualStyleBackColor = true;
            this.signUpBtn.Click += new System.EventHandler(this.signUpBtn_Click);
            // 
            // expCatMasBtn
            // 
            this.expCatMasBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expCatMasBtn.Location = new System.Drawing.Point(12, 342);
            this.expCatMasBtn.Name = "expCatMasBtn";
            this.expCatMasBtn.Size = new System.Drawing.Size(171, 60);
            this.expCatMasBtn.TabIndex = 5;
            this.expCatMasBtn.Text = "Expense Category Master";
            this.expCatMasBtn.UseVisualStyleBackColor = true;
            this.expCatMasBtn.Click += new System.EventHandler(this.expCatMasBtn_Click);
            // 
            // recExpBtn
            // 
            this.recExpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recExpBtn.Location = new System.Drawing.Point(12, 165);
            this.recExpBtn.Name = "recExpBtn";
            this.recExpBtn.Size = new System.Drawing.Size(171, 54);
            this.recExpBtn.TabIndex = 3;
            this.recExpBtn.Text = "Record Expenses";
            this.recExpBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.recExpBtn.UseVisualStyleBackColor = true;
            this.recExpBtn.Click += new System.EventHandler(this.recExpBtn_Click);
            // 
            // recIncBtn
            // 
            this.recIncBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recIncBtn.Location = new System.Drawing.Point(12, 253);
            this.recIncBtn.Name = "recIncBtn";
            this.recIncBtn.Size = new System.Drawing.Size(171, 57);
            this.recIncBtn.TabIndex = 4;
            this.recIncBtn.Text = "Record Income";
            this.recIncBtn.UseVisualStyleBackColor = true;
            this.recIncBtn.Click += new System.EventHandler(this.recIncBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.logOutBtn);
            this.panel2.Controls.Add(this.homeBtn);
            this.panel2.Controls.Add(this.closeBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(860, 42);
            this.panel2.TabIndex = 1;
            // 
            // homeBtn
            // 
            this.homeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homeBtn.BackgroundImage")));
            this.homeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.homeBtn.Location = new System.Drawing.Point(755, 3);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(48, 36);
            this.homeBtn.TabIndex = 1;
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeBtn.BackgroundImage")));
            this.closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeBtn.Location = new System.Drawing.Point(809, 3);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(48, 36);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // panelcontent
            // 
            this.panelcontent.Controls.Add(this.label1);
            this.panelcontent.Controls.Add(this.pictureBox1);
            this.panelcontent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelcontent.Location = new System.Drawing.Point(200, 42);
            this.panelcontent.Name = "panelcontent";
            this.panelcontent.Size = new System.Drawing.Size(860, 579);
            this.panelcontent.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(860, 578);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(207, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cash Management System";
            // 
            // logOutBtn
            // 
            this.logOutBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logOutBtn.BackgroundImage")));
            this.logOutBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logOutBtn.Location = new System.Drawing.Point(701, 3);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(48, 36);
            this.logOutBtn.TabIndex = 2;
            this.logOutBtn.UseVisualStyleBackColor = true;
            this.logOutBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 621);
            this.ControlBox = false;
            this.Controls.Add(this.panelcontent);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelcontent.ResumeLayout(false);
            this.panelcontent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button signUpBtn;
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
    }
}

