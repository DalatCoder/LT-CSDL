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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnLoad_Click(object sender, EventArgs e)
		{
			string connectionString = "server=.; database = RestaunrantManagement; Integrated Security = true; ";

			SqlConnection sqlConnection = new SqlConnection(connectionString);


			string query = "SELECT ID, NAME, TYPE FROM Category";

			SqlCommand sqlCommand = sqlConnection.CreateCommand();
			sqlCommand.CommandText = query;

			sqlConnection.Open();

			SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

			DisplayCategory(sqlDataReader);

			sqlConnection.Close();
		}

		private void DisplayCategory(SqlDataReader reader)
		{
			lvCategory.Items.Clear();

			while (reader.Read())
			{
				ListViewItem item = new ListViewItem(reader["ID"].ToString());

				item.SubItems.Add(reader["Name"].ToString());
				item.SubItems.Add(reader["Type"].ToString());

				lvCategory.Items.Add(item);
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			string connectionString = "server=.; database = RestaunrantManagement; Integrated Security = true; ";
			SqlConnection connection = new SqlConnection(connectionString);

			SqlCommand command = connection.CreateCommand();
			command.CommandText = $"INSERT INTO Category(Name, [Type]) VALUES (N'{txtName.Text}', {int.Parse(txtType.Text)})";

			connection.Open();

			int numOfRowsEffected = command.ExecuteNonQuery();

			connection.Close();

			if (numOfRowsEffected != 1)
			{
				MessageBox.Show("Có lỗi xảy ra.");
				return;
			}

			btnLoad.PerformClick();

			txtName.Text = "";
			txtType.Text = "";
		}

		private void lvCategory_Click(object sender, EventArgs e)
		{
			ListViewItem item = lvCategory.SelectedItems[0];

			txtID.Text = item.SubItems[0].Text;
			txtName.Text = item.SubItems[1].Text;
			txtType.Text = item.SubItems[2].Text == "0" ? "Thức uống" : "Đồ ăn";

			btnUpdate.Enabled = true;
			btnDelete.Enabled = true;
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			string connectionString = "server=.; database = RestaunrantManagement; Integrated Security = true; ";
			SqlConnection connection = new SqlConnection(connectionString);
			SqlCommand command = connection.CreateCommand();

			string name = txtName.Text;   
			string type = txtType.Text == "Thức uống" ? "0" : "1";
			string id = txtID.Text;

			command.CommandText = $"UPDATE Category SET Name = N'{name}', [Type] = {type} WHERE ID = {id}";

			connection.Open();

			int numOfRowsEffected = command.ExecuteNonQuery();

			if (numOfRowsEffected != 1)
			{
				MessageBox.Show("Có lỗi xảy ra");
				return;
			}

			ListViewItem item = lvCategory.SelectedItems[0];
			item.SubItems[1].Text = name;
			item.SubItems[2].Text = type;

			txtID.Text = "";
			txtName.Text = "";
			txtType.Text = "";

			btnUpdate.Enabled = false;
			btnDelete.Enabled = false;

			connection.Close();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			string connectionString = "server=.; database = RestaunrantManagement; Integrated Security = true; ";
			SqlConnection connection = new SqlConnection(connectionString);
			SqlCommand command = connection.CreateCommand();

			command.CommandText = $"DELETE FROM Category WHERE ID = {txtID.Text}";

			connection.Open();

			int numOfRowsEffected = command.ExecuteNonQuery();

			if (numOfRowsEffected != 1)
			{
				MessageBox.Show("Có lỗi xảy ra.");
				return;
			}

			lvCategory.Items.Remove(lvCategory.SelectedItems[0]);

			txtID.Text = "";
			txtName.Text = "";
			txtType.Text = "";

			btnUpdate.Enabled = false;
			btnDelete.Enabled = false;

			connection.Close();
		}

		private void tsmDelete_Click(object sender, EventArgs e)
		{
			if (lvCategory.SelectedItems.Count > 0)
				btnDelete.PerformClick();
		}

		private void tsmViewFood_Click(object sender, EventArgs e)
		{
			if(txtID.Text != "")
			{
				frmFood frmFood = new frmFood();
				frmFood.Show(this);
				frmFood.LoadFood(Convert.ToInt32(txtID.Text));
			}
		}

		private void btnBills_Click(object sender, EventArgs e)
		{
			BillsForm billsForm = new BillsForm();
			billsForm.ShowDialog();
		}

		private void btnAccount_Click(object sender, EventArgs e)
		{
			AccountManagerForm managerForm = new AccountManagerForm();
			managerForm.ShowDialog();
		}
	}
}
