using CoffeeShop.DTO;
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

		public Account GetAccountByUserName(string userName)
		{
			string query = "EXEC USP_GetAccountByUserName @userName";
			object[] param = new object[] { userName };

			DataTable table = DataProvider.Instance.ExecuteQuery(query, param);
			foreach (DataRow row in table.Rows)
			{
				return new Account(row);
			}

			return null;
		}
	}
}
