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
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvFood)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvFood
			// 
			this.dgvFood.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvFood.Location = new System.Drawing.Point(0, 55);
			this.dgvFood.MultiSelect = false;
			this.dgvFood.Name = "dgvFood";
			this.dgvFood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvFood.Size = new System.Drawing.Size(883, 410);
			this.dgvFood.TabIndex = 0;
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(726, 12);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(144, 23);
			this.btnDelete.TabIndex = 1;
			this.btnDelete.Text = "Xóa món ăn được chọn";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(576, 12);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(144, 23);
			this.btnSave.TabIndex = 2;
			this.btnSave.Text = "Lưu danh sách sản phẩm";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// frmFood
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(882, 465);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.dgvFood);
			this.Name = "frmFood";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FoodForm";
			((System.ComponentModel.ISupportInitialize)(this.dgvFood)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvFood;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnSave;
	}
}