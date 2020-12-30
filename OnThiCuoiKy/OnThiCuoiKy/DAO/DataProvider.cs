using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnThiCuoiKy.DAO
{
	public class DataProvider
	{
		string connectionString = "Data Source=.;Initial Catalog=RestaurantManagement;Integrated Security=True";

		public DataTable ExecuteQuery(string query)
		{
			SqlConnection connection = new SqlConnection(connectionString);

			SqlCommand command = new SqlCommand();
			command.Connection = connection;
			command.CommandText = query;

			connection.Open();

			DataTable table = new DataTable();

			SqlDataAdapter adapter = new SqlDataAdapter(command);
			adapter.Fill(table);

			connection.Close();
			connection.Dispose();

			return table;
		}

		public int ExecuteNonQuery(string query)
		{
			SqlConnection connection = new SqlConnection(connectionString);

			SqlCommand command = new SqlCommand();
			command.Connection = connection;
			command.CommandText = query;

			connection.Open();

			int soDongBiTacDong = command.ExecuteNonQuery();

			connection.Close();
			connection.Dispose();

			return soDongBiTacDong;
		}

		public object ExecuteScalar(string query)
		{
			SqlConnection connection = new SqlConnection(connectionString);

			SqlCommand command = new SqlCommand();
			command.Connection = connection;
			command.CommandText = query;

			connection.Open();

			object ketQua = command.ExecuteScalar();

			connection.Close();
			connection.Dispose();

			return ketQua;
		}
	}
}
