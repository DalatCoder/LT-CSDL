namespace Lab07_Advanced_Command_Execution
{
	partial class FormFoodInfo
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
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtUnit = new System.Windows.Forms.TextBox();
			this.txtNotes = new System.Windows.Forms.TextBox();
			this.cboCatName = new System.Windows.Forms.ComboBox();
			this.btnAddNew = new System.Windows.Forms.Button();
			this.btnAddFood = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnUpdateFood = new System.Windows.Forms.Button();
			this.nudPrice = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(42, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "FoodID";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 94);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(26, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Unit";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 129);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(77, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "CategoryName";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(12, 163);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(31, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Price";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(12, 193);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(35, 13);
			this.label6.TabIndex = 5;
			this.label6.Text = "Notes";
			// 
			// txtFoodId
			// 
			this.txtFoodId.Location = new System.Drawing.Point(108, 23);
			this.txtFoodId.Name = "txtFoodId";
			this.txtFoodId.ReadOnly = true;
			this.txtFoodId.Size = new System.Drawing.Size(216, 20);
			this.txtFoodId.TabIndex = 6;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(108, 57);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(473, 20);
			this.txtName.TabIndex = 7;
			// 
			// txtUnit
			// 
			this.txtUnit.Location = new System.Drawing.Point(108, 91);
			this.txtUnit.Name = "txtUnit";
			this.txtUnit.Size = new System.Drawing.Size(473, 20);
			this.txtUnit.TabIndex = 8;
			// 
			// txtNotes
			// 
			this.txtNotes.Location = new System.Drawing.Point(108, 190);
			this.txtNotes.Multiline = true;
			this.txtNotes.Name = "txtNotes";
			this.txtNotes.Size = new System.Drawing.Size(473, 65);
			this.txtNotes.TabIndex = 9;
			// 
			// cboCatName
			// 
			this.cboCatName.FormattingEnabled = true;
			this.cboCatName.Location = new System.Drawing.Point(108, 126);
			this.cboCatName.Name = "cboCatName";
			this.cboCatName.Size = new System.Drawing.Size(349, 21);
			this.cboCatName.TabIndex = 10;
			// 
			// btnAddNew
			// 
			this.btnAddNew.Location = new System.Drawing.Point(475, 126);
			this.btnAddNew.Name = "btnAddNew";
			this.btnAddNew.Size = new System.Drawing.Size(106, 23);
			this.btnAddNew.TabIndex = 11;
			this.btnAddNew.Text = "Add &New";
			this.btnAddNew.UseVisualStyleBackColor = true;
			// 
			// btnAddFood
			// 
			this.btnAddFood.Location = new System.Drawing.Point(108, 276);
			this.btnAddFood.Name = "btnAddFood";
			this.btnAddFood.Size = new System.Drawing.Size(106, 23);
			this.btnAddFood.TabIndex = 12;
			this.btnAddFood.Text = "&Add";
			this.btnAddFood.UseVisualStyleBackColor = true;
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(475, 276);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(106, 23);
			this.btnCancel.TabIndex = 13;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnUpdateFood
			// 
			this.btnUpdateFood.Location = new System.Drawing.Point(291, 276);
			this.btnUpdateFood.Name = "btnUpdateFood";
			this.btnUpdateFood.Size = new System.Drawing.Size(106, 23);
			this.btnUpdateFood.TabIndex = 14;
			this.btnUpdateFood.Text = "&Update";
			this.btnUpdateFood.UseVisualStyleBackColor = true;
			// 
			// nudPrice
			// 
			this.nudPrice.Location = new System.Drawing.Point(108, 161);
			this.nudPrice.Name = "nudPrice";
			this.nudPrice.Size = new System.Drawing.Size(473, 20);
			this.nudPrice.TabIndex = 15;
			// 
			// FormFoodInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(607, 311);
			this.Controls.Add(this.nudPrice);
			this.Controls.Add(this.btnUpdateFood);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnAddFood);
			this.Controls.Add(this.btnAddNew);
			this.Controls.Add(this.cboCatName);
			this.Controls.Add(this.txtNotes);
			this.Controls.Add(this.txtUnit);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.txtFoodId);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FormFoodInfo";
			this.Text = "FormFoodInfo";
			this.Load += new System.EventHandler(this.FormFoodInfo_Load);
			((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
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
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtUnit;
		private System.Windows.Forms.TextBox txtNotes;
		private System.Windows.Forms.ComboBox cboCatName;
		private System.Windows.Forms.Button btnAddNew;
		private System.Windows.Forms.Button btnAddFood;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnUpdateFood;
		private System.Windows.Forms.NumericUpDown nudPrice;
	}
}