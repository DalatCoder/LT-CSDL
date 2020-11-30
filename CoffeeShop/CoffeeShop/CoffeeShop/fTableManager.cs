﻿using System;
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
	}
}
