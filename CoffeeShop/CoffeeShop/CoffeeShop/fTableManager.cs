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

				switch (table.Status)
				{
					case "Trống":
						btn.BackColor = Color.Aqua;
						break;

					default:
						btn.BackColor = Color.LightPink;
						break;
				}

				fpTable.Controls.Add(btn);
			}
		}

		#endregion

		#region events
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
