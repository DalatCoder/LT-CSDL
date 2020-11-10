namespace Lab06_Basic_Command
{
	partial class AccountManagerForm
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
			this.dgvAccount = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvAccount
			// 
			this.dgvAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvAccount.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvAccount.Location = new System.Drawing.Point(0, 0);
			this.dgvAccount.Name = "dgvAccount";
			this.dgvAccount.ReadOnly = true;
			this.dgvAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvAccount.Size = new System.Drawing.Size(800, 450);
			this.dgvAccount.TabIndex = 0;
			// 
			// AccountManagerForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.dgvAccount);
			this.Name = "AccountManagerForm";
			this.Text = "AccountManagerForm";
			((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvAccount;
	}
}