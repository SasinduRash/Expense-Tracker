﻿namespace Mini_cash_management_system
{
    partial class ExpCatMastFrm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.expTextBox = new System.Windows.Forms.TextBox();
            this.expIdTextBox = new System.Windows.Forms.TextBox();
            this.expCatUpdateBtn = new System.Windows.Forms.Button();
            this.expCatDeleteBtn = new System.Windows.Forms.Button();
            this.expCatAddBtn = new System.Windows.Forms.Button();
            this.dataGridViewExp = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Expense Category Master";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(68, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Category";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Category ID";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // expTextBox
            // 
            this.expTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expTextBox.Location = new System.Drawing.Point(224, 206);
            this.expTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.expTextBox.Name = "expTextBox";
            this.expTextBox.Size = new System.Drawing.Size(249, 32);
            this.expTextBox.TabIndex = 6;
            // 
            // expIdTextBox
            // 
            this.expIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expIdTextBox.Location = new System.Drawing.Point(224, 156);
            this.expIdTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.expIdTextBox.Name = "expIdTextBox";
            this.expIdTextBox.Size = new System.Drawing.Size(249, 32);
            this.expIdTextBox.TabIndex = 5;
            // 
            // expCatUpdateBtn
            // 
            this.expCatUpdateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.expCatUpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expCatUpdateBtn.ForeColor = System.Drawing.Color.White;
            this.expCatUpdateBtn.Location = new System.Drawing.Point(213, 292);
            this.expCatUpdateBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.expCatUpdateBtn.Name = "expCatUpdateBtn";
            this.expCatUpdateBtn.Size = new System.Drawing.Size(123, 59);
            this.expCatUpdateBtn.TabIndex = 7;
            this.expCatUpdateBtn.Text = "Update";
            this.expCatUpdateBtn.UseVisualStyleBackColor = false;
            this.expCatUpdateBtn.Click += new System.EventHandler(this.expCatUpdateBtn_Click);
            // 
            // expCatDeleteBtn
            // 
            this.expCatDeleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expCatDeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expCatDeleteBtn.ForeColor = System.Drawing.Color.White;
            this.expCatDeleteBtn.Location = new System.Drawing.Point(351, 292);
            this.expCatDeleteBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.expCatDeleteBtn.Name = "expCatDeleteBtn";
            this.expCatDeleteBtn.Size = new System.Drawing.Size(123, 59);
            this.expCatDeleteBtn.TabIndex = 8;
            this.expCatDeleteBtn.Text = "Delete";
            this.expCatDeleteBtn.UseVisualStyleBackColor = false;
            this.expCatDeleteBtn.Click += new System.EventHandler(this.expCatDeleteBtn_Click);
            // 
            // expCatAddBtn
            // 
            this.expCatAddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.expCatAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expCatAddBtn.ForeColor = System.Drawing.Color.White;
            this.expCatAddBtn.Location = new System.Drawing.Point(72, 292);
            this.expCatAddBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.expCatAddBtn.Name = "expCatAddBtn";
            this.expCatAddBtn.Size = new System.Drawing.Size(123, 59);
            this.expCatAddBtn.TabIndex = 9;
            this.expCatAddBtn.Text = "Add";
            this.expCatAddBtn.UseVisualStyleBackColor = false;
            this.expCatAddBtn.Click += new System.EventHandler(this.expCatAddBtn_Click);
            // 
            // dataGridViewExp
            // 
            this.dataGridViewExp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewExp.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewExp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewExp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExp.Location = new System.Drawing.Point(78, 382);
            this.dataGridViewExp.Name = "dataGridViewExp";
            this.dataGridViewExp.ReadOnly = true;
            this.dataGridViewExp.RowHeadersWidth = 62;
            this.dataGridViewExp.RowTemplate.Height = 28;
            this.dataGridViewExp.Size = new System.Drawing.Size(424, 272);
            this.dataGridViewExp.TabIndex = 11;
            // 
            // ExpCatMastFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 726);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridViewExp);
            this.Controls.Add(this.expCatAddBtn);
            this.Controls.Add(this.expCatDeleteBtn);
            this.Controls.Add(this.expCatUpdateBtn);
            this.Controls.Add(this.expTextBox);
            this.Controls.Add(this.expIdTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ExpCatMastFrm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ExpCatMastFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox expTextBox;
        private System.Windows.Forms.TextBox expIdTextBox;
        private System.Windows.Forms.Button expCatUpdateBtn;
        private System.Windows.Forms.Button expCatDeleteBtn;
        private System.Windows.Forms.Button expCatAddBtn;
        private System.Windows.Forms.DataGridView dataGridViewExp;
    }
}