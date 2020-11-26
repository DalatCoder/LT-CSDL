namespace Lab09_Entity_Framework
{
	partial class UpdateFoodForm
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
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtFoodId = new System.Windows.Forms.TextBox();
			this.txtFoodName = new System.Windows.Forms.TextBox();
			this.txtFoodUnit = new System.Windows.Forms.TextBox();
			this.txtFoodNotes = new System.Windows.Forms.TextBox();
			this.cbbFoodCategory = new System.Windows.Forms.ComboBox();
			this.nudFoodPrice = new System.Windows.Forms.NumericUpDown();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.nudFoodPrice)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(36, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Mã số";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tên món ăn";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 94);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(88, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Thuộc danh mục";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 131);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(60, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Đơn vị tính";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 169);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(44, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Đơn giá";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 214);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(71, 13);
			this.label6.TabIndex = 5;
			this.label6.Text = "Ghi chú khác";
			// 
			// txtFoodId
			// 
			this.txtFoodId.Location = new System.Drawing.Point(159, 20);
			this.txtFoodId.Name = "txtFoodId";
			this.txtFoodId.ReadOnly = true;
			this.txtFoodId.Size = new System.Drawing.Size(100, 20);
			this.txtFoodId.TabIndex = 6;
			// 
			// txtFoodName
			// 
			this.txtFoodName.Location = new System.Drawing.Point(159, 55);
			this.txtFoodName.Name = "txtFoodName";
			this.txtFoodName.Size = new System.Drawing.Size(358, 20);
			this.txtFoodName.TabIndex = 7;
			// 
			// txtFoodUnit
			// 
			this.txtFoodUnit.Location = new System.Drawing.Point(159, 128);
			this.txtFoodUnit.Name = "txtFoodUnit";
			this.txtFoodUnit.Size = new System.Drawing.Size(358, 20);
			this.txtFoodUnit.TabIndex = 8;
			// 
			// txtFoodNotes
			// 
			this.txtFoodNotes.Location = new System.Drawing.Point(159, 211);
			this.txtFoodNotes.Multiline = true;
			this.txtFoodNotes.Name = "txtFoodNotes";
			this.txtFoodNotes.Size = new System.Drawing.Size(358, 76);
			this.txtFoodNotes.TabIndex = 9;
			// 
			// cbbFoodCategory
			// 
			this.cbbFoodCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbbFoodCategory.FormattingEnabled = true;
			this.cbbFoodCategory.Location = new System.Drawing.Point(159, 91);
			this.cbbFoodCategory.Name = "cbbFoodCategory";
			this.cbbFoodCategory.Size = new System.Drawing.Size(358, 21);
			this.cbbFoodCategory.TabIndex = 10;
			// 
			// nudFoodPrice
			// 
			this.nudFoodPrice.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.nudFoodPrice.Location = new System.Drawing.Point(159, 167);
			this.nudFoodPrice.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
			this.nudFoodPrice.Name = "nudFoodPrice";
			this.nudFoodPrice.Size = new System.Drawing.Size(358, 20);
			this.nudFoodPrice.TabIndex = 11;
			this.nudFoodPrice.ThousandsSeparator = true;
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(442, 293);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 12;
			this.btnCancel.Text = "&Thoát";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnSave
			// 
			this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnSave.Location = new System.Drawing.Point(361, 293);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 13;
			this.btnSave.Text = "Lưu";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// UpdateFoodForm
			// 
			this.AcceptButton = this.btnSave;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(528, 323);
			this.ControlBox = false;
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.nudFoodPrice);
			this.Controls.Add(this.cbbFoodCategory);
			this.Controls.Add(this.txtFoodNotes);
			this.Controls.Add(this.txtFoodUnit);
			this.Controls.Add(this.txtFoodName);
			this.Controls.Add(this.txtFoodId);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "UpdateFoodForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Thêm/cập nhật món ăn";
			this.Load += new System.EventHandler(this.UpdateFoodForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.nudFoodPrice)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtFoodId;
		private System.Windows.Forms.TextBox txtFoodName;
		private System.Windows.Forms.TextBox txtFoodUnit;
		private System.Windows.Forms.TextBox txtFoodNotes;
		private System.Windows.Forms.ComboBox cbbFoodCategory;
		private System.Windows.Forms.NumericUpDown nudFoodPrice;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSave;
	}
}