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
	}
}
