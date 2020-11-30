using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.DTO
{
	public class Bill
	{
		private int iD;
		private DateTime? dateCheckIn;
		private DateTime? dateCheckOut;
		private int status;

		public int ID { get => iD; set => iD = value; }
		public DateTime? DateCheckIn { get => dateCheckIn; set => dateCheckIn = value; }
		public DateTime? DateCheckOut { get => dateCheckOut; set => dateCheckOut = value; }
		public int Status { get => status; set => status = value; }

		public Bill(int iD, DateTime? dateCheckIn, DateTime? dateCheckOut, int status)
		{
			ID = iD;
			DateCheckIn = dateCheckIn;
			DateCheckOut = dateCheckOut;
			Status = status;
		}

		public Bill(DataRow row)
		{
			ID = (int)row["id"];
			DateCheckIn = (DateTime?)row["DateCheckIn"];

			if(!string.IsNullOrWhiteSpace(row["DateCheckOut"].ToString()))
				DateCheckOut = (DateTime?)row["DateCheckOut"];

			Status = (int)row["status"];
		}
	}
}
