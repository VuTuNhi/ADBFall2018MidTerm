namespace ADBTeam12_DB4O
{
	partial class Employee_form
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.Label fullNameLabel;
			System.Windows.Forms.Label iDLabel;
			System.Windows.Forms.Label salaryLabel;
			System.Windows.Forms.Label skillLabel;
			System.Windows.Forms.Label companyIDLabel;
			this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.fullNameTextBox = new System.Windows.Forms.TextBox();
			this.iDTextBox = new System.Windows.Forms.TextBox();
			this.salaryTextBox = new System.Windows.Forms.TextBox();
			this.skillTextBox = new System.Windows.Forms.TextBox();
			this.companyIDComboBox = new System.Windows.Forms.ComboBox();
			this.employeeDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button1 = new System.Windows.Forms.Button();
			fullNameLabel = new System.Windows.Forms.Label();
			iDLabel = new System.Windows.Forms.Label();
			salaryLabel = new System.Windows.Forms.Label();
			skillLabel = new System.Windows.Forms.Label();
			companyIDLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// employeeBindingSource
			// 
			this.employeeBindingSource.DataSource = typeof(ADBTeam12_DB4O.Employee);
			// 
			// fullNameLabel
			// 
			fullNameLabel.AutoSize = true;
			fullNameLabel.Location = new System.Drawing.Point(65, 21);
			fullNameLabel.Name = "fullNameLabel";
			fullNameLabel.Size = new System.Drawing.Size(57, 13);
			fullNameLabel.TabIndex = 1;
			fullNameLabel.Text = "Full Name:";
			// 
			// fullNameTextBox
			// 
			this.fullNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "FullName", true));
			this.fullNameTextBox.Location = new System.Drawing.Point(128, 18);
			this.fullNameTextBox.Name = "fullNameTextBox";
			this.fullNameTextBox.Size = new System.Drawing.Size(100, 20);
			this.fullNameTextBox.TabIndex = 2;
			// 
			// iDLabel
			// 
			iDLabel.AutoSize = true;
			iDLabel.Location = new System.Drawing.Point(65, 47);
			iDLabel.Name = "iDLabel";
			iDLabel.Size = new System.Drawing.Size(21, 13);
			iDLabel.TabIndex = 3;
			iDLabel.Text = "ID:";
			// 
			// iDTextBox
			// 
			this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "ID", true));
			this.iDTextBox.Location = new System.Drawing.Point(128, 44);
			this.iDTextBox.Name = "iDTextBox";
			this.iDTextBox.Size = new System.Drawing.Size(100, 20);
			this.iDTextBox.TabIndex = 4;
			// 
			// salaryLabel
			// 
			salaryLabel.AutoSize = true;
			salaryLabel.Location = new System.Drawing.Point(65, 73);
			salaryLabel.Name = "salaryLabel";
			salaryLabel.Size = new System.Drawing.Size(39, 13);
			salaryLabel.TabIndex = 5;
			salaryLabel.Text = "Salary:";
			// 
			// salaryTextBox
			// 
			this.salaryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Salary", true));
			this.salaryTextBox.Location = new System.Drawing.Point(128, 70);
			this.salaryTextBox.Name = "salaryTextBox";
			this.salaryTextBox.Size = new System.Drawing.Size(100, 20);
			this.salaryTextBox.TabIndex = 6;
			// 
			// skillLabel
			// 
			skillLabel.AutoSize = true;
			skillLabel.Location = new System.Drawing.Point(65, 99);
			skillLabel.Name = "skillLabel";
			skillLabel.Size = new System.Drawing.Size(29, 13);
			skillLabel.TabIndex = 7;
			skillLabel.Text = "Skill:";
			// 
			// skillTextBox
			// 
			this.skillTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "Skill", true));
			this.skillTextBox.Location = new System.Drawing.Point(128, 96);
			this.skillTextBox.Name = "skillTextBox";
			this.skillTextBox.Size = new System.Drawing.Size(100, 20);
			this.skillTextBox.TabIndex = 8;
			// 
			// companyIDLabel
			// 
			companyIDLabel.AutoSize = true;
			companyIDLabel.Location = new System.Drawing.Point(280, 21);
			companyIDLabel.Name = "companyIDLabel";
			companyIDLabel.Size = new System.Drawing.Size(68, 13);
			companyIDLabel.TabIndex = 9;
			companyIDLabel.Text = "Company ID:";
			// 
			// companyIDComboBox
			// 
			this.companyIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employeeBindingSource, "HomeBase.CompanyID", true));
			this.companyIDComboBox.FormattingEnabled = true;
			this.companyIDComboBox.Location = new System.Drawing.Point(354, 18);
			this.companyIDComboBox.Name = "companyIDComboBox";
			this.companyIDComboBox.Size = new System.Drawing.Size(121, 21);
			this.companyIDComboBox.TabIndex = 10;
			// 
			// employeeDataGridView
			// 
			this.employeeDataGridView.AutoGenerateColumns = false;
			this.employeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.employeeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
			this.employeeDataGridView.DataSource = this.employeeBindingSource;
			this.employeeDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.employeeDataGridView.Location = new System.Drawing.Point(0, 145);
			this.employeeDataGridView.Name = "employeeDataGridView";
			this.employeeDataGridView.Size = new System.Drawing.Size(800, 305);
			this.employeeDataGridView.TabIndex = 10;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
			this.dataGridViewTextBoxColumn1.HeaderText = "ID";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "FullName";
			this.dataGridViewTextBoxColumn2.HeaderText = "FullName";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Skill";
			this.dataGridViewTextBoxColumn3.HeaderText = "Skill";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "HomeBase";
			this.dataGridViewTextBoxColumn4.HeaderText = "HomeBase";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "Manager";
			this.dataGridViewTextBoxColumn5.HeaderText = "Manager";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.DataPropertyName = "Salary";
			this.dataGridViewTextBoxColumn6.HeaderText = "Salary";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(368, 73);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 39);
			this.button1.TabIndex = 11;
			this.button1.Text = "Them";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Employee_form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.employeeDataGridView);
			this.Controls.Add(companyIDLabel);
			this.Controls.Add(this.companyIDComboBox);
			this.Controls.Add(fullNameLabel);
			this.Controls.Add(this.fullNameTextBox);
			this.Controls.Add(iDLabel);
			this.Controls.Add(this.iDTextBox);
			this.Controls.Add(salaryLabel);
			this.Controls.Add(this.salaryTextBox);
			this.Controls.Add(skillLabel);
			this.Controls.Add(this.skillTextBox);
			this.Name = "Employee_form";
			this.Text = "Employee_form";
			this.Load += new System.EventHandler(this.Employee_form_Load);
			((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.employeeDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.BindingSource employeeBindingSource;
		private System.Windows.Forms.TextBox fullNameTextBox;
		private System.Windows.Forms.TextBox iDTextBox;
		private System.Windows.Forms.TextBox salaryTextBox;
		private System.Windows.Forms.TextBox skillTextBox;
		private System.Windows.Forms.ComboBox companyIDComboBox;
		private System.Windows.Forms.DataGridView employeeDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.Button button1;
	}
}