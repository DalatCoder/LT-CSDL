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
	public partial class AccountManagerForm : Form
	{
		public AccountManagerForm()
		{
			InitializeComponent();

			LoadAccount();
		}

		public void LoadAccount()
		{
			string connectionString = "server=.; database = RestaunrantManagement; Integrated Security = true; ";
			SqlConnection connection = new SqlConnection(connectionString);
			SqlCommand command = connection.CreateCommand();

			command.CommandText = "SELECT * FROM Account";

			connection.Open();

			string categoryName = command.ExecuteScalar().ToString();
			this.Text = "Danh sách toàn bộ tài khoản";

			SqlDataAdapter adapter = new SqlDataAdapter(command);

			DataTable table = new DataTable("Food");
			adapter.Fill(table);

			dgvAccount.DataSource = table;

			// Prevent user to edit ID
			dgvAccount.Columns[0].ReadOnly = true;

			connection.Close();
		}
	}
}
