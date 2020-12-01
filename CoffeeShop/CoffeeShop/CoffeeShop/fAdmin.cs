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
		BindingSource foodList = new BindingSource();

		public fAdmin()
		{
			InitializeComponent();

			LoadState();
		}

		#region Methods	
		void LoadState()
		{
			dgvFood.DataSource = foodList;

			LoadDateTimePickerBill();
			LoadListBillByDate(dtpFromDate.Value, dtpToDate.Value);
			LoadListFood();
			LoadCategoryIntoCombobox(cbFoodCategory);
			AddFoodBinding();
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

		void LoadCategoryIntoCombobox(ComboBox cb)
		{
			cb.DataSource = CategoryDAO.Instance.GetListCategory();
			cb.DisplayMember = "Name";
			cb.ValueMember = "ID";
		}

		void LoadListFood()
		{
			foodList.DataSource = FoodDAO.Instance.GetListFood();
		}

		void AddFoodBinding()
		{
			// DataSourceUpdateMode.Never: đi 1 luồng, one way binding
			txtFoodName.DataBindings.Add(new Binding("Text", dgvFood.DataSource, "Name", true, DataSourceUpdateMode.Never));
			txtFoodId.DataBindings.Add(new Binding("Text", dgvFood.DataSource, "ID", true, DataSourceUpdateMode.Never));
			nmFoodPrice.DataBindings.Add(new Binding("Value", dgvFood.DataSource, "Price", true, DataSourceUpdateMode.Never));
			cbFoodCategory.DataBindings.Add(new Binding("SelectedValue", dgvFood.DataSource, "CategoryID", true, DataSourceUpdateMode.Never));
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

		private void btnAddFood_Click(object sender, EventArgs e)
		{
			string name = txtFoodName.Text;
			int categoryID = (int)cbFoodCategory.SelectedValue;
			float price = (float)nmFoodPrice.Value;

			if (FoodDAO.Instance.InsertFood(name, categoryID, price))
			{
				MessageBox.Show("Thêm món thành công");
				LoadListFood();
			}
			else
			{
				MessageBox.Show("Có lỗi khi thêm món");
			}
		}
	}
}