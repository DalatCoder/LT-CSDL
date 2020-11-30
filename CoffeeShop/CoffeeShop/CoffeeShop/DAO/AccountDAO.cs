using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.DAO
{
	public class AccountDAO
	{
		private AccountDAO() { }

		private static AccountDAO _instance;

		public static AccountDAO Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new AccountDAO();
				}
				return _instance;
			}
		}

		public bool Login(string userName, string password)
		{
			string query = "EXEC USP_Login @userName , @password";
			object[] param = new object[] { userName, password };
			DataTable result = DataProvider.Instance.ExecuteQuery(query, param);
			return result.Rows.Count > 0;
		}
	}
}
