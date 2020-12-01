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
	public class AccountEvent : EventArgs
	{
		private Account acc;

		public AccountEvent(Account acc)
		{
			this.acc = acc;
		}

		public Account Acc { get => acc; set => acc = value; }
	}

	public partial class fAccountProfile : Form
	{
		private Account account;
		private EventHandler<AccountEvent> updateAccountEvent;

		public event EventHandler<AccountEvent> UpdateAccountEvent
		{
			add { updateAccountEvent += value; }
			remove { updateAccountEvent -= value; }
		}

		public fAccountProfile(Account acc)
		{
			account = acc;
			InitializeComponent();
			LoadAccount(account);	
		}
		
		void LoadAccount(Account account)
		{
			txtDisplayName.Text = account.DisplayName;
			txtUserName.Text = account.UserName;
		}

		void UpdateAccount()
		{
			string displayName = txtDisplayName.Text;
			string password = txtPassWord.Text;
			string newpass = txtPasswordNew.Text;
			string newpass2 = txtPasswordNew2.Text;
			string username = txtUserName.Text;

			if (!newpass.Equals(newpass2))
			{
				MessageBox.Show("Vui lòng nhập lại mật khẩu đúng với mật khẩu mới");
				return;
			}

			bool isSuccess = AccountDAO.Instance.UpdateAccount(username, displayName, password, newpass);
			if (isSuccess)
			{
				MessageBox.Show("Cập nhật thông tin tài khoản thành công");
				updateAccountEvent?.Invoke(this, new AccountEvent(AccountDAO.Instance.GetAccountByUserName(username)));
			}
			else
				MessageBox.Show("Vui lòng điền đúng mật khẩu hiện tại");
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			UpdateAccount();
		}
	}
}
