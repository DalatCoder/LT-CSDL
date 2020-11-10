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

namespace Lab06_Basic_Command
{
	public partial class frmFood : Form
	{
		int categoryID;

		public frmFood()
		{
			InitializeComponent();
		}

		public void LoadFood(int categoryID)
		{
			this.categoryID = categoryID;
			string connectionString = "server=.; database = RestaunrantManagement; Integrated Security = true; ";
			SqlConnection connection = new SqlConnection(connectionString);
			SqlCommand command = connection.CreateCommand();

			command.CommandText = "SELECT Name FROM Category WHERE ID = " + categoryID;

			connection.Open();

			string categoryName = command.ExecuteScalar().ToString();
			this.Text = "Danh sách các món ăn thuộc nhóm: " + categoryName;

			command.CommandText = "SELECT ID, Name, Unit, Price, Notes FROM Food WHERE FoodCategoryID = " + categoryID;

			SqlDataAdapter adapter = new SqlDataAdapter(command);

			DataTable table = new DataTable("Food");
			adapter.Fill(table);

			dgvFood.DataSource = table;

			// Prevent user to edit ID
			dgvFood.Columns[0].ReadOnly = true;

			connection.Close();
			connection.Dispose();
			adapter.Dispose();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (dgvFood.SelectedRows.Count == 0) return;

			var selectedRow = dgvFood.SelectedRows[0];

			string foodID = selectedRow.Cells[0].Value.ToString();

			string connectionString = "server=.; database = RestaunrantManagement; Integrated Security = true; ";
			SqlConnection connection = new SqlConnection(connectionString);
			SqlCommand command = connection.CreateCommand();

			string query = "DELETE FROM Food WHERE ID = " + foodID;
			command.CommandText = query;

			connection.Open();

			int numOfRowsEffected = command.ExecuteNonQuery();

			if (numOfRowsEffected != 1)
			{
				MessageBox.Show("Có lỗi xảy ra.");
				return;
			}

			dgvFood.Rows.Remove(selectedRow);

			connection.Close();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			string connectionString = "server=.; database = RestaunrantManagement; Integrated Security = true; ";
			SqlConnection connection = new SqlConnection(connectionString);
			SqlCommand command = connection.CreateCommand();

			connection.Open();

			command.CommandText = "DELETE FROM Food WHERE FoodCategoryID = " + categoryID;
			command.ExecuteNonQuery();

			for (int i = 0; i < dgvFood.Rows.Count - 1; i++)
			{
				string query = string.Format("" +
					"INSERT INTO Food(Name, Unit, FoodCategoryID, Price, Notes)" + " "+
					"VALUES (N'{0}', N'{1}', {2}, {3}, N'{4}')",
					dgvFood.Rows[i].Cells["Name"].Value,
					dgvFood.Rows[i].Cells["Unit"].Value,
					categoryID,
					dgvFood.Rows[i].Cells["Price"].Value,
					dgvFood.Rows[i].Cells["Notes"].Value).ToString();
				command.CommandText = query;
				command.ExecuteNonQuery();
			}

			connection.Close();
		}
	}
}
