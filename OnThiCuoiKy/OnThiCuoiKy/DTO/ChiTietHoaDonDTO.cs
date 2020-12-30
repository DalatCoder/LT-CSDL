using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnThiCuoiKy.DTO
{
	public class ChiTietHoaDonDTO
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Unit { get; set; }
		public decimal Price { get; set; }
		public int Quantity { get; set; }
		public decimal Total { get; set; }

		public ChiTietHoaDonDTO()
		{

		}

		public ChiTietHoaDonDTO(int id, string name, string unit, decimal price, int quantity, decimal total)
		{
			Id = id;
			Name = name;
			Unit = unit;
			Price = price;
			Quantity = quantity;
			Total = total;
		}
	}
}
