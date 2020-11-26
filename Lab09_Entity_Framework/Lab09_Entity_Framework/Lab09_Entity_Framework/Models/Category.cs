using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_Entity_Framework.Models
{
	public class Category
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public CategoryType Type { get; set; }
	}

	public enum CategoryType
	{
		Drink,
		Food
	}
}
