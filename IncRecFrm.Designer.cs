namespace Mini_cash_management_system
{
    partial class IncRecFrm
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
            this.incAddBtn = new System.Windows.Forms.Button();
            this.incAmtTextBox = new System.Windows.Forms.TextBox();
            this.incDesTextBox = new System.Windows.Forms.TextBox();
            this.incCatComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // incAddBtn
            // 
            this.incAddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.incAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incAddBtn.ForeColor = System.Drawing.Color.White;
            this.incAddBtn.Location = new System.Drawing.Point(414, 330);
            this.incAddBtn.Name = "incAddBtn";
            this.incAddBtn.Size = new System.Drawing.Size(109, 47);
            this.incAddBtn.TabIndex = 16;
            this.incAddBtn.Text = "Add";
            this.incAddBtn.UseVisualStyleBackColor = false;
            this.incAddBtn.Click += new System.EventHandler(this.incAddBtn_Click);
            // 
            // incAmtTextBox
            // 
            this.incAmtTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incAmtTextBox.Location = new System.Drawing.Point(301, 261);
            this.incAmtTextBox.Name = "incAmtTextBox";
            this.incAmtTextBox.Size = new System.Drawing.Size(134, 28);
            this.incAmtTextBox.TabIndex = 15;
            // 
            // incDesTextBox
            // 
            this.incDesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incDesTextBox.Location = new System.Drawing.Point(301, 168);
            this.incDesTextBox.Multiline = true;
            this.incDesTextBox.Name = "incDesTextBox";
            this.incDesTextBox.Size = new System.Drawing.Size(222, 75);
            this.incDesTextBox.TabIndex = 14;
            // 
            // incCatComboBox
            // 
            this.incCatComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incCatComboBox.FormattingEnabled = true;
            this.incCatComboBox.Items.AddRange(new object[] {
            "",
            "Sales",
            "Rent",
            "Others"});
            this.incCatComboBox.Location = new System.Drawing.Point(301, 113);
            this.incCatComboBox.Name = "incCatComboBox";
            this.incCatComboBox.Size = new System.Drawing.Size(226, 30);
            this.incCatComboBox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Description";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 22);
            this.label2.TabIndex = 10;
            this.label2.Text = "Income category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Record Income";
            // 
            // IncRecFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.incAddBtn);
            this.Controls.Add(this.incAmtTextBox);
            this.Controls.Add(this.incDesTextBox);
            this.Controls.Add(this.incCatComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "IncRecFrm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.IncRecFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button incAddBtn;
        private System.Windows.Forms.TextBox incAmtTextBox;
        private System.Windows.Forms.TextBox incDesTextBox;
        private System.Windows.Forms.ComboBox incCatComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}