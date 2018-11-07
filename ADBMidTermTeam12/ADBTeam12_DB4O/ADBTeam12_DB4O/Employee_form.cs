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
	public partial class Employee_form : Form
	{
		public Employee_form()
		{
			InitializeComponent();
		}
		public void laydulieu()
		{
			using (var db = Db4oEmbedded.OpenFile("Team12_EmployeeManager.yap"))
			{
				var result = from Employee em in db select em;
				employeeBindingSource.DataSource = result.ToList();
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			using (var db = Db4oEmbedded.OpenFile("Team12_EmployeeManager.yap"))
			{
				var com = new Company
				{
					CompanyID = int.Parse(companyIDComboBox.Text)
				};
				IObjectSet result = db.QueryByExample(com);
				var compa = result[0];
				var em = new Employee
				{
					ID = int.Parse(iDTextBox.Text),
					FullName = fullNameTextBox.Text,
					HomeBase = (Company)compa,
					Salary = Convert.ToDouble(salaryTextBox.Text),
					Skill = skillTextBox.Text
				};
				db.Store(em);
				db.Commit();
				db.Close();
				laydulieu();
			}
		}

		private void Employee_form_Load(object sender, EventArgs e)
		{
			using (var db = Db4oEmbedded.OpenFile("Team12_EmployeeManager.yap"))
			{
				var result = from Company c in db select c.CompanyID;
				companyIDComboBox.DataSource = result.ToList();
			}
			laydulieu();
		}
	}
}
