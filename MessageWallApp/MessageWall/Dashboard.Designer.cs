namespace MessageWall
{
	partial class Dashboard
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
			this.addAddressButton = new System.Windows.Forms.Button();
			this.peopleListBox = new System.Windows.Forms.ListBox();
			this.lastNameTextBox = new System.Windows.Forms.TextBox();
			this.firstNameTextBox = new System.Windows.Forms.TextBox();
			this.addNameButton = new System.Windows.Forms.Button();
			this.lastNameLabel = new System.Windows.Forms.Label();
			this.firstNameLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// addAddressButton
			// 
			this.addAddressButton.Location = new System.Drawing.Point(515, 254);
			this.addAddressButton.Name = "addAddressButton";
			this.addAddressButton.Size = new System.Drawing.Size(231, 35);
			this.addAddressButton.TabIndex = 5;
			this.addAddressButton.Text = "Add Address";
			this.addAddressButton.UseVisualStyleBackColor = true;
			this.addAddressButton.Click += new System.EventHandler(this.addAddressButton_Click);
			// 
			// peopleListBox
			// 
			this.peopleListBox.FormattingEnabled = true;
			this.peopleListBox.ItemHeight = 29;
			this.peopleListBox.Location = new System.Drawing.Point(158, 254);
			this.peopleListBox.Name = "peopleListBox";
			this.peopleListBox.Size = new System.Drawing.Size(328, 207);
			this.peopleListBox.TabIndex = 4;
			// 
			// lastNameTextBox
			// 
			this.lastNameTextBox.Location = new System.Drawing.Point(360, 135);
			this.lastNameTextBox.Name = "lastNameTextBox";
			this.lastNameTextBox.Size = new System.Drawing.Size(126, 35);
			this.lastNameTextBox.TabIndex = 2;
			// 
			// firstNameTextBox
			// 
			this.firstNameTextBox.Location = new System.Drawing.Point(158, 135);
			this.firstNameTextBox.Name = "firstNameTextBox";
			this.firstNameTextBox.Size = new System.Drawing.Size(126, 35);
			this.firstNameTextBox.TabIndex = 1;
			// 
			// addNameButton
			// 
			this.addNameButton.Location = new System.Drawing.Point(547, 135);
			this.addNameButton.Name = "addNameButton";
			this.addNameButton.Size = new System.Drawing.Size(118, 35);
			this.addNameButton.TabIndex = 3;
			this.addNameButton.Text = "Add";
			this.addNameButton.UseVisualStyleBackColor = true;
			this.addNameButton.Click += new System.EventHandler(this.addNameButton_Click);
			// 
			// lastNameLabel
			// 
			this.lastNameLabel.AutoSize = true;
			this.lastNameLabel.Location = new System.Drawing.Point(358, 86);
			this.lastNameLabel.Name = "lastNameLabel";
			this.lastNameLabel.Size = new System.Drawing.Size(128, 29);
			this.lastNameLabel.TabIndex = 15;
			this.lastNameLabel.Text = "Last Name";
			// 
			// firstNameLabel
			// 
			this.firstNameLabel.AutoSize = true;
			this.firstNameLabel.Location = new System.Drawing.Point(153, 86);
			this.firstNameLabel.Name = "firstNameLabel";
			this.firstNameLabel.Size = new System.Drawing.Size(131, 29);
			this.firstNameLabel.TabIndex = 14;
			this.firstNameLabel.Text = "First Name";
			// 
			// Dashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(894, 631);
			this.Controls.Add(this.addAddressButton);
			this.Controls.Add(this.peopleListBox);
			this.Controls.Add(this.lastNameTextBox);
			this.Controls.Add(this.firstNameTextBox);
			this.Controls.Add(this.addNameButton);
			this.Controls.Add(this.lastNameLabel);
			this.Controls.Add(this.firstNameLabel);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(7);
			this.Name = "Dashboard";
			this.Text = "Dashboard";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button addAddressButton;
		private System.Windows.Forms.ListBox peopleListBox;
		private System.Windows.Forms.TextBox lastNameTextBox;
		private System.Windows.Forms.TextBox firstNameTextBox;
		private System.Windows.Forms.Button addNameButton;
		private System.Windows.Forms.Label lastNameLabel;
		private System.Windows.Forms.Label firstNameLabel;
	}
}

