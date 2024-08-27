namespace Mini_cash_management_system
{
    partial class ExpRecFrm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.expCatComboBox = new System.Windows.Forms.ComboBox();
            this.expDesTextBox = new System.Windows.Forms.TextBox();
            this.expAmtTextBox = new System.Windows.Forms.TextBox();
            this.expAddBtn = new System.Windows.Forms.Button();
            this.incCatDeleteBtn = new System.Windows.Forms.Button();
            this.incCatUpdateBtn = new System.Windows.Forms.Button();
            this.dataGridViewExpR = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExpR)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Record Expense";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(57, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Expense category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Amount";
            // 
            // expCatComboBox
            // 
            this.expCatComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expCatComboBox.FormattingEnabled = true;
            this.expCatComboBox.Location = new System.Drawing.Point(334, 138);
            this.expCatComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.expCatComboBox.Name = "expCatComboBox";
            this.expCatComboBox.Size = new System.Drawing.Size(254, 34);
            this.expCatComboBox.TabIndex = 5;
            // 
            // expDesTextBox
            // 
            this.expDesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expDesTextBox.Location = new System.Drawing.Point(334, 206);
            this.expDesTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.expDesTextBox.Multiline = true;
            this.expDesTextBox.Name = "expDesTextBox";
            this.expDesTextBox.Size = new System.Drawing.Size(249, 93);
            this.expDesTextBox.TabIndex = 6;
            // 
            // expAmtTextBox
            // 
            this.expAmtTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expAmtTextBox.Location = new System.Drawing.Point(334, 322);
            this.expAmtTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.expAmtTextBox.Name = "expAmtTextBox";
            this.expAmtTextBox.Size = new System.Drawing.Size(150, 32);
            this.expAmtTextBox.TabIndex = 7;
            // 
            // expAddBtn
            // 
            this.expAddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.expAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expAddBtn.ForeColor = System.Drawing.Color.White;
            this.expAddBtn.Location = new System.Drawing.Point(740, 138);
            this.expAddBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.expAddBtn.Name = "expAddBtn";
            this.expAddBtn.Size = new System.Drawing.Size(123, 59);
            this.expAddBtn.TabIndex = 8;
            this.expAddBtn.Text = "Add";
            this.expAddBtn.UseVisualStyleBackColor = false;
            this.expAddBtn.Click += new System.EventHandler(this.expAddBtn_Click);
            // 
            // incCatDeleteBtn
            // 
            this.incCatDeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.incCatDeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incCatDeleteBtn.ForeColor = System.Drawing.Color.White;
            this.incCatDeleteBtn.Location = new System.Drawing.Point(740, 295);
            this.incCatDeleteBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.incCatDeleteBtn.Name = "incCatDeleteBtn";
            this.incCatDeleteBtn.Size = new System.Drawing.Size(123, 59);
            this.incCatDeleteBtn.TabIndex = 20;
            this.incCatDeleteBtn.Text = "Delete";
            this.incCatDeleteBtn.UseVisualStyleBackColor = false;
            // 
            // incCatUpdateBtn
            // 
            this.incCatUpdateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.incCatUpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incCatUpdateBtn.ForeColor = System.Drawing.Color.White;
            this.incCatUpdateBtn.Location = new System.Drawing.Point(740, 216);
            this.incCatUpdateBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.incCatUpdateBtn.Name = "incCatUpdateBtn";
            this.incCatUpdateBtn.Size = new System.Drawing.Size(123, 59);
            this.incCatUpdateBtn.TabIndex = 19;
            this.incCatUpdateBtn.Text = "Update";
            this.incCatUpdateBtn.UseVisualStyleBackColor = false;
            // 
            // dataGridViewExpR
            // 
            this.dataGridViewExpR.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewExpR.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewExpR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewExpR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExpR.Location = new System.Drawing.Point(53, 393);
            this.dataGridViewExpR.Name = "dataGridViewExpR";
            this.dataGridViewExpR.ReadOnly = true;
            this.dataGridViewExpR.RowHeadersWidth = 62;
            this.dataGridViewExpR.RowTemplate.Height = 28;
            this.dataGridViewExpR.Size = new System.Drawing.Size(810, 272);
            this.dataGridViewExpR.TabIndex = 21;
            // 
            // ExpRecFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 757);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridViewExpR);
            this.Controls.Add(this.incCatDeleteBtn);
            this.Controls.Add(this.incCatUpdateBtn);
            this.Controls.Add(this.expAddBtn);
            this.Controls.Add(this.expAmtTextBox);
            this.Controls.Add(this.expDesTextBox);
            this.Controls.Add(this.expCatComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ExpRecFrm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ExpRecFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExpR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox expCatComboBox;
        private System.Windows.Forms.TextBox expDesTextBox;
        private System.Windows.Forms.TextBox expAmtTextBox;
        private System.Windows.Forms.Button expAddBtn;
        private System.Windows.Forms.Button incCatDeleteBtn;
        private System.Windows.Forms.Button incCatUpdateBtn;
        private System.Windows.Forms.DataGridView dataGridViewExpR;
    }
}