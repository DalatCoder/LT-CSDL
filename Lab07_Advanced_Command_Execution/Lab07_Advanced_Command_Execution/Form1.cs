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

		private void tsmCaculateQuantity_Click(object sender, EventArgs e)
		{
			string connectionString = "server=.; database = RestaurantManagement; Integrated Security = true; ";
			SqlConnection connection = new SqlConnection(connectionString);
			SqlCommand command = connection.CreateCommand();
			command.CommandText = "SELECT @numSaleFood = sum(Quantity) FROM BillDetails WHERE FoodID = @foodId";

			if(dgvFoodList.SelectedRows.Count > 0)
			{
				DataGridViewRow selectedRow = dgvFoodList.SelectedRows[0];

				DataRowView rowView = selectedRow.DataBoundItem as DataRowView;

				command.Parameters.Add("@foodId", SqlDbType.Int);
				command.Parameters["@foodId"].Value = rowView["ID"];

				command.Parameters.Add("@numSaleFood", SqlDbType.Int);
				command.Parameters["@numSaleFood"].Direction = ParameterDirection.Output;

				connection.Open();

				command.ExecuteNonQuery();

				string result = command.Parameters["@numSaleFood"].Value.ToString();
				string message = $"Tổng số lượng món {rowView["Name"]} đã bán là {result} {rowView["Unit"]}";

				if (string.IsNullOrWhiteSpace(result))
					message = $"Món {rowView["Name"]} chưa bán được {rowView["Unit"]} nào!";

				MessageBox.Show(message);

				connection.Close();
			}

			command.Dispose();
			connection.Dispose();
		}

		private void tsmAddFood_Click(object sender, EventArgs e)
		{
			FormFoodInfo formFood = new FormFoodInfo();
			formFood.FormClosed += FormFood_FormClosed;

			formFood.Show(this);
		}

		private void FormFood_FormClosed(object sender, FormClosedEventArgs e)
		{
			int index = cboCategory.SelectedIndex;
			cboCategory.SelectedIndex = -1;
			cboCategory.SelectedIndex = index;
		}

		private void tsmUpdateFood_Click(object sender, EventArgs e)
		{
			if (dgvFoodList.SelectedRows.Count > 0)
			{
				DataGridViewRow selectedRow = dgvFoodList.SelectedRows[0];
				DataRowView rowView = selectedRow.DataBoundItem as DataRowView;

				FormFoodInfo foodForm = new FormFoodInfo();
				foodForm.FormClosed += new FormClosedEventHandler(FormFood_FormClosed);

				foodForm.Show(this);
				foodForm.DisplayFoodInfo(rowView);	
			}
		}

		private void txtSearchByName_TextChanged(object sender, EventArgs e)
		{
			if (foodTable == null) return;

			string filterExpression = $"Name LIKE '%{txtSearchByName.Text}%'";
			string sortExpression = "Price DESC";

			DataViewRowState rowStateFilter = DataViewRowState.OriginalRows;

			DataView foodView = new DataView(foodTable, filterExpression, sortExpression, rowStateFilter);

			dgvFoodList.DataSource = foodView;
		}
	}
}
