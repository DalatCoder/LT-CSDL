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

			LoadDateTimePickerBill();
			LoadListBillByDate(dtpFromDate.Value, dtpToDate.Value);
		}

		#region Methods	
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

		#endregion


		#region Events
		private void btnViewBill_Click(object sender, EventArgs e)
		{
			LoadListBillByDate(dtpFromDate.Value, dtpToDate.Value);
		}
		#endregion
	}
}
