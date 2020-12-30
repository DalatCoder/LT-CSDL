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
			string query = "SELECT * FROM [Table]";
			DataProvider provider = new DataProvider();

			DataTable table = provider.ExecuteQuery(query);

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
			string query = String.Format("" +
				"INSERT INTO [Table] (Name, Status, Capacity)" +
				"VALUES(N'{0}', {1}, {2})", tenBanAn, status, capacity
				).ToString();

			DataProvider provider = new DataProvider();
			int soDongBiTacDong = provider.ExecuteNonQuery(query);

			if (soDongBiTacDong > 0) return true;

			return false;
		}

		public bool CapNhatBanAn(int id, string tenBanAn, int status, int capacity)
		{
			string query = String.Format("" +
				"UPDATE [Table]" +
				"SET" +
				"	Name = N'{0}'," +
				"	Status = {1}," +
				"	Capacity = {2}" +
				"WHERE ID = {3}",
				tenBanAn, status, capacity, id
			).ToString();

			DataProvider provider = new DataProvider();
			int soDongBiTacDong = provider.ExecuteNonQuery(query);

			if (soDongBiTacDong > 0) return true;

			return false;
		}
	}
}
