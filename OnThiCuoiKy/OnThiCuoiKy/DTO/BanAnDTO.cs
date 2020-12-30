using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnThiCuoiKy.DTO
{
	public class BanAnDTO
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int Status { get; set; }
		public int Capacity { get; set; }

		public BanAnDTO()
		{

		}

		public BanAnDTO(int id, string name, int status, int capacity)
		{
			Id = id;
			Name = name;
			Status = status;
			Capacity = capacity;
		}
	}
}
