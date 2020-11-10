namespace Lab06_Basic_Command
{
	partial class BillDetailsForm
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
			this.dgvBillDetails = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvBillDetails)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvBillDetails
			// 
			this.dgvBillDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvBillDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvBillDetails.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvBillDetails.Location = new System.Drawing.Point(0, 0);
			this.dgvBillDetails.MultiSelect = false;
			this.dgvBillDetails.Name = "dgvBillDetails";
			this.dgvBillDetails.Size = new System.Drawing.Size(800, 450);
			this.dgvBillDetails.TabIndex = 0;
			// 
			// BillDetailsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dgvBillDetails);
			this.Name = "BillDetailsForm";
			((System.ComponentModel.ISupportInitialize)(this.dgvBillDetails)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvBillDetails;
	}
}