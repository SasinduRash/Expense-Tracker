namespace Mini_cash_management_system
{
    partial class IncCatMastFrm
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
            this.incCatAddBtn = new System.Windows.Forms.Button();
            this.incCatDeleteBtn = new System.Windows.Forms.Button();
            this.incCatUpdateBtn = new System.Windows.Forms.Button();
            this.incTextBox = new System.Windows.Forms.TextBox();
            this.incIdTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // incCatAddBtn
            // 
            this.incCatAddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.incCatAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incCatAddBtn.ForeColor = System.Drawing.Color.White;
            this.incCatAddBtn.Location = new System.Drawing.Point(67, 236);
            this.incCatAddBtn.Name = "incCatAddBtn";
            this.incCatAddBtn.Size = new System.Drawing.Size(109, 47);
            this.incCatAddBtn.TabIndex = 17;
            this.incCatAddBtn.Text = "Add";
            this.incCatAddBtn.UseVisualStyleBackColor = false;
            this.incCatAddBtn.Click += new System.EventHandler(this.incCatAddBtn_Click);
            // 
            // incCatDeleteBtn
            // 
            this.incCatDeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.incCatDeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incCatDeleteBtn.ForeColor = System.Drawing.Color.White;
            this.incCatDeleteBtn.Location = new System.Drawing.Point(315, 236);
            this.incCatDeleteBtn.Name = "incCatDeleteBtn";
            this.incCatDeleteBtn.Size = new System.Drawing.Size(109, 47);
            this.incCatDeleteBtn.TabIndex = 16;
            this.incCatDeleteBtn.Text = "Delete";
            this.incCatDeleteBtn.UseVisualStyleBackColor = false;
            this.incCatDeleteBtn.Click += new System.EventHandler(this.incCatDeleteBtn_Click);
            // 
            // incCatUpdateBtn
            // 
            this.incCatUpdateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.incCatUpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incCatUpdateBtn.ForeColor = System.Drawing.Color.White;
            this.incCatUpdateBtn.Location = new System.Drawing.Point(192, 236);
            this.incCatUpdateBtn.Name = "incCatUpdateBtn";
            this.incCatUpdateBtn.Size = new System.Drawing.Size(109, 47);
            this.incCatUpdateBtn.TabIndex = 15;
            this.incCatUpdateBtn.Text = "Update";
            this.incCatUpdateBtn.UseVisualStyleBackColor = false;
            this.incCatUpdateBtn.Click += new System.EventHandler(this.incCatUpdateBtn_Click);
            // 
            // incTextBox
            // 
            this.incTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incTextBox.Location = new System.Drawing.Point(202, 167);
            this.incTextBox.Name = "incTextBox";
            this.incTextBox.Size = new System.Drawing.Size(222, 28);
            this.incTextBox.TabIndex = 14;
            // 
            // incIdTextBox
            // 
            this.incIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incIdTextBox.Location = new System.Drawing.Point(202, 127);
            this.incIdTextBox.Name = "incIdTextBox";
            this.incIdTextBox.Size = new System.Drawing.Size(222, 28);
            this.incIdTextBox.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 22);
            this.label3.TabIndex = 12;
            this.label3.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Category ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Income Category Master";
            // 
            // IncCatMastFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.incCatAddBtn);
            this.Controls.Add(this.incCatDeleteBtn);
            this.Controls.Add(this.incCatUpdateBtn);
            this.Controls.Add(this.incTextBox);
            this.Controls.Add(this.incIdTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "IncCatMastFrm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button incCatAddBtn;
        private System.Windows.Forms.Button incCatDeleteBtn;
        private System.Windows.Forms.Button incCatUpdateBtn;
        private System.Windows.Forms.TextBox incTextBox;
        private System.Windows.Forms.TextBox incIdTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}