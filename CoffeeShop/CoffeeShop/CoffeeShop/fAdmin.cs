using CoffeeShop.DAO;
using CoffeeShop.DTO;
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
		BindingSource accountList = new BindingSource();

		public fAdmin()
		{
			InitializeComponent();

			LoadState();
		}

		#region Methods	
		void LoadState()
		{
			dgvFood.DataSource = foodList;
			dgvAccount.DataSource = accountList;

			LoadDateTimePickerBill();
			LoadListBillByDate(dtpFromDate.Value, dtpToDate.Value);
			LoadListFood();
			LoadAccount();
			LoadCategoryIntoCombobox(cbFoodCategory);
			AddFoodBinding();
			AddAccountBinding();
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

		void AddAccountBinding()
		{
			txtUserName.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "UserName", true, DataSourceUpdateMode.Never));
			txtDisplayName.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
			txtAccountType.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "Type", true, DataSourceUpdateMode.Never));
		}

		List<Food> SearchFoodByName(string name)
		{
			List<Food> listFood = FoodDAO.Instance.SearchFoodByName(name);
			return listFood;	
		}

		void LoadAccount()
		{
			accountList.DataSource = AccountDAO.Instance.GetListAccount();
		}

		#endregion


		#region Events
		private void btnViewBill_Click(object sender, EventArgs e)
		{
			LoadListBillByDate(dtpFromDate.Value, dtpToDate.Value);
		}

		private void btnViewFood_Click(object sender, EventArgs e)
		{
			LoadListFood();
		}

		private void btnSearchFood_Click(object sender, EventArgs e)
		{
			foodList.DataSource = SearchFoodByName(txtSearchFoodName.Text);
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
				insertFood?.Invoke(this, new EventArgs());
			}
			else
			{
				MessageBox.Show("Có lỗi khi thêm món");
			}
		}

		private void btnEditFood_Click(object sender, EventArgs e)
		{
			string name = txtFoodName.Text;
			int categoryID = (int)cbFoodCategory.SelectedValue;
			float price = (float)nmFoodPrice.Value;
			int foodID = int.Parse(txtFoodId.Text);

			if (FoodDAO.Instance.UpdateFood(foodID, name, categoryID, price))
			{
				MessageBox.Show("Cập nhật món thành công");
				LoadListFood();
				updateFood?.Invoke(this, new EventArgs());
			}
			else
			{
				MessageBox.Show("Có lỗi khi cập nhật món");
			}
		}

		private void btnDeleteFood_Click(object sender, EventArgs e)
		{
			int foodID = int.Parse(txtFoodId.Text);

			if (FoodDAO.Instance.Delete(foodID))
			{
				MessageBox.Show("Xóa món thành công");
				LoadListFood();
				deleteFood?.Invoke(this, new EventArgs());
			}
			else
			{
				MessageBox.Show("Có lỗi khi xóa món");
			}
		}

		private event EventHandler insertFood;
		public event EventHandler InsertFood
		{
			add { insertFood += value; }
			remove { insertFood -= value; }
		}

		private event EventHandler updateFood;
		public event EventHandler UpdateFood
		{
			add { updateFood += value; }
			remove { updateFood -= value; }
		}

		private event EventHandler deleteFood;
		public event EventHandler DeleteFood
		{
			add { deleteFood += value; }
			remove { deleteFood -= value; }
		}

		private void btnViewAccount_Click(object sender, EventArgs e)
		{
			LoadAccount();
		}
		#endregion
	}
}