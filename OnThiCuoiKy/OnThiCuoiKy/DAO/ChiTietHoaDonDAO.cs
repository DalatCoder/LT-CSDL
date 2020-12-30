using OnThiCuoiKy.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnThiCuoiKy.DAO
{
	public class ChiTietHoaDonDAO
	{
		public List<ChiTietHoaDonDTO> LayChiTietHoaDonTheoBan(int tableId)
		{
			string query = String.Format(
				"SELECT [Table].ID, Food.Name, Food.Unit, Food.Price, BillDetails.Quantity, (Food.Price * BillDetails.Quantity) AS Total " +
				"FROM[Table] " +
				"JOIN Bills ON[Table].ID = Bills.TableID " +
				"JOIN BillDetails ON Bills.ID = BillDetails.InvoiceID " +
				"JOIN Food ON Food.ID = BillDetails.FoodID " +
				"WHERE[Table].ID = {0}", tableId
				).ToString();

			DataProvider provider = new DataProvider();

			DataTable table = provider.ExecuteQuery(query);

			List<ChiTietHoaDonDTO> dsChiTietHoaDon = new List<ChiTietHoaDonDTO>();

			foreach (DataRow row in table.Rows)
			{
				int id = Convert.ToInt32(row["ID"]);
				string name = row["Name"].ToString();
				string unit = row["Unit"].ToString();
				decimal price = Convert.ToDecimal(row["Price"]);
				int quantity = Convert.ToInt32(row["Quantity"]);
				decimal total = Convert.ToDecimal(row["Total"]);

				ChiTietHoaDonDTO chiTietHoadon = new ChiTietHoaDonDTO(id, name, unit, price, quantity, total);
				dsChiTietHoaDon.Add(chiTietHoadon);
			}

			return dsChiTietHoaDon;
		}
	}
}
