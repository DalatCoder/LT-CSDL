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
	}
}
