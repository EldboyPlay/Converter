﻿namespace Converter {
	partial class Form2 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.POut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PIn,
            this.NumberIn,
            this.POut,
            this.Result});
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(823, 322);
            this.dataGridView1.TabIndex = 2;
            // 
            // PIn
            // 
            this.PIn.HeaderText = "Основание исх.числа";
            this.PIn.Name = "PIn";
            this.PIn.ReadOnly = true;
            this.PIn.Width = 128;
            // 
            // NumberIn
            // 
            this.NumberIn.HeaderText = "Исходное число";
            this.NumberIn.Name = "NumberIn";
            this.NumberIn.ReadOnly = true;
            this.NumberIn.Width = 104;
            // 
            // POut
            // 
            this.POut.HeaderText = "Основание результата";
            this.POut.Name = "POut";
            this.POut.ReadOnly = true;
            this.POut.Width = 135;
            // 
            // Result
            // 
            this.Result.HeaderText = "Результат";
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            this.Result.Width = 84;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Converter.Properties.Resources.Фон_главного_меню;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(848, 345);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "История";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

		}
        // Элементы кнопок второй формы
		#endregion
		public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn POut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
    }
}