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
		public frmFood()
		{
			InitializeComponent();
		}

		public void LoadFood(int categoryID)
		{
			string connectionString = "server=.; database = RestaunrantManagement; Integrated Security = true; ";
			SqlConnection connection = new SqlConnection(connectionString);
			SqlCommand command = connection.CreateCommand();

			command.CommandText = "SELECT Name FROM Category WHERE ID = " + categoryID;

			connection.Open();

			string categoryName = command.ExecuteScalar().ToString();
			this.Text = "Danh sách các món ăn thuộc nhóm: " + categoryName;

			command.CommandText = "SELECT * FROM Food WHERE FoodCategoryID = " + categoryID;

			SqlDataAdapter adapter = new SqlDataAdapter(command);

			DataTable table = new DataTable("Food");
			adapter.Fill(table);

			dgvFood.DataSource = table;

			connection.Close();
			connection.Dispose();
			adapter.Dispose();
		}
	}
}
