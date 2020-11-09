namespace Lab06_Basic_Command
{
	partial class frmFood
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
			this.dgvFood = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvFood)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvFood
			// 
			this.dgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvFood.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvFood.Location = new System.Drawing.Point(0, 0);
			this.dgvFood.Name = "dgvFood";
			this.dgvFood.Size = new System.Drawing.Size(632, 380);
			this.dgvFood.TabIndex = 0;
			// 
			// frmFood
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(632, 380);
			this.Controls.Add(this.dgvFood);
			this.Name = "frmFood";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FoodForm";
			((System.ComponentModel.ISupportInitialize)(this.dgvFood)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvFood;
	}
}