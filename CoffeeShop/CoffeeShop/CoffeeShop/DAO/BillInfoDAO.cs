using CoffeeShop.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.DAO
{
	public class BillInfoDAO
	{
		private static BillInfoDAO _instance;

		public static BillInfoDAO Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new BillInfoDAO();
				}
				return _instance;
			}
		}

		private BillInfoDAO() { }

		public List<BillInfo> GetListBillInfo(int billID)
		{
			List<BillInfo> billInfos = new List<BillInfo>();
			string query = "EXEC USP_GetBillInfosByBillID @billID";
			object[] param = new object[] { billID };

			DataTable table = DataProvider.Instance.ExecuteQuery(query, param);

			foreach (DataRow row in table.Rows)
			{
				billInfos.Add(new BillInfo(row));
			}

			return billInfos;
		}
	}
}
