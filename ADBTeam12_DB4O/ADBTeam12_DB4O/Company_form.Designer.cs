namespace ADBTeam12_DB4O
{
	partial class Company_form
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
			System.Windows.Forms.Label cityLabel;
			System.Windows.Forms.Label companyIDLabel;
			System.Windows.Forms.Label companyNameLabel;
			System.Windows.Forms.Label houseNumberLabel;
			System.Windows.Forms.Label streetLabel;
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cityTextBox = new System.Windows.Forms.TextBox();
			this.companyIDTextBox = new System.Windows.Forms.TextBox();
			this.companyNameTextBox = new System.Windows.Forms.TextBox();
			this.houseNumberTextBox = new System.Windows.Forms.TextBox();
			this.streetTextBox = new System.Windows.Forms.TextBox();
			this.companyDataGridView = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
			cityLabel = new System.Windows.Forms.Label();
			companyIDLabel = new System.Windows.Forms.Label();
			companyNameLabel = new System.Windows.Forms.Label();
			houseNumberLabel = new System.Windows.Forms.Label();
			streetLabel = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.companyDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button3);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(cityLabel);
			this.groupBox1.Controls.Add(this.cityTextBox);
			this.groupBox1.Controls.Add(companyIDLabel);
			this.groupBox1.Controls.Add(this.companyIDTextBox);
			this.groupBox1.Controls.Add(companyNameLabel);
			this.groupBox1.Controls.Add(this.companyNameTextBox);
			this.groupBox1.Controls.Add(houseNumberLabel);
			this.groupBox1.Controls.Add(this.houseNumberTextBox);
			this.groupBox1.Controls.Add(streetLabel);
			this.groupBox1.Controls.Add(this.streetTextBox);
			this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
			this.groupBox1.Location = new System.Drawing.Point(0, 0);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(622, 231);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Cong ty";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// cityLabel
			// 
			cityLabel.AutoSize = true;
			cityLabel.Location = new System.Drawing.Point(71, 28);
			cityLabel.Name = "cityLabel";
			cityLabel.Size = new System.Drawing.Size(27, 13);
			cityLabel.TabIndex = 0;
			cityLabel.Text = "City:";
			// 
			// cityTextBox
			// 
			this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "City", true));
			this.cityTextBox.Location = new System.Drawing.Point(162, 25);
			this.cityTextBox.Name = "cityTextBox";
			this.cityTextBox.Size = new System.Drawing.Size(159, 20);
			this.cityTextBox.TabIndex = 1;
			// 
			// companyIDLabel
			// 
			companyIDLabel.AutoSize = true;
			companyIDLabel.Location = new System.Drawing.Point(71, 54);
			companyIDLabel.Name = "companyIDLabel";
			companyIDLabel.Size = new System.Drawing.Size(68, 13);
			companyIDLabel.TabIndex = 2;
			companyIDLabel.Text = "Company ID:";
			// 
			// companyIDTextBox
			// 
			this.companyIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "CompanyID", true));
			this.companyIDTextBox.Location = new System.Drawing.Point(162, 51);
			this.companyIDTextBox.Name = "companyIDTextBox";
			this.companyIDTextBox.Size = new System.Drawing.Size(159, 20);
			this.companyIDTextBox.TabIndex = 3;
			// 
			// companyNameLabel
			// 
			companyNameLabel.AutoSize = true;
			companyNameLabel.Location = new System.Drawing.Point(71, 80);
			companyNameLabel.Name = "companyNameLabel";
			companyNameLabel.Size = new System.Drawing.Size(85, 13);
			companyNameLabel.TabIndex = 4;
			companyNameLabel.Text = "Company Name:";
			// 
			// companyNameTextBox
			// 
			this.companyNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "CompanyName", true));
			this.companyNameTextBox.Location = new System.Drawing.Point(162, 77);
			this.companyNameTextBox.Name = "companyNameTextBox";
			this.companyNameTextBox.Size = new System.Drawing.Size(159, 20);
			this.companyNameTextBox.TabIndex = 5;
			// 
			// houseNumberLabel
			// 
			houseNumberLabel.AutoSize = true;
			houseNumberLabel.Location = new System.Drawing.Point(71, 106);
			houseNumberLabel.Name = "houseNumberLabel";
			houseNumberLabel.Size = new System.Drawing.Size(81, 13);
			houseNumberLabel.TabIndex = 6;
			houseNumberLabel.Text = "House Number:";
			// 
			// houseNumberTextBox
			// 
			this.houseNumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "HouseNumber", true));
			this.houseNumberTextBox.Location = new System.Drawing.Point(162, 103);
			this.houseNumberTextBox.Name = "houseNumberTextBox";
			this.houseNumberTextBox.Size = new System.Drawing.Size(159, 20);
			this.houseNumberTextBox.TabIndex = 7;
			// 
			// streetLabel
			// 
			streetLabel.AutoSize = true;
			streetLabel.Location = new System.Drawing.Point(71, 132);
			streetLabel.Name = "streetLabel";
			streetLabel.Size = new System.Drawing.Size(38, 13);
			streetLabel.TabIndex = 8;
			streetLabel.Text = "Street:";
			// 
			// streetTextBox
			// 
			this.streetTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.companyBindingSource, "Street", true));
			this.streetTextBox.Location = new System.Drawing.Point(162, 129);
			this.streetTextBox.Name = "streetTextBox";
			this.streetTextBox.Size = new System.Drawing.Size(159, 20);
			this.streetTextBox.TabIndex = 9;
			// 
			// companyDataGridView
			// 
			this.companyDataGridView.AutoGenerateColumns = false;
			this.companyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.companyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
			this.companyDataGridView.DataSource = this.companyBindingSource;
			this.companyDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.companyDataGridView.Location = new System.Drawing.Point(0, 231);
			this.companyDataGridView.Name = "companyDataGridView";
			this.companyDataGridView.Size = new System.Drawing.Size(622, 219);
			this.companyDataGridView.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(64, 173);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 36);
			this.button1.TabIndex = 10;
			this.button1.Text = "Them";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(190, 173);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(123, 36);
			this.button2.TabIndex = 11;
			this.button2.Text = "Danh sach nhan vien";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(371, 173);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 36);
			this.button3.TabIndex = 12;
			this.button3.Text = "Xuat cau 7";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.DataPropertyName = "CompanyID";
			this.dataGridViewTextBoxColumn1.HeaderText = "CompanyID";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "CompanyName";
			this.dataGridViewTextBoxColumn2.HeaderText = "CompanyName";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "HouseNumber";
			this.dataGridViewTextBoxColumn3.HeaderText = "HouseNumber";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "Street";
			this.dataGridViewTextBoxColumn4.HeaderText = "Street";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "City";
			this.dataGridViewTextBoxColumn5.HeaderText = "City";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			// 
			// companyBindingSource
			// 
			this.companyBindingSource.DataSource = typeof(ADBTeam12_DB4O.Company);
			// 
			// Company_form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(622, 450);
			this.Controls.Add(this.companyDataGridView);
			this.Controls.Add(this.groupBox1);
			this.Name = "Company_form";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Company_form_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.companyDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox cityTextBox;
		private System.Windows.Forms.BindingSource companyBindingSource;
		private System.Windows.Forms.TextBox companyIDTextBox;
		private System.Windows.Forms.TextBox companyNameTextBox;
		private System.Windows.Forms.TextBox houseNumberTextBox;
		private System.Windows.Forms.TextBox streetTextBox;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.DataGridView companyDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
	}
}

