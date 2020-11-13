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
	public partial class Form1 : Form
	{
		private DataTable foodTable;	

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			LoadCategory();
		}

		private void LoadCategory()
		{
			string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true; ";
			SqlConnection connection = new SqlConnection(connectionString);
			SqlCommand command = connection.CreateCommand();

			connection.Open();

			command.CommandText = "SELECT ID, Name FROM Category";
			SqlDataAdapter adapter = new SqlDataAdapter(command);
			DataTable table = new DataTable("Category");

			adapter.Fill(table);

			cboCategory.DataSource = table;
			cboCategory.DisplayMember = "Name";
			cboCategory.ValueMember = "ID";

			connection.Close();
			connection.Dispose();
		}

		private void cboCategory_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cboCategory.SelectedIndex == -1) return;

			string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true; ";
			SqlConnection connection = new SqlConnection(connectionString);
			SqlCommand command = connection.CreateCommand();

			command.CommandText = "SELECT * FROM Food WHERE FoodCategoryID = @categoryId";
			command.Parameters.Add("@categoryId", SqlDbType.Int);

			if (cboCategory.SelectedValue is DataRowView)
			{
				DataRowView rowView = cboCategory.SelectedValue as DataRowView;
				command.Parameters["@categoryId"].Value = rowView["ID"];
			}
			else
			{
				command.Parameters["@categoryId"].Value = cboCategory.SelectedValue;
			}

			SqlDataAdapter adapter = new SqlDataAdapter(command);
			foodTable = new DataTable();

			connection.Open();

			adapter.Fill(foodTable);

			connection.Close();
			connection.Dispose();

			dgvFoodList.DataSource = foodTable;

			lblQuantity.Text = foodTable.Rows.Count.ToString();
			lblCatName.Text = cboCategory.Text;
		}
	}
}
