using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab07_Advanced_Command_Execution
{
	public partial class FormFoodInfo : Form
	{
		public FormFoodInfo()
		{
			InitializeComponent();
		}

		private void FormFoodInfo_Load(object sender, EventArgs e)
		{
			InitValues();
		}

		private void InitValues()
		{
			string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true; ";
			SqlConnection connection = new SqlConnection(connectionString);
			
			SqlCommand command = connection.CreateCommand();
			command.CommandText = "SELECT ID, Name FROM Category";

			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataSet dataset = new DataSet();

			connection.Open();

			adapter.Fill(dataset, "Category");

			cboCatName.DataSource = dataset.Tables["Category"];
			cboCatName.DisplayMember = "Name";
			cboCatName.ValueMember = "ID";

			connection.Close();
			connection.Dispose();
		}

		private void ResetText()
		{
			txtFoodId.ResetText();
			txtName.ResetText();
			txtNotes.ResetText();
			txtUnit.ResetText();
			cboCatName.ResetText();
			nudPrice.ResetText();
		}

		private void btnAddFood_Click(object sender, EventArgs e)
		{
			try
			{
				string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true; ";
				SqlConnection connection = new SqlConnection(connectionString);

				SqlCommand command = connection.CreateCommand();
				command.CommandText = "EXECUTE InsertFood @id OUTPUT, @name, @unit, @foodCategoryID, @price, @notes";

				command.Parameters.Add("@id", SqlDbType.Int);
				command.Parameters.Add("@name", SqlDbType.NVarChar, 1000);
				command.Parameters.Add("@unit", SqlDbType.NVarChar, 100);
				command.Parameters.Add("@foodCategoryID", SqlDbType.Int);
				command.Parameters.Add("@price", SqlDbType.Int);
				command.Parameters.Add("@notes", SqlDbType.NVarChar, 3000);

				command.Parameters["@id"].Direction = ParameterDirection.Output;

				command.Parameters["@name"].Value = txtName.Text;
				command.Parameters["@unit"].Value = txtUnit.Text;
				command.Parameters["@foodCategoryID"].Value = cboCatName.SelectedValue;
				command.Parameters["@price"].Value = nudPrice.Value;
				command.Parameters["@notes"].Value = txtNotes.Text;

				connection.Open();

				int numRowAffected = command.ExecuteNonQuery();

				if (numRowAffected > 0)
				{
					string foodID = command.Parameters["@id"].Value.ToString();
					MessageBox.Show($"Successfully adding new food. Food ID = {foodID}", "Message");
					this.ResetText();
				}
				else
				{
					MessageBox.Show("Adding food fail");
				}

				connection.Close();
				connection.Dispose();
			}
			catch(SqlException exception)
			{
				MessageBox.Show(exception.Message, "SQL Error");
			}
			catch(Exception exception)
			{
				MessageBox.Show(exception.Message, "Error");
			}
		}
	
		public void DisplayFoodInfo(DataRowView rowView)
		{
			try
			{
				txtFoodId.Text = rowView["ID"].ToString();
				txtName.Text = rowView["Name"].ToString();
				txtUnit.Text = rowView["Unit"].ToString();
				txtNotes.Text = rowView["Notes"].ToString();
				nudPrice.Value = decimal.Parse(rowView["Price"].ToString());

				cboCatName.SelectedIndex = -1;

				for (int index = 0; index < cboCatName.Items.Count; index++)
				{
					DataRowView cat = cboCatName.Items[index] as DataRowView;
					if (cat["ID"].ToString() == rowView["FoodCategoryID"].ToString())
					{
						cboCatName.SelectedIndex = index;
						break;
					}
				}
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message, "Error");
				this.Close();
			}
		}

		private void btnUpdateFood_Click(object sender, EventArgs e)
		{
			try
			{
				string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true; ";
				SqlConnection connection = new SqlConnection(connectionString);

				SqlCommand command = connection.CreateCommand();
				command.CommandText = "EXECUTE UpdateFood @id, @name, @unit, @foodCategoryID, @price, @notes";

				command.Parameters.Add("@id", SqlDbType.Int);
				command.Parameters.Add("@name", SqlDbType.NVarChar, 1000);
				command.Parameters.Add("@unit", SqlDbType.NVarChar, 100);
				command.Parameters.Add("@foodCategoryID", SqlDbType.Int);
				command.Parameters.Add("@price", SqlDbType.Int);
				command.Parameters.Add("@notes", SqlDbType.NVarChar, 3000);

				command.Parameters["@id"].Value = int.Parse(txtFoodId.Text);
				command.Parameters["@name"].Value = txtName.Text;
				command.Parameters["@unit"].Value = txtUnit.Text;
				command.Parameters["@foodCategoryID"].Value = cboCatName.SelectedValue;
				command.Parameters["@price"].Value = nudPrice.Value;
				command.Parameters["@notes"].Value = txtNotes.Text;

				connection.Open();

				int numRowAffected = command.ExecuteNonQuery();

				if (numRowAffected > 0)
				{
					MessageBox.Show("Successfully updating food", "Message");
					this.ResetText();
				}
				else
				{
					MessageBox.Show("Updating food failed");
				}

				connection.Close();
				connection.Dispose();
			}
			catch(SqlException exception)
			{
				MessageBox.Show(exception.Message, "SQL Error");
			}
			catch(Exception exception)
			{
				MessageBox.Show(exception.Message, "Error");
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
