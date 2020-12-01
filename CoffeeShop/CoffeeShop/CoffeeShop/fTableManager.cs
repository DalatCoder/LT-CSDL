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
		public fTableManager()
		{
			InitializeComponent();

			LoadTable();
		}

		#region Method

		void LoadTable()
		{
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
			int tableID = ((sender as Button).Tag as Table).ID;
			ShowBill(tableID);
		}

		private void menuLogOut_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void menuPersonalInfo_Click(object sender, EventArgs e)
		{
			fAccountProfile f = new fAccountProfile();
			f.ShowDialog();
		}

		private void menuAdmin_Click(object sender, EventArgs e)
		{
			fAdmin f = new fAdmin();
			f.ShowDialog();
		}
		#endregion
	}
}
