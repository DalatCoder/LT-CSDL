using OnThiCuoiKy.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnThiCuoiKy.DAO
{
	public class BanAnDAO
	{
		public List<BanAnDTO> LayDSBanAn()
		{
			string connectionString = "Data Source=.;Initial Catalog=RestaurantManagement;Integrated Security=True";

			string query = "SELECT * FROM [Table]";

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

			List<BanAnDTO> dsBanAn = new List<BanAnDTO>();

			foreach(DataRow row in table.Rows)
			{
				int id = Convert.ToInt32(row["ID"]);
				string name = row["Name"].ToString();
				int status = Convert.ToInt32(row["Status"]);
				int capacity = Convert.ToInt32(row["Capacity"]);

				var banAnMoi = new BanAnDTO(id, name, status, capacity);

				dsBanAn.Add(banAnMoi);
			}

			return dsBanAn;
		}
	
		public bool TaoBanAn(string tenBanAn, int status, int capacity)
		{
			string connectionString = "Data Source=.;Initial Catalog=RestaurantManagement;Integrated Security=True";

			string query = String.Format("" +
				"INSERT INTO [Table] (Name, Status, Capacity)" +
				"VALUES(N'{0}', {1}, {2})", tenBanAn, status, capacity
				).ToString();

			SqlConnection connection = new SqlConnection(connectionString);

			SqlCommand command = new SqlCommand();
			command.Connection = connection;
			command.CommandText = query;

			connection.Open();

			int soDongBiTacDong = command.ExecuteNonQuery();

			connection.Close();
			connection.Dispose();

			if (soDongBiTacDong > 0) return true;

			return false;
		}
	}
}
