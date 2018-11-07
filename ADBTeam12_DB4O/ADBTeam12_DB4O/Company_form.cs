using Db4objects.Db4o;
using Db4objects.Db4o.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADBTeam12_DB4O
{
	public partial class Company_form : Form
	{
		public Company_form()
		{
			InitializeComponent();
		}

		public void LoadData()
		{
			using (IObjectContainer db = Db4oEmbedded.OpenFile("Team12_EmployeeManager.yap"))
			{
				var result = from Company c in db select c;
				companyBindingSource.DataSource = result.ToList();
				db.Close();
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Company newcompany = new Company
			{
				City = this.cityTextBox.Text.ToString(),
				CompanyID = int.Parse(this.companyIDTextBox.Text),
				CompanyName = this.companyNameTextBox.Text.ToString(),
				HouseNumber = this.houseNumberTextBox.Text.ToString(),
				Street = this.streetTextBox.Text.ToString()
			};
			using (IObjectContainer db = Db4oEmbedded.OpenFile("Team12_EmployeeManager.yap"))
			{
				db.Store(newcompany);
				db.Close();
			}
			LoadData();
		}

		private void groupBox1_Enter(object sender, EventArgs e)
		{

		}

		private void button2_Click(object sender, EventArgs e)
		{
			Form nhanvien = new Employee_form();
			nhanvien.Show();
		}

		private void Company_form_Load(object sender, EventArgs e)
		{
			LoadData();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			using (var db = Db4oEmbedded.OpenFile("Team12_EmployeeManager.yap"))
			{
				IEnumerable<string> result1 = from Employee em in db
											  where em.HomeBase != null && em.Salary > 500
											  group em.HomeBase by em.HomeBase.CompanyName into a
											  where a.Count() > 2
											  select a.Key;
				List<Company> com = new List<Company>();
				foreach (var i in result1.ToList())
				{
					IEnumerable<Company> result = from Company c in db where c.CompanyName == i.ToString() select c;
					com.Add(((Company)result.ToList()[0]));

				}
				companyBindingSource.DataSource = com;
			}
		}
	}
}
