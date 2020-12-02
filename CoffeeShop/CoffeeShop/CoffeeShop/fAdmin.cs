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
		BindingSource categoryList = new BindingSource();

		public Account LoginAccount;

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
			dgvCategory.DataSource = categoryList;

			LoadDateTimePickerBill();
			LoadListBillByDate(dtpFromDate.Value, dtpToDate.Value);
			LoadListFood();
			LoadListCategory();
			LoadAccount();
			LoadCategoryIntoCombobox(cbFoodCategory);
			AddFoodBinding();
			AddCategoryBinding();
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

		#region Category Methods

		void LoadListCategory()
		{
			categoryList.DataSource = CategoryDAO.Instance.GetListCategory();
		}

		void AddCategoryBinding()
		{
			txtCategoryId.DataBindings.Add(new Binding("Text", dgvCategory.DataSource, "ID", true, DataSourceUpdateMode.Never));
			txtCategoryName.DataBindings.Add(new Binding("Text", dgvCategory.DataSource, "Name", true, DataSourceUpdateMode.Never));
		}

		#endregion

		List<Food> SearchFoodByName(string name)
		{
			List<Food> listFood = FoodDAO.Instance.SearchFoodByName(name);
			return listFood;	
		}

		#region Account Methods

		void LoadAccount()
		{
			accountList.DataSource = AccountDAO.Instance.GetListAccount();
		}

		void AddAccountBinding()
		{
			txtUserName.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "UserName", true, DataSourceUpdateMode.Never));
			txtDisplayName.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
			nmAccountType.DataBindings.Add(new Binding("Text", dgvAccount.DataSource, "Type", true, DataSourceUpdateMode.Never));
		}

		void AddAccount(string userName, string displayNane, int type)
		{
			if (AccountDAO.Instance.Insert(userName, displayNane, type))
			{
				MessageBox.Show("Thêm tài khoản mới thành công");
				LoadAccount();
			}
			else
			{
				MessageBox.Show("Có lỗi trong quá trình thêm tài khoản");
			}

			LoadAccount();
		}

		void UpdateAccount(string userName, string displayNane, int type)
		{
			if (AccountDAO.Instance.Update(userName, displayNane, type))
			{
				MessageBox.Show("Cập nhât tài khoản thành công");
				LoadAccount();
			}
			else
			{
				MessageBox.Show("Có lỗi trong quá trình cập nhật tài khoản");
			}

			LoadAccount();
		}

		void DeleteAccount(string userName)
		{
			if (userName.Equals(LoginAccount.UserName))
			{
				MessageBox.Show("Tài khoản đang đăng nhập nên không thể xóa");
				return;
			}

			if (AccountDAO.Instance.Delete(userName))
			{
				MessageBox.Show("Xóa tài khoản thành công");
				LoadAccount();
			}
			else
			{
				MessageBox.Show("Có lỗi trong quá trình xóa tài khoản");
			}

			LoadAccount();
		}

		void ResetPassword(string userName)
		{
			if (AccountDAO.Instance.ResetPassword(userName))
			{
				MessageBox.Show("Đặt lại mật khẩu mặc định thành công");
				LoadAccount();
			}
			else
			{
				MessageBox.Show("Có lỗi trong quá trình đặt lại mật khẩu");
			}
		}

		#endregion

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

		private void btnAddAccount_Click(object sender, EventArgs e)
		{
			string userName = txtNewUserName.Text;
			string displayName = txtDisplayName.Text;
			int type = (int)nmAccountType.Value;

			AddAccount(userName, displayName, type);
		}

		private void btnEditAccount_Click(object sender, EventArgs e)
		{
			string userName = txtUserName.Text;
			string displayName = txtDisplayName.Text;
			int type = (int)nmAccountType.Value;

			UpdateAccount(userName, displayName, type);
		}

		private void btnDeleteAccount_Click(object sender, EventArgs e)
		{
			string userName = txtUserName.Text;

			DeleteAccount(userName);
		}
		#endregion

		private void btnResetPassword_Click(object sender, EventArgs e)
		{
			string userName = txtUserName.Text;

			ResetPassword(userName);
		}

		private void btnViewCategory_Click(object sender, EventArgs e)
		{
			LoadListCategory();
		}

		private event EventHandler insertCategoryEvent;
		public event EventHandler InsertCategoryEvent
		{
			add { insertCategoryEvent += value; }
			remove { insertCategoryEvent -= value; }
		}

		private event EventHandler updateCategoryEvent;
		public event EventHandler UpdateCategoryEvent
		{
			add { updateCategoryEvent += value; }
			remove { updateCategoryEvent -= value; }
		}

		private void btnAddCategory_Click(object sender, EventArgs e)
		{
			string name = txtCategoryName.Text;

			if (CategoryDAO.Instance.InsertCategory(name))
			{
				string msg = "Thêm nhóm thức ăn mới thành công";
				MessageBox.Show(msg);
				LoadListCategory();
				insertCategoryEvent?.Invoke(this, new EventArgs());
			}
			else
			{
				string msg = "Có lỗi xảy ra trong quá trình thêm nhóm thức ăn";
				MessageBox.Show(msg);
			}
		}

		private void btnEditCategory_Click(object sender, EventArgs e)
		{
			int id = int.Parse(txtCategoryId.Text);
			string name = txtCategoryName.Text;

			if (CategoryDAO.Instance.UpdateCategory(id, name))
			{
				MessageBox.Show("Cập nhật nhóm thức ăn thành công");
				LoadListCategory();
				updateCategoryEvent?.Invoke(this, new EventArgs());
			}
			else
			{
				MessageBox.Show("Có lỗi xảy ra trong quá trinh cập nhật món thức ăn");
			}
		}
	}
}