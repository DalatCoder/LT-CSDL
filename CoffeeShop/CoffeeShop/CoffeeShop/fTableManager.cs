using CoffeeShop.DAO;
using CoffeeShop.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
	public partial class fTableManager : Form
	{
		private Account account;
		public Table CurerntTable { get => lvFood.Tag as Table; }

		public fTableManager(Account acc)
		{
			account = acc;
			InitializeComponent();

			ChangeAccount();
			LoadTable();
			LoadCategory();
		}

		#region Method

		void ChangeAccount()
		{
			menuAdmin.Enabled = account.Type == 1;
			thôngTinTàiKhoảnToolStripMenuItem.Text += $" ({account.DisplayName})";
		}

		void LoadCategory()
		{
			List<Category> categories = CategoryDAO.Instance.GetListCategory();
			cbCategory.DataSource = categories;
			cbCategory.DisplayMember = "Name";
		}

		void LoadFoodListByCategoryID(int catID)
		{
			List<Food> foods = FoodDAO.Instance.GetFoodsByCategoryID(catID);
			cbFood.DataSource = foods;
			cbFood.DisplayMember = "Name";
		}

		void LoadTable()
		{
			fpTable.Controls.Clear();
			List<Table> tableList = TableDAO.Instance.LoadTableList();

			foreach (Table table in tableList)
			{
				Button btn = new Button()
				{
					Width = TableDAO.TableWidth,
					Height = TableDAO.TableHeight
				};
				btn.Text = table.Name + Environment.NewLine + table.Status;
				btn.Tag = table;

				switch (table.Status)
				{
					case "Trống":
						btn.BackColor = Color.Aqua;
						break;

					default:
						btn.BackColor = Color.LightPink;
						break;
				}

				btn.Click += Btn_Click;
				fpTable.Controls.Add(btn);
			}
		}

		void ShowBill(int tableId)
		{
			List<DTO.Menu> listMenu = MenuDAO.Instance.GetListMenuByTable(tableId);
			float totalPrice = 0;

			lvFood.Items.Clear();
			foreach (DTO.Menu item in listMenu)
			{
				ListViewItem lsvItem = new ListViewItem(item.FoodName);
				lsvItem.SubItems.Add(item.Count.ToString());
				lsvItem.SubItems.Add(item.Price.ToString());
				lsvItem.SubItems.Add(item.TotalPrice.ToString("###,###,###"));
				lvFood.Items.Add(lsvItem);

				totalPrice += item.TotalPrice;
			}

			CultureInfo culture = new CultureInfo("vi-VN");
			// Thread.CurrentThread.CurrentCulture = culture;
			txtTotalPrice.Text = totalPrice.ToString("c", culture);
		}
		#endregion


		#region Events
		private void Btn_Click(object sender, EventArgs e)
		{
			Table currentTable = (sender as Button).Tag as Table;
			int tableID = currentTable.ID;
			lvFood.Tag = currentTable; // Lưu trữ bàn hiện tại vào tag của listview để dễ sử dụng 

			ShowBill(tableID);
		}

		private void menuLogOut_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void menuPersonalInfo_Click(object sender, EventArgs e)
		{
			fAccountProfile f = new fAccountProfile(account);
			f.UpdateAccountEvent += F_UpdateAccountEvent;
			f.ShowDialog();
		}

		private void F_UpdateAccountEvent(object sender, AccountEvent e)
		{
			this.thôngTinTàiKhoảnToolStripMenuItem.Text = $"Thông tin tài khoản ({e.Acc.DisplayName})";
		}

		private void menuAdmin_Click(object sender, EventArgs e)
		{
			fAdmin f = new fAdmin();
			f.LoginAccount = account;
			f.InsertFood += F_InsertFood;
			f.UpdateFood += F_UpdateFood;
			f.DeleteFood += F_DeleteFood;
			f.InsertCategoryEvent += F_InsertCategoryEvent;
			f.UpdateCategoryEvent += F_UpdateCategoryEvent;
			f.InsertTableEvent += F_InsertTableEvent;
			f.UpdateTableEvent += F_UpdateTableEvent;
			f.ShowDialog();
		}

		private void F_UpdateTableEvent(object sender, EventArgs e)
		{
			LoadTable();
		}

		private void F_InsertTableEvent(object sender, EventArgs e)
		{
			LoadTable();
		}

		private void F_UpdateCategoryEvent(object sender, EventArgs e)
		{
			LoadCategory();
		}

		private void F_InsertCategoryEvent(object sender, EventArgs e)
		{
			LoadCategory();
		}

		private void F_DeleteFood(object sender, EventArgs e)
		{
			LoadFoodListByCategoryID((cbCategory.SelectedItem as Category).ID);
			if (this.CurerntTable != null)
			{
				ShowBill(this.CurerntTable.ID);
				LoadTable();
			}
		}

		private void F_UpdateFood(object sender, EventArgs e)
		{
			LoadFoodListByCategoryID((cbCategory.SelectedItem as Category).ID);
			if (this.CurerntTable != null)
				ShowBill(this.CurerntTable.ID);
		}

		private void F_InsertFood(object sender, EventArgs e)
		{
			LoadFoodListByCategoryID((cbCategory.SelectedItem as Category).ID);
			if (this.CurerntTable != null)
				ShowBill(this.CurerntTable.ID);
		}

		private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
		{
			int id = 0;

			ComboBox cb = sender as ComboBox;

			if (cb.SelectedItem == null)
				return;

			Category selected = cb.SelectedItem as Category;
			id = selected.ID;

			LoadFoodListByCategoryID(id);
		}
		#endregion

		private void btnAdd_Click(object sender, EventArgs e)
		{
			if (this.CurerntTable == null)
			{
				MessageBox.Show("Hãy chọn bàn cần thêm món");
				return;
			}

			Table table = this.CurerntTable;

			int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
			int idFood = (cbFood.SelectedItem as Food).ID;
			int count = (int)nmAmount.Value;

			if (idBill == -1)
			{
				BillDAO.Instance.InsertBill(table.ID);
				idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
			}

			BillInfoDAO.Instance.InsertBillInfo(idBill, idFood, count);

			ShowBill(table.ID);
			LoadTable();
		}

		private void btnCheckout_Click(object sender, EventArgs e)
		{
			if (this.CurerntTable == null) return;

			int billID = BillDAO.Instance.GetUncheckBillIDByTableID(this.CurerntTable.ID);
			int discount = (int)nmDiscount.Value;
			double totalPrice = Convert.ToDouble(txtTotalPrice.Text.Replace(".", string.Empty).Split(',')[0]);
			double finalTotalPrice = totalPrice - (totalPrice * discount / 100);

			if (billID != -1)
			{
				StringBuilder builder = new StringBuilder();
				builder.AppendLine($"Bạn có chắc chắn thanh toán hóa đơn cho {this.CurerntTable.Name} ?");
				builder.AppendLine($"Tổng tiền ban đầu: {totalPrice}");
				builder.AppendLine($"Discount: {discount}%");
				builder.AppendLine($"Tổng tiền sau khi giảm giá: {finalTotalPrice}");
				string msg = builder.ToString();

				DialogResult result = MessageBox.Show(msg, "Thông báo", MessageBoxButtons.OKCancel);
				if (result == DialogResult.OK)
				{
					BillDAO.Instance.Checkout(billID, discount, (float)finalTotalPrice);
					ShowBill(this.CurerntTable.ID);
				}
			}

			LoadTable();
		}

		private void thêmMónToolStripMenuItem_Click(object sender, EventArgs e)
		{
			btnAdd.PerformClick();
		}

		private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
		{
			btnCheckout.PerformClick();
		}
	}
}
