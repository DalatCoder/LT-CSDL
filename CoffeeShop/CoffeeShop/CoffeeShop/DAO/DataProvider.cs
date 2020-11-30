using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.DAO
{
	public class DataProvider
	{
		private readonly string connectionSTR;
		public DataProvider()
		{
			connectionSTR = "Data Source=.;Initial Catalog=CoffeeShop;Integrated Security=True";
		}

		public DataTable ExecuteQuery(string query, object[] parameter = null)
		{
			DataTable data = new DataTable();

			using (SqlConnection connection = new SqlConnection(connectionSTR))
			{
				connection.Open();

				SqlCommand command = new SqlCommand(query, connection);

				if (parameter != null)
				{
					string[] listParams = query.Split(' ');
					int i = 0;

					foreach (string item in listParams)
					{
						if (item.StartsWith("@"))
						{
							command.Parameters.AddWithValue(item, parameter[i]);
							i += 1;
						}
					}
				}

				SqlDataAdapter adapter = new SqlDataAdapter(command);

				adapter.Fill(data);

				connection.Close();
			}

			return data;
		}
	}
}
