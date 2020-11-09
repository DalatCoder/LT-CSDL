using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05_Winform_Complete
{
	public partial class Form1 : Form
	{
		private StudentManager studentManager;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			studentManager = new StudentManager(new PlainTextDataSource("../../students.txt"));
		}
	}
}
