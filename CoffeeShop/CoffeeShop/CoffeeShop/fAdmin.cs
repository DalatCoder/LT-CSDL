using CoffeeShop.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
	public partial class fAdmin : Form
	{
		public fAdmin()
		{
			InitializeComponent();

			LoadState();
		}

		#region Methods	
		void LoadState()
		{
			LoadDateTimePickerBill();
			LoadListBillByDate(dtpFromDate.Value, dtpToDate.Value);
			LoadListFood();
		}

		void LoadDateTimePickerBill()
		{
			DateTime today = DateTime.Now;
			dtpFromDate.Value = new DateTime(today.Year, today.Month, 1);
			dtpToDate.Value = dtpFromDate.Value.AddMonths(1).AddDays(-1);
		}

		void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
		{
			dtgvBill.DataSource = BillDAO.Instance.GetBillListByDate(checkIn, checkOut);
		}

		void LoadListFood()
		{
			dgvFood.DataSource = FoodDAO.Instance.GetListFood();
		}

		#endregion


		#region Events
		private void btnViewBill_Click(object sender, EventArgs e)
		{
			LoadListBillByDate(dtpFromDate.Value, dtpToDate.Value);
		}
		#endregion

		private void btnViewFood_Click(object sender, EventArgs e)
		{
			LoadListFood();
		}
	}
}
